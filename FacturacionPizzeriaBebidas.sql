USE [master]
GO
/****** Object:  Database [facturacion]    Script Date: 5/5/2018 1:50:23 PM ******/
CREATE DATABASE [facturacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'facturacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\facturacion.mdf' , SIZE = 4544KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'facturacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\facturacion_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [facturacion] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [facturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [facturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [facturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [facturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [facturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [facturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [facturacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [facturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [facturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [facturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [facturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [facturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [facturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [facturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [facturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [facturacion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [facturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [facturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [facturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [facturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [facturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [facturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [facturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [facturacion] SET RECOVERY FULL 
GO
ALTER DATABASE [facturacion] SET  MULTI_USER 
GO
ALTER DATABASE [facturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [facturacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [facturacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [facturacion] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [facturacion] SET DELAYED_DURABILITY = DISABLED 
GO
USE [facturacion]
GO
/****** Object:  Table [dbo].[activation]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[activation](
	[activated] [bit] NOT NULL CONSTRAINT [DF_activation_activated]  DEFAULT ((0)),
	[tipo] [nchar](10) NULL,
	[fecha_activado] [date] NULL,
	[fecha_vencimiento] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[componentesProductos]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[componentesProductos](
	[idProducto] [int] NOT NULL,
	[idIngrediente] [int] NOT NULL,
	[idUnidad] [int] NOT NULL,
	[cantidad] [float] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EntradaSalidaProductos]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntradaSalidaProductos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NULL,
	[cantidadEntradaSalida] [float] NULL,
	[idUnidad] [int] NULL,
	[costo] [float] NULL,
	[costoTotal] [float] NULL,
	[fecha] [datetime] NULL,
	[proveedor] [varchar](100) NULL,
	[tipoTransaccion] [varchar](50) NULL,
 CONSTRAINT [PK_EntradaProductos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[facturas]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[facturas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL CONSTRAINT [DF_facturas_fecha]  DEFAULT (CONVERT([datetime2](0),getdate())),
	[cliente] [varchar](100) NOT NULL,
	[total] [decimal](18, 2) NOT NULL,
	[estado] [bit] NOT NULL CONSTRAINT [DF_facturas_estado]  DEFAULT ((1)),
	[idusuario] [int] NOT NULL,
	[efectivo] [decimal](18, 2) NULL,
	[descuento_porciento] [float] NULL,
 CONSTRAINT [PK_facturas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[facturasDetalles]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facturasDetalles](
	[idFactura] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [float] NOT NULL,
	[idUnidad] [int] NOT NULL,
	[subtotal] [float] NOT NULL,
	[precioUnidad] [float] NOT NULL,
	[fecha] [datetime] NULL CONSTRAINT [DF_facturasDetalles_fecha]  DEFAULT (CONVERT([datetime2](0),getdate()))
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[itbis]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itbis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[itbis] [float] NOT NULL,
 CONSTRAINT [PK_itbis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[productos]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[producto] [nvarchar](100) NOT NULL,
	[id_unidad] [nvarchar](50) NOT NULL,
	[id_tipo] [nvarchar](50) NOT NULL,
	[costo] [float] NOT NULL CONSTRAINT [DF_productos_costo]  DEFAULT ((0)),
	[precio] [float] NOT NULL CONSTRAINT [DF_productos_precio]  DEFAULT ((0)),
	[existencia] [float] NOT NULL CONSTRAINT [DF_productos_existencia]  DEFAULT ((0)),
	[existencia_minima] [float] NOT NULL CONSTRAINT [DF_productos_existencia_minima]  DEFAULT ((0)),
	[fecha] [datetime] NOT NULL CONSTRAINT [DF_productos_fecha]  DEFAULT (CONVERT([datetime2](0),getdate())),
	[itbis] [float] NULL CONSTRAINT [DF_productos_itbis]  DEFAULT ((0)),
 CONSTRAINT [PK_productos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tipo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[unidad]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unidad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[unidad] [nvarchar](15) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_unidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[estado] [bit] NOT NULL,
	[usuario] [varchar](100) NOT NULL,
	[tipoUsuario] [varchar](100) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[clave] [varchar](30) NOT NULL,
	[crearUsuario] [bit] NOT NULL,
	[crearProducto] [bit] NOT NULL,
	[crearTipoProducto] [bit] NOT NULL,
	[crearTipoUnidad] [bit] NOT NULL,
	[facturacion] [bit] NOT NULL,
	[historialFacturas] [bit] NOT NULL,
	[entradaProductos] [bit] NOT NULL,
	[salidaProductos] [bit] NOT NULL,
	[repExistencia] [bit] NOT NULL,
	[repCuadre] [bit] NOT NULL,
	[repVentas] [bit] NOT NULL,
	[componentesProductos] [bit] NOT NULL,
	[repEntrada] [bit] NOT NULL,
	[repSalida] [bit] NOT NULL,
	[eliminarFactura] [bit] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[activarDesactivarFactura]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[activarDesactivarFactura]
@estado bit , @mensaje bit output, @idFactura int
as
set @mensaje = 0;
begin
		begin
			update facturas set estado = @estado where id = @idFactura
			set @mensaje = 1;
		end

end








GO
/****** Object:  StoredProcedure [dbo].[activarSoftware]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[activarSoftware]
@mensaje bit output, @tipo varchar(50)
as
declare @fechaActivacion date = (select getdate())
declare @fechaVencimiento date = (select DATEADD(DAY, 30, getdate()))
set @mensaje = 0
begin
	if @tipo = 'Trial'
		begin
			update activation set activated = 1, tipo = 'Trial', fecha_activado = @fechaActivacion, fecha_vencimiento = @fechaVencimiento
			set @mensaje = 1

		end
	else
		begin
			update activation set tipo = 'Full'
			set @mensaje = 1
		end
		
	
end







GO
/****** Object:  StoredProcedure [dbo].[actualizarComponenteProducto]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[actualizarComponenteProducto]
@idProducto int, @idIngrediente int, @cantidad float, @mensaje int output
as
set @mensaje = 0
begin 

	update componentesProductos set cantidad = @cantidad 
	where idProducto = @idProducto and idIngrediente = @idIngrediente
	set @mensaje = 1
end









GO
/****** Object:  StoredProcedure [dbo].[actualizarProducto]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarProducto]
@id int, @producto varchar(100), @idUnidad int, @idTipoProducto int, @costo float , @precio float, @alerta float, @mensaje bit output, @itbis float
as
set @mensaje = 0;
begin
	update productos set producto = @producto, id_unidad = @idUnidad, id_tipo = @idTipoProducto, costo = @costo,
	precio = @precio, existencia_minima = @alerta, itbis = @itbis where id = @id;
	set @mensaje = 1;
end








GO
/****** Object:  StoredProcedure [dbo].[actualizarTipoProducto]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarTipoProducto]
@id int, @tipoProducto varchar(100), @mensaje bit output
as
set @mensaje = 0;
begin
	update tipo set tipo = @tipoProducto where id = @id;
	set @mensaje = 1;
end








GO
/****** Object:  StoredProcedure [dbo].[actualizarTipoUnidad]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarTipoUnidad]
@id int, @unidad varchar(15), @descripcion varchar(50), @mensaje bit output
as
set @mensaje = 0;
begin
	update unidad set unidad = @unidad, descripcion = @descripcion where id = @id;
	set @mensaje = 1;
end








GO
/****** Object:  StoredProcedure [dbo].[actualizarUsuarios]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[actualizarUsuarios]
@idUsuario int,@estadoUsuario bit, @usuario varchar(100), @tipoUsuario varchar(100), @nombre varchar(100), @clave varchar(30), @crearUsuario bit,
@crearProducto bit, @crearTipoProducto bit, @crearTipoUnidad bit, @facturacion bit, @historialFacturas bit, @entradaProductos bit,
@salidaProductos bit, @repExistencia bit, @repCuadre bit, @repVentas bit,@componentes bit, @repEntrada bit, @repSalida bit ,@mensaje bit output,
@eliminarFactura bit
as
set @mensaje = 0
begin
	
	update usuarios set estado = @estadoUsuario, usuario = @usuario, tipoUsuario = @tipoUsuario, nombre = @nombre, clave = @clave, crearUsuario = @crearUsuario,
	 crearProducto = @crearProducto, crearTipoProducto = @crearTipoProducto, crearTipoUnidad = @crearTipoUnidad, facturacion = @facturacion,
	historialFacturas = @historialFacturas, entradaProductos = @entradaProductos, salidaProductos = @salidaProductos,repExistencia = @repExistencia, 
	repCuadre = @repCuadre, repVentas= @repVentas, componentesProductos = @componentes, repEntrada = @repEntrada, repSalida = @repSalida,
	eliminarFactura = @eliminarFactura
	where id = @idUsuario
	
	set @mensaje = 1

end










GO
/****** Object:  StoredProcedure [dbo].[AgregarExistencia]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[AgregarExistencia]
@idProducto int,@cantidadEntradaSalida float ,@idUnidad int, @costo float, @proveedor varchar(100), @fecha datetime, @tipoTransaccion varchar(20), 
@mensaje int output

as

set @mensaje = 0
begin
	if @tipoTransaccion = 'Entrada'
		begin
			update productos set costo = @costo, existencia = existencia + @cantidadEntradaSalida where id = @idProducto
			
			insert into EntradaSalidaProductos (idProducto, cantidadEntradaSalida, idUnidad, costo, costoTotal, fecha, proveedor, tipoTransaccion)
			Values(  @idProducto, @cantidadEntradaSalida, @idUnidad, @costo, (@cantidadEntradaSalida * @costo), @fecha, @proveedor, @tipoTransaccion)
			
			set @mensaje = 1
		end
	if @tipoTransaccion = 'Salida'
		begin
			update productos set costo = @costo, existencia = existencia - @cantidadEntradaSalida where id = @idProducto
			
			insert into EntradaSalidaProductos (idProducto, cantidadEntradaSalida, idUnidad, costo, costoTotal, fecha, proveedor, tipoTransaccion)
			Values(  @idProducto, @cantidadEntradaSalida, @idUnidad, @costo, (@cantidadEntradaSalida * @costo), @fecha, 'null', @tipoTransaccion)
			set @mensaje = 1
			
			declare @cantidadMinima float = (select existencia_minima from productos where id = @idProducto)
			declare @cantidadActual float = (select existencia from productos where id = @idProducto)

			if @cantidadMinima >= @cantidadActual
				begin
					set @mensaje = 2
				end

			
		end

end








GO
/****** Object:  StoredProcedure [dbo].[borrarOrdenYDetalles]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[borrarOrdenYDetalles]
@idFactura int , @mensaje bit output
as
begin
	delete from facturas where id = @idFactura
	delete from facturasDetalles where idFactura = @idFactura
end








GO
/****** Object:  StoredProcedure [dbo].[buscarProductoNoTerminado]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarProductoNoTerminado]
@producto varchar(100)
as
begin
	
	select p.id as ID, p.producto as PRODUCTO,u.unidad as UNIDAD, t.tipo as TIPO, p.costo as COSTO, p.existencia as EXISTENCIA, p.existencia_minima as MIN_EXISTENCIA, u.id as IDUNIDAD
	from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo where t.id = 1 AND p.producto  Like '%'+@producto+'%'
end








GO
/****** Object:  StoredProcedure [dbo].[buscarProductoTerminado]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[buscarProductoTerminado]
@producto varchar(100)
as
begin
	
	select  p.id as ID, p.producto as PRODUCTO, u.unidad as UNIDAD, p.precio as 'PRECIO($RD)', u.id as IDUNIDAD
	from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo where t.id = 2 AND p.producto  Like '%'+@producto+'%'
end








GO
/****** Object:  StoredProcedure [dbo].[cuadreDiario]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[cuadreDiario]
@fecha datetime, @idUsuario int
as

begin

	
	
		begin 
			select fecha,id, cliente, (total + (total * 0.10)) as total, efectivo, descuento_porciento, ( (total + (total * 0.10)) - (descuento_porciento/100) * (total + (total * 0.10))) as total_pagar,
			 (efectivo - ( (total + (total * 0.10)) - (descuento_porciento/100) * (total + (total * 0.10)))) as devuelta
			from facturas 
			where format(fecha,'dd/MM/yyyy') = format(@fecha,'dd/MM/yyyy') and idusuario = @idUsuario and estado = 1
		end
	
	
end













GO
/****** Object:  StoredProcedure [dbo].[eliminarComponenteProducto]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminarComponenteProducto]
@idProducto int, @idIngrediente int, @mensaje bit output
as
set @mensaje = 0
begin 
	
		
	delete from componentesProductos 
	where idProducto = @idProducto and idIngrediente = @idIngrediente
	set @mensaje = 1

		

end










GO
/****** Object:  StoredProcedure [dbo].[facturaCliente]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[facturaCliente]
@reImprimirId int = 1
as
begin
	if @reImprimirId = 0
		begin
			declare @idFactura int = (Select MAX(id) from facturas)
			select fd.cantidad, p.producto, u.unidad ,(fd.subtotal - (fd.subtotal * p.itbis))  as subtotal,
			(p.itbis * fd.subtotal) as itbis, CAST(p.precio AS DECIMAL(18,2))  as precio
			from productos p 
			join facturasDetalles fd on p.id = fd.idProducto join unidad u on p.id_unidad = u.id
			where fd.idFactura = @idFactura
		end
	else
		begin
			
			select fd.cantidad, p.producto, u.unidad ,(fd.subtotal - (fd.subtotal * p.itbis))  as subtotal, 
			(p.itbis * fd.subtotal) as itbis,CAST(p.precio AS DECIMAL(18,2))  as precio
			from productos p 
			join facturasDetalles fd on p.id = fd.idProducto 
			join unidad u on p.id_unidad = u.id
			where fd.idFactura = @reImprimirId
		end
end









GO
/****** Object:  StoredProcedure [dbo].[guardarProducto]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[guardarProducto]
@producto varchar(100), @idUnidad int, @idTipoProducto int, @costo float, @precio float, @alerta float ,@mensaje bit output, @itbis float
as
begin
set @mensaje = 0
	if exists (select * from productos where @producto = producto)
		begin
			set @mensaje = 0;
		end
	else
		begin
			insert into productos(producto, id_unidad, id_tipo, costo, precio, existencia_minima, itbis) 
			Values (@producto, @idUnidad, @idTipoProducto, @costo, @precio, @alerta, @itbis)
			set @mensaje = 1;
		end
end








GO
/****** Object:  StoredProcedure [dbo].[guardarTipoProducto]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[guardarTipoProducto]
@tipoProducto varchar(100), @mensaje bit output
as
begin
set @mensaje = 0
	if exists (select * from tipo where @tipoProducto = tipo)
		begin
			set @mensaje = 0;
		end
	else
		begin
			insert into tipo(tipo) Values (@tipoProducto)
			set @mensaje = 1;
		end
end








GO
/****** Object:  StoredProcedure [dbo].[guardarTipoUnidad]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[guardarTipoUnidad]
@unidad varchar(15), @descripcion varchar(50), @mensaje bit output
as
begin
set @mensaje = 0
	if exists (select * from unidad where @unidad = unidad)
		begin
			set @mensaje = 0;
		end
	else
		begin
			insert into unidad (unidad, descripcion) Values (@unidad, @descripcion)
			set @mensaje = 1;
		end
end








GO
/****** Object:  StoredProcedure [dbo].[historialFacturas]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[historialFacturas]
@noFactura int=0, @cliente varchar(100)='', @activa bit, @desde date, @hasta date
as
declare @sql nvarchar(1000)
begin
	set @sql = 'select f.id as FacturaNo, f.fecha as FECHA, f.cliente as CLIENTE, ((f.total + (f.total * 0.10)) - ((f.total + (f.total * 0.10)) * f.descuento_porciento /100)) as TOTAL, u.nombre as CAJERO 
				from facturas f join usuarios u on f.idusuario = u.id
				where format(f.fecha,''yyyy-MM-dd'') BETWEEN format(@desde,''yyyy-MM-dd'') and format(@hasta,''yyyy-MM-dd'') and f.estado = @activa '
	if @cliente != ''
		set @sql = @sql + N'and f.cliente Like (''%''+@p1+''%'') '
	if @noFactura != 0
		set @sql = @sql + N'and f.id = @p2'

	execute sp_executesql @sql, N'@p1 varchar(100), @p2 int,@desde date,@hasta date,@activa bit', @p1=@cliente, @p2=@noFactura,@desde=@desde,@hasta=@hasta,@activa=@activa
	
	
end










GO
/****** Object:  StoredProcedure [dbo].[insertarComponenteProducto]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertarComponenteProducto]
@idProducto int, @idIngrediente int, @idUnidad int, @cantidad float, @mensaje int output
as
set @mensaje = 0
begin 
	if NOT EXISTS(Select * from componentesProductos where idProducto = @idProducto and idIngrediente = @idIngrediente)
		begin
			insert into componentesProductos (idProducto, idIngrediente, idUnidad, cantidad) 
			VALUES (@idProducto, @idIngrediente, @idUnidad, @cantidad)
			set @mensaje = 1

		end
	else
		begin
			set @mensaje = 2
		end

end









GO
/****** Object:  StoredProcedure [dbo].[insertarFactura]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertarFactura]
@cliente varchar(100), @total float, @idUsuario int, @efectivo float ,@mensaje bit output,
@descuento float
as
set @mensaje = 0
begin
	
	insert into facturas (cliente, total, idusuario, efectivo, descuento_porciento)
	Values (@cliente, @total, @idUsuario, @efectivo, @descuento)
	set @mensaje = 1
end








GO
/****** Object:  StoredProcedure [dbo].[insertarFacturaDetalles]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[insertarFacturaDetalles]
@idProducto int, @cantidad float, @idUnidad int, @subTotal float, @precioUnidad float,@mensaje bit output
as
set @mensaje = 0

begin
	declare @idFactura int  = (SELECT MAX(id) from facturas)
	insert into facturasDetalles (idFactura, idProducto, cantidad, idUnidad, subtotal, precioUnidad)
	values(@idFactura, @idProducto, @cantidad, @idUnidad, @subTotal, @precioUnidad)
	set @mensaje = 1;
end








GO
/****** Object:  StoredProcedure [dbo].[insertarUsuarios]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertarUsuarios]
@estadoUsuario bit, @usuario varchar(100), @tipoUsuario varchar(100), @nombre varchar(100), @clave varchar(30), @crearUsuario bit,
@crearProducto bit, @crearTipoProducto bit, @crearTipoUnidad bit, @facturacion bit, @historialFacturas bit, @entradaProductos bit,
@salidaProductos bit, @repExistencia bit, @repCuadre bit, @repVentas bit,@componente bit ,@repEntrada bit, @repSalida bit, @mensaje bit output,
@eliminarFactura bit
as
set @mensaje = 0
begin
	
	insert into usuarios (estado, usuario, tipoUsuario, nombre, clave, crearUsuario, crearProducto, crearTipoProducto, crearTipoUnidad, facturacion,
	historialFacturas, entradaProductos, salidaProductos,repExistencia, repCuadre, repVentas, componentesProductos, repEntrada, repSalida, eliminarFactura) 
	VALUES (@estadoUsuario, @usuario, @tipoUsuario, @nombre, @clave, @crearUsuario, @crearTipoProducto, @crearTipoProducto, @crearTipoUnidad, @facturacion,
	@historialFacturas, @entradaProductos, @salidaProductos ,@repExistencia, @repCuadre, @repVentas, @componente, @repEntrada, @repSalida, @eliminarFactura)
	set @mensaje = 1

end










GO
/****** Object:  StoredProcedure [dbo].[loginUsuario]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[loginUsuario]
@usuario varchar(100), @clave varchar(30), @mensaje bit output, @idUsuario int output, @tipoUsuario varchar(100) output, @nombreUsuario varchar(100) output
as
set @mensaje = 0

begin
	 
	 select id, usuario, tipoUsuario, nombre from usuarios where usuario = @usuario and clave = @clave and estado = 1
	 if @@ROWCOUNT > 0
		set @mensaje = 1
		select @idUsuario = id, @tipoUsuario = tipoUsuario, @nombreUsuario = nombre from usuarios where usuario = @usuario
	 

end









GO
/****** Object:  StoredProcedure [dbo].[obtener_dias_activo]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_dias_activo]

as

declare @fechaActivacion date = (select fecha_activado from activation )
declare @fechaVencimiento date = (select fecha_vencimiento from activation)
declare @dias int = ISNULL(DATEDIFF(DAY,format (GETDATE(), 'yyyy-MM-dd'),  format (@fechaVencimiento, 'yyyy-MM-dd')), 0)
begin
  
	select @dias as DIAS
end




GO
/****** Object:  StoredProcedure [dbo].[obtenerCantidadbebidas]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtenerCantidadbebidas]
@idProducto int
as

begin
	select existencia as EXISTENCIA, producto as NOMBRE
	from productos where id = @idProducto
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerComponentesProductos]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtenerComponentesProductos]
@idProducto int
as

begin
	select p.producto as INGREDIENTE ,u.unidad as UNIDAD, c.cantidad as CANTIDAD, p.id as ID_INGREDIENTE, u.id as IDUNIDAD
	from componentesProductos c join productos p on p.id = c.idIngrediente join unidad u on c.idUnidad = u.id
	where c.idProducto = @idProducto
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerDetalleFactura]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtenerDetalleFactura]
@idFactura int
as
begin
	select idProducto as IDPRODUCTO, cantidad as CANTIDAD  
	from facturasDetalles 
	where idFactura = @idFactura
	
end



GO
/****** Object:  StoredProcedure [dbo].[obtenerFactura]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[obtenerFactura]
@reImprimirId int
as

declare @itbis float = (select itbis from itbis where id = 1)
begin
	if @reImprimirId = 0
		begin
			

			declare @idFactura int = (Select MAX(id) from facturas)
			select id, fecha, cliente, total - (total * @itbis) as subtototal, efectivo , (total * @itbis) as ITBISTOTAL, (total * 0.10) as DIEZPORCLEY,
			(total + (total * 0.10)) * descuento_porciento/100 as DESCUENTO, total + (total * 0.10) as total,
			(total + (total * 0.10)) - ((total + (total * 0.10)) * descuento_porciento/100) as TOTALPAGAR
			from facturas where id = @idFactura
		end
	else
		begin
		
			select id, fecha, cliente, total - (total * @itbis) as subtototal, efectivo , (total * @itbis) as ITBISTOTAL, (total * 0.10) as DIEZPORCLEY,
			(total + (total * 0.10)) * descuento_porciento/100 as DESCUENTO, total + (total * 0.10) as total,
			(total + (total * 0.10)) - ((total + (total * 0.10)) * descuento_porciento/100) as TOTALPAGAR
			from facturas where id = @reImprimirId
		end
	
end









GO
/****** Object:  StoredProcedure [dbo].[obtenerItbis]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerItbis]
as
begin

	select id as ID, itbis as ITBIS from itbis
end




GO
/****** Object:  StoredProcedure [dbo].[obtenerNombreIngrediente]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtenerNombreIngrediente]
@idIngrediente int, @nombre varchar(100) output
as

begin
	set @nombre = (select producto from productos where id = @idIngrediente)
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerNumeroFacturaSiguiente]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtenerNumeroFacturaSiguiente]
@numeroFactura int output
as

begin
	set @numeroFactura = (Select COALESCE(MAX(id), 0) from facturas) + 1
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerProducto]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerProducto]
@tipoProducto varchar(30)
as
begin
    if(@tipoProducto ='bebida')
		begin
			select p.id as ID, p.producto as PRODUCTO,u.unidad as UNIDAD, t.tipo as TIPO, p.costo as COSTO, p.precio as PRECIO, p.itbis as ITBIS, p.existencia_minima as MIN_EXISTENCIA
			from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo  where p.id_tipo = 3
		end
	else if (@tipoProducto = 'terminado')
		begin
			select p.id as ID, p.producto as PRODUCTO,u.unidad as UNIDAD, t.tipo as TIPO, p.costo as COSTO, p.precio as PRECIO, p.itbis as ITBIS
			from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo  where p.id_tipo = 2
		end
	
	else if (@tipoProducto = 'ingredientes')
		begin
			select p.id as ID, p.producto as PRODUCTO,u.unidad as UNIDAD, t.tipo as TIPO, p.costo as COSTO, p.precio as PRECIO, p.existencia_minima as MIN_EXISTENCIA
			from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo where p.id_tipo = 1
		end
	else
		begin
			select p.id as ID, p.producto as PRODUCTO,u.unidad as UNIDAD, t.tipo as TIPO, p.costo as COSTO, p.precio as PRECIO, p.existencia_minima as MIN_EXISTENCIA
			from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo
		end

end








GO
/****** Object:  StoredProcedure [dbo].[obtenerProductoFacturar]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[obtenerProductoFacturar]
as
begin

	select p.id as ID, p.producto as PRODUCTO, u.unidad as UNIDAD, p.precio as 'PRECIO($RD)', u.id as IDUNIDAD, p.id_tipo as IDTIPO
	from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo where t.id != 1
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerProductoNoTerminado]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerProductoNoTerminado]
as
begin

	select p.id as ID, p.producto as PRODUCTO,u.unidad as UNIDAD, t.tipo as TIPO, p.costo as COSTO, p.existencia as EXISTENCIA, p.existencia_minima as MIN_EXISTENCIA, u.id as IDUNIDAD
	from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo where t.id != 2
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerProductoTerminado]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[obtenerProductoTerminado]
as
begin

	select p.id as ID, p.producto as PRODUCTO, u.unidad as UNIDAD, p.precio as 'PRECIO($RD)', u.id as IDUNIDAD, p.id_tipo as IDTIPO
	from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo where t.id =2
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerProductoTerminadoFacturar]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[obtenerProductoTerminadoFacturar]
@producto varchar(100)
as
begin
	
	if @producto = ''
		begin
			select p.id as ID, p.producto as PRODUCTO, u.unidad as UNIDAD, p.precio as 'PRECIO($RD)', u.id as IDUNIDAD, p.id_tipo as IDTIPO
			from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo where t.id != 1

		end
	else
		begin
			select p.id as ID, p.producto as PRODUCTO, u.unidad as UNIDAD, p.precio as 'PRECIO($RD)', u.id as IDUNIDAD, p.id_tipo as IDTIPO
			from unidad u join productos p on u.id=p.id_unidad join tipo t on t.id = p.id_tipo where t.id != 1 and P.producto like '%' + @producto + '%'
		end
	
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerProveedor]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerProveedor]
as

begin
	SELECT MIN(proveedor) as Proveedor
	FROM EntradaSalidaProductos where proveedor != 'null'
	GROUP BY proveedor
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerTipoProducto]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerTipoProducto]
as
begin
	select id as IDENTIFICADOR, tipo as TIPO from tipo
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerTipoUnidad]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerTipoUnidad]
as
begin
	select id as IDENTIFICADOR, unidad as UNIDAD, descripcion as DESCRIPCION from unidad
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerUnidadComponente]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[obtenerUnidadComponente]
@idProducto int
as
begin
	select u.unidad as UNIDAD , u.id as ID from unidad u join productos p on p.id_unidad= u.id  where p.id = @idProducto
end








GO
/****** Object:  StoredProcedure [dbo].[obtenerUsuarios]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtenerUsuarios]
@filtro bit
as

begin
	select id as ID, usuario as USUARIO, tipoUsuario as TIPO, nombre as NOMBRE, crearUsuario as CREAR_USUARIO,
	crearProducto as CREAR_PRODUCTO, crearTipoProducto as CREAR_TIPO_PRODUCTO, crearTipoUnidad as CREAR_UNIDAD,
	facturacion as FACTURACION, historialFacturas as HISTORIAL_FACTURAS, entradaProductos as ENTRADA_PRODUCTOS,
	salidaProductos as SALIDA_PRODUCTOS ,repExistencia as REPORTE_EXISTENCIA, repCuadre as CUADRE, repVentas as REPORTE_VENTAS, 
	clave as CLAVE, estado as ESTADO, componentesProductos as INGREDIENTES_PRODUCTOS, repEntrada as REPORTE_ENTRADA,
	repSalida as REPORTE_SALIDA, eliminarFactura as ELIMINAR_FACTURA
	from usuarios where id != 1 and estado = @filtro
	

end

--@filtro bit, @estadoUsuario bit, @usuario varchar(100), @tipoUsuario varchar(100), @nombre varchar(100), @clave 








GO
/****** Object:  StoredProcedure [dbo].[permisoUsuario]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[permisoUsuario]
@idUsuario int
as

begin
	select crearUsuario as CREAR_USUARIO, crearProducto as CREAR_PRODUCTO, crearTipoProducto as CREAR_TIPO_PRODUCTO, 
	crearTipoUnidad as CREAR_UNIDAD, facturacion as FACTURACION, historialFacturas as HISTORIAL_FACTURAS, 
	entradaProductos as ENTRADA_PRODUCTOS,salidaProductos as SALIDA_PRODUCTOS ,repExistencia as REPORTE_EXISTENCIA, 
	repCuadre as CUADRE, repVentas as REPORTE_VENTAS, estado as ESTADO, componentesProductos as INGREDIENTES_PRODUCTOS,
	repEntrada as REPORTE_ENTRADA, repSalida as REPORTE_SALIDA, eliminarFactura as ELIMINAR_FACTURA
	from usuarios where id = @idUsuario
	

end








GO
/****** Object:  StoredProcedure [dbo].[primerLogin]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[primerLogin]
as
begin
	IF NOT EXISTS (SELECT * FROM usuarios)
		insert into usuarios (estado, usuario, tipoUsuario, nombre, clave, crearUsuario, crearProducto, crearTipoProducto, crearTipoUnidad, facturacion,
		historialFacturas, entradaProductos, salidaProductos, repExistencia, repCuadre, repVentas, componentesProductos,repEntrada, repSalida, eliminarFactura) 
		Values(1, 'admin', 'Administrador', 'Administrador Sistema', 'factSys1', 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1)
	IF NOT EXISTS (SELECT * FROM tipo)
		begin
			insert into tipo (tipo) Values('Ingrediente')
			insert into tipo (tipo) Values('Producto Terminado')
			insert into tipo (tipo) Values('Bebida')

			insert into itbis (itbis) Values(0.18)
			insert into activation (activated) Values (0)
		end
		
end








GO
/****** Object:  StoredProcedure [dbo].[reporteEntradaProductos]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[reporteEntradaProductos]
@desde date, @hasta date, @proveedor varchar(150), @idProducto int
as

begin
	if @proveedor = '' and @idProducto = 0
		begin
			select p.producto as PRODUCTO, esp.cantidadEntradaSalida as CANTIDAD, u.unidad as UNIDAD, esp.costo as COSTO, esp.costoTotal as COSTO_TOTAL, FORMAT(esp.fecha,'dd/MM/yyyy'), esp.proveedor as PROVEEDOR
			from EntradaSalidaProductos esp join productos p on esp.idProducto = p.id join unidad u on u.id = esp.idUnidad
			where format(esp.fecha,'dd/MM/yyyy') BETWEEN format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy') and esp.tipoTransaccion = 'Entrada'
			--group by p.producto, u.unidad, FORMAT(esp.fecha,'dd/MM/yyyy'), esp.proveedor
			order by FORMAT(esp.fecha,'dd/MM/yyyy') ASC
		end
	if @proveedor != '' and @idProducto = 0
		begin 
			select p.producto as PRODUCTO, esp.cantidadEntradaSalida as CANTIDAD, u.unidad as UNIDAD, esp.costo as COSTO, esp.costoTotal as COSTO_TOTAL, FORMAT(esp.fecha,'dd/MM/yyyy'), esp.proveedor as PROVEEDOR
			from EntradaSalidaProductos esp join productos p on esp.idProducto = p.id join unidad u on u.id = esp.idUnidad
			where format(esp.fecha,'dd/MM/yyyy') BETWEEN format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy') and esp.proveedor Like ('%'+@proveedor+'%') and esp.tipoTransaccion = 'Entrada'
			--group by p.producto, u.unidad, FORMAT(esp.fecha,'dd/MM/yyyy'),  esp.proveedor	
			order by FORMAT(esp.fecha,'dd/MM/yyyy') ASC
		end
	
	if @proveedor = '' and @idProducto != 0
		begin 
			select p.producto as PRODUCTO, esp.cantidadEntradaSalida as CANTIDAD, u.unidad as UNIDAD, esp.costo as COSTO, esp.costoTotal as COSTO_TOTAL, FORMAT(esp.fecha,'dd/MM/yyyy'), esp.proveedor as PROVEEDOR
			from EntradaSalidaProductos esp join productos p on esp.idProducto = p.id join unidad u on u.id = esp.idUnidad
			where format(esp.fecha,'dd/MM/yyyy') BETWEEN format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy') and esp.idProducto = @idProducto and esp.tipoTransaccion = 'Entrada'
			--group by p.producto, u.unidad, FORMAT(esp.fecha,'dd/MM/yyyy'), esp.proveedor
			order by FORMAT(esp.fecha,'dd/MM/yyyy') ASC
		end
	if @proveedor != '' and @idProducto != 0
		begin 
			select p.producto as PRODUCTO, esp.cantidadEntradaSalida as CANTIDAD, u.unidad as UNIDAD, esp.costo as COSTO, esp.costoTotal as COSTO_TOTAL, FORMAT(esp.fecha,'dd/MM/yyyy'), esp.proveedor as PROVEEDOR
			from EntradaSalidaProductos esp join productos p on esp.idProducto = p.id join unidad u on u.id = esp.idUnidad
			where format(esp.fecha,'dd/MM/yyyy') BETWEEN format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy') and esp.proveedor Like ('%'+@proveedor+'%') and esp.idProducto = @idProducto and esp.tipoTransaccion = 'Entrada'
			--group by p.producto, u.unidad,FORMAT(esp.fecha,'dd/MM/yyyy'),  esp.proveedor
			order by FORMAT(esp.fecha,'dd/MM/yyyy') ASC
			
		end
	
end












GO
/****** Object:  StoredProcedure [dbo].[reporteExistencia]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[reporteExistencia]
as
begin
	select p.producto,  u.unidad ,p.existencia, p.existencia_minima from productos p 
	join unidad u on u.id = p.id_unidad where id_tipo != 2
	Order by existencia ASC
end








GO
/****** Object:  StoredProcedure [dbo].[reporteSalidaProductos]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporteSalidaProductos]
@desde date, @hasta date, @proveedor varchar(150), @idProducto int
as

begin
	if @proveedor = '' and @idProducto = 0
		begin
			select p.producto as PRODUCTO, sum(esp.cantidadEntradaSalida) as CANTIDAD, u.unidad as UNIDAD, esp.costo as COSTO, sum(esp.costoTotal) as COSTO_TOTAL, FORMAT(esp.fecha,'dd/MM/yyyy')
			from EntradaSalidaProductos esp join productos p on esp.idProducto = p.id join unidad u on u.id = esp.idUnidad
			where format(esp.fecha,'dd/MM/yyyy') BETWEEN format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy') and esp.tipoTransaccion = 'Salida'
			group by p.producto, u.unidad, esp.costo, FORMAT(esp.fecha,'dd/MM/yyyy')
			order by FORMAT(esp.fecha,'dd/MM/yyyy') ASC
		end
	if @proveedor != '' and @idProducto = 0
		begin 
			select p.producto as PRODUCTO, sum(esp.cantidadEntradaSalida) as CANTIDAD, u.unidad as UNIDAD, esp.costo as COSTO, sum(esp.costoTotal) as COSTO_TOTAL, FORMAT(esp.fecha,'dd/MM/yyyy')
			from EntradaSalidaProductos esp join productos p on esp.idProducto = p.id join unidad u on u.id = esp.idUnidad
			where format(esp.fecha,'dd/MM/yyyy') BETWEEN format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy') and esp.proveedor Like ('%'+@proveedor+'%') and esp.tipoTransaccion = 'Salida'
			group by p.producto, u.unidad, esp.costo, FORMAT(esp.fecha,'dd/MM/yyyy')
			order by FORMAT(esp.fecha,'dd/MM/yyyy') ASC
		end
	
	if @proveedor = '' and @idProducto != 0
		begin 
			select p.producto as PRODUCTO, sum(esp.cantidadEntradaSalida) as CANTIDAD, u.unidad as UNIDAD, esp.costo as COSTO, sum(esp.costoTotal) as COSTO_TOTAL, FORMAT(esp.fecha,'dd/MM/yyyy')
			from EntradaSalidaProductos esp join productos p on esp.idProducto = p.id join unidad u on u.id = esp.idUnidad
			where format(esp.fecha,'dd/MM/yyyy') BETWEEN format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy') and esp.idProducto = @idProducto and esp.tipoTransaccion = 'Salida'
			group by p.producto, u.unidad, esp.costo, FORMAT(esp.fecha,'dd/MM/yyyy')
			order by FORMAT(esp.fecha,'dd/MM/yyyy') ASC
		end
	if @proveedor != '' and @idProducto != 0
		begin 
			select p.producto as PRODUCTO, sum(esp.cantidadEntradaSalida) as CANTIDAD, u.unidad as UNIDAD, esp.costo as COSTO, sum(esp.costoTotal) as COSTO_TOTAL, FORMAT(esp.fecha,'dd/MM/yyyy')
			from EntradaSalidaProductos esp join productos p on esp.idProducto = p.id join unidad u on u.id = esp.idUnidad
			where format(esp.fecha,'dd/MM/yyyy') BETWEEN format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy') and esp.proveedor Like ('%'+@proveedor+'%') and esp.idProducto = @idProducto and esp.tipoTransaccion = 'Salida'
			group by p.producto, u.unidad, esp.costo, FORMAT(esp.fecha,'dd/MM/yyyy')
			order by FORMAT(esp.fecha,'dd/MM/yyyy') ASC
		end
	
end













GO
/****** Object:  StoredProcedure [dbo].[reporteVentas]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporteVentas]
@desde date, @hasta date, @idProducto int
as

begin

	
	if @idProducto != 0
		begin 
			select format(fd.fecha,'dd/MM/yyyy'), p.producto, u.unidad, sum(fd.cantidad) as cantidad, fd.precioUnidad, sum(fd.subtotal) as subtotal
			from facturasDetalles fd join productos p on fd.idProducto = p.id join unidad u on fd.idUnidad = u.id join facturas f on f.id = fd.idFactura
			where format(fd.fecha,'dd/MM/yyyy') BETWEEN format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy') and fd.idProducto = @idProducto and f.estado = 1
			group by p.producto,format(fd.fecha,'dd/MM/yyyy'),u.unidad,fd.precioUnidad
			order by  format(fd.fecha,'dd/MM/yyyy') asc
		end
	if @idProducto = 0
		begin 
			select format(fd.fecha,'dd/MM/yyyy'), p.producto, u.unidad, sum(fd.cantidad) as cantidad, fd.precioUnidad, sum(fd.subtotal) as subtotal
			from facturasDetalles fd join productos p on fd.idProducto = p.id join unidad u on fd.idUnidad = u.id join facturas f on f.id = fd.idFactura
			where format(fd.fecha,'dd/MM/yyyy') BETWEEN format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy') and f.estado = 1
			group by p.producto,format(fd.fecha,'dd/MM/yyyy'),u.unidad,fd.precioUnidad
			order by  format(fd.fecha,'dd/MM/yyyy') asc
		end
	
end













GO
/****** Object:  StoredProcedure [dbo].[RestarBebida]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RestarBebida]
@idProducto int, @cantidad float , @mensaje int output
as 
set @mensaje = 0
begin
	
	
	declare @Existencia int = (select existencia as INGREDIENTE_EXISTENCIA  
	from productos
	where id = @idProducto )
	
	declare @costo float = ( select costo
	from productos
	where id = @idProducto)
	
	declare @idUnidad int = ( select id_unidad
	from productos
	where id = @idProducto)
	
	declare @fecha datetime = (select  CONVERT([datetime2](0),getdate()))
	
	update productos set costo = @costo, existencia = existencia - @cantidad where id = @idProducto
		
	insert into EntradaSalidaProductos (idProducto, cantidadEntradaSalida, idUnidad, costo, costoTotal, fecha, proveedor, tipoTransaccion)
	Values(  @idProducto, @cantidad, @idUnidad, @costo, (@cantidad* @costo), @fecha, 'null', 'Salida')
	set @mensaje = 1


	declare @cantidadMinima float = (select existencia_minima from productos where id = @idProducto)
	declare @cantidadActual float = (select existencia from productos where id = @idProducto)
	
	
	if @cantidadMinima >= @cantidadActual
			set @mensaje = 2
		
end








GO
/****** Object:  StoredProcedure [dbo].[RestarExistenciaComponente]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RestarExistenciaComponente]
@idProducto int, @idIngrediente int, @cantidad float , @mensaje int output
as 
set @mensaje = 0
begin
	declare @cantidadIngrediente int = (select cp.cantidad as CANTIDAD_INGREDIENTE 
	from componentesProductos cp join productos p on cp.idIngrediente = p.id 
	where cp.idProducto = @idProducto and cp.idIngrediente = @idIngrediente) * @cantidad
	
	declare @ExistenciaIngrediente int = (select p.existencia as INGREDIENTE_EXISTENCIA  
	from componentesProductos cp join productos p on cp.idIngrediente = p.id 
	where cp.idProducto = @idProducto and cp.idIngrediente = @idIngrediente)
	
	declare @costo float = ( select p.costo
	from componentesProductos cp join productos p on cp.idIngrediente = p.id 
	where cp.idProducto = @idProducto and cp.idIngrediente = @idIngrediente)
	
	declare @idUnidad int = ( select cp.idUnidad
	from componentesProductos cp join productos p on cp.idIngrediente = p.id 
	where cp.idProducto = @idProducto and cp.idIngrediente = @idIngrediente)
	
	declare @fecha datetime = (select  CONVERT([datetime2](0),getdate()))
	
	update productos set costo = @costo, existencia = existencia - @cantidadIngrediente where id = @idIngrediente
		
	insert into EntradaSalidaProductos (idProducto, cantidadEntradaSalida, idUnidad, costo, costoTotal, fecha, proveedor, tipoTransaccion)
	Values(  @idIngrediente, @cantidadIngrediente, @idUnidad, @costo, (@cantidadIngrediente * @costo), @fecha, 'null', 'Salida')
	set @mensaje = 1


	declare @cantidadMinima float = (select existencia_minima from productos where id = @idIngrediente)
	declare @cantidadActual float = (select existencia from productos where id = @idIngrediente)
	
	
	if @cantidadMinima >= @cantidadActual
			set @mensaje = 2
		
end








GO
/****** Object:  StoredProcedure [dbo].[revisarSoftwareActivado]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[revisarSoftwareActivado]
@mensaje varchar(50) output
as
declare @tipo varchar(50) = (select ISNULL(tipo, 'none') from activation)
set @mensaje = 0
begin
	if @tipo = 'none'
		begin
			set @mensaje = '0'
		end
	else if @tipo = 'Trial'
		begin
			set @mensaje = 'Trial'
		end
	else if @tipo = 'Full'
		begin
			set @mensaje = 'Full'
		end
end







GO
/****** Object:  StoredProcedure [dbo].[SumarExistencia]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[SumarExistencia]
@idIngrediente int, @cantidad float, @mensaje bit output 
as
set @mensaje = 0
begin 

	update productos set existencia = existencia + @cantidad where id = @idIngrediente
	set @mensaje = 1
end



GO
/****** Object:  StoredProcedure [dbo].[SumarExistenciaBebida]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SumarExistenciaBebida]
 @cantidad float, @mensaje int output , @idProducto int
as
set @mensaje = 0

declare @idtipoProd int = (select id_tipo from productos where id = @idProducto)
begin 
	if @idtipoProd = 3
		begin
			update productos set existencia = existencia + @cantidad where id = @idProducto

			set @mensaje = 1
		end
	 else
		begin
			 set @mensaje = 3
		end
end



GO
/****** Object:  StoredProcedure [dbo].[ValidarExistenciaComponente]    Script Date: 5/5/2018 1:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ValidarExistenciaComponente]
@idIngrediente int, @mensaje bit output  ,@cantidad float
as 
set @mensaje = 0
begin
	declare @cantidadIngrediente float = @cantidad
	
	declare @ExistenciaIngrediente int = (select existencia
	from productos where id = @idIngrediente)
	
	
	if (@ExistenciaIngrediente - @cantidadIngrediente ) >= 0
		begin 
			
			set @mensaje = 1
		end
		
end








GO
USE [master]
GO
ALTER DATABASE [facturacion] SET  READ_WRITE 
GO
