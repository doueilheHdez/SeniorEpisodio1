/****** Object:  Database [PracticaNomina]    Script Date: 08/10/2022 02:01:29 a. m. ******/
CREATE DATABASE [PracticaNomina]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PracticaNomina', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PracticaNomina.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PracticaNomina_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PracticaNomina_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PracticaNomina] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PracticaNomina].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PracticaNomina] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PracticaNomina] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PracticaNomina] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PracticaNomina] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PracticaNomina] SET ARITHABORT OFF 
GO
ALTER DATABASE [PracticaNomina] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PracticaNomina] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PracticaNomina] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PracticaNomina] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PracticaNomina] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PracticaNomina] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PracticaNomina] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PracticaNomina] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PracticaNomina] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PracticaNomina] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PracticaNomina] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PracticaNomina] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PracticaNomina] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PracticaNomina] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PracticaNomina] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PracticaNomina] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PracticaNomina] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PracticaNomina] SET RECOVERY FULL 
GO
ALTER DATABASE [PracticaNomina] SET  MULTI_USER 
GO
ALTER DATABASE [PracticaNomina] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PracticaNomina] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PracticaNomina] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PracticaNomina] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PracticaNomina] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PracticaNomina] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PracticaNomina', N'ON'
GO
ALTER DATABASE [PracticaNomina] SET QUERY_STORE = OFF
GO
USE [PracticaNomina]
GO
/****** Object:  Table [dbo].[Tbl_CapturaMovimientos]    Script Date: 08/10/2022 02:01:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_CapturaMovimientos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NOT NULL,
	[Rol] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
	[CantidadEntrega] [int] NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
	[FechaMovimiento] [datetime] NOT NULL,
	[CubrioTurno] [bit] NULL,
 CONSTRAINT [PK_Tbl_CapturaMovimientos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Empleados]    Script Date: 08/10/2022 02:01:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Empleados](
	[Numero] [int] NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
	[Rol] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
	[Activo] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificado] [datetime] NULL,
	[FechaBaja] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Empleados] PRIMARY KEY CLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_EmpleadosHistorial]    Script Date: 08/10/2022 02:01:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_EmpleadosHistorial](
	[Numero] [int] NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
	[Rol] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
	[Activo] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
	[FechaModificado] [datetime] NULL,
	[FechaBaja] [datetime] NULL,
	[Moviento] [nvarchar](50) NULL,
	[FechaMovimiento] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Sueldos]    Script Date: 08/10/2022 02:01:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sueldos](
	[Rol] [nvarchar](50) NOT NULL,
	[SueldoBasexHora] [decimal](18, 2) NOT NULL,
	[BonoxHora] [decimal](18, 2) NOT NULL,
	[AplicaVales] [bit] NOT NULL,
	[ValeDespensa] [decimal](18, 2) NOT NULL,
	[FechaMovimiento] [datetime] NULL,
	[BonoxHoraAdicional] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Tbl_Sueldos] PRIMARY KEY CLUSTERED 
(
	[Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_CapturaMovimientos] ADD  DEFAULT (getdate()) FOR [FechaMovimiento]
GO
ALTER TABLE [dbo].[Tbl_Empleados] ADD  CONSTRAINT [DF_Tbl_Empleados_Activo]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Tbl_Empleados] ADD  CONSTRAINT [DF_Tbl_Empleados_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Tbl_Sueldos] ADD  CONSTRAINT [DF_Tbl_Sueldos_FechaMovimiento]  DEFAULT (getdate()) FOR [FechaMovimiento]
GO
ALTER TABLE [dbo].[Tbl_CapturaMovimientos]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_CapturaMovimientos_Tbl_Empleados] FOREIGN KEY([Numero])
REFERENCES [dbo].[Tbl_Empleados] ([Numero])
GO
ALTER TABLE [dbo].[Tbl_CapturaMovimientos] CHECK CONSTRAINT [FK_Tbl_CapturaMovimientos_Tbl_Empleados]
GO
ALTER TABLE [dbo].[Tbl_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Empleados_Tbl_Sueldos] FOREIGN KEY([Rol])
REFERENCES [dbo].[Tbl_Sueldos] ([Rol])
GO
ALTER TABLE [dbo].[Tbl_Empleados] CHECK CONSTRAINT [FK_Tbl_Empleados_Tbl_Sueldos]
GO
/****** Object:  StoredProcedure [dbo].[sp_CalculoSalario]    Script Date: 08/10/2022 02:01:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================  
-- Author:  Daniel Oueilhe Hdez  
-- Create date: 2022-10-07  
-- Description: Calculo de salario  
-- Se retiene a todos los empleados un 9% de impuesto sobre la renta (ISR). Aquellos
-- empleados que en su sueldo mensual sobrepasan los $16,000.00 se les debe
-- retener un 3% adicional de ISR.
--● Los empleados reciben un 4% sobre su sueldo mensual en vales de despensa
--(antes de impuestos, esto no aplica para los subcontratados).
-- =============================================  
CREATE PROCEDURE [dbo].[sp_CalculoSalario](  
 @Numero int, 
 @FechaInicio DATE,
 @FechaFinal DATE
 )
AS  
BEGIN  
 SET NOCOUNT ON; 
 
 DECLARE @Rol nvarchar(50)
 DECLARE @Tipo nvarchar(50)
 DECLARE @SalarioBruto decimal(18,2)
 DECLARE @SalarioNeto decimal(18,2)
 DECLARE @SaldoVales decimal(18,2)
 DECLARE @Vales decimal(5,2)
 DECLARE @ISR_Base decimal(5,2) = 9
 DECLARE @ISR_Adicional decimal(5,2) = 3
 DECLARE @Retencio_ISR decimal(5,2)

 -- informacion del empleado
 SELECT @Rol=Rol,@Tipo=Tipo FROM Tbl_Empleados WHERE Numero=@Numero
 SELECT @Vales=ValeDespensa FROM Tbl_Sueldos WHERE Rol=@Rol

  -- Obetener la sumatorio del monto
  Select @SalarioBruto=SUM(Monto)
  from Tbl_CapturaMovimientos 
  where Numero=@Numero and Fecha>=@FechaInicio and Fecha<@FechaFinal
 
  -- Regla ISR
  if @SalarioBruto>16000
  begin
	set @Retencio_ISR = (@SalarioBruto * ((@ISR_Base + @ISR_Adicional) / 100))
  end
  else
  begin
	set @Retencio_ISR = (@SalarioBruto * (@ISR_Base / 100))
  end

	set @SalarioNeto = @SalarioBruto - @Retencio_ISR

-- regla para calcular el saldo de vales
  IF @Tipo<>'Externo'
	BEGIN
		SET @SaldoVales = (@SalarioBruto * (@Vales / 100))
	END

 SELECT @SalarioBruto AS SalarioBruto, @Retencio_ISR as ISR, @SalarioNeto as SalarioNeto, @SaldoVales as Vales

END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetEmpleados]    Script Date: 08/10/2022 02:01:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  
-- =============================================  
-- Author:  Daniel Oueilhe Hdez  
-- Create date: 2022-10-06  
-- Description: Guardar el moviento de la Alta, Modificacion y Baja  
-- =============================================  
CREATE PROCEDURE [dbo].[sp_GetEmpleados]  
 @Numero bigint  
AS  
BEGIN  
 SET NOCOUNT ON;  
  
 SELECT Numero,Nombre,Rol,Tipo,Activo,FechaRegistro,FechaModificado,FechaBaja  
 FROM Tbl_Empleados 
 WHERE Numero=@Numero AND Activo=1
  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SetCapturaMovimiento]    Script Date: 08/10/2022 02:01:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================  
-- Author:  Daniel Oueilhe Hdez  
-- Create date: 2022-10-07  
-- Description: Guardar la captura de movimiento  
-- =============================================  
CREATE PROCEDURE [dbo].[sp_SetCapturaMovimiento](  
 @Numero int, 
 @Fecha DATE,
 @CantidadEntrega INT,
 @CubrioTurno BIT,
 @CubrioTurnoRol nvarchar(50),  
 @CubrioTurnoTipo nvarchar(50)
 )
AS  
BEGIN  
 SET NOCOUNT ON; 
 
 DECLARE @Rol nvarchar(50)
 DECLARE @Tipo nvarchar(50)
 DECLARE @Monto decimal(18,2)
 DECLARE @SueldoBasexHora decimal(18,2)
 DECLARE @BonoxHora decimal(18,2)
 DECLARE @BonoxHoraAdicional decimal(18,2)
 DECLARE @HorasJornada int = 8
  
 SELECT @Rol=Rol,@Tipo=Tipo FROM Tbl_Empleados WHERE Numero=@Numero

 IF @CubrioTurno=1
 BEGIN
	
	SELECT @SueldoBasexHora=SueldoBasexHora,@BonoxHora=BonoxHora, @BonoxHoraAdicional=BonoxHoraAdicional FROM Tbl_Sueldos WHERE Rol=@CubrioTurnoRol

	IF @Rol='Auxiliar'
	BEGIN
		SET @Monto = (@SueldoBasexHora * @HorasJornada) +  (@BonoxHoraAdicional*@CantidadEntrega)
	END
	ELSE
	BEGIN
		SET @Monto = (@SueldoBasexHora * @HorasJornada)+ (@BonoxHora*@HorasJornada) + (@BonoxHoraAdicional*@CantidadEntrega)
	END

	SET @Rol=@CubrioTurnoRol
	SET @Tipo=@CubrioTurnoTipo
 END
 ELSE
 BEGIN
   SELECT @SueldoBasexHora=SueldoBasexHora,@BonoxHora=BonoxHora, @BonoxHoraAdicional=BonoxHoraAdicional FROM Tbl_Sueldos WHERE Rol=@Rol

   SET @Monto = (@SueldoBasexHora * @HorasJornada)+ (@BonoxHora*@HorasJornada) + (@BonoxHoraAdicional*@CantidadEntrega)
 END

 INSERT INTO Tbl_CapturaMovimientos(Numero,Rol,Tipo,Fecha,CantidadEntrega,Monto,CubrioTurno)
 VALUES(@Numero,@Rol,@Tipo,@Fecha,@CantidadEntrega,@Monto,@CubrioTurno)

END

GO
/****** Object:  StoredProcedure [dbo].[sp_SetEmpleados]    Script Date: 08/10/2022 02:01:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Daniel Oueilhe Hdez
-- Create date: 2022-10-06
-- Description:	Guardar el moviento de la Alta, Modificacion y Baja
-- =============================================
CREATE PROCEDURE [dbo].[sp_SetEmpleados]
	@Numero int,
	@Nombre nvarchar(200),
	@Rol nvarchar(50),
	@Tipo nvarchar(50),
	@Movimento nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	IF @Movimento = 'Nuevo'
	BEGIN
		-- Se hacer el registro del empleado
		INSERT INTO Tbl_Empleados(Numero,Nombre,Rol,Tipo)
		VALUES(@Numero,@Nombre,@Rol,@Tipo)
	END
	ELSE IF @Movimento = 'Modificar'
	BEGIN
		-- Se guarda en el historial el registro previo algun cambio

		INSERT INTO Tbl_EmpleadosHistorial(Numero,Nombre,Rol,Tipo,Activo,FechaRegistro,FechaModificado,FechaBaja,Moviento,FechaMovimiento)
		SELECT Numero,Nombre,Rol,Tipo,Activo,FechaRegistro,FechaModificado,FechaBaja,@Movimento,GETDATE()
		FROM Tbl_Empleados WHERE Numero=@Numero
		
		-- Actualiza los datos por el número de empleado
		UPDATE Tbl_Empleados SET 
			Nombre=@Nombre,
			Rol=@Rol,
			Tipo=@Tipo,
			FechaModificado=GETDATE()
		WHERE Numero=@Numero
	END
	ELSE IF @Movimento = 'Eliminar'
	BEGIN

		-- Se guarda en el historial el registro previo algun cambio
		INSERT INTO Tbl_EmpleadosHistorial(Numero,Nombre,Rol,Tipo,Activo,FechaRegistro,FechaModificado,FechaBaja,Moviento,FechaMovimiento)
		SELECT Numero,Nombre,Rol,Tipo,Activo,FechaRegistro,FechaModificado,FechaBaja,@Movimento,GETDATE()
		FROM Tbl_Empleados WHERE Numero=@Numero

		-- Actualiza los datos por el número de empleado
		UPDATE Tbl_Empleados SET 
			FechaBaja=GETDATE(),
			Activo=0
		WHERE Numero=@Numero	
		
	END

END
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidaFechaMovimiento]    Script Date: 08/10/2022 02:01:29 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================  
-- Author:  Daniel Oueilhe Hdez  
-- Create date: 2022-10-07  
-- Description: Valida que no exista mas de un registro empelado por fecha  
-- =============================================  
CREATE PROCEDURE [dbo].[sp_ValidaFechaMovimiento](  
 @Numero int, 
 @Fecha DATE
 )
AS
BEGIN
	if exists(select 1 from Tbl_CapturaMovimientos where Numero=@Numero and Fecha=@Fecha)
	begin
		select 'Existe la fecha registrada del número de empleado ' + @Numero as respuesta
	end
END
GO
USE [master]
GO
ALTER DATABASE [PracticaNomina] SET  READ_WRITE 
GO

INSERT INTO Tbl_Sueldos(Rol,SueldoBasexHora,BonoxHora,AplicaVales,ValeDespensa,BonoxHoraAdicional)
VALUES('Chofer',30,10,1,4,5)
,('Cargador',30,5,1,4,5)
,('Auxiliar',30,0,0,4,0)

GO