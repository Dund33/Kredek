USE [master]
GO
/****** Object:  Database [LukaszDrozdzLab5Homework]    Script Date: 5/20/2019 11:08:39 PM ******/
CREATE DATABASE [LukaszDrozdzLab5Homework]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LukaszDrozdzLab5Homework', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\LukaszDrozdzLab5Homework.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LukaszDrozdzLab5Homework_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\LukaszDrozdzLab5Homework_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LukaszDrozdzLab5Homework].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET ARITHABORT OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET  MULTI_USER 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET QUERY_STORE = OFF
GO
USE [LukaszDrozdzLab5Homework]
GO
/****** Object:  Table [dbo].[CoalTypes]    Script Date: 5/20/2019 11:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoalTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CoalName] [nvarchar](63) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CoalCertificates]    Script Date: 5/20/2019 11:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoalCertificates](
	[CoalID] [int] NOT NULL,
	[Wex] [float] NOT NULL,
	[Wa] [float] NOT NULL,
	[Wtr] [float] NOT NULL,
	[Ar] [float] NOT NULL,
	[Ad] [float] NOT NULL,
	[Str] [float] NOT NULL,
	[Std] [float] NOT NULL,
	[Vdaf] [float] NOT NULL,
	[Ri] [float] NOT NULL,
	[Qir] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 5/20/2019 11:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[CoalID] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[Price] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CoalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[CoalFull]    Script Date: 5/20/2019 11:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CoalFull] As(
	SELECT ID, CoalName, Amount, Price ,Wex, Wa, Wtr, Ar, Ad, Str, Std, Vdaf, Ri, Qir FROM CoalTypes JOIN CoalCertificates ON
	CoalTypes.ID = CoalCertificates.CoalID JOIN Stock ON Stock.CoalID = CoalTypes.ID
)
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 5/20/2019 11:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](63) NOT NULL,
	[LastName] [nvarchar](63) NOT NULL,
	[Address] [nvarchar](127) NOT NULL,
	[PESEL] [nvarchar](31) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 5/20/2019 11:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PESEL] [nvarchar](31) NOT NULL,
	[CoalID] [int] NOT NULL,
	[AmountOfCoal] [float] NOT NULL,
	[Cost] [money] NOT NULL,
	[Tax] [money] NOT NULL,
	[DocumentID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[CoalBasic]    Script Date: 5/20/2019 11:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CoalBasic] As(
	Select ID, CoalName, Amount, Price From CoalTypes 
	JOIN Stock ON CoalTypes.ID = Stock.CoalID
)
GO
/****** Object:  View [dbo].[TransactionFull]    Script Date: 5/20/2019 11:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TransactionFull]
AS
SELECT        dbo.CoalBasic.CoalName, dbo.Clients.FirstName, dbo.Clients.LastName, dbo.Clients.PESEL, dbo.Transactions.AmountOfCoal, dbo.Transactions.Cost, dbo.Transactions.Tax, dbo.Transactions.DocumentID
FROM            dbo.Transactions INNER JOIN
                         dbo.CoalBasic ON dbo.Transactions.CoalID = dbo.CoalBasic.ID INNER JOIN
                         dbo.Clients ON dbo.Clients.PESEL = dbo.Transactions.PESEL
GO
/****** Object:  Table [dbo].[Deliveries]    Script Date: 5/20/2019 11:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deliveries](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CoalID] [int] NOT NULL,
	[AmountOfCoal] [float] NOT NULL,
	[Cost] [money] NOT NULL,
	[Tax] [money] NOT NULL,
	[DocumentID] [nvarchar](63) NOT NULL,
	[Date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionsAnonymous]    Script Date: 5/20/2019 11:08:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionsAnonymous](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DocumentID] [nvarchar](63) NOT NULL,
	[ClientFirstName] [nvarchar](63) NULL,
	[ClientLastName] [nvarchar](63) NOT NULL,
	[ClientAddress] [nvarchar](255) NOT NULL,
	[PESEL] [nvarchar](15) NOT NULL,
	[CoalID] [int] NOT NULL,
	[AmountOfCoal] [float] NOT NULL,
	[Cost] [money] NOT NULL,
	[Tax] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ID], [FirstName], [LastName], [Address], [PESEL]) VALUES (1, N'Jan', N'Kowalski', N'Prusa 22 Wrocław', N'12121212121')
INSERT [dbo].[Clients] ([ID], [FirstName], [LastName], [Address], [PESEL]) VALUES (2, N'Zdenek', N'Smetana', N'22 Cerny Most Praha', N'1234')
SET IDENTITY_INSERT [dbo].[Clients] OFF
INSERT [dbo].[CoalCertificates] ([CoalID], [Wex], [Wa], [Wtr], [Ar], [Ad], [Str], [Std], [Vdaf], [Ri], [Qir]) VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[CoalCertificates] ([CoalID], [Wex], [Wa], [Wtr], [Ar], [Ad], [Str], [Std], [Vdaf], [Ri], [Qir]) VALUES (2, 2, 2, 3, 2, 12, 2, 0, 1, 122, 2)
SET IDENTITY_INSERT [dbo].[CoalTypes] ON 

INSERT [dbo].[CoalTypes] ([ID], [CoalName]) VALUES (1, N'Groszek')
INSERT [dbo].[CoalTypes] ([ID], [CoalName]) VALUES (2, N'Kostka')
SET IDENTITY_INSERT [dbo].[CoalTypes] OFF
SET IDENTITY_INSERT [dbo].[Deliveries] ON 

INSERT [dbo].[Deliveries] ([ID], [CoalID], [AmountOfCoal], [Cost], [Tax], [DocumentID], [Date]) VALUES (1, 1, 10, 0.0000, 0.0000, N'0', CAST(N'2019-05-19' AS Date))
INSERT [dbo].[Deliveries] ([ID], [CoalID], [AmountOfCoal], [Cost], [Tax], [DocumentID], [Date]) VALUES (2, 1, 1000, 200.0000, 46.0000, N'22/23', CAST(N'2019-05-19' AS Date))
INSERT [dbo].[Deliveries] ([ID], [CoalID], [AmountOfCoal], [Cost], [Tax], [DocumentID], [Date]) VALUES (3, 2, 10, 10.0000, 10.0000, N'10', CAST(N'2019-05-19' AS Date))
INSERT [dbo].[Deliveries] ([ID], [CoalID], [AmountOfCoal], [Cost], [Tax], [DocumentID], [Date]) VALUES (4, 3, 1, 1.0000, 1.0000, N'1a', CAST(N'2019-05-19' AS Date))
INSERT [dbo].[Deliveries] ([ID], [CoalID], [AmountOfCoal], [Cost], [Tax], [DocumentID], [Date]) VALUES (5, 1, 1000, 800.0000, 100.0000, N'23', CAST(N'1995-05-20' AS Date))
INSERT [dbo].[Deliveries] ([ID], [CoalID], [AmountOfCoal], [Cost], [Tax], [DocumentID], [Date]) VALUES (6, 2, 1000, 1200.0000, 200.0000, N'42', CAST(N'2019-05-20' AS Date))
SET IDENTITY_INSERT [dbo].[Deliveries] OFF
INSERT [dbo].[Stock] ([CoalID], [Amount], [Price]) VALUES (1, 500, 10.0000)
INSERT [dbo].[Stock] ([CoalID], [Amount], [Price]) VALUES (2, 900, 120.0000)
SET IDENTITY_INSERT [dbo].[Transactions] ON 

INSERT [dbo].[Transactions] ([ID], [PESEL], [CoalID], [AmountOfCoal], [Cost], [Tax], [DocumentID]) VALUES (1, N'12121212121', 1, 100, 1000.0000, 230.0000, 29)
INSERT [dbo].[Transactions] ([ID], [PESEL], [CoalID], [AmountOfCoal], [Cost], [Tax], [DocumentID]) VALUES (2, N'12121212121', 1, 100, 1000.0000, 230.0000, 30)
INSERT [dbo].[Transactions] ([ID], [PESEL], [CoalID], [AmountOfCoal], [Cost], [Tax], [DocumentID]) VALUES (3, N'1234', 2, 100, 12000.0000, 2760.0000, 89)
SET IDENTITY_INSERT [dbo].[Transactions] OFF
SET IDENTITY_INSERT [dbo].[TransactionsAnonymous] ON 

INSERT [dbo].[TransactionsAnonymous] ([ID], [DocumentID], [ClientFirstName], [ClientLastName], [ClientAddress], [PESEL], [CoalID], [AmountOfCoal], [Cost], [Tax]) VALUES (1, N'22/2019', N'Jan', N'Kowalski', N'Cośtam', N'13123124', 1, 100, 10000.0000, 2300.0000)
INSERT [dbo].[TransactionsAnonymous] ([ID], [DocumentID], [ClientFirstName], [ClientLastName], [ClientAddress], [PESEL], [CoalID], [AmountOfCoal], [Cost], [Tax]) VALUES (2, N'22/12', N'a', N'b', N'1', N'1', 2, 50, 5100.0000, 1173.0000)
INSERT [dbo].[TransactionsAnonymous] ([ID], [DocumentID], [ClientFirstName], [ClientLastName], [ClientAddress], [PESEL], [CoalID], [AmountOfCoal], [Cost], [Tax]) VALUES (3, N'1', N'Jan', N'Kowalski', N'12', N'12', 3, 1, 100.0000, 23.0000)
INSERT [dbo].[TransactionsAnonymous] ([ID], [DocumentID], [ClientFirstName], [ClientLastName], [ClientAddress], [PESEL], [CoalID], [AmountOfCoal], [Cost], [Tax]) VALUES (4, N'1', N'Jan', N'Kowalski', N'we', N'11212', 1, 0, 0.0000, 0.0000)
SET IDENTITY_INSERT [dbo].[TransactionsAnonymous] OFF
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Transactions"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "CoalBasic"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Clients"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TransactionFull'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TransactionFull'
GO
USE [master]
GO
ALTER DATABASE [LukaszDrozdzLab5Homework] SET  READ_WRITE 
GO
