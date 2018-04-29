using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFacturacion.Classes;

namespace SistemaFacturacion.Forms
{
    public partial class VentanaReportesForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        FuncionesGLobales FG = new FuncionesGLobales();
        Usuarios U = new Usuarios();
        public VentanaReportesForm()
        {
            InitializeComponent();
        }

        private void historialFacturas_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("HISTORIAL FACTURAS");

            if (permiso)
            {
                HistorialFacturasForm form = new HistorialFacturasForm();
                form.Show();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso para esta acción", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void salidaProductoReporte_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("REPORTE SALIDA");
            if (permiso)
            {
                Program.ReporteMetodo = "Reporte Salida";
                ReportesForm form = new ReportesForm();
                form.Show();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso", "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void existenciaReporte_btn_Click(object sender, EventArgs e)
        {
            Program.ReporteMetodo = "ExistenciaActual";
            ReportesForm form = new ReportesForm();
            form.Show();
        }

        private void entradaProductosReporte_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("REPORTE ENTRADA"); ;
            if (permiso)
            {
                Program.ReporteMetodo = "Reporte Entrada";
                ReportesForm form = new ReportesForm();
                form.Show();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso", "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ventasReporte_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("REPORTE VENTAS");
            if (permiso)
            {
                Program.ReporteMetodo = "Reporte Ventas";
                ReportesForm form = new ReportesForm();
                form.Show();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso", "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VentanaReportesForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
