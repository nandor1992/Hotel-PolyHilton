USE [master]
GO
/****** Object:  Database [Polihilton]    Script Date: 29.04.2014 19:30:20 ******/
CREATE DATABASE [Polihilton]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Polihilton', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Polihilton.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Polihilton_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Polihilton_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Polihilton] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Polihilton].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Polihilton] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Polihilton] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Polihilton] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Polihilton] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Polihilton] SET ARITHABORT OFF 
GO
ALTER DATABASE [Polihilton] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Polihilton] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Polihilton] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Polihilton] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Polihilton] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Polihilton] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Polihilton] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Polihilton] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Polihilton] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Polihilton] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Polihilton] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Polihilton] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Polihilton] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Polihilton] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Polihilton] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Polihilton] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Polihilton] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Polihilton] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Polihilton] SET RECOVERY FULL 
GO
ALTER DATABASE [Polihilton] SET  MULTI_USER 
GO
ALTER DATABASE [Polihilton] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Polihilton] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Polihilton] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Polihilton] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Polihilton]
GO
/****** Object:  Table [dbo].[Cleaning]    Script Date: 29.04.2014 19:30:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cleaning](
	[clean_id] [int] IDENTITY(1,1) NOT NULL,
	[r_id] [int] NOT NULL,
	[u_id] [int] NOT NULL,
	[status] [varchar](50) NOT NULL,
	[date_required] [datetime] NOT NULL,
 CONSTRAINT [PK_Cleaning] PRIMARY KEY CLUSTERED 
(
	[clean_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Discounts]    Script Date: 29.04.2014 19:30:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discounts](
	[d_id] [int] IDENTITY(1,1) NOT NULL,
	[r_id] [int] NOT NULL,
	[price] [int] NOT NULL,
 CONSTRAINT [PK_Discounts] PRIMARY KEY CLUSTERED 
(
	[d_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rezervations]    Script Date: 29.04.2014 19:30:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervations](
	[rez_id] [int] IDENTITY(1,1) NOT NULL,
	[u_id] [int] NOT NULL,
	[r_id] [int] NOT NULL,
	[start_date] [datetime] NOT NULL,
	[end_date] [datetime] NOT NULL,
	[rez_price] [int] NOT NULL,
 CONSTRAINT [PK_Rezervations] PRIMARY KEY CLUSTERED 
(
	[rez_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 29.04.2014 19:30:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rooms](
	[r_id] [int] IDENTITY(1,1) NOT NULL,
	[r_type_id] [int] NOT NULL,
	[r_number] [int] NOT NULL,
	[r_floor] [int] NOT NULL,
	[orientation] [varchar](50) NOT NULL,
	[surface] [int] NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[r_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoomTypes]    Script Date: 29.04.2014 19:30:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RoomTypes](
	[r_type_id] [int] IDENTITY(1,1) NOT NULL,
	[capacity] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[price] [int] NOT NULL,
 CONSTRAINT [PK_RoomTypes] PRIMARY KEY CLUSTERED 
(
	[r_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 29.04.2014 19:30:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[u_id] [int] IDENTITY(1,1) NOT NULL,
	[u_type_id] [int] NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[u_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserTypes]    Script Date: 29.04.2014 19:30:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserTypes](
	[u_type_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserTypes] PRIMARY KEY CLUSTERED 
(
	[u_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cleaning] ON 

INSERT [dbo].[Cleaning] ([clean_id], [r_id], [u_id], [status], [date_required]) VALUES (1, 4, 3, N'Pending', CAST(0x0000A31C00000000 AS DateTime))
INSERT [dbo].[Cleaning] ([clean_id], [r_id], [u_id], [status], [date_required]) VALUES (2, 8, 3, N'Cleaned', CAST(0x0000A31800000000 AS DateTime))
INSERT [dbo].[Cleaning] ([clean_id], [r_id], [u_id], [status], [date_required]) VALUES (3, 19, 3, N'Cleaned', CAST(0x0000A2E400000000 AS DateTime))
INSERT [dbo].[Cleaning] ([clean_id], [r_id], [u_id], [status], [date_required]) VALUES (4, 21, 3, N'Pending', CAST(0x0000A31C00000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Cleaning] OFF
SET IDENTITY_INSERT [dbo].[Discounts] ON 

INSERT [dbo].[Discounts] ([d_id], [r_id], [price]) VALUES (1, 8, 170)
INSERT [dbo].[Discounts] ([d_id], [r_id], [price]) VALUES (2, 22, 100)
INSERT [dbo].[Discounts] ([d_id], [r_id], [price]) VALUES (3, 18, 90)
SET IDENTITY_INSERT [dbo].[Discounts] OFF
SET IDENTITY_INSERT [dbo].[Rezervations] ON 

INSERT [dbo].[Rezervations] ([rez_id], [u_id], [r_id], [start_date], [end_date], [rez_price]) VALUES (1, 1, 3, CAST(0x0000A35500000000 AS DateTime), CAST(0x0000A35800000000 AS DateTime), 90)
INSERT [dbo].[Rezervations] ([rez_id], [u_id], [r_id], [start_date], [end_date], [rez_price]) VALUES (2, 1, 10, CAST(0x0000A31E00000000 AS DateTime), CAST(0x0000A32700000000 AS DateTime), 100)
INSERT [dbo].[Rezervations] ([rez_id], [u_id], [r_id], [start_date], [end_date], [rez_price]) VALUES (3, 2, 8, CAST(0x0000A33D00000000 AS DateTime), CAST(0x0000A34A00000000 AS DateTime), 170)
INSERT [dbo].[Rezervations] ([rez_id], [u_id], [r_id], [start_date], [end_date], [rez_price]) VALUES (4, 2, 21, CAST(0x0000A39A00000000 AS DateTime), CAST(0x0000A39D00000000 AS DateTime), 90)
SET IDENTITY_INSERT [dbo].[Rezervations] OFF
SET IDENTITY_INSERT [dbo].[Rooms] ON 

INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (1, 3, 101, 1, N'Sea', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (2, 2, 102, 1, N'Sea', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (3, 1, 103, 1, N'Sea', 25)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (4, 5, 104, 1, N'Sea', 40)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (5, 4, 105, 1, N'Sea', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (6, 1, 106, 1, N'Sea', 25)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (7, 5, 107, 1, N'Sea', 40)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (8, 5, 108, 1, N'City', 40)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (10, 3, 109, 1, N'City', 35)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (11, 2, 110, 1, N'City', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (12, 1, 111, 1, N'City', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (13, 5, 112, 1, N'City', 40)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (14, 4, 113, 1, N'City', 35)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (15, 3, 201, 2, N'Sea', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (16, 3, 202, 2, N'Sea', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (17, 4, 203, 2, N'Sea', 35)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (18, 1, 204, 2, N'Sea', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (19, 6, 205, 2, N'Sea', 80)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (20, 5, 206, 2, N'City', 40)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (21, 3, 207, 2, N'City', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (22, 2, 208, 2, N'City', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (23, 3, 209, 2, N'City', 30)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (24, 4, 210, 2, N'City', 35)
INSERT [dbo].[Rooms] ([r_id], [r_type_id], [r_number], [r_floor], [orientation], [surface]) VALUES (25, 7, 211, 2, N'City', 85)
SET IDENTITY_INSERT [dbo].[Rooms] OFF
SET IDENTITY_INSERT [dbo].[RoomTypes] ON 

INSERT [dbo].[RoomTypes] ([r_type_id], [capacity], [name], [price]) VALUES (1, 1, N'Single', 90)
INSERT [dbo].[RoomTypes] ([r_type_id], [capacity], [name], [price]) VALUES (2, 2, N'Twin', 120)
INSERT [dbo].[RoomTypes] ([r_type_id], [capacity], [name], [price]) VALUES (3, 2, N'Double', 100)
INSERT [dbo].[RoomTypes] ([r_type_id], [capacity], [name], [price]) VALUES (4, 3, N'Double Extra', 150)
INSERT [dbo].[RoomTypes] ([r_type_id], [capacity], [name], [price]) VALUES (5, 4, N'Family', 200)
INSERT [dbo].[RoomTypes] ([r_type_id], [capacity], [name], [price]) VALUES (6, 2, N'Presidential Suite', 500)
INSERT [dbo].[RoomTypes] ([r_type_id], [capacity], [name], [price]) VALUES (7, 2, N'Executive Suite', 400)
SET IDENTITY_INSERT [dbo].[RoomTypes] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([u_id], [u_type_id], [username], [password], [firstName], [lastName]) VALUES (1, 1, N'username1', N'password1', N'Test', N'User')
INSERT [dbo].[Users] ([u_id], [u_type_id], [username], [password], [firstName], [lastName]) VALUES (2, 1, N'username2', N'password2', N'Test2', N'User2')
INSERT [dbo].[Users] ([u_id], [u_type_id], [username], [password], [firstName], [lastName]) VALUES (3, 2, N'admin', N'admin', N'Administrator', N'Retea')
INSERT [dbo].[Users] ([u_id], [u_type_id], [username], [password], [firstName], [lastName]) VALUES (4, 3, N'cleaninglady', N'cleaning', N'Cleaning', N'Lady')
INSERT [dbo].[Users] ([u_id], [u_type_id], [username], [password], [firstName], [lastName]) VALUES (5, 4, N'receptionlady', N'reception', N'Reception', N'Lady')
SET IDENTITY_INSERT [dbo].[Users] OFF
SET IDENTITY_INSERT [dbo].[UserTypes] ON 

INSERT [dbo].[UserTypes] ([u_type_id], [name]) VALUES (1, N'normal')
INSERT [dbo].[UserTypes] ([u_type_id], [name]) VALUES (2, N'admin')
INSERT [dbo].[UserTypes] ([u_type_id], [name]) VALUES (3, N'cleaning')
INSERT [dbo].[UserTypes] ([u_type_id], [name]) VALUES (4, N'reception')
SET IDENTITY_INSERT [dbo].[UserTypes] OFF
ALTER TABLE [dbo].[Cleaning]  WITH CHECK ADD  CONSTRAINT [FK_Cleaning_Rooms] FOREIGN KEY([r_id])
REFERENCES [dbo].[Rooms] ([r_id])
GO
ALTER TABLE [dbo].[Cleaning] CHECK CONSTRAINT [FK_Cleaning_Rooms]
GO
ALTER TABLE [dbo].[Cleaning]  WITH CHECK ADD  CONSTRAINT [FK_Cleaning_Users] FOREIGN KEY([u_id])
REFERENCES [dbo].[Users] ([u_id])
GO
ALTER TABLE [dbo].[Cleaning] CHECK CONSTRAINT [FK_Cleaning_Users]
GO
ALTER TABLE [dbo].[Discounts]  WITH CHECK ADD  CONSTRAINT [FK_Discounts_Rooms] FOREIGN KEY([r_id])
REFERENCES [dbo].[Rooms] ([r_id])
GO
ALTER TABLE [dbo].[Discounts] CHECK CONSTRAINT [FK_Discounts_Rooms]
GO
ALTER TABLE [dbo].[Rezervations]  WITH CHECK ADD  CONSTRAINT [FK_Rezervations_Rooms] FOREIGN KEY([r_id])
REFERENCES [dbo].[Rooms] ([r_id])
GO
ALTER TABLE [dbo].[Rezervations] CHECK CONSTRAINT [FK_Rezervations_Rooms]
GO
ALTER TABLE [dbo].[Rezervations]  WITH CHECK ADD  CONSTRAINT [FK_Rezervations_Users] FOREIGN KEY([u_id])
REFERENCES [dbo].[Users] ([u_id])
GO
ALTER TABLE [dbo].[Rezervations] CHECK CONSTRAINT [FK_Rezervations_Users]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_RoomTypes] FOREIGN KEY([r_type_id])
REFERENCES [dbo].[RoomTypes] ([r_type_id])
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_RoomTypes]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserTypes] FOREIGN KEY([u_type_id])
REFERENCES [dbo].[UserTypes] ([u_type_id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserTypes]
GO
USE [master]
GO
ALTER DATABASE [Polihilton] SET  READ_WRITE 
GO
