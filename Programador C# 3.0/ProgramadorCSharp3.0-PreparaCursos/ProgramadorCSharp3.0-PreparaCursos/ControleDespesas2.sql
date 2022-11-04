USE [master]
GO
/****** Object:  Database [Despesas2]    Script Date: 22/08/2013 09:58:28 ******/
CREATE DATABASE [Despesas2]
 CONTAINMENT = NONE
GO
ALTER DATABASE [Despesas2] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Despesas2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Despesas2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Despesas2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Despesas2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Despesas2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Despesas2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Despesas2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Despesas2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Despesas2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Despesas2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Despesas2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Despesas2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Despesas2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Despesas2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Despesas2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Despesas2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Despesas2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Despesas2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Despesas2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Despesas2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Despesas2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Despesas2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Despesas2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Despesas2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Despesas2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Despesas2] SET  MULTI_USER 
GO
ALTER DATABASE [Despesas2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Despesas2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Despesas2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Despesas2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Despesas2]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 22/08/2013 09:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[ID_CATEGORIA] [int] IDENTITY(1,1) NOT NULL,
	[NOME_CATEGORIA] [nvarchar](30) NOT NULL,
	[DESCRICAO_CATEGORIA] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_CATEGORIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contas]    Script Date: 22/08/2013 09:58:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contas](
	[ID_DESPESA] [int] IDENTITY(1,1) NOT NULL,
	[DESCRICAO_DESPESA] [nvarchar](max) NOT NULL,
	[ID_CATEGORIA] [int] NOT NULL,
	[VALOR] [decimal](8, 2) NOT NULL,
	[DATA] [datetime] NOT NULL,
 CONSTRAINT [PK__Contas__48E8AE50E0AC0EA2] PRIMARY KEY CLUSTERED 
(
	[ID_DESPESA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Contas]  WITH CHECK ADD  CONSTRAINT [FK_Contas_Categoria] FOREIGN KEY([ID_CATEGORIA])
REFERENCES [dbo].[Categorias] ([ID_CATEGORIA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contas] CHECK CONSTRAINT [FK_Contas_Categoria]
GO
USE [master]
GO
ALTER DATABASE [Despesas2] SET  READ_WRITE 
GO
