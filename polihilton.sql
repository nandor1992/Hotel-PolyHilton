SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoomTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RoomTypes](
	[r_type_id] [int] IDENTITY(1,1) NOT NULL,
	[capacity] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[price] [int] NOT NULL,
 CONSTRAINT [PK_RoomTypes] PRIMARY KEY CLUSTERED 
(
	[r_type_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserTypes](
	[u_type_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserTypes] PRIMARY KEY CLUSTERED 
(
	[u_type_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Rooms]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Rezervations]') AND type in (N'U'))
BEGIN
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
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cleaning]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Cleaning](
	[clean_id] [int] IDENTITY(1,1) NOT NULL,
	[r_id] [int] NOT NULL,
	[u_id] [int] NOT NULL,
	[status] [varchar](50) NOT NULL,
	[date_required] [datetime] NOT NULL,
 CONSTRAINT [PK_Cleaning] PRIMARY KEY CLUSTERED 
(
	[clean_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Users](
	[u_id] [int] NOT NULL,
	[u_type_id] [int] NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[u_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Discounts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Discounts](
	[d_id] [int] IDENTITY(1,1) NOT NULL,
	[r_id] [int] NOT NULL,
	[price] [int] NOT NULL,
 CONSTRAINT [PK_Discounts] PRIMARY KEY CLUSTERED 
(
	[d_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Rooms_RoomTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Rooms]'))
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_RoomTypes] FOREIGN KEY([r_type_id])
REFERENCES [dbo].[RoomTypes] ([r_type_id])
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_RoomTypes]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Rezervations_Rooms]') AND parent_object_id = OBJECT_ID(N'[dbo].[Rezervations]'))
ALTER TABLE [dbo].[Rezervations]  WITH CHECK ADD  CONSTRAINT [FK_Rezervations_Rooms] FOREIGN KEY([r_id])
REFERENCES [dbo].[Rooms] ([r_id])
GO
ALTER TABLE [dbo].[Rezervations] CHECK CONSTRAINT [FK_Rezervations_Rooms]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Rezervations_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Rezervations]'))
ALTER TABLE [dbo].[Rezervations]  WITH CHECK ADD  CONSTRAINT [FK_Rezervations_Users] FOREIGN KEY([u_id])
REFERENCES [dbo].[Users] ([u_id])
GO
ALTER TABLE [dbo].[Rezervations] CHECK CONSTRAINT [FK_Rezervations_Users]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Cleaning_Rooms]') AND parent_object_id = OBJECT_ID(N'[dbo].[Cleaning]'))
ALTER TABLE [dbo].[Cleaning]  WITH CHECK ADD  CONSTRAINT [FK_Cleaning_Rooms] FOREIGN KEY([r_id])
REFERENCES [dbo].[Rooms] ([r_id])
GO
ALTER TABLE [dbo].[Cleaning] CHECK CONSTRAINT [FK_Cleaning_Rooms]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Cleaning_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Cleaning]'))
ALTER TABLE [dbo].[Cleaning]  WITH CHECK ADD  CONSTRAINT [FK_Cleaning_Users] FOREIGN KEY([u_id])
REFERENCES [dbo].[Users] ([u_id])
GO
ALTER TABLE [dbo].[Cleaning] CHECK CONSTRAINT [FK_Cleaning_Users]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Users_UserTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserTypes] FOREIGN KEY([u_type_id])
REFERENCES [dbo].[UserTypes] ([u_type_id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserTypes]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Discounts_Rooms]') AND parent_object_id = OBJECT_ID(N'[dbo].[Discounts]'))
ALTER TABLE [dbo].[Discounts]  WITH CHECK ADD  CONSTRAINT [FK_Discounts_Rooms] FOREIGN KEY([r_id])
REFERENCES [dbo].[Rooms] ([r_id])
GO
ALTER TABLE [dbo].[Discounts] CHECK CONSTRAINT [FK_Discounts_Rooms]
