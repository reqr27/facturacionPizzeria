using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SistemaFacturacion.Classes
{
    class TipoProducto
    {
        private Conexion C = new Conexion();

        string MtipoProducto;
        int MidTipoProducto;


        public string Tipo
        {
            get { return MtipoProducto; }
            set { MtipoProducto = value; }
        }

        public int idTipoProducto
        {
            get { return MidTipoProducto; }
            set { MidTipoProducto = value; }
        }


        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tipoProducto", MtipoProducto));

            C.EjecutarSP("guardarTipoProducto", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public string Actualizar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tipoProducto", MtipoProducto));
            lst.Add(new clsParametros("@id", MidTipoProducto));
            C.EjecutarSP("actualizarTipoProducto", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerTipoProducto()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtenerTipoProducto", lst);
        }
    }

}
