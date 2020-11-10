Use master
GO
CREATE DATABASE [CAAppBasicDB]
GO

USE [CAAppBasicDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeviceCodes]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeviceCodes](
	[UserCode] [nvarchar](200) NOT NULL,
	[DeviceCode] [nvarchar](200) NOT NULL,
	[SubjectId] [nvarchar](200) NULL,
	[ClientId] [nvarchar](200) NOT NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[Expiration] [datetime2](7) NOT NULL,
	[Data] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DeviceCodes] PRIMARY KEY CLUSTERED 
(
	[UserCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[GenderID] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED 
(
	[GenderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersistedGrants]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersistedGrants](
	[Key] [nvarchar](200) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[SubjectId] [nvarchar](200) NULL,
	[ClientId] [nvarchar](200) NOT NULL,
	[CreationTime] [datetime2](7) NOT NULL,
	[Expiration] [datetime2](7) NULL,
	[Data] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_PersistedGrants] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 11/10/2020 10:41:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [bigint] IDENTITY(1,1) NOT NULL,
	[SchoolAdmissionNumber] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[OtherNames] [nvarchar](101) NULL,
	[GenderID] [int] NOT NULL,
	[NationalityID] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[ConfirmPassword] [nvarchar](50) NOT NULL,
	[FatherSurname] [nvarchar](50) NULL,
	[FatherFirstName] [nvarchar](50) NULL,
	[FatherOtherNames] [nvarchar](101) NULL,
	[FatherNationalityID] [int] NULL,
	[FatherEmail] [nvarchar](50) NULL,
	[FatherTelephone] [nvarchar](50) NULL,
	[FatherProfession] [nvarchar](50) NULL,
	[FatherOffice] [nvarchar](100) NULL,
	[FatherResidentialAddress] [ntext] NULL,
	[MotherSurname] [nvarchar](50) NULL,
	[MotherFirstName] [nvarchar](50) NULL,
	[MotherOtherNames] [nvarchar](101) NULL,
	[MotherNationalityID] [int] NULL,
	[MotherEmail] [nvarchar](50) NULL,
	[MotherTelephone] [nvarchar](50) NULL,
	[MotherProfession] [nvarchar](50) NULL,
	[MotherOffice] [nvarchar](100) NULL,
	[MotherResidentialAddress] [ntext] NULL,
	[GuardianSurname] [nvarchar](50) NULL,
	[GuardianFirstName] [nvarchar](50) NULL,
	[GuardianOtherNames] [nvarchar](101) NULL,
	[GuardianNationalityID] [int] NULL,
	[GuardianEmail] [nvarchar](50) NULL,
	[GuardianTelephone] [nvarchar](50) NULL,
	[GuardianProfession] [nvarchar](50) NULL,
	[GuardianOffice] [nvarchar](100) NULL,
	[GuardianResidentialAddress] [ntext] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'3.1.4')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'101fec26-3c19-4d47-8cb9-393581fe1d26', N'Student', N'STUDENT', N'082a62fe-3547-475e-91aa-8daf9d140849')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'139bb7cc-3ca2-4c15-85d6-c685ec4170ed', N'SubjectTeacher', N'SUBJECTTEACHER', N'c96c770b-d7ba-4cac-ab81-369352ac7032')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'46ca60a8-1ecc-49ec-9d37-450879317dfe', N'ClassTeacher', N'CLASSTEACHER', N'dbb6505d-067b-40e0-a3ee-d04c455aa14f')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'694a5c58-8577-4c1d-8796-8106c17ed96e', N'SchoolAdmin', N'SCHOOLADMIN', N'8ce8c63e-4045-48c3-b540-9b9d268462a0')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'f6f5f82d-b115-45f6-893c-5418a3196571', N'SuperAdmin', N'SUPERADMIN', N'645173a6-5b7c-45dd-9b9f-30b4d69ffc4e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e14390e8-6438-4487-b9c5-e1abeb2e7d0a', N'f6f5f82d-b115-45f6-893c-5418a3196571')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e14390e8-6438-4487-b9c5-e1abeb2e7d0a', N'benjaminsqlserver', N'BENJAMINSQLSERVER', N'benjaminsqlserver', N'BENJAMINSQLSERVER', 0, N'AQAAAAEAACcQAAAAECAXsBSdxTmNDthMeoppcjSGKgMIjwpg4THPp4xAsK97Xf9yqG8NUS1YmDV9GVCp5Q==', N'JHZZHEDFPTAGRU5WT64MOZMCRAX4L5FC', N'f03ea2f4-65f3-4a46-9d0b-9748aa9f081d', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (1, N'Afghanistan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (2, N'Albania ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (3, N'Algeria ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (4, N'American Samoa ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (5, N'Andorra ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (6, N'Angola ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (7, N'Anguilla ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (8, N'Antigua & Barbuda ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (9, N'Argentina ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (10, N'Armenia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (11, N'Aruba ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (12, N'Australia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (13, N'Austria ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (14, N'Azerbaijan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (15, N'Bahamas, The ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (16, N'Bahrain ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (17, N'Bangladesh ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (18, N'Barbados ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (19, N'Belarus ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (20, N'Belgium ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (21, N'Belize ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (22, N'Benin ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (23, N'Bermuda ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (24, N'Bhutan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (25, N'Bolivia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (26, N'Bosnia & Herzegovina ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (27, N'Botswana ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (28, N'Brazil ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (29, N'British Virgin Is. ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (30, N'Brunei ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (31, N'Bulgaria ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (32, N'Burkina Faso ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (33, N'Burma ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (34, N'Burundi ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (35, N'Cambodia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (36, N'Cameroon ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (37, N'Canada ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (38, N'Cape Verde ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (39, N'Cayman Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (40, N'Central African Rep. ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (41, N'Chad ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (42, N'Chile ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (43, N'China ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (44, N'Colombia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (45, N'Comoros ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (46, N'Congo, Dem. Rep. ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (47, N'Congo, Repub. of the ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (48, N'Cook Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (49, N'Costa Rica ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (50, N'Cote d''Ivoire ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (51, N'Croatia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (52, N'Cuba ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (53, N'Cyprus ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (54, N'Czech Republic ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (55, N'Denmark ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (56, N'Djibouti ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (57, N'Dominica ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (58, N'Dominican Republic ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (59, N'East Timor ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (60, N'Ecuador ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (61, N'Egypt ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (62, N'El Salvador ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (63, N'Equatorial Guinea ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (64, N'Eritrea ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (65, N'Estonia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (66, N'Ethiopia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (67, N'Faroe Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (68, N'Fiji ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (69, N'Finland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (70, N'France ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (71, N'French Guiana ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (72, N'French Polynesia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (73, N'Gabon ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (74, N'Gambia, The ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (75, N'Gaza Strip ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (76, N'Georgia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (77, N'Germany ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (78, N'Ghana ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (79, N'Gibraltar ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (80, N'Greece ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (81, N'Greenland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (82, N'Grenada ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (83, N'Guadeloupe ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (84, N'Guam ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (85, N'Guatemala ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (86, N'Guernsey ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (87, N'Guinea ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (88, N'Guinea-Bissau ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (89, N'Guyana ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (90, N'Haiti ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (91, N'Honduras ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (92, N'Hong Kong ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (93, N'Hungary ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (94, N'Iceland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (95, N'India ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (96, N'Indonesia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (97, N'Iran ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (98, N'Iraq ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (99, N'Ireland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (100, N'Isle of Man ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (101, N'Israel ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (102, N'Italy ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (103, N'Jamaica ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (104, N'Japan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (105, N'Jersey ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (106, N'Jordan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (107, N'Kazakhstan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (108, N'Kenya ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (109, N'Kiribati ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (110, N'Korea, North ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (111, N'Korea, South ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (112, N'Kuwait ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (113, N'Kyrgyzstan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (114, N'Laos ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (115, N'Latvia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (116, N'Lebanon ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (117, N'Lesotho ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (118, N'Liberia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (119, N'Libya ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (120, N'Liechtenstein ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (121, N'Lithuania ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (122, N'Luxembourg ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (123, N'Macau ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (124, N'Macedonia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (125, N'Madagascar ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (126, N'Malawi ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (127, N'Malaysia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (128, N'Maldives ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (129, N'Mali ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (130, N'Malta ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (131, N'Marshall Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (132, N'Martinique ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (133, N'Mauritania ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (134, N'Mauritius ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (135, N'Mayotte ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (136, N'Mexico ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (137, N'Micronesia, Fed. St. ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (138, N'Moldova ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (139, N'Monaco ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (140, N'Mongolia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (141, N'Montserrat ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (142, N'Morocco ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (143, N'Mozambique ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (144, N'Namibia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (145, N'Nauru ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (146, N'Nepal ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (147, N'Netherlands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (148, N'Netherlands Antilles ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (149, N'New Caledonia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (150, N'New Zealand ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (151, N'Nicaragua ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (152, N'Niger ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (153, N'Nigeria ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (154, N'N. Mariana Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (155, N'Norway ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (156, N'Oman ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (157, N'Pakistan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (158, N'Palau ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (159, N'Panama ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (160, N'Papua New Guinea ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (161, N'Paraguay ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (162, N'Peru ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (163, N'Philippines ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (164, N'Poland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (165, N'Portugal ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (166, N'Puerto Rico ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (167, N'Qatar ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (168, N'Reunion ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (169, N'Romania ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (170, N'Russia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (171, N'Rwanda ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (172, N'Saint Helena ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (173, N'Saint Kitts & Nevis ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (174, N'Saint Lucia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (175, N'St Pierre & Miquelon ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (176, N'Saint Vincent and the Grenadines ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (177, N'Samoa ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (178, N'San Marino ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (179, N'Sao Tome & Principe ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (180, N'Saudi Arabia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (181, N'Senegal ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (182, N'Serbia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (183, N'Seychelles ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (184, N'Sierra Leone ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (185, N'Singapore ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (186, N'Slovakia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (187, N'Slovenia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (188, N'Solomon Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (189, N'Somalia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (190, N'South Africa ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (191, N'Spain ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (192, N'Sri Lanka ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (193, N'Sudan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (194, N'Suriname ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (195, N'Swaziland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (196, N'Sweden ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (197, N'Switzerland ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (198, N'Syria ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (199, N'Taiwan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (200, N'Tajikistan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (201, N'Tanzania ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (202, N'Thailand ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (203, N'Togo ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (204, N'Tonga ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (205, N'Trinidad & Tobago ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (206, N'Tunisia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (207, N'Turkey ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (208, N'Turkmenistan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (209, N'Turks & Caicos Is ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (210, N'Tuvalu ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (211, N'Uganda ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (212, N'Ukraine ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (213, N'United Arab Emirates ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (214, N'United Kingdom ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (215, N'United States ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (216, N'Uruguay ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (217, N'Uzbekistan ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (218, N'Vanuatu ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (219, N'Venezuela ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (220, N'Vietnam ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (221, N'Virgin Islands ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (222, N'Wallis and Futuna ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (223, N'West Bank ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (224, N'Western Sahara ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (225, N'Yemen ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (226, N'Zambia ')
GO
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (227, N'Zimbabwe ')
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Genders]    Script Date: 11/10/2020 10:41:16 AM ******/
ALTER TABLE [dbo].[Genders] ADD  CONSTRAINT [IX_Genders] UNIQUE NONCLUSTERED 
(
	[GenderName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Students]    Script Date: 11/10/2020 10:41:16 AM ******/
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [IX_Students] UNIQUE NONCLUSTERED 
(
	[SchoolAdmissionNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Students_1]    Script Date: 11/10/2020 10:41:16 AM ******/
ALTER TABLE [dbo].[Students] ADD  CONSTRAINT [IX_Students_1] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Countries] FOREIGN KEY([NationalityID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Countries]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Countries1] FOREIGN KEY([FatherNationalityID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Countries1]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Countries2] FOREIGN KEY([MotherNationalityID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Countries2]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Countries3] FOREIGN KEY([GuardianNationalityID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Countries3]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Genders] FOREIGN KEY([GenderID])
REFERENCES [dbo].[Genders] ([GenderID])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Genders]
GO
