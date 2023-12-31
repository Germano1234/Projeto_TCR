USE [master]
GO
/****** Object:  Database [AgendaTCR]    Script Date: 12/31/2023 5:35:35 PM ******/
CREATE DATABASE [AgendaTCR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AgendaTCR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\AgendaTCR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AgendaTCR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\AgendaTCR_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AgendaTCR] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AgendaTCR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AgendaTCR] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AgendaTCR] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AgendaTCR] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AgendaTCR] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AgendaTCR] SET ARITHABORT OFF 
GO
ALTER DATABASE [AgendaTCR] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AgendaTCR] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AgendaTCR] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AgendaTCR] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AgendaTCR] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AgendaTCR] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AgendaTCR] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AgendaTCR] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AgendaTCR] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AgendaTCR] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AgendaTCR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AgendaTCR] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AgendaTCR] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AgendaTCR] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AgendaTCR] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AgendaTCR] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AgendaTCR] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AgendaTCR] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AgendaTCR] SET  MULTI_USER 
GO
ALTER DATABASE [AgendaTCR] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AgendaTCR] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AgendaTCR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AgendaTCR] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AgendaTCR] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AgendaTCR] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AgendaTCR] SET QUERY_STORE = ON
GO
ALTER DATABASE [AgendaTCR] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AgendaTCR]
GO
/****** Object:  Table [dbo].[Agenda]    Script Date: 12/31/2023 5:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agenda](
	[Id_Agenda] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](10) NULL,
	[Data_Agenda] [date] NULL,
	[Hora] [varchar](10) NULL,
	[Id_Usuario] [int] NULL,
	[Id_Quadra] [int] NULL,
 CONSTRAINT [PK_Agenda] PRIMARY KEY CLUSTERED 
(
	[Id_Agenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jogo]    Script Date: 12/31/2023 5:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jogo](
	[Id_Jogo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Jogo] [nchar](10) NULL,
	[Id_Tenista1] [int] NULL,
	[Id_Tenista2] [int] NULL,
	[Id_Tenista3] [int] NULL,
	[Id_Tenista4] [int] NULL,
 CONSTRAINT [PK_Jogo] PRIMARY KEY CLUSTERED 
(
	[Id_Jogo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professor]    Script Date: 12/31/2023 5:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[Id_Professor] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[Contato] [varchar](50) NULL,
	[Nivel] [varchar](50) NULL,
 CONSTRAINT [PK_Professor] PRIMARY KEY CLUSTERED 
(
	[Id_Professor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quadra]    Script Date: 12/31/2023 5:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quadra](
	[Id_Quadra] [int] IDENTITY(1,1) NOT NULL,
	[Piso] [varchar](50) NULL,
	[Coberta] [varchar](10) NULL,
 CONSTRAINT [PK_Quadra] PRIMARY KEY CLUSTERED 
(
	[Id_Quadra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tenista]    Script Date: 12/31/2023 5:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tenista](
	[Id_Tenista] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NULL,
	[Contato] [nchar](30) NULL,
	[UTR] [float] NULL,
 CONSTRAINT [PK_Tenista] PRIMARY KEY CLUSTERED 
(
	[Id_Tenista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [AgendaTCR] SET  READ_WRITE 
GO
