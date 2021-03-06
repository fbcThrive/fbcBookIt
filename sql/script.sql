USE [master]
GO
/****** Object:  Database [BookInventory]    Script Date: 3/28/2015 12:12:10 AM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'BookInventory')
BEGIN
CREATE DATABASE [BookInventory]
 CONTAINMENT = NONE
END

GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookInventory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookInventory] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookInventory] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookInventory] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookInventory] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookInventory] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookInventory] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookInventory] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BookInventory] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookInventory] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookInventory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookInventory] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookInventory] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookInventory] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookInventory] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookInventory] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookInventory] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookInventory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookInventory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookInventory] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookInventory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookInventory] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookInventory] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookInventory] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookInventory] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookInventory] SET  MULTI_USER 
GO
ALTER DATABASE [BookInventory] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookInventory] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookInventory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookInventory] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BookInventory]
GO
/****** Object:  Table [dbo].[BookLoan]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookLoan]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BookLoan](
	[ID] [uniqueidentifier] NOT NULL,
	[BookRequestID] [uniqueidentifier] NOT NULL,
	[OutDate] [date] NULL,
	[InDate] [date] NULL,
	[CopyID] [uniqueidentifier] NOT NULL,
	[StatusID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[BookRequest]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookRequest]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BookRequest](
	[ID] [uniqueidentifier] NOT NULL,
	[STSID] [uniqueidentifier] NOT NULL,
	[RequestDate] [date] NULL,
	[TitleID] [uniqueidentifier] NOT NULL,
	[FormatID] [int] NOT NULL,
	[StatusID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Copy]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Copy]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Copy](
	[ID] [uniqueidentifier] NOT NULL,
	[TitleID] [uniqueidentifier] NOT NULL,
	[FormatID] [int] NOT NULL,
	[Volume] [int] NOT NULL,
	[Pages] [int] NULL,
	[Hours] [int] NULL,
	[ProofRead] [bit] NULL,
	[Consumable] [bit] NULL,
	[CopyNumber] [int] NOT NULL,
	[StatusID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [uc_TitleVolume] UNIQUE NONCLUSTERED 
(
	[TitleID] ASC,
	[CopyNumber] ASC,
	[Volume] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CopyStatus]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CopyStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CopyStatus](
	[ID] [int] NOT NULL,
	[StatusDescription] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[District]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[District]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[District](
	[ID] [uniqueidentifier] NOT NULL,
	[DistrictName] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FormatType]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FormatType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FormatType](
	[ID] [int] NOT NULL,
	[FormatDescription] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoanStatus]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoanStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LoanStatus](
	[ID] [int] NOT NULL,
	[StatusDescription] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RequestStatus]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RequestStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RequestStatus](
	[ID] [int] NOT NULL,
	[StatusDescription] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[School]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[School]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[School](
	[ID] [uniqueidentifier] NOT NULL,
	[DistrictID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](500) NULL,
	[StreetAddress] [varchar](500) NULL,
	[City] [varchar](500) NULL,
	[State] [varchar](100) NULL,
	[ZipPlus4] [char](10) NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](500) NULL,
	[ContactName] [varchar](100) NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Student](
	[ID] [uniqueidentifier] NOT NULL,
	[LastName] [varchar](100) NULL,
	[FirstName] [varchar](100) NULL,
	[MiddleName] [varchar](100) NULL,
	[DateOfBirth] [date] NULL,
	[Grade] [varchar](10) NULL,
	[Gender] [char](1) NULL,
	[VisionDiagnosis] [varchar](8000) NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StudentTeacherSchool]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StudentTeacherSchool](
	[StudentID] [uniqueidentifier] NOT NULL,
	[TeacherID] [uniqueidentifier] NOT NULL,
	[SchoolID] [uniqueidentifier] NOT NULL,
	[ID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Teacher]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Teacher](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](500) NOT NULL,
	[Title] [varchar](500) NULL,
	[StreetAddress] [varchar](500) NULL,
	[City] [varchar](500) NULL,
	[State] [varchar](100) NULL,
	[ZipPlus4] [char](10) NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](500) NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Title]    Script Date: 3/28/2015 12:12:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Title]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Title](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](500) NOT NULL,
	[ISBN] [varchar](500) NOT NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__District__Active__1920BF5C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[District] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__FormatTyp__Activ__1BFD2C07]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[FormatType] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__School__Active__22AA2996]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[School] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Student__Active__25869641]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Teacher__Active__2A4B4B5E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Teacher] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__BookRe__2D27B809]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan]  WITH CHECK ADD FOREIGN KEY([BookRequestID])
REFERENCES [dbo].[BookRequest] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__CopyID__2E1BDC42]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan]  WITH CHECK ADD FOREIGN KEY([CopyID])
REFERENCES [dbo].[Copy] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__Status__2F10007B]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan]  WITH CHECK ADD FOREIGN KEY([StatusID])
REFERENCES [dbo].[LoanStatus] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__Forma__300424B4]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD FOREIGN KEY([FormatID])
REFERENCES [dbo].[FormatType] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__Statu__30F848ED]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD FOREIGN KEY([StatusID])
REFERENCES [dbo].[RequestStatus] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__STSID__31EC6D26]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD FOREIGN KEY([STSID])
REFERENCES [dbo].[StudentTeacherSchool] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__Title__32E0915F]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD FOREIGN KEY([TitleID])
REFERENCES [dbo].[Title] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Copy__FormatID__33D4B598]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy]  WITH CHECK ADD FOREIGN KEY([FormatID])
REFERENCES [dbo].[FormatType] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Copy__StatusID__34C8D9D1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy]  WITH CHECK ADD FOREIGN KEY([StatusID])
REFERENCES [dbo].[CopyStatus] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Copy__TitleID__35BCFE0A]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy]  WITH CHECK ADD FOREIGN KEY([TitleID])
REFERENCES [dbo].[Title] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_SchoolDistrict]') AND parent_object_id = OBJECT_ID(N'[dbo].[School]'))
ALTER TABLE [dbo].[School]  WITH CHECK ADD  CONSTRAINT [fk_SchoolDistrict] FOREIGN KEY([DistrictID])
REFERENCES [dbo].[District] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_SchoolDistrict]') AND parent_object_id = OBJECT_ID(N'[dbo].[School]'))
ALTER TABLE [dbo].[School] CHECK CONSTRAINT [fk_SchoolDistrict]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Schoo__37A5467C]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool]  WITH CHECK ADD FOREIGN KEY([SchoolID])
REFERENCES [dbo].[School] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Stude__38996AB5]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool]  WITH CHECK ADD FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Teach__398D8EEE]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool]  WITH CHECK ADD FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([ID])
GO
USE [master]
GO
ALTER DATABASE [BookInventory] SET  READ_WRITE 
GO
