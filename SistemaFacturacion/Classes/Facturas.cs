using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaFacturacion.Classes
{
    class Facturas
    {
        private Conexion C = new Conexion();

        string Mproducto;
        int MidTipoUnidad;
        double Mtotal;
        double Mprecio;
        int MidProducto;
        DateTime Mfecha;
        string Mcliente;
        int MidUsuario;
        int MidFactura;
        double MsubTotal;
        double Mcantidad;
        bool Mestado;
        DateTime Mdesde;
        DateTime Mhasta;
        double Mefectivo;
        double Mdescuento;


        public string Producto
        {
            get { return Mproducto; }
            set { Mproducto = value; }
        }

        public int idUsuario
        {
            get { return MidUsuario; }
            set { MidUsuario = value; }
        }

        public int idTipoUnidad
        {
            get { return MidTipoUnidad; }
            set { MidTipoUnidad = value; }
        }

        public double Total
        {
            get { return Mtotal; }
            set { Mtotal = value; }
        }

        public double Descuento
        {
            get { return Mdescuento; }
            set { Mdescuento = value; }
        }

        public double Efectivo
        {
            get { return Mefectivo; }
            set { Mefectivo = value; }
        }

        public double Precio
        {
            get { return Mprecio; }
            set { Mprecio = value; }
        }

        public string Cliente
        {
            get { return Mcliente; }
            set { Mcliente = value; }
        }

        public int idProducto
        {
            get { return MidProducto; }
            set { MidProducto = value; }
        }

        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }

        public double SubTotal
        {
            get { return MsubTotal; }
            set { MsubTotal = value; }
        }

        public double Cantidad
        {
            get { return Mcantidad; }
            set { Mcantidad = value; }
        }

        public int idFactura
        {
            get { return MidFactura; }
            set { MidFactura = value; }
        }

        public bool Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }

        public DateTime Desde
        {
            get { return Mdesde; }
            set { Mdesde = value; }
        }

        public DateTime Hasta
        {
            get { return Mhasta; }
            set { Mhasta = value; }
        }

        public string RegistrarFactura()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@total", Mtotal));
            lst.Add(new clsParametros("@idUsuario", MidUsuario));
            lst.Add(new clsParametros("@cliente", Mcliente));
            lst.Add(new clsParametros("@efectivo", Mefectivo));
            lst.Add(new clsParametros("@descuento", Mdescuento));




            C.EjecutarSP("insertarFactura", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarFacturaDetalles()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idProducto", MidProducto));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            lst.Add(new clsParametros("@idUnidad", MidTipoUnidad));
            lst.Add(new clsParametros("@subTotal", MsubTotal));
            lst.Add(new clsParametros("@precioUnidad", Mprecio));
            C.EjecutarSP("insertarFacturaDetalles", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string EliminarRegistroFallido()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idFactura", MidFactura));
            
            C.EjecutarSP("borrarOrdenYDetalles", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public string NumeroFacturaSiguiente()
        {
            string facturaSiguiente = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@numeroFactura", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
           
            C.EjecutarSP("obtenerNumeroFacturaSiguiente", ref lst);
            facturaSiguiente = lst[0].Valor.ToString();
            return facturaSiguiente;
        }

        public DataTable HistorialFacturas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@cliente", Mcliente));
            lst.Add(new clsParametros("@noFactura", MidFactura));
            lst.Add(new clsParametros("@activa", Mestado));
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));

            return dt = C.Listado("historialFacturas", lst);
        }

        public string ActivarDesactivarFactura()
        {
            string msj = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idFactura", MidFactura));
            lst.Add(new clsParametros("@estado", Mestado));
            C.EjecutarSP("activarDesactivarFactura", ref lst);
            msj = lst[0].Valor.ToString();
            return msj;
        }
    }
}
