USE [master]
GO
/****** Object:  Database [APP_Ecole]    Script Date: 24/06/2020 23:19:23 ******/
CREATE DATABASE [APP_Ecole]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'APP_Ecole', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\APP_Ecole.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'APP_Ecole_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\APP_Ecole_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [APP_Ecole] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [APP_Ecole].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [APP_Ecole] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [APP_Ecole] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [APP_Ecole] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [APP_Ecole] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [APP_Ecole] SET ARITHABORT OFF 
GO
ALTER DATABASE [APP_Ecole] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [APP_Ecole] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [APP_Ecole] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [APP_Ecole] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [APP_Ecole] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [APP_Ecole] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [APP_Ecole] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [APP_Ecole] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [APP_Ecole] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [APP_Ecole] SET  ENABLE_BROKER 
GO
ALTER DATABASE [APP_Ecole] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [APP_Ecole] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [APP_Ecole] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [APP_Ecole] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [APP_Ecole] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [APP_Ecole] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [APP_Ecole] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [APP_Ecole] SET RECOVERY FULL 
GO
ALTER DATABASE [APP_Ecole] SET  MULTI_USER 
GO
ALTER DATABASE [APP_Ecole] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [APP_Ecole] SET DB_CHAINING OFF 
GO
ALTER DATABASE [APP_Ecole] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [APP_Ecole] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [APP_Ecole] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'APP_Ecole', N'ON'
GO
ALTER DATABASE [APP_Ecole] SET QUERY_STORE = OFF
GO
USE [APP_Ecole]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [APP_Ecole]
GO
/****** Object:  Table [dbo].[Stagiaire]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stagiaire](
	[code_stagiaire] [int] IDENTITY(1,1) NOT NULL,
	[nom_st] [nvarchar](50) NULL,
	[prenom_st] [nvarchar](50) NULL,
	[adress_st] [nvarchar](50) NULL,
	[Photo] [image] NULL,
	[email_st] [nvarchar](50) NULL,
	[genre] [nvarchar](50) NULL,
	[tel_st] [nvarchar](50) NULL,
	[DateNaiss] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[code_stagiaire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscription]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscription](
	[code_stagiaire] [int] NOT NULL,
	[Code_groupe] [int] NULL,
	[dateInscription] [date] NULL,
 CONSTRAINT [PK_Inscription] PRIMARY KEY CLUSTERED 
(
	[code_stagiaire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groupe]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groupe](
	[Code_groupe] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Groupe] [nvarchar](50) NULL,
	[Année_scolaire] [nvarchar](50) NULL,
	[Année] [nvarchar](50) NULL,
	[CodeFil] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Code_groupe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GetStagaire]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[GetStagaire] as
select stgr.*,ins.Code_groupe ,gr.Nom_Groupe
from Stagiaire stgr,Inscription ins, Groupe gr
where stgr.code_stagiaire=ins.code_stagiaire
and ins.Code_groupe=gr.Code_groupe
GO
/****** Object:  Table [dbo].[Role]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compteUser]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compteUser](
	[code_User] [int] IDENTITY(1,1) NOT NULL,
	[LoginUser] [nvarchar](50) NULL,
	[mot_de_passe] [nvarchar](50) NULL,
	[IdRole] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[code_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[UserRoles]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script de la commande SelectTopNRows à partir de SSMS  ******/
CREATE VIEW [dbo].[UserRoles] AS
SELECT u.code_User,u.LoginUser,u.mot_de_passe,r.Name FROM compteUser AS u JOIN ROLE AS R ON u.IdRole = r.Id
GO
/****** Object:  Table [dbo].[Filière]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Filière](
	[code_Fil] [int] IDENTITY(1,1) NOT NULL,
	[nom_Fil] [nvarchar](50) NULL,
	[CodeNiveau] [int] NULL,
	[date_Création] [date] NULL,
	[code_secteur] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[code_Fil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Module]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Module](
	[code_mod] [int] IDENTITY(1,1) NOT NULL,
	[Intitulé_mod] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[code_mod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enseignant]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enseignant](
	[code_Ens] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](50) NULL,
	[prenom] [nvarchar](50) NULL,
	[cin] [nvarchar](50) NULL,
	[dateNaissance] [date] NULL,
	[adresse] [nvarchar](50) NULL,
	[tel] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[grade] [nvarchar](50) NULL,
	[statut] [nvarchar](50) NULL,
	[Genre] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[code_Ens] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Affecation]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Affecation](
	[code_Ens] [int] NULL,
	[code_mod] [int] NULL,
	[code_fil] [int] NULL,
	[date_affectation] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GetEnsegnient]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create view [dbo].[GetEnsegnient] as
select ens.*,fil.nom_Fil,mode.Intitulé_mod
from Enseignant ens,Affecation aff  , Module mode,Filière fil
where aff.code_Ens=ens.code_Ens
and mode.code_mod=aff.code_mod
and aff.code_fil=fil.code_Fil
GO
/****** Object:  Table [dbo].[Niveau]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Niveau](
	[Code_niveau] [int] IDENTITY(1,1) NOT NULL,
	[intitué_niveau] [nvarchar](50) NULL,
	[date_Création] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Code_niveau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Secteur]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Secteur](
	[code_sect] [int] IDENTITY(1,1) NOT NULL,
	[intitulé_sect] [nvarchar](50) NULL,
	[date_Création] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[code_sect] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GetFiliere]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GetFiliere]
AS
SELECT        fil.code_Fil AS Expr1, sect.intitulé_sect, niv.intitué_niveau, fil.nom_Fil, fil.date_Création
FROM            dbo.Secteur AS sect INNER JOIN
                         dbo.Filière AS fil ON sect.code_sect = fil.code_secteur INNER JOIN
                         dbo.Niveau AS niv ON fil.CodeNiveau = niv.Code_niveau
GO
/****** Object:  Table [dbo].[Diplome]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diplome](
	[Code_Diplome] [int] IDENTITY(1,1) NOT NULL,
	[IntituléDiplome] [nvarchar](50) NOT NULL,
	[Code_secteur] [int] NOT NULL,
	[Code_Niveau] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Code_Diplome] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GetDiplome]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[GetDiplome] as
select Code_Diplome,IntituléDiplome ,sec.intitulé_sect,niv.Code_niveau,sec.code_sect,niv.intitué_niveau
from Diplome dip, Secteur sec,Niveau niv
where dip.Code_Niveau=niv.Code_niveau
and dip.Code_secteur=sec.code_sect
GO
/****** Object:  Table [dbo].[ModuleFiliere]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModuleFiliere](
	[code_mod] [int] NOT NULL,
	[code_fil] [int] NULL,
	[masseHoraire] [nvarchar](50) NULL,
	[Coefficient] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[code_mod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GetModuleFiliere]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GetModuleFiliere]
AS
SELECT        fil.nom_Fil, mode.Intitulé_mod, modfil.masseHoraire, modfil.Coefficient, modfil.code_fil, modfil.code_mod
FROM            dbo.Module AS mode INNER JOIN
                         dbo.ModuleFiliere AS modfil ON mode.code_mod = modfil.code_mod INNER JOIN
                         dbo.Filière AS fil ON modfil.code_fil = fil.code_Fil
GO
/****** Object:  Table [dbo].[AnneeScolaire]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnneeScolaire](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[AnneeScolaire] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GetGroupes]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[GetGroupes] as
select gr.*,fil.nom_Fil,anne.AnneeScolaire
from Groupe gr,Filière fil,AnneeScolaire anne
where gr.Année_scolaire=anne.id
and gr.CodeFil= fil.code_Fil
GO
/****** Object:  Table [dbo].[Examen]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examen](
	[code_stagiaire] [int] NULL,
	[code_mod] [int] NULL,
	[DateExamen] [date] NULL,
	[Note] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolePermission]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolePermission](
	[IdRole] [int] NOT NULL,
	[IdPermission] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Affecation]  WITH CHECK ADD FOREIGN KEY([code_Ens])
REFERENCES [dbo].[Enseignant] ([code_Ens])
GO
ALTER TABLE [dbo].[Affecation]  WITH CHECK ADD  CONSTRAINT [Fk_fil] FOREIGN KEY([code_fil])
REFERENCES [dbo].[Filière] ([code_Fil])
GO
ALTER TABLE [dbo].[Affecation] CHECK CONSTRAINT [Fk_fil]
GO
ALTER TABLE [dbo].[Affecation]  WITH CHECK ADD  CONSTRAINT [Fk_Mode] FOREIGN KEY([code_mod])
REFERENCES [dbo].[Module] ([code_mod])
GO
ALTER TABLE [dbo].[Affecation] CHECK CONSTRAINT [Fk_Mode]
GO
ALTER TABLE [dbo].[compteUser]  WITH CHECK ADD  CONSTRAINT [FK_compteUser_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[compteUser] CHECK CONSTRAINT [FK_compteUser_Role]
GO
ALTER TABLE [dbo].[Diplome]  WITH CHECK ADD FOREIGN KEY([Code_secteur])
REFERENCES [dbo].[Secteur] ([code_sect])
GO
ALTER TABLE [dbo].[Diplome]  WITH CHECK ADD  CONSTRAINT [Fk_Niveau] FOREIGN KEY([Code_Niveau])
REFERENCES [dbo].[Niveau] ([Code_niveau])
GO
ALTER TABLE [dbo].[Diplome] CHECK CONSTRAINT [Fk_Niveau]
GO
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD  CONSTRAINT [FK_Examen_Stagiaire] FOREIGN KEY([code_stagiaire])
REFERENCES [dbo].[Stagiaire] ([code_stagiaire])
GO
ALTER TABLE [dbo].[Examen] CHECK CONSTRAINT [FK_Examen_Stagiaire]
GO
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD  CONSTRAINT [fk_group] FOREIGN KEY([code_mod])
REFERENCES [dbo].[Groupe] ([Code_groupe])
GO
ALTER TABLE [dbo].[Examen] CHECK CONSTRAINT [fk_group]
GO
ALTER TABLE [dbo].[Filière]  WITH CHECK ADD FOREIGN KEY([CodeNiveau])
REFERENCES [dbo].[Niveau] ([Code_niveau])
GO
ALTER TABLE [dbo].[Filière]  WITH CHECK ADD  CONSTRAINT [FK_secteur] FOREIGN KEY([code_secteur])
REFERENCES [dbo].[Secteur] ([code_sect])
GO
ALTER TABLE [dbo].[Filière] CHECK CONSTRAINT [FK_secteur]
GO
ALTER TABLE [dbo].[Groupe]  WITH CHECK ADD FOREIGN KEY([CodeFil])
REFERENCES [dbo].[Filière] ([code_Fil])
GO
ALTER TABLE [dbo].[Inscription]  WITH CHECK ADD FOREIGN KEY([Code_groupe])
REFERENCES [dbo].[Groupe] ([Code_groupe])
GO
ALTER TABLE [dbo].[Inscription]  WITH CHECK ADD  CONSTRAINT [FK_Inscription_Stagiaire1] FOREIGN KEY([code_stagiaire])
REFERENCES [dbo].[Stagiaire] ([code_stagiaire])
GO
ALTER TABLE [dbo].[Inscription] CHECK CONSTRAINT [FK_Inscription_Stagiaire1]
GO
ALTER TABLE [dbo].[ModuleFiliere]  WITH CHECK ADD  CONSTRAINT [fk] FOREIGN KEY([code_mod])
REFERENCES [dbo].[Module] ([code_mod])
GO
ALTER TABLE [dbo].[ModuleFiliere] CHECK CONSTRAINT [fk]
GO
ALTER TABLE [dbo].[ModuleFiliere]  WITH CHECK ADD FOREIGN KEY([code_fil])
REFERENCES [dbo].[Filière] ([code_Fil])
GO
ALTER TABLE [dbo].[RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_RolePermission_Permission] FOREIGN KEY([IdPermission])
REFERENCES [dbo].[Permission] ([Id])
GO
ALTER TABLE [dbo].[RolePermission] CHECK CONSTRAINT [FK_RolePermission_Permission]
GO
ALTER TABLE [dbo].[RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_RolePermission_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[RolePermission] CHECK CONSTRAINT [FK_RolePermission_Role]
GO
/****** Object:  StoredProcedure [dbo].[GetExams]    Script Date: 24/06/2020 23:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[GetExams] 
@CodeGroupe int ,
@codeModule int
as
begin
select strg.code_stagiaire,strg.nom_st,strg.prenom_st ,mode.Intitulé_mod
from Stagiaire strg , Inscription ins,Module mode
where strg.code_stagiaire=ins.code_stagiaire
and ins.Code_groupe=@CodeGroupe
and mode.code_mod=@codeModule
end
GO
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
         Begin Table = "sect"
            Begin Extent = 
               Top = 22
               Left = 497
               Bottom = 135
               Right = 706
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fil"
            Begin Extent = 
               Top = 25
               Left = 286
               Bottom = 155
               Right = 495
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "niv"
            Begin Extent = 
               Top = 84
               Left = 38
               Bottom = 365
               Right = 247
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GetFiliere'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GetFiliere'
GO
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
         Begin Table = "mode"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "modfil"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 232
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fil"
            Begin Extent = 
               Top = 234
               Left = 38
               Bottom = 364
               Right = 247
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GetModuleFiliere'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GetModuleFiliere'
GO
USE [master]
GO
ALTER DATABASE [APP_Ecole] SET  READ_WRITE 
GO
