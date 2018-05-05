using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SistemaFacturacion.Classes
{
    class Usuarios
    {
        private Conexion C = new Conexion();

        int MidUsuario;
        bool Mfiltro;
        bool Mestado;
        string Musuario;
        string MtipoUsuario;
        string Mnombre;
        string Mclave;
        bool McrearUsuario;
        bool McrearProducto;
        bool McrearTipoProducto;
        bool McrearTipoUnidad;
        bool Mfacturacion;
        bool MhistorialFacturas;
        bool MentradaProductos;
        bool MsalidaProductos;
        bool MrepExistencia;
        bool MrepCuadre;
        bool MrepVentas;
        bool McomponentesProductos;
        bool MrepEntrada;
        bool MrepSalida;
        string MtipoActivacion;
        bool MeliminarFactura;

        public int idUsuario
        {
            get { return MidUsuario; }
            set { MidUsuario = value; }
        }

        public bool Filtro
        {
            get { return Mfiltro; }
            set { Mfiltro = value; }
        }

        public bool EliminarFactura
        {
            get { return MeliminarFactura; }
            set { MeliminarFactura = value; }
        }


        public bool Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }

        public string Usuario
        {
            get { return Musuario; }
            set { Musuario = value; }
        }

        public string TipoUsuario
        {
            get { return MtipoUsuario; }
            set { MtipoUsuario = value; }
        }

        public string TipoActivacion
        {
            get { return MtipoActivacion; }
            set { MtipoActivacion = value; }
        }

        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }

        public string Clave
        {
            get { return Mclave; }
            set { Mclave = value; }
        }

        public bool CrearUsuario
        {
            get { return McrearUsuario; }
            set { McrearUsuario = value; }
        }

        public bool CrearProducto
        {
            get { return McrearProducto; }
            set { McrearProducto = value; }
        }

        public bool CrearTipoProducto
        {
            get { return McrearTipoProducto; }
            set { McrearTipoProducto = value; }
        }

        public bool CrearTipoUnidad
        {
            get { return McrearTipoUnidad; }
            set { McrearTipoUnidad = value; }
        }

        public bool Facturacion
        {
            get { return Mfacturacion; }
            set { Mfacturacion = value; }
        }

        public bool HistorialFacturas
        {
            get { return MhistorialFacturas; }
            set { MhistorialFacturas = value; }
        }

        public bool EntradaProductos
        {
            get { return MentradaProductos; }
            set { MentradaProductos = value; }
        }

        public bool SalidaProductos
        {
            get { return MsalidaProductos; }
            set { MsalidaProductos = value; }
        }

        public bool RepExistencia
        {
            get { return MrepExistencia; }
            set { MrepExistencia = value; }
        }

        public bool RepCuadre
        {
            get { return MrepCuadre; }
            set { MrepCuadre = value; }
        }

        public bool RepVentas
        {
            get { return MrepVentas; }
            set { MrepVentas = value; }
        }

        public bool ComponentesProductos
        {
            get { return McomponentesProductos; }
            set { McomponentesProductos = value; }
        }

        public bool ReporteEntrada
        {
            get { return MrepEntrada; }
            set { MrepEntrada = value; }
        }

        public bool ReporteSalida
        {
            get { return MrepSalida; }
            set { MrepSalida = value; }
        }

        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@estadoUsuario", Mestado));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@tipoUsuario", MtipoUsuario));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@crearUsuario", McrearUsuario));
            lst.Add(new clsParametros("@crearProducto", McrearProducto));
            lst.Add(new clsParametros("@crearTipoProducto", McrearTipoProducto));
            lst.Add(new clsParametros("@crearTipoUnidad", McrearTipoUnidad));
            lst.Add(new clsParametros("@facturacion", Mfacturacion));
            lst.Add(new clsParametros("@historialFacturas",MhistorialFacturas));
            lst.Add(new clsParametros("@entradaProductos", MentradaProductos));
            lst.Add(new clsParametros("@salidaProductos", MsalidaProductos));
            lst.Add(new clsParametros("@repExistencia", MrepExistencia));
            lst.Add(new clsParametros("@repCuadre", MrepCuadre));
            lst.Add(new clsParametros("@repVentas", MrepVentas));
            lst.Add(new clsParametros("@componente", McomponentesProductos));
            lst.Add(new clsParametros("@repEntrada", MrepEntrada));
            lst.Add(new clsParametros("@repSalida", MrepSalida));
            lst.Add(new clsParametros("@eliminarFactura", MeliminarFactura));


            C.EjecutarSP("insertarUsuarios", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public string Actualizar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idUsuario", MidUsuario));
            lst.Add(new clsParametros("@estadoUsuario", Mestado));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@tipoUsuario", MtipoUsuario));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@crearUsuario", McrearUsuario));
            lst.Add(new clsParametros("@crearProducto", McrearProducto));
            lst.Add(new clsParametros("@crearTipoProducto", McrearTipoProducto));
            lst.Add(new clsParametros("@crearTipoUnidad", McrearTipoUnidad));
            lst.Add(new clsParametros("@facturacion", Mfacturacion));
            lst.Add(new clsParametros("@historialFacturas", MhistorialFacturas));
            lst.Add(new clsParametros("@entradaProductos", MentradaProductos));
            lst.Add(new clsParametros("@salidaProductos", MsalidaProductos));
            lst.Add(new clsParametros("@repExistencia", MrepExistencia));
            lst.Add(new clsParametros("@repCuadre", MrepCuadre));
            lst.Add(new clsParametros("@repVentas", MrepVentas));
            lst.Add(new clsParametros("@componentes", McomponentesProductos));
            lst.Add(new clsParametros("@repEntrada", MrepEntrada));
            lst.Add(new clsParametros("@repSalida", MrepSalida));
            lst.Add(new clsParametros("@eliminarFactura", MeliminarFactura));

            C.EjecutarSP("actualizarUsuarios", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@filtro", Mfiltro));
            return dt = C.Listado("obtenerUsuarios", lst);
        }

        public string[] Login()
        {
            string[] mensaje = new string[4]; ;
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idusuario", "", SqlDbType.Int, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tipoUsuario", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
            lst.Add(new clsParametros("@nombreUsuario", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));



            C.EjecutarSP("loginUsuario", ref lst);
            mensaje[0] = lst[0].Valor.ToString();
            mensaje[1] = lst[1].Valor.ToString();
            mensaje[2] = lst[2].Valor.ToString();
            mensaje[3] = lst[3].Valor.ToString();
            return mensaje;
        }

        public void PrimeraCorrida()
        {
            List<clsParametros> lst = new List<clsParametros>();

            C.EjecutarSP("primerLogin", ref lst);
            
            
        }

        public DataTable ObtenerPermisosUsuarios()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idUsuario", MidUsuario));
            return dt = C.Listado("permisoUsuario", lst);
        }

        public string ActivarSoftware()
        {
            string mensaje ="";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tipo", MtipoActivacion));
            C.EjecutarSP("activarSoftware", ref lst);
            mensaje = lst[0].Valor.ToString();
           
            return mensaje;
        }

        public string RevisarSoftwareActivado()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));

            C.EjecutarSP("revisarSoftwareActivado", ref lst);
            mensaje = lst[0].Valor.ToString();

            return mensaje;
        }

        public DataTable ObtenerDiasActivo()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@idFactura", Mid));
            return dt = C.Listado("obtener_dias_activo", lst);
        }

    }
}
