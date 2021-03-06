USE [master]
GO
/****** Object:  Database [BookInventory]    Script Date: 3/28/2015 10:44:29 PM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'BookInventory')
BEGIN
CREATE DATABASE [BookInventory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookInventory', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BookInventory.mdf' , SIZE = 10432KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BookInventory_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BookInventory_log.ldf' , SIZE = 10368KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
ALTER DATABASE [BookInventory] SET COMPATIBILITY_LEVEL = 120
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
ALTER DATABASE [BookInventory] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BookInventory]
GO
/****** Object:  Table [dbo].[BookLoan]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookLoan]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BookLoan](
	[BookLoanId] [uniqueidentifier] NOT NULL,
	[BookRequestID] [uniqueidentifier] NOT NULL,
	[OutDate] [date] NULL,
	[InDate] [date] NULL,
	[StatusID] [int] NOT NULL,
	[VolumeID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK__BookLoan__3214EC2707243F01] PRIMARY KEY CLUSTERED 
(
	[BookLoanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[BookRequest]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookRequest]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BookRequest](
	[BookRequestId] [uniqueidentifier] NOT NULL,
	[StudentTeacherSchoolId] [uniqueidentifier] NOT NULL,
	[RequestDate] [date] NULL,
	[TitleID] [uniqueidentifier] NOT NULL,
	[RequestStatusId] [int] NULL,
	[FormatTypeID] [int] NULL,
 CONSTRAINT [PK__BookRequ__3214EC27EC6C8E6F] PRIMARY KEY CLUSTERED 
(
	[BookRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Copy]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Copy]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Copy](
	[CopyId] [uniqueidentifier] NOT NULL,
	[TitleID] [uniqueidentifier] NOT NULL,
	[ProofRead] [bit] NULL,
	[Consumable] [bit] NULL,
	[StartLocation] [varchar](50) NULL,
	[EndLocation] [varchar](50) NULL,
	[AcquisitionDate] [date] NULL,
	[DiscardedDate] [date] NULL,
	[CopyStatusID] [int] NULL,
	[Active] [bit] NOT NULL,
	[FormatTypeID] [int] NULL,
 CONSTRAINT [PK__Copy__3214EC274A02401D] PRIMARY KEY CLUSTERED 
(
	[CopyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CopyStatus]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CopyStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CopyStatus](
	[CopyStatusId] [int] NOT NULL,
	[StatusDescription] [varchar](100) NULL,
	[Active] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[CopyStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[District]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[District]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[District](
	[DistrictId] [uniqueidentifier] NOT NULL,
	[DistrictName] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK__District__3214EC27AFDFB664] PRIMARY KEY CLUSTERED 
(
	[DistrictId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FormatType]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FormatType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FormatType](
	[FormatTypeId] [int] NOT NULL,
	[FormatDescription] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
	[Category] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FormatTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoanStatus]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoanStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LoanStatus](
	[LoanStatusId] [int] NOT NULL,
	[StatusDescription] [varchar](100) NULL,
	[Active] [bit] NOT NULL DEFAULT ((1)),
 CONSTRAINT [PK__LoanStat__3214EC271C45545C] PRIMARY KEY CLUSTERED 
(
	[LoanStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RequestStatus]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RequestStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RequestStatus](
	[RequestStatusId] [int] NOT NULL,
	[StatusDescription] [varchar](100) NULL,
	[Active] [bit] NOT NULL DEFAULT ((1)),
 CONSTRAINT [PK__RequestS__3214EC2714656624] PRIMARY KEY CLUSTERED 
(
	[RequestStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[School]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[School]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[School](
	[SchoolID] [uniqueidentifier] NOT NULL,
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
 CONSTRAINT [PK__School__3214EC2784A78DEC] PRIMARY KEY CLUSTERED 
(
	[SchoolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Student](
	[StudentID] [uniqueidentifier] NOT NULL,
	[LastName] [varchar](100) NULL,
	[FirstName] [varchar](100) NULL,
	[MiddleName] [varchar](100) NULL,
	[DateOfBirth] [date] NULL,
	[Grade] [varchar](10) NULL,
	[Gender] [char](1) NULL,
	[VisionDiagnosis] [varchar](8000) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK__Student__3214EC27084EBB5F] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StudentTeacherSchool]    Script Date: 3/28/2015 10:44:29 PM ******/
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
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Teacher]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Teacher](
	[TeacherID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](500) NOT NULL,
	[Title] [varchar](500) NULL,
	[StreetAddress] [varchar](500) NULL,
	[City] [varchar](500) NULL,
	[State] [varchar](100) NULL,
	[ZipPlus4] [char](10) NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](500) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK__Teacher__3214EC278B83B852] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Title]    Script Date: 3/28/2015 10:44:29 PM ******/
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
/****** Object:  Table [dbo].[Volume]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Volume]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Volume](
	[VolumeID] [uniqueidentifier] NOT NULL,
	[Pages] [int] NULL,
	[VolumeStatusID] [int] NULL,
	[VolumeNumber] [int] NULL,
	[CopyID] [uniqueidentifier] NULL,
	[Barcode] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[VolumeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [uc_CopyVolume] UNIQUE NONCLUSTERED 
(
	[CopyID] ASC,
	[VolumeNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VolumeStatus]    Script Date: 3/28/2015 10:44:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VolumeStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[VolumeStatus](
	[VolumeStatusId] [int] NOT NULL,
	[StatusDescription] [varchar](100) NULL,
	[Active] [bit] NOT NULL DEFAULT ((1)),
 CONSTRAINT [PK__CopyStat__3214EC27B7B55C72] PRIMARY KEY CLUSTERED 
(
	[VolumeStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Copy__Acquisitio__2C3393D0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Copy] ADD  DEFAULT (getdate()) FOR [AcquisitionDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Copy__Active__2D27B809]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Copy] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__District__Active__2E1BDC42]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[District] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__FormatTyp__Activ__4222D4EF]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[FormatType] ADD  CONSTRAINT [DF__FormatTyp__Activ__4222D4EF]  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__School__Active__300424B4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[School] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Student__Active__30F848ED]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__StudentTe__Activ__31EC6D26]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StudentTeacherSchool] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Teacher__Active__32E0915F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Teacher] ADD  DEFAULT ((1)) FOR [Active]
END

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__BookRe__286302EC]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan]  WITH CHECK ADD  CONSTRAINT [FK__BookLoan__BookRe__286302EC] FOREIGN KEY([BookRequestID])
REFERENCES [dbo].[BookRequest] ([BookRequestId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__BookRe__286302EC]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan] CHECK CONSTRAINT [FK__BookLoan__BookRe__286302EC]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__BookRe__45F365D3]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan]  WITH CHECK ADD  CONSTRAINT [FK__BookLoan__BookRe__45F365D3] FOREIGN KEY([BookRequestID])
REFERENCES [dbo].[BookRequest] ([BookRequestId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__BookRe__45F365D3]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan] CHECK CONSTRAINT [FK__BookLoan__BookRe__45F365D3]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__Status__2A4B4B5E]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan]  WITH CHECK ADD  CONSTRAINT [FK__BookLoan__Status__2A4B4B5E] FOREIGN KEY([StatusID])
REFERENCES [dbo].[LoanStatus] ([LoanStatusId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__Status__2A4B4B5E]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan] CHECK CONSTRAINT [FK__BookLoan__Status__2A4B4B5E]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__Status__47DBAE45]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan]  WITH CHECK ADD  CONSTRAINT [FK__BookLoan__Status__47DBAE45] FOREIGN KEY([StatusID])
REFERENCES [dbo].[LoanStatus] ([LoanStatusId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__Status__47DBAE45]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan] CHECK CONSTRAINT [FK__BookLoan__Status__47DBAE45]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookLoan__Volume__37A5467C]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookLoan]'))
ALTER TABLE [dbo].[BookLoan]  WITH CHECK ADD FOREIGN KEY([VolumeID])
REFERENCES [dbo].[Volume] ([VolumeID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__Forma__5441852A]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD FOREIGN KEY([FormatTypeID])
REFERENCES [dbo].[FormatType] ([FormatTypeId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__Statu__2C3393D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD  CONSTRAINT [FK__BookReque__Statu__2C3393D0] FOREIGN KEY([RequestStatusId])
REFERENCES [dbo].[RequestStatus] ([RequestStatusId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__Statu__2C3393D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest] CHECK CONSTRAINT [FK__BookReque__Statu__2C3393D0]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__Statu__49C3F6B7]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD  CONSTRAINT [FK__BookReque__Statu__49C3F6B7] FOREIGN KEY([RequestStatusId])
REFERENCES [dbo].[RequestStatus] ([RequestStatusId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__Statu__49C3F6B7]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest] CHECK CONSTRAINT [FK__BookReque__Statu__49C3F6B7]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__STSID__2D27B809]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD  CONSTRAINT [FK__BookReque__STSID__2D27B809] FOREIGN KEY([StudentTeacherSchoolId])
REFERENCES [dbo].[StudentTeacherSchool] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__STSID__2D27B809]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest] CHECK CONSTRAINT [FK__BookReque__STSID__2D27B809]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__STSID__4AB81AF0]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD  CONSTRAINT [FK__BookReque__STSID__4AB81AF0] FOREIGN KEY([StudentTeacherSchoolId])
REFERENCES [dbo].[StudentTeacherSchool] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__STSID__4AB81AF0]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest] CHECK CONSTRAINT [FK__BookReque__STSID__4AB81AF0]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__Title__3E52440B]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD FOREIGN KEY([TitleID])
REFERENCES [dbo].[Title] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__BookReque__Title__3F466844]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRequest]'))
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD FOREIGN KEY([TitleID])
REFERENCES [dbo].[Title] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Copy__CopyStatus__403A8C7D]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy]  WITH CHECK ADD FOREIGN KEY([CopyStatusID])
REFERENCES [dbo].[CopyStatus] ([CopyStatusId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Copy__FormatType__5535A963]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy]  WITH CHECK ADD FOREIGN KEY([FormatTypeID])
REFERENCES [dbo].[FormatType] ([FormatTypeId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Copy__TitleID__4316F928]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy]  WITH CHECK ADD FOREIGN KEY([TitleID])
REFERENCES [dbo].[Title] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Copy__TitleID__440B1D61]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy]  WITH CHECK ADD FOREIGN KEY([TitleID])
REFERENCES [dbo].[Title] ([ID])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_SchoolDistrict]') AND parent_object_id = OBJECT_ID(N'[dbo].[School]'))
ALTER TABLE [dbo].[School]  WITH CHECK ADD  CONSTRAINT [fk_SchoolDistrict] FOREIGN KEY([DistrictID])
REFERENCES [dbo].[District] ([DistrictId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_SchoolDistrict]') AND parent_object_id = OBJECT_ID(N'[dbo].[School]'))
ALTER TABLE [dbo].[School] CHECK CONSTRAINT [fk_SchoolDistrict]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Schoo__32E0915F]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool]  WITH CHECK ADD  CONSTRAINT [FK__StudentTe__Schoo__32E0915F] FOREIGN KEY([SchoolID])
REFERENCES [dbo].[School] ([SchoolID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Schoo__32E0915F]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool] CHECK CONSTRAINT [FK__StudentTe__Schoo__32E0915F]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Schoo__4F7CD00D]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool]  WITH CHECK ADD  CONSTRAINT [FK__StudentTe__Schoo__4F7CD00D] FOREIGN KEY([SchoolID])
REFERENCES [dbo].[School] ([SchoolID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Schoo__4F7CD00D]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool] CHECK CONSTRAINT [FK__StudentTe__Schoo__4F7CD00D]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Stude__33D4B598]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool]  WITH CHECK ADD  CONSTRAINT [FK__StudentTe__Stude__33D4B598] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Stude__33D4B598]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool] CHECK CONSTRAINT [FK__StudentTe__Stude__33D4B598]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Stude__5070F446]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool]  WITH CHECK ADD  CONSTRAINT [FK__StudentTe__Stude__5070F446] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Stude__5070F446]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool] CHECK CONSTRAINT [FK__StudentTe__Stude__5070F446]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Teach__34C8D9D1]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool]  WITH CHECK ADD  CONSTRAINT [FK__StudentTe__Teach__34C8D9D1] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Teach__34C8D9D1]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool] CHECK CONSTRAINT [FK__StudentTe__Teach__34C8D9D1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Teach__5165187F]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool]  WITH CHECK ADD  CONSTRAINT [FK__StudentTe__Teach__5165187F] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__StudentTe__Teach__5165187F]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentTeacherSchool]'))
ALTER TABLE [dbo].[StudentTeacherSchool] CHECK CONSTRAINT [FK__StudentTe__Teach__5165187F]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Volume__CopyID__4BAC3F29]') AND parent_object_id = OBJECT_ID(N'[dbo].[Volume]'))
ALTER TABLE [dbo].[Volume]  WITH CHECK ADD FOREIGN KEY([CopyID])
REFERENCES [dbo].[Copy] ([CopyId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Volume__VolumeSt__4CA06362]') AND parent_object_id = OBJECT_ID(N'[dbo].[Volume]'))
ALTER TABLE [dbo].[Volume]  WITH CHECK ADD FOREIGN KEY([VolumeStatusID])
REFERENCES [dbo].[VolumeStatus] ([VolumeStatusId])
GO
USE [master]
GO
ALTER DATABASE [BookInventory] SET  READ_WRITE 
GO
