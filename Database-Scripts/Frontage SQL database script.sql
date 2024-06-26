/****** Object:  Database [Company]    Script Date: 4/30/2024 2:49:30 PM ******/
CREATE DATABASE [Company]  (EDITION = 'Basic', SERVICE_OBJECTIVE = 'Basic', MAXSIZE = 1 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS, LEDGER = OFF;
GO
ALTER DATABASE [Company] SET COMPATIBILITY_LEVEL = 160
GO
ALTER DATABASE [Company] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Company] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Company] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Company] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Company] SET ARITHABORT OFF 
GO
ALTER DATABASE [Company] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Company] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Company] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Company] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Company] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Company] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Company] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Company] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Company] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Company] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Company] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Company] SET  MULTI_USER 
GO
ALTER DATABASE [Company] SET ENCRYPTION ON
GO
ALTER DATABASE [Company] SET QUERY_STORE = ON
GO
ALTER DATABASE [Company] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 7), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 4/30/2024 2:49:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[color_name] [varchar](50) NOT NULL,
	[hex] [varchar](8) NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[color_name] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studies]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studies](
	[study_id] [int] IDENTITY(1,1) NOT NULL,
	[study_num] [varchar](7) NOT NULL,
	[sponsor] [varchar](45) NULL,
	[technician_id] [int] NULL,
	[color] [varchar](45) NULL,
	[deleted] [tinyint] NULL,
	[start_date] [varchar](45) NULL,
	[end_date] [varchar](45) NULL,
 CONSTRAINT [PK__studies__C751365EB5C63CE2] PRIMARY KEY CLUSTERED 
(
	[study_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taskevents]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taskevents](
	[event_id] [int] IDENTITY(1,1) NOT NULL,
	[task_id] [int] NULL,
	[type] [varchar](45) NULL,
	[study_id] [int] NULL,
	[tech_id] [int] NOT NULL,
	[study_num] [varchar](7) NULL,
	[date] [varchar](50) NULL,
	[duration] [int] NULL,
	[comments] [varchar](100) NULL,
	[deleted] [tinyint] NULL,
	[event_count] [int] NULL,
 CONSTRAINT [PK_taskevents] PRIMARY KEY CLUSTERED 
(
	[event_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tasks]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tasks](
	[task_id] [int] IDENTITY(1,1) NOT NULL,
	[study_num] [varchar](7) NULL,
	[study_id] [int] NULL,
	[tech_id] [int] NULL,
	[study_start_date] [varchar](50) NULL,
	[study_end_date] [varchar](50) NULL,
	[task_start_date] [varchar](50) NULL,
	[duration] [int] NULL,
	[type] [varchar](45) NULL,
	[daily_frequency] [varchar](30) NULL,
	[weekly_frequency] [varchar](30) NULL,
	[custom_days] [binary](1) NULL,
	[num_occurrences] [int] NULL,
	[comments] [varchar](100) NULL,
	[deleted] [tinyint] NULL,
 CONSTRAINT [PK__tasks__0492148DB6EEB80B] PRIMARY KEY CLUSTERED 
(
	[task_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskTypes]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskTypes](
	[typeID] [int] IDENTITY(1,1) NOT NULL,
	[taskType] [varchar](50) NULL,
	[deleted] [tinyint] NULL,
 CONSTRAINT [PK_TaskType] PRIMARY KEY CLUSTERED 
(
	[typeID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[technicians]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[technicians](
	[tech_id] [int] IDENTITY(1,1) NOT NULL,
	[tech_emp_num] [int] NULL,
	[tech_first_name] [varchar](45) NULL,
	[tech_last_name] [varchar](45) NULL,
	[tech_nickname] [varchar](45) NULL,
	[tech_email] [varchar](45) NULL,
	[tech_initials] [varchar](4) NULL,
	[deleted] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[tech_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](5000) NOT NULL,
	[isAdmin] [bit] NOT NULL,
	[deleted] [tinyint] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[studies] ADD  CONSTRAINT [DF__studies__deleted__37A5467C]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[taskevents] ADD  CONSTRAINT [DF__taskevent__delet__3B75D760]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[tasks] ADD  CONSTRAINT [DF_tasks_deleted]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[technicians] ADD  DEFAULT ((0)) FOR [deleted]
GO
/****** Object:  StoredProcedure [dbo].[FillComboBoxColors]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FillComboBoxColors]
AS   
BEGIN
   SET NOCOUNT ON;
   SELECT color_name
   FROM dbo.Colors
   WHERE NOT EXISTS(
		SELECT 1
		FROM dbo.studies
		WHERE studies.color LIKE '%' + colors.color_name + '%'
		AND studies.deleted = 0
		AND CONVERT(DATE, studies.end_date, 107) > CONVERT(DATE, GETDATE() AT TIME ZONE 'Central Standard Time')
   );
END
GO
/****** Object:  StoredProcedure [dbo].[FillComboBoxEventTechs]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Author, , Name>
-- Create Date: <Create Date, , >
-- Description: <Description, , >
-- =============================================
CREATE PROCEDURE [dbo].[FillComboBoxEventTechs]

    @taskid INT,
	@eventCount INT -- abbie added this
AS
BEGIN
    SET NOCOUNT ON

    -- Insert statements for procedure here
    SELECT (tech.tech_first_name + ' ' + tech_last_name) as "Name", tech.tech_id as "ID"
    FROM 
        dbo.technicians tech
    WHERE 
        tech.deleted = 0
        AND NOT EXISTS (
            SELECT 1
            FROM dbo.taskevents evt
            WHERE evt.tech_id = tech.tech_id
            AND evt.task_id = @taskid
			AND evt.event_count = @eventCount -- abbie added this
        );
END
GO
/****** Object:  StoredProcedure [dbo].[FillComboBoxSponsor]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FillComboBoxSponsor]
AS   
BEGIN
   SET NOCOUNT ON;
   SELECT DISTINCT sponsor
   FROM dbo.studies
   WHERE studies.deleted = 0
   AND CONVERT(DATE, studies.end_date, 107) > CONVERT(DATE, GETDATE() AT TIME ZONE 'Central Standard Time');
END
GO
/****** Object:  StoredProcedure [dbo].[FillComboBoxStudyNum]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FillComboBoxStudyNum]
AS   
BEGIN
   SET NOCOUNT ON;
   SELECT
   study_num
   FROM dbo.studies
   WHERE studies.deleted = 0 AND
   CONVERT(DATE, [end_date], 107) >= CONVERT(DATE, GETDATE() AT TIME ZONE 'Central Standard Time');
END
GO
/****** Object:  StoredProcedure [dbo].[FillComboBoxTaskTypes]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FillComboBoxTaskTypes]
AS   
BEGIN
   SET NOCOUNT ON;
   SELECT taskType
   FROM dbo.TaskTypes
   WHERE TaskTypes.deleted = 0;
END
GO
/****** Object:  StoredProcedure [dbo].[FillComboBoxTechs]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FillComboBoxTechs]
AS   
BEGIN
   SET NOCOUNT ON;
   SELECT (technicians.tech_first_name + ' ' + tech_last_name) as "Name", technicians.tech_id as "ID"
   FROM dbo.technicians
   WHERE technicians.deleted = 0;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllEventsForTech]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllEventsForTech] 
	-- Add the parameters for the stored procedure here
	@techid INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM taskevents
	WHERE tech_id = @techid AND deleted = 0;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllStudies]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllStudies]
AS  
BEGIN
    SELECT studies.study_id, studies.study_num AS "Study Number", studies.sponsor AS "Sponsor", (technicians.tech_first_name + ' ' + technicians.tech_last_name) AS "Technician Name"
    FROM dbo.studies
	JOIN technicians ON technicians.tech_id = studies.technician_id
    WHERE studies.deleted = 0;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllTasks]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllTasks]
AS
BEGIN
    SET NOCOUNT ON

    SELECT task_id, study_id, study_num AS "Study Number", type AS "Task Type",
   (technicians.tech_first_name + ' ' + technicians.tech_last_name) AS "Technician Name",
   LEFT(study_start_date, 11) AS "Study Start Date", LEFT(study_end_date, 11) AS "Study End Date"
   FROM dbo.tasks
   JOIN technicians ON technicians.tech_id = tasks.tech_id
   WHERE tasks.deleted = 0;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllTechniciansSP]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- GetAllTechniciansSP Stored Procedure
CREATE PROCEDURE [dbo].[GetAllTechniciansSP] AS
BEGIN
	SELECT tech_id, (tech_first_name + ' ' + tech_last_name) AS "Name"
    FROM dbo.technicians
    WHERE deleted = 0;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAnEvent]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAnEvent] 
	-- Add the parameters for the stored procedure here
	@eventid INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
		event_id,
		task_id,
		study_num,
        study_id,
		tech_id,
        date,
		duration,
		event_count,
		type,
		comments
        
		FROM 
		taskevents
		WHERE event_id = @eventid AND deleted = 0;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAStudy]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- GetAStudy Stored Procedure
CREATE PROCEDURE [dbo].[GetAStudy] 
	@sid INT 
AS
BEGIN
    SELECT study_id, study_num, sponsor, technician_id, color, deleted, start_date, end_date
	FROM studies
    WHERE study_id = @sid AND deleted = 0;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetATask]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetATask] 
	-- Add the parameters for the stored procedure here
	@tid INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		task_id,
		study_num,
        study_id,
		tech_id,
        study_start_date,
        study_end_date,
		task_start_date,
		duration,
		type,
		daily_frequency,
        weekly_frequency,
		num_occurrences,
		custom_days,
		comments
        
		FROM 
		tasks
		WHERE task_id = @tid;

END
GO
/****** Object:  StoredProcedure [dbo].[GetATechnicianSP]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- GetATechnicianSP Stored Procedure
CREATE PROCEDURE [dbo].[GetATechnicianSP] @tid INT AS
BEGIN
    SELECT * FROM dbo.technicians
    WHERE tech_id = @tid AND deleted = 0;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAUserSP]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAUserSP] @username VARCHAR(50)
AS   
BEGIN
   SET NOCOUNT ON;
   SELECT username, isAdmin FROM dbo.users
   WHERE deleted = 0
   AND username = @username;
END
GO
/****** Object:  StoredProcedure [dbo].[GetStudyIDFromNum]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudyIDFromNum]
   @snum VARCHAR(100) -- Adjust the length as per your data
AS   
BEGIN
   SET NOCOUNT ON;
   
   SELECT study_id
   FROM dbo.studies
   WHERE study_num = @snum;
END
GO
/****** Object:  StoredProcedure [dbo].[GetStudyNumFromID]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudyNumFromID]
	@sid INT
AS
BEGIN
    SET NOCOUNT ON
    SELECT study_num
    FROM dbo.studies
    WHERE study_id = @sid;
END
GO
/****** Object:  StoredProcedure [dbo].[GetStudyTasks]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- GetStudyTasks Stored Procedure
CREATE PROCEDURE [dbo].[GetStudyTasks] @sid INT AS
BEGIN
    SELECT task_id, study_num AS "Study Number", (technicians.tech_first_name + ' ' + technicians.tech_last_name) AS "Technician Name", type AS "Task Type", 
	task_start_date AS "Task Start Date",  LEFT(study_start_date, 11) AS "Study Start Date", LEFT(study_end_date, 11) AS "Study End Date"
	FROM dbo.tasks
	JOIN technicians ON technicians.tech_id = tasks.tech_id
    WHERE study_id = @sid AND tasks.deleted = 0;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetTaskEvents]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- GetTaskEvents Stored Procedure
CREATE PROCEDURE [dbo].[GetTaskEvents] @tid INT AS
BEGIN
    SELECT 
        te.event_id, 
        te.event_count AS "Event Count", 
        te.study_num AS "Study Number", 
        te.type AS "Task Type",
        (t.tech_first_name + ' ' + t.tech_last_name) AS "Technician Name",
        DATENAME(dw, te.date) AS "Day of Week",
        LEFT(te.date, 11) AS "Date",
        RIGHT(te.date, 7) AS "Start time",
        te.duration AS "Duration in Minutes"
    FROM 
        dbo.taskevents AS te
    INNER JOIN 
        dbo.technicians AS t ON te.tech_id = t.tech_id
    WHERE 
        te.task_id = @tid 
        AND te.deleted = 0;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetTechIDFromName]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTechIDFromName]
   @tname VARCHAR(100) -- Adjust the length as per your data
AS   
BEGIN
   SET NOCOUNT ON;
   
   SELECT tech_id AS "ID" 
   FROM dbo.technicians
   WHERE (tech_first_name + ' ' + tech_last_name) = @tname;
END
GO
/****** Object:  StoredProcedure [dbo].[GetTechNameFromID]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTechNameFromID]
   @tid INT -- Adjust the length as per your data
AS   
BEGIN
   SET NOCOUNT ON;
   
   SELECT (tech_first_name + ' ' + tech_last_name) as "Name"
   FROM dbo.technicians
   WHERE tech_id = @tid;
END
GO
/****** Object:  StoredProcedure [dbo].[InsertEvent]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- InsertEvent Stored Procedure
CREATE PROCEDURE [dbo].[InsertEvent] @taskid INT, @studyid INT, @study_num_param VARCHAR(7), @techid INT, @type_param VARCHAR(30), @start DATETIME, @duration_param INT, @eventcount INT
,@comments VARCHAR(100), -- abbie did this
@insertedID INT 

OUTPUT AS
BEGIN
    INSERT INTO dbo.taskevents(task_id, study_id, study_num, tech_id, type, date, duration, event_count
	, comments) -- abbie added this
    VALUES (@taskid, @studyid, @study_num_param, @techid, @type_param, @start, @duration_param, @eventcount 
	, @comments); -- abbie added this
	SET @insertedID = SCOPE_IDENTITY();
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertStudy]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- InsertStudy Stored Procedure
CREATE PROCEDURE [dbo].[InsertStudy] @sponsor_param VARCHAR(45), @studynum_param VARCHAR(7), @technicianID_param INT, @color_param VARCHAR(20), @startdate DATETIME, @endDate DATETIME, @insertedID INT OUTPUT AS
BEGIN
    INSERT INTO dbo.studies (study_num, sponsor, technician_id, color, start_date, end_date)
    VALUES (@studynum_param, @sponsor_param, @technicianID_param, @color_param, @startdate, @endDate);
	SET @insertedID = SCOPE_IDENTITY();
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertTask]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- InsertTask Stored Procedure
CREATE PROCEDURE [dbo].[InsertTask] @studynum_param VARCHAR(7), @studyid int, @techid INT, @studystartdate DATETIME, @studyenddate DATETIME, @taskstartdate DATETIME, @duration_param INT, @type_param VARCHAR(45), @dailyfreq VARCHAR(20), @weeklyfreq VARCHAR(50),  

@comments VARCHAR(100),
@num_occ INT, @customdays binary, @insertedID INT OUTPUT as
BEGIN
    INSERT INTO dbo.tasks (study_num, study_id, tech_id, study_start_date, study_end_date, task_start_date, duration, type, daily_frequency, weekly_frequency, 
	--time_of_day, 
	num_occurrences, custom_days, comments)
    VALUES (@studynum_param, @studyid, @techid, @studystartdate, @studyenddate, @taskstartdate, @duration_param, @type_param, @dailyfreq, @weeklyfreq, 
	@num_occ, @customdays, @comments);
	SET @insertedID = SCOPE_IDENTITY();
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertTechnician]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- InsertTechnician Stored Procedure
CREATE PROCEDURE [dbo].[InsertTechnician] @employeeNum INT, @firstname VARCHAR(45), @lastname VARCHAR(45), @nickname VARCHAR(30), @email VARCHAR(40), @initials_param VARCHAR(6), @insertedID INT OUTPUT AS
BEGIN
    INSERT INTO dbo.technicians(tech_emp_num, tech_first_name, tech_last_name, tech_nickname, tech_email, tech_initials)
    VALUES (@employeeNum, @firstname, @lastname, @nickname, @email, @initials_param);
	SET @insertedID = SCOPE_IDENTITY();
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- InsertUser Stored Procedure
CREATE PROCEDURE [dbo].[InsertUser] @username VARCHAR(50), @isAdmin INT, @password VARCHAR(5000), @insertedUser VARCHAR(50) OUTPUT AS
BEGIN
    INSERT INTO dbo.users(username, isAdmin, password, deleted)
    VALUES (@username, @isAdmin, HASHBYTES('SHA2_512', @password), 0);
	SET @insertedUser = SCOPE_IDENTITY();
END;
GO
/****** Object:  StoredProcedure [dbo].[ResetUserPassword]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- UpdateUserSP Stored Procedure
CREATE PROCEDURE [dbo].[ResetUserPassword] @username VARCHAR(50), @password VARCHAR(5000) AS
BEGIN
    UPDATE dbo.users
    SET password = HASHBYTES('SHA2_512', @password)
    WHERE username = @username;
END;
GO
/****** Object:  StoredProcedure [dbo].[SearchEvents]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SearchEvents]
   @studyNum VARCHAR(100), -- Adjust the length as per your data
   @type VARCHAR(100),
   @techName VARCHAR(100),
   @boolToday INT,
   --@boolUnassigned INT, -- abbie get rid of this
   @boolCurrentFuture INT
AS   
BEGIN
   SET NOCOUNT ON;
   
   SELECT event_id, event_count AS "Event Count", taskevents.study_num AS "Study Number", taskevents.type AS "Task Type",
   (technicians.tech_first_name + ' ' + technicians.tech_last_name) AS "Technician Name",
   DATENAME(dw, date) AS "Day of Week",
   LEFT(date, 11) AS "Date",
   RIGHT(date, 7) AS "Start time",
   duration AS "Duration in Minutes"
   FROM dbo.taskevents
   JOIN technicians ON technicians.tech_id = taskevents.tech_id
   WHERE
   (@boolToday = 0 OR FORMAT(CONVERT(DATE, date), 'MMM d yyyy') = FORMAT(CONVERT(datetimeoffset, SYSDATETIMEOFFSET() AT TIME ZONE 'Central Standard Time'), 'MMM d yyyy')) 
   --AND
   --(@boolUnassigned = 0 OR [date] LIKE '%' + '6:00AM' + '%') -- abbie get rid of this
   AND
   (@boolCurrentFuture = 0 OR CONVERT(DATE, date) >= CONVERT(DATE, SYSDATETIMEOFFSET() AT TIME ZONE 'Central Standard Time'))
   AND
   CONVERT(VARCHAR(100), taskevents.study_num) LIKE '%' + @studyNum + '%' 
   AND taskevents.type LIKE '%' + @type + '%' 
   AND (technicians.tech_first_name + ' ' + technicians.tech_last_name) LIKE '%' + @techName + '%'
   AND taskevents.deleted = 0;
END

GO
/****** Object:  StoredProcedure [dbo].[SearchStudies]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchStudies]
   @studyNum VARCHAR(100), -- Adjust the length as per your data
   @sponsor VARCHAR(100),
   @techName VARCHAR(100),
   @boolCurrentFuture INT
AS   
BEGIN
   SET NOCOUNT ON;
   
   SELECT study_id, study_num AS "Study Number", sponsor AS "Sponsor", (technicians.tech_first_name + ' ' + technicians.tech_last_name) AS "Technician Name"
   FROM dbo.studies
   JOIN technicians ON technicians.tech_id = studies.technician_id
   WHERE
       (CONVERT(VARCHAR(100), study_num) LIKE '%' + @studyNum + '%' 
	   AND
	   (@boolCurrentFuture = 0 OR CONVERT(DATE, end_date) >= CONVERT(DATE, SYSDATETIMEOFFSET() AT TIME ZONE 'Central Standard Time'))
       AND sponsor LIKE '%' + @sponsor + '%' 
       AND (technicians.tech_first_name + ' ' + technicians.tech_last_name) LIKE '%' + @techName + '%')
       AND studies.deleted = 0;
END
GO
/****** Object:  StoredProcedure [dbo].[SearchTasks]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchTasks]
   @studyNum VARCHAR(100), -- Adjust the length as per your data
   @type VARCHAR(100),
   @techName VARCHAR(100),
   @boolCurrentFuture INT
AS   
BEGIN
   SET NOCOUNT ON;
   
SELECT 
    tasks.task_id, 
    tasks.study_num AS "Study Number", 
    tasks.type AS "Task Type",
    (technicians.tech_first_name + ' ' + technicians.tech_last_name) AS "Technician Name",
	LEFT(tasks.task_start_date, 11) AS "Task Start Date",
    LEFT(study_start_date, 11) AS "Study Start Date", 
    LEFT(study_end_date, 11) AS "Study End Date",
    MAX(taskevents.event_count) AS "Total Event Count"
FROM
    dbo.tasks
JOIN 
    technicians ON technicians.tech_id = tasks.tech_id
JOIN 
    taskevents ON taskevents.task_id = tasks.task_id
WHERE
    (CONVERT(VARCHAR(100), tasks.study_num) LIKE '%' + @studyNum + '%' 
    AND
    (@boolCurrentFuture = 0 OR CONVERT(DATE, study_end_date) >= CONVERT(DATE, SYSDATETIMEOFFSET() AT TIME ZONE 'Central Standard Time'))
    AND tasks.type LIKE '%' + @type + '%' 
    AND (technicians.tech_first_name + ' ' + technicians.tech_last_name) LIKE '%' + @techName + '%')
    AND tasks.deleted = 0
	AND taskevents.deleted = 0
GROUP BY
    tasks.task_id, 
    tasks.study_num, 
    tasks.type,
    technicians.tech_first_name,
    technicians.tech_last_name,
	tasks.task_start_date,
    study_start_date,
    study_end_date;

END
GO
/****** Object:  StoredProcedure [dbo].[SearchTechnicians]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchTechnicians]
   @input VARCHAR(100) -- Adjust the length as per your data
AS   
BEGIN
   SET NOCOUNT ON;
   
   SELECT tech_id, (tech_first_name + ' ' + tech_last_name) AS "Name"
   FROM dbo.technicians
   WHERE
       (tech_first_name LIKE '%' + @input + '%' 
       OR tech_last_name LIKE '%' + @input + '%' )
       AND deleted = 0;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStudySP]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- UpdateStudySP Stored Procedure
CREATE PROCEDURE [dbo].[UpdateStudySP] @studyid INT, @studynum_param VARCHAR(7), @sponsor_param VARCHAR(45), @techid INT, @color_param VARCHAR(20), @startdate_param DATETIME, @endDate_param DATETIME AS
BEGIN
    UPDATE dbo.studies
    SET study_num = @studynum_param,
        sponsor = @sponsor_param,
        technician_id = @techid,
        color = @color_param,
        start_date = @startdate_param,
        end_date = @endDate_param
    WHERE study_id = @studyid;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateTaskEventSP]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- UpdateTaskEventSP Stored Procedure
CREATE PROCEDURE [dbo].[UpdateTaskEventSP] @eventid INT, @techID INT, @type_param VARCHAR(20), @date_param DATETIME, @duration_param INT, @comments VARCHAR(100) AS
BEGIN
    UPDATE dbo.taskevents
    SET tech_id = @techID,
		type = @type_param,
        date = @date_param,
        duration = @duration_param,
		comments = @comments
    WHERE event_id = @eventid;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateTaskUsingSP]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- UpdateTaskUsingSP Stored Procedure
CREATE PROCEDURE [dbo].[UpdateTaskUsingSP] @taskid INT, @studynum_param VARCHAR(7), @studyid int, @studystartdate DATETIME, @studyenddate DATETIME, @taskstartdate DATETIME, @duration_param INT, @type_param VARCHAR(45), @dailyfreq VARCHAR(20), @weeklyfreq VARCHAR(50),  
--@timeday VARCHAR(20), 
@comments VARCHAR(100),
@customdays BINARY, @num_occ INT as
BEGIN
    UPDATE dbo.tasks
    SET study_num = @studynum_param,
		study_id = @studyid,
		study_start_date = @studystartdate,
		study_end_date = @studyenddate,
		task_start_date = @taskstartdate,
		duration = @duration_param,
        type = @type_param,
		daily_frequency = @dailyfreq,
        weekly_frequency = @weeklyfreq,
        -- time_of_day = @timeday,
		comments = @comments,
        num_occurrences = @num_occ,
		custom_days = @customdays
        
    WHERE task_id = @taskid;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateTechnicianSP]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- UpdateTechnicianSP Stored Procedure
CREATE PROCEDURE [dbo].[UpdateTechnicianSP] @techid INT, @empNum INT, @fname VARCHAR(45), @lname VARCHAR(45), @nickname VARCHAR(20), @email VARCHAR(45), @initials VARCHAR(5) AS
BEGIN
    UPDATE dbo.technicians
    SET tech_emp_num = @empNum,
        tech_first_name = @fname,
        tech_last_name = @lname,
        tech_nickname = @nickname,
        tech_email = @email,
        tech_initials = @initials
    WHERE tech_id = @techid;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateUserSP]    Script Date: 4/30/2024 2:49:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- UpdateUserSP Stored Procedure
CREATE PROCEDURE [dbo].[UpdateUserSP] @username VARCHAR(50), @isAdmin INT AS
BEGIN
    UPDATE dbo.users
    SET isAdmin = @isAdmin
    WHERE username = @username;
END;
GO
ALTER DATABASE [Company] SET  READ_WRITE 
GO
