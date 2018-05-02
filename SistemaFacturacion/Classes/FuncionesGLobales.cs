using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Management;

namespace SistemaFacturacion.Classes
{
    class FuncionesGLobales
    {
        public bool ValidarPermisoTransaccion(string transaccion)
        {
            bool acceso = false;
            Usuarios U = new Usuarios();
            DataTable dt = new DataTable();
            U.idUsuario = Program.GidUsuario;
            dt = U.ObtenerPermisosUsuarios();
            if (Convert.ToBoolean(dt.Rows[0]["ESTADO"]))
            {
                if (transaccion == "CREAR USUARIO")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR_USUARIO"]);
                }
                else if (transaccion == "CREAR PRODUCTO")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR_PRODUCTO"]);
                }

                else if (transaccion == "CREAR TIPO PRODUCTO")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR_TIPO_PRODUCTO"]);
                }

                else if (transaccion == "CREAR UNIDAD")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR_UNIDAD"]);
                }
                else if (transaccion == "FACTURACION")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["FACTURACION"]);
                }

                else if (transaccion == "HISTORIAL FACTURAS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["HISTORIAL_FACTURAS"]);
                }

                else if (transaccion == "ENTRADA PRODUCTOS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["ENTRADA_PRODUCTOS"]);
                }

                else if (transaccion == "SALIDA PRODUCTOS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["SALIDA_PRODUCTOS"]);
                }

                else if (transaccion == "REPORTE EXISTENCIA")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["REPORTE_EXISTENCIA"]);
                }

                else if (transaccion == "CUADRE")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CUADRE"]);
                }

                else if (transaccion == "REPORTE ENTRADA")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["REPORTE_ENTRADA"]);
                }

                else if (transaccion == "REPORTE SALIDA")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["REPORTE_SALIDA"]);
                }

                else if (transaccion == "INGREDIENTES PRODUCTOS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["INGREDIENTES_PRODUCTOS"]);
                }

                else
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["REPORTE_VENTAS"]);
                }
            }
            

            return acceso;
        }

        public string serial()
        {

            //wmic diskdrive get serialnumber
            ManagementClass mangnmt = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";

            foreach (ManagementObject strt in mcol)
            {
                if (Convert.ToString(strt["MediaType"]).ToUpper().Contains("FIXED"))
                {
                    result += Convert.ToString(strt["SerialNumber"]); //wmic diskdrive get serialnumber
                }
            }
            string time = DateTime.Now.ToString("yyyyMM");

            return time.Trim() + result.Trim();
        }

        public string serialKeyActivation(int total)
        {
            string result = "none";
            
            int totalSumSerial = 10000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);
            int totalSumSerial2 = 5000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);

            if (totalSumSerial == total)
            {
                result = "Full";
            }
            else if(totalSumSerial2== total)
            {
                result = "Trial";
            }
            return result;
        }

    }
}
