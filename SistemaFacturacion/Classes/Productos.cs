using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaFacturacion.Classes
{
    class Productos
    {
        private Conexion C = new Conexion();

        string Mproducto;
        int MidTipoUnidad;
        int MidTipoProducto;
        double Mcosto;
        double Mprecio;
        double Mexistencia;
        double Malerta;
        int MidProducto;
        int MidIngrediente;
        DateTime Mfecha;
        string Mproveedor;
        string MtipoTransaccion;
        double McantidadEntradaSalida;
        string MtipoProducto;
        double Mitbis;
        int MidFactura;
        double Mcantidad;


        public string Producto
        {
            get { return Mproducto; }
            set { Mproducto = value; }
        }

        public string TipoProducto
        {
            get { return MtipoProducto; }
            set { MtipoProducto = value; }
        }

        public int idTipoProducto
        {
            get { return MidTipoProducto; }
            set { MidTipoProducto = value; }
        }

        public int idTipoUnidad
        {
            get { return MidTipoUnidad; }
            set { MidTipoUnidad = value; }
        }

        public int idFactura
        {
            get { return MidFactura; }
            set { MidFactura = value; }
        }

        public double Costo
        {
            get { return Mcosto; }
            set { Mcosto = value; }
        }

        public double Cantidad
        {
            get { return Mcantidad; }
            set { Mcantidad = value; }
        }

        public double Itbis
        {
            get { return Mitbis; }
            set { Mitbis = value; }
        }

        public double Precio
        {
            get { return Mprecio; }
            set { Mprecio = value; }
        }

        public double Existencia
        {
            get { return Mexistencia; }
            set { Mexistencia = value; }
        }

        public double Alerta
        {
            get { return Malerta; }
            set { Malerta = value; }
        }

        public int idProducto
        {
            get { return MidProducto; }
            set { MidProducto = value; }
        }

        public int idIngrediente
        {
            get { return MidIngrediente; }
            set { MidIngrediente = value; }
        }

        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }

        public string Proveedor
        {
            get { return Mproveedor; }
            set { Mproveedor = value; }
        }

        public string TipoTransaccion
        {
            get { return MtipoTransaccion; }
            set { MtipoTransaccion = value; }
        }

        public double CantidadEntradaSalida
        {
            get { return McantidadEntradaSalida; }
            set { McantidadEntradaSalida = value; }
        }

        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@producto", Mproducto));
            lst.Add(new clsParametros("@idUnidad", MidTipoUnidad));
            lst.Add(new clsParametros("@idTipoProducto", MidTipoProducto));
            lst.Add(new clsParametros("@costo", Mcosto));
            lst.Add(new clsParametros("@precio", Mprecio));
            lst.Add(new clsParametros("@itbis", Mitbis));
            lst.Add(new clsParametros("@alerta", Malerta));


            C.EjecutarSP("guardarProducto", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public string Actualizar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", MidProducto));
            lst.Add(new clsParametros("@producto", Mproducto));
            lst.Add(new clsParametros("@idUnidad", MidTipoUnidad));
            lst.Add(new clsParametros("@idTipoProducto", MidTipoProducto));
            lst.Add(new clsParametros("@costo", Mcosto));
            lst.Add(new clsParametros("@precio", Mprecio));
            lst.Add(new clsParametros("@itbis", Mitbis));
            lst.Add(new clsParametros("@alerta", Malerta));
            C.EjecutarSP("actualizarProducto", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerProducto()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@tipoProducto", MtipoProducto));
            return dt = C.Listado("obtenerProducto", lst);
        }

        public DataTable ObtenerProductosNoTerminados()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtenerProductoNoTerminado", lst);
        }

        public DataTable BuscarProductosNoTerminados()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@producto", Mproducto));
            return dt = C.Listado("buscarProductoNoTerminado", lst);
        }

        public string EntradaSalidaProductos()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idProducto", MidProducto));
            lst.Add(new clsParametros("@cantidadEntradaSalida", McantidadEntradaSalida));
            lst.Add(new clsParametros("@idUnidad", MidTipoUnidad));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@costo", Mcosto));
            lst.Add(new clsParametros("@proveedor", Mproveedor));
            lst.Add(new clsParametros("@tipoTransaccion", MtipoTransaccion));
            C.EjecutarSP("agregarExistencia", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerProveedores()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtenerProveedor", lst);
        }

        public DataTable ObtenerProductosTerminados()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtenerProductoFacturar", lst);
        }


        public DataTable BuscarProductosTerminados()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@producto", Mproducto));
            return dt = C.Listado("buscarProductoTerminado", lst);
        }

        public DataTable BuscarProductosTerminadosFacturar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@producto", Mproducto));
            return dt = C.Listado("obtenerProductoTerminadoFacturar", lst);
        }

        public DataTable ObtenerUnidadComponente()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idProducto", MidProducto));
            return dt = C.Listado("obtenerUnidadComponente", lst);
        }

        public DataTable ObtenerComponentesProducto()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idProducto", MidProducto));
            return dt = C.Listado("obtenerComponentesProductos", lst);
        }

        public DataTable ObtenerExistenciaBebidas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idProducto", MidProducto));
            return dt = C.Listado("obtenerCantidadbebidas", lst);
        }

        public string InsertarComponenteProducto()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idProducto", MidProducto));
            lst.Add(new clsParametros("@idUnidad", MidTipoUnidad));
            lst.Add(new clsParametros("@idIngrediente", MidIngrediente));
            lst.Add(new clsParametros("@cantidad", McantidadEntradaSalida));
            


            C.EjecutarSP("insertarComponenteProducto", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string EliminarComponenteProducto()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idProducto", MidProducto));
            lst.Add(new clsParametros("@idIngrediente", MidIngrediente));
            C.EjecutarSP("eliminarComponenteProducto", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public string ActualizarComponenteProducto()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idProducto", MidProducto));
            lst.Add(new clsParametros("@idIngrediente", MidIngrediente));
            lst.Add(new clsParametros("@cantidad", McantidadEntradaSalida));

            C.EjecutarSP("actualizarComponenteProducto", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ValidarExistenciaIngrediente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idIngrediente", MidIngrediente));
            lst.Add(new clsParametros("@cantidad", McantidadEntradaSalida));

            C.EjecutarSP("validarExistenciaComponente", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RestarExistenciaComponente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idProducto", MidProducto));
            lst.Add(new clsParametros("@idIngrediente", MidIngrediente));
            lst.Add(new clsParametros("@cantidad", McantidadEntradaSalida));
            C.EjecutarSP("restarExistenciaComponente", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RestarExistenciaBebidas()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idProducto", MidProducto));
            lst.Add(new clsParametros("@cantidad", McantidadEntradaSalida));
            C.EjecutarSP("RestarBebida", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ObtenerNombreIngrediente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@nombre", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
            lst.Add(new clsParametros("@idIngrediente", MidIngrediente));
            C.EjecutarSP("obtenerNombreIngrediente", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerItbis()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtenerItbis", lst);
        }

        public DataTable ObtenerDetallesFactura()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idFactura", MidFactura));
            return dt = C.Listado("obtenerDetalleFactura", lst);
        }

        public string SumarExistencia()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idIngrediente", MidIngrediente));
            lst.Add(new clsParametros("@cantidad", Mcantidad));

            C.EjecutarSP("SumarExistencia", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string SumarExistenciaBebida()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idProducto", MidProducto));
            lst.Add(new clsParametros("@cantidad", Mcantidad));

            C.EjecutarSP("SumarExistenciaBebida", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

    }
}
