using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaFacturacion.Classes
{
    class TipoUnidad
    {
        private Conexion C = new Conexion();

        string Munidad;
        string Mdescripcion;
        int MidTipoUnidad;


        public string Unidad
        {
            get { return Munidad; }
            set { Munidad = value; }
        }

        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }

        public int idTipoUnidad
        {
            get { return MidTipoUnidad; }
            set { MidTipoUnidad = value; }
        }


        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@unidad", Munidad));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            
            C.EjecutarSP("guardarTipoUnidad", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public string Actualizar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@unidad", Munidad));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@id", MidTipoUnidad));
            C.EjecutarSP("actualizarTipoUnidad", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtenerTipoUnidad()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = C.Listado("obtenerTipoUnidad", lst);
        }
    }

}
