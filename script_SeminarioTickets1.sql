USE [master]
GO
/****** Object:  Database [SeminarioTickets]    Script Date: 1/7/2023 19:49:45 ******/
CREATE DATABASE [SeminarioTickets]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SeminarioTickets', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SeminarioTickets.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SeminarioTickets_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SeminarioTickets_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SeminarioTickets] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SeminarioTickets].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SeminarioTickets] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SeminarioTickets] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SeminarioTickets] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SeminarioTickets] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SeminarioTickets] SET ARITHABORT OFF 
GO
ALTER DATABASE [SeminarioTickets] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SeminarioTickets] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SeminarioTickets] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SeminarioTickets] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SeminarioTickets] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SeminarioTickets] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SeminarioTickets] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SeminarioTickets] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SeminarioTickets] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SeminarioTickets] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SeminarioTickets] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SeminarioTickets] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SeminarioTickets] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SeminarioTickets] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SeminarioTickets] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SeminarioTickets] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SeminarioTickets] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SeminarioTickets] SET RECOVERY FULL 
GO
ALTER DATABASE [SeminarioTickets] SET  MULTI_USER 
GO
ALTER DATABASE [SeminarioTickets] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SeminarioTickets] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SeminarioTickets] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SeminarioTickets] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SeminarioTickets] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SeminarioTickets] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SeminarioTickets', N'ON'
GO
ALTER DATABASE [SeminarioTickets] SET QUERY_STORE = ON
GO
ALTER DATABASE [SeminarioTickets] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SeminarioTickets]
GO
/****** Object:  Table [dbo].[Bitacoras]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacoras](
	[IdBit] [int] NOT NULL,
	[FchBit] [date] NOT NULL,
	[HrBit] [time](7) NOT NULL,
	[EmUsu] [nvarchar](255) NOT NULL,
	[TipBit] [nvarchar](10) NOT NULL,
	[DscBit] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Bitacoras] PRIMARY KEY CLUSTERED 
(
	[IdBit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[idCli] [nvarchar](13) NOT NULL,
	[NomCli] [nvarchar](80) NOT NULL,
	[TelCli] [int] NOT NULL,
	[EmCli] [nvarchar](255) NOT NULL,
	[DirCli] [nvarchar](500) NULL,
	[RtnCli] [nvarchar](20) NULL,
	[GenCli] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[idCli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[IdEmp] [int] NOT NULL,
	[NomEmp] [nvarchar](70) NOT NULL,
	[FchNacEmp] [date] NOT NULL,
	[EmEmp] [nvarchar](255) NOT NULL,
	[DirEmp] [nvarchar](500) NOT NULL,
	[TelEmp] [int] NOT NULL,
	[GenEmp] [bit] NOT NULL,
	[IdPst] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IdEmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventos]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[IdEvt] [int] NOT NULL,
	[NomEvt] [nvarchar](70) NOT NULL,
	[IdEvn] [int] NOT NULL,
	[FchEvt] [date] NOT NULL,
	[HrEvt] [time](7) NOT NULL,
	[IdLug] [int] NOT NULL,
	[CapEvt] [int] NOT NULL,
	[ResEvt] [int] NOT NULL,
 CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED 
(
	[IdEvt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaDetalle]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaDetalle](
	[NumFac] [int] NOT NULL,
	[IdTct] [int] NOT NULL,
	[CantTct] [int] NOT NULL,
 CONSTRAINT [PK_FacturaDetalle] PRIMARY KEY CLUSTERED 
(
	[NumFac] ASC,
	[IdTct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturasEncabezado]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasEncabezado](
	[NumFac] [int] NOT NULL,
	[IdCli] [nvarchar](13) NOT NULL,
	[IdEmp] [int] NOT NULL,
	[FchEmp] [nchar](10) NOT NULL,
 CONSTRAINT [PK_FacturasEncabezado] PRIMARY KEY CLUSTERED 
(
	[NumFac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lugares]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lugares](
	[IdJug] [int] NOT NULL,
	[NomLug] [nvarchar](40) NOT NULL,
	[CapLug] [int] NOT NULL,
 CONSTRAINT [PK_Lugares] PRIMARY KEY CLUSTERED 
(
	[IdJug] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Niveles]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Niveles](
	[IdNvl] [int] NOT NULL,
	[NomNvl] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Niveles] PRIMARY KEY CLUSTERED 
(
	[IdNvl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puestos]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puestos](
	[IdPst] [int] NOT NULL,
	[NomPst] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Puestos] PRIMARY KEY CLUSTERED 
(
	[IdPst] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[IdTct] [int] NOT NULL,
	[FchTct] [date] NOT NULL,
	[IdEvt] [int] NOT NULL,
	[IdCli] [nvarchar](13) NOT NULL,
	[IdUbc] [int] NOT NULL,
	[NumUbc] [int] NOT NULL,
	[PrcTct] [int] NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[IdTct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEventos]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEventos](
	[IdEvn] [int] NOT NULL,
	[NomEvn] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_TipoEventos] PRIMARY KEY CLUSTERED 
(
	[IdEvn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ubicaciones]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ubicaciones](
	[IdUbc] [int] NOT NULL,
	[ZonaUbc] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Ubicaciones] PRIMARY KEY CLUSTERED 
(
	[IdUbc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[EmUsu] [nvarchar](255) NOT NULL,
	[ConUsu] [nvarchar](255) NOT NULL,
	[CodEnvUsu] [int] NULL,
	[IdNvl] [int] NOT NULL,
	[EstUsu] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[EmUsu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bitacoras]  WITH CHECK ADD  CONSTRAINT [FK_Bitacoras_Usuarios] FOREIGN KEY([EmUsu])
REFERENCES [dbo].[Usuarios] ([EmUsu])
GO
ALTER TABLE [dbo].[Bitacoras] CHECK CONSTRAINT [FK_Bitacoras_Usuarios]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Puestos] FOREIGN KEY([IdPst])
REFERENCES [dbo].[Puestos] ([IdPst])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Puestos]
GO
ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [FK_Eventos_Lugares] FOREIGN KEY([IdLug])
REFERENCES [dbo].[Lugares] ([IdJug])
GO
ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [FK_Eventos_Lugares]
GO
ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [FK_Eventos_TipoEventos] FOREIGN KEY([IdEvt])
REFERENCES [dbo].[TipoEventos] ([IdEvn])
GO
ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [FK_Eventos_TipoEventos]
GO
ALTER TABLE [dbo].[FacturaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturaDetalle_FacturasEncabezado] FOREIGN KEY([NumFac])
REFERENCES [dbo].[FacturasEncabezado] ([NumFac])
GO
ALTER TABLE [dbo].[FacturaDetalle] CHECK CONSTRAINT [FK_FacturaDetalle_FacturasEncabezado]
GO
ALTER TABLE [dbo].[FacturaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturaDetalle_Tickets] FOREIGN KEY([IdTct])
REFERENCES [dbo].[Tickets] ([IdTct])
GO
ALTER TABLE [dbo].[FacturaDetalle] CHECK CONSTRAINT [FK_FacturaDetalle_Tickets]
GO
ALTER TABLE [dbo].[FacturasEncabezado]  WITH CHECK ADD  CONSTRAINT [FK_FacturasEncabezado_Clientes] FOREIGN KEY([IdCli])
REFERENCES [dbo].[Clientes] ([idCli])
GO
ALTER TABLE [dbo].[FacturasEncabezado] CHECK CONSTRAINT [FK_FacturasEncabezado_Clientes]
GO
ALTER TABLE [dbo].[FacturasEncabezado]  WITH CHECK ADD  CONSTRAINT [FK_FacturasEncabezado_Empleados] FOREIGN KEY([IdCli])
REFERENCES [dbo].[Clientes] ([idCli])
GO
ALTER TABLE [dbo].[FacturasEncabezado] CHECK CONSTRAINT [FK_FacturasEncabezado_Empleados]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Eventos] FOREIGN KEY([IdEvt])
REFERENCES [dbo].[Eventos] ([IdEvt])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Eventos]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Ubicaciones] FOREIGN KEY([IdUbc])
REFERENCES [dbo].[Ubicaciones] ([IdUbc])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Ubicaciones]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Niveles] FOREIGN KEY([IdNvl])
REFERENCES [dbo].[Niveles] ([IdNvl])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Niveles]
GO
/****** Object:  StoredProcedure [dbo].[InsercionBitacora]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionBitacora] 
	-- Add the parameters for the stored procedure here
	@IdBit int,
	@FchBit date,
	@HrBit time(7),
	@EmUsu nvarchar(255),
	@TipBit nvarchar(10),
	@DscBit nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Bitacoras VALUES(@IdBit,@FchBit, @HrBit,@EmUsu,@TipBit,@DscBit)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionClientes]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionClientes] 
	-- Add the parameters for the stored procedure here
	@IdCli nvarchar(13),
	@NomCli nvarchar(70),
	@TelCli int,
	@EmCli nvarchar(255),
	@DirCli nvarchar(500),
	@RtnCli nvarchar(20),
	@GenCli bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Clientes values (@IdCli,@NomCli,@TelCli,@EmCli,@DirCli,@RtnCli,@GenCli)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionEmpleados]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionEmpleados]
	-- Add the parameters for the stored procedure here
	@IdEmp int,
	@NomEmp nvarchar(70),
	@FchNacEmp date,
	@EmEmp nvarchar(255),
	@DirEmp nvarchar(500),
	@TelEmp int,
	@GenEmp bit,
	@IdPst int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Empleados Values (@IdEmp,@NomEmp,@FchNacEmp,@EmEmp,@DirEmp,@TelEmp,@GenEmp,@IdPst)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionEventos]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionEventos]
	-- Add the parameters for the stored procedure here
	@IdEvt int,
	@NomEvt nvarchar(70),
	@IdEvn int,
	@FchEvt date,
	@HrEvt time(7),
	@IdLug int,
	@CapEvt int,
	@ResEvt int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	INSERT INTO Eventos Values (@IdEvt,@NomEvt,@IdEvn,@FchEvt,@HrEvt,@IdLug,@CapEvt,@ResEvt)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionFacturaDetalle]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionFacturaDetalle] 
	-- Add the parameters for the stored procedure here
	@NumFac int,
	@IdTct int,
	@CantTct int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO FacturaDetalle VALUES(@NumFac,@IdTct,@CantTct)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionFacturaEncabezado]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionFacturaEncabezado]
	-- Add the parameters for the stored procedure here
	@NumFac int,
	@IdCli nvarchar(13),
	@IdEmp int,
	@FchEmp date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO FacturasEncabezado VALUES(@NumFac,@IdCli,@IdEmp,@FchEmp)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionLugares]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionLugares]
	-- Add the parameters for the stored procedure here
	@IdLug int,
	@NomLug nvarchar(40),
	@CapLug int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Lugares VALUES(@IdLug,@NomLug,@CapLug)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionNiveles]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionNiveles] 
	-- Add the parameters for the stored procedure here
	@IdNvl int,
	@NomNvl nvarchar(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Niveles VALUES(@IdNvl,@NomNvl)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionPUestos]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionPUestos]
	-- Add the parameters for the stored procedure here
	@IdPst int,
	@NomPst nvarchar(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Puestos VALUES(@IdPst,@NomPst)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionTickets]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionTickets]
	-- Add the parameters for the stored procedure here
	@IdTct int,
	@FchTct date,
	@IdEvt int,
	@IdCli nvarchar(13),
	@IdUbc int,
	@NumUbc int,
	@PrcTct int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Tickets VALUES(@IdTct,@FchTct,@IdEvt,@IdCli,@IdUbc,@NumUbc,@PrcTct)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionTipoEventos]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionTipoEventos]
	-- Add the parameters for the stored procedure here
	@IdEvn int,
	@NomEvn nvarchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO TipoEventos VALUES (@IdEvn,@NomEvn)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionUbicaciones]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionUbicaciones]
	-- Add the parameters for the stored procedure here
	@IdUbc int,
	@ZonaUbc nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Ubicaciones VALUES(@IdUbc,@ZonaUbc)
END
GO
/****** Object:  StoredProcedure [dbo].[InsercionUsuarios]    Script Date: 1/7/2023 19:49:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsercionUsuarios] 
	-- Add the parameters for the stored procedure here
	@EmUsu nvarchar(255),
	@ConUsu nvarchar(255),
	@CodEnvUsu int,
	@IdNvl int,
	@EstUsu bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		INSERT INTO Usuarios VALUES (@EmUsu,@ConUsu,@CodEnvUsu,@IdNvl,@EstUsu)
END
GO
USE [master]
GO
ALTER DATABASE [SeminarioTickets] SET  READ_WRITE 
GO
