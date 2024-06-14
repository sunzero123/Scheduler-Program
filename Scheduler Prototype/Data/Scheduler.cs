using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Scheduler_Prototype.Data;
using Scheduler_Prototype.Models;
using System.Data;
using System.Management.Instrumentation;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Scheduler_Prototype.Data
{

    public class Scheduler
    {
        private List<Events> events = new List<Events>();
        private List<Events> droppedEvents = new List<Events>();
        private List<Events> dbEvents = new List<Events>();
        int eventCount = 0;

        public void AddEvent(Events newEvent)
        {
            if (!HasConflict(newEvent, 1))
            {
                eventCount += 1;
                newEvent.eventCount = eventCount; // count of events local to a task
                try
                {

                    DBUtilsForScheduler.InsertEventUsingSP(newEvent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding Event with stored procedure: " + ex.Message);
                }

            }
            else
            {
                eventCount += 1;
                newEvent.eventCount = eventCount;
                droppedEvents.Add(newEvent);
                eventCount -= 1;
            }
        }

        public void AddTech(Events newEvent)
        {
            if (!HasConflict(newEvent, 1))
            {
                events.Add(newEvent);
                try
                {
                    DBUtilsForScheduler.InsertEventUsingSP(newEvent);
                    MessageBox.Show($"Technican added to '{newEvent.eventID}' successfully."); // When there's a conflict this is zero
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding additional technician with stored procedure: " + ex.Message);
                }

            }
            else
            {          
                MessageBox.Show($"Additional technician could not added due to time conflict at '{newEvent.startDateTime}'.");
            }
        }

        // add unassigned event just autoschedules the event into the next available time slot. Can start searching at different times
        public Events AddUnassignedEvent(Events newEvent, int mode) // mode is 1 if calling to find a start time for initial task. 2 for actual events
        {
            while (HasConflict(newEvent, 2))
            {
                newEvent.startDateTime = newEvent.startDateTime.AddMinutes(15);
            }
            if (!HasConflict(newEvent, 2))
            {
                eventCount += 1;
                newEvent.eventCount = eventCount; // count of events local to a task
                if (mode == 1)
                {
                    try
                    {
                        eventCount = 0;
                        return newEvent;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding Event with stored procedure: " + ex.Message);
                    }
                }
                if (mode == 2)
                {
                    try
                    {
                        DBUtilsForScheduler.InsertEventUsingSP(newEvent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding Event with stored procedure: " + ex.Message);
                    }
                }
            }
            return null;
        }

        private bool HasConflict(Events newEvent, int mode) // mode 2 is unassigned time
        {
            // Only checks for event conflicts with the same technician 
            int techid = newEvent.techID;

            DataTable dbEventsDataTable = DBUtilsForScheduler.GetEventsByTechSP(techid);

            foreach (DataRow row in dbEventsDataTable.Rows)
            {
                Events dbEvent = ConvertDataRowToEvent(row); // Implement this method
                if (newEvent.startDateTime < dbEvent.startDateTime + dbEvent.Duration &&
                    newEvent.startDateTime + newEvent.Duration > dbEvent.startDateTime)
                {
                    if (mode == 1)
                    {
                        dbEvents.Add(dbEvent);
                    }
                    return true;
                }
            }
            return false;
        }

        public bool EventTechHasConflict(Events e)
        {
            int techid = e.techID;

            DataTable dbEventsDataTable = DBUtilsForScheduler.GetEventsByTechSP(techid);

            foreach (DataRow row in dbEventsDataTable.Rows)
            {
                Events dbEvent = ConvertDataRowToEvent(row); // Implement this method
                if (e.startDateTime < dbEvent.startDateTime + dbEvent.Duration &&
                    e.startDateTime + e.Duration > dbEvent.startDateTime)
                {
                    return true;
                }
            }
            return false;
        }

        private Events ConvertDataRowToEvent(DataRow row)
        {
            int eventID = Convert.ToInt32(row["event_id"]);
            DateTime startDateTime = Convert.ToDateTime(row["date"]);
            TimeSpan duration = TimeSpan.FromMinutes(Convert.ToDouble(row["duration"]));

            return new Events(eventID, startDateTime, duration);
        }
        public void ClearEventCount()
        {
            eventCount = 0; // clears event count so creating multiple tasks in one session start at 0
        }
        public void PrintSchedule() // Not used currently but could be useful for testing
        {
            MessageBox.Show("Current Schedule:");
            foreach (var e in events)
            {
                MessageBox.Show($"- {e.eventID}: {e.startDateTime} to {e.startDateTime + e.Duration}");
            }
        }
        public void PrintSucessfulEvents() // not used currently
        {
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine("Successfully added events");
            messageBuilder.AppendLine("-------------------------------------------------------------------");
            foreach (var e in events)
            {


                messageBuilder.AppendLine($">>> Event count: {e.eventCount} on date/time: {e.startDateTime}");
            }

            MessageBox.Show(messageBuilder.ToString());
        }
        public void clearEvents()
        {
            events.Clear();
        }
        public void clearDroppedEvents()
        {
            droppedEvents.Clear();
        }
        public void clearDbEvents()
        {
            dbEvents.Clear();
        }
        public void PrintDroppedEvents()
        {
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine("Dropped events");
            messageBuilder.AppendLine("---------------------------------------------------");

            for (int i = 0; i < droppedEvents.Count; i++)
            {
                var droppedEvent = droppedEvents[i];
                var dbEvent = dbEvents[i];

                messageBuilder.AppendLine($">>> Event count: {droppedEvent.eventCount} on date/time: {droppedEvent.startDateTime} conflicts with existing event id:{dbEvent.eventID}");
            }

            MessageBox.Show(messageBuilder.ToString());
        }
    }
}

