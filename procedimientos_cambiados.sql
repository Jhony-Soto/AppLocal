USE [Banco_Sena]
GO
/****** Object:  StoredProcedure [dbo].[sp_tbl_elemeentos_prestamos_hechos]    Script Date: 28/04/2020 11:57:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_tbl_elemeentos_prestamos_hechos]
@variable varchar(max),
@fecha_inicial date,
@fecha_final date
as
begin
select ele.codigo as 'Codigo',
		ele.nombre+' '+ma.nombre+' '+mo.nombre as 'Elemento',
		tpe.nombre as 'Tipo de elemento',
		presele.estado as 'Estado',
		presele.fecha_prestamo as 'Fecha de prestamo',
		presele.fecha_devolucion as 'Fecha de devolucion',
		presele.observaciones as 'Observaciones',
		presele.cantidad as 'Cantidad',
		pres.codcliente as 'Documento',
		tpres.nombre 'Tipo de prestamo',
		cli.nombres+' '+cli.apellidos as 'Cliente',
		fi.codigo as 'Ficha',
		fi.programa as 'Programa',
		ad.nombres+' '+ad.apellidos as 'Administrador'

from tbl_elemento as ele inner join tbl_prestamo_elemento as presele
	on ele.codigo=presele.codelemento

	inner join tbl_tipo_elemento as tpe
	on ele.tipo_elemento=tpe.codigo

	inner join tbl_modelo as mo
	on ele.codmodelo=mo.codigo

	inner join tbl_marca as ma
	on mo.codmarca=ma.codigo

	inner join tbl_prestamo as pres
	on presele.codprestamo=pres.codigo

	inner join tbl_tipo_prestamo as tpres
	on pres.tipo_prestamo=tpres.codigo

	inner join tbl_cliente as cli
	on cli.documento=pres.codcliente

		inner join tbl_ficha as fi
	on cli.codficha=fi.codigo

	inner join tbl_administrador as ad 
	on pres.codadministrador=ad.documento

	where cast(presele.fecha_prestamo as date)>=@fecha_inicial  and  cast(presele.fecha_devolucion as date)<=@fecha_final  and 
		  ele.codigo like '%'+@variable+'%' and presele.estado<>'1'
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_tbl_elemento_prestamo_sin_fechas]    Script Date: 28/04/2020 11:57:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_tbl_elemento_prestamo_sin_fechas]
@variable varchar(max)
as 
begin
	select ele.codigo as 'Codigo',
		ele.nombre+' '+ma.nombre+' '+mo.nombre as 'Elemento',
		 tpe.nombre as 'Tipo de elemento',
		presele.estado as 'Estado',
		presele.fecha_prestamo as 'Fecha de prestamo',
		presele.fecha_devolucion as 'Fecha de devolucion',
		presele.observaciones as 'Observaciones',
		presele.cantidad as 'Cantidad',
		pres.codcliente as 'Documento',
		tpres.nombre 'Tipo de prestamo',
		cli.nombres+' '+cli.apellidos as 'Cliente',
		fi.codigo as 'Ficha',
		fi.programa as 'Programa',
		ad.nombres+' '+ad.apellidos as 'Administrador'

from tbl_elemento as ele inner join tbl_prestamo_elemento as presele
	on ele.codigo=presele.codelemento

	inner join tbl_tipo_elemento as tpe
	on ele.tipo_elemento=tpe.codigo

	inner join tbl_modelo as mo
	on ele.codmodelo=mo.codigo

	inner join tbl_marca as ma
	on mo.codmarca=ma.codigo

	inner join tbl_prestamo as pres
	on presele.codprestamo=pres.codigo

	inner join tbl_tipo_prestamo as tpres
	on pres.tipo_prestamo=tpres.codigo

	inner join tbl_cliente as cli
	on cli.documento=pres.codcliente

	inner join tbl_ficha as fi
	on cli.codficha=fi.codigo

	inner join tbl_administrador as ad 
	on pres.codadministrador=ad.documento

	where ele.codigo like '%'+@variable+'%' and presele.estado<>'1'
end


GO
