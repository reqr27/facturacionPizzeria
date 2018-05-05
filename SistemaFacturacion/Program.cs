using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFacturacion.Classes;
using System.Threading;
using System.Diagnostics;


namespace SistemaFacturacion
{
    public static class Program
    {
        public static string Gproducto;
        public static int GproductoId;
        public static string Gunidad;
        public static double Gexistencia;
        public static double Gcosto;
        public static double GentradaSalida;
        public static int GidUnidad;
        public static string Gcantidad;
        public static string Gprecio;
        public static int GfacturaId;
        public static int GtipoProductoId;
        public static string ReporteMetodo;
        public static string Gusuario;
        public static int GidUsuario;
        public static string GtipoUsuario;
        public static string GnombreUsuario;
        public static double Gefectivo;
        public static double Gdevuelta;
        public static bool SoftwareActivated = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String thisprocessname = Process.GetCurrentProcess().ProcessName;

            if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            {
                
                return;
            }
               
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.LoginForm());
        }
    }
}
