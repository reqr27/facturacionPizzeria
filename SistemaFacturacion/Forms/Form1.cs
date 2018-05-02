using SistemaFacturacion.Classes;
using SistemaFacturacion.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SistemaFacturacion
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        FuncionesGLobales FG = new FuncionesGLobales();
        Usuarios U = new Usuarios();
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fecha_lbl.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            timer1.Enabled = true;
            this.MaximizeBox = false;
            //panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            //panel1.Anchor = AnchorStyles.None;

            panel3.Location = new Point(this.ClientSize.Width / 2 - panel3.Size.Width / 2);
            panel3.Anchor = AnchorStyles.None;

            
            usuario_lbl.Text ="Usuario: " + Program.Gusuario + "    -    ID: " + Program.GidUsuario.ToString() + "    -    Tipo Usuario: " + Program.GtipoUsuario;
            Properties.Settings.Default.user = Program.Gusuario;
            Properties.Settings.Default.Save();
            //panel3.Location = new Point(this.ClientSize.Width / 2 - panel3.Size.Width / 2);
            //panel3.Anchor = AnchorStyles.None;
            RevisarActivado();

        }


        private void agregarTipoProducto_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("CREAR TIPO PRODUCTO");

            if (permiso)
            {
                TipoProductoForm form = new TipoProductoForm();
                form.ShowDialog();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso para esta acción", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

      

        private void entradaProductos_btn_Click(object sender, EventArgs e)
        {
            bool permisoentrada = FG.ValidarPermisoTransaccion("ENTRADA PRODUCTOS");
            bool permisosalida = FG.ValidarPermisoTransaccion("SALIDA PRODUCTOS");

            if (permisoentrada || permisosalida)
            {
                EntradaProductosForm form = new EntradaProductosForm();
                form.ShowDialog();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso para esta acción", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void facturacion_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("FACTURACION");

            if (permiso)
            {
                FacturarForm form = new FacturarForm();
                form.Show();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso para esta acción", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

       
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CerrarSesion();


        }
        public void CerrarSesion()
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "LoginForm")
                    f.Hide();

            }

            LoginForm form = new LoginForm();
            form.ShowDialog();
            //this.Close();
        }
      
        private void activarSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarSoftwareForm form = new ActivarSoftwareForm();
            form.ShowDialog();
            RevisarActivado();
        }

       

        private void timer1_Tick(object sender, EventArgs e)

        {
            fecha_lbl.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void cerrarSesion_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CerrarSesion();
        }

        private void cuadreDiario_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("CUADRE");
            if (permiso)
            {
                Program.ReporteMetodo = "Cuadre Caja";
                ReportesForm form = new ReportesForm();
                form.Show();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso", "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void config_btn_Click(object sender, EventArgs e)
        {
            ConfiguracionesForm frm = new ConfiguracionesForm();
            frm.Show();
        }

        private void reportes_btn_Click(object sender, EventArgs e)
        {
            VentanaReportesForm frm = new VentanaReportesForm();
            frm.Show();
        }

        private void cuadreDiario_btn_Click_1(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("CUADRE DIARIO");
            if (permiso)
            {
                Program.ReporteMetodo = "Cuadre Caja";
                ReportesForm form = new ReportesForm();
                form.Show();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso", "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void activar_btn_Click(object sender, EventArgs e)
        {
            ActivarSoftwareForm frm = new ActivarSoftwareForm();
            frm.ShowDialog();
            RevisarActivado();
        }

        public void RevisarActivado()
        {
            string mensaje = U.RevisarSoftwareActivado();
            if (mensaje == "0")
            {
                timer2.Stop();
                agregarTipoProducto_btn.Enabled = false;
                config_btn.Enabled = false;
                reportes_btn.Enabled = false;

                entradaProductos_btn.Enabled = false;

                facturacion_btn.Enabled = false;

                cuadreDiario_btn.Enabled = false;
                activado_lbl.Visible = true;
                activar_btn.Visible = true;
            }
            else if (mensaje == "Trial")
            {
                DataTable dt = new DataTable();
                dt = U.ObtenerDiasActivo();

                string dias = dt.Rows[0]["DIAS"].ToString();
                if(dias == "0")
                {
                    timer2.Stop();
                    agregarTipoProducto_btn.Enabled = false;
                    config_btn.Enabled = false;
                    reportes_btn.Enabled = false;

                    entradaProductos_btn.Enabled = false;

                    facturacion_btn.Enabled = false;
                    activado_lbl.Text = "Version De Prueba ha vencido";
                    cuadreDiario_btn.Enabled = false;
                    activado_lbl.Visible = true;
                    activar_btn.Visible = true;
                    CerrarForms();
                }
                else
                {
                    timer2.Start();
                    agregarTipoProducto_btn.Enabled = false;
                    config_btn.Enabled = true;
                    reportes_btn.Enabled = true;

                    entradaProductos_btn.Enabled = true;

                    facturacion_btn.Enabled = true;

                    cuadreDiario_btn.Enabled = true;
                    activado_lbl.Visible = true;
                    activado_lbl.Text = "Version De Prueba - Vence en: " + dias + " días";
                    activar_btn.Visible = true;
                }
                

                
            }

            else if (mensaje == "Full")
            {
                timer2.Stop();
                agregarTipoProducto_btn.Enabled = false;
                config_btn.Enabled = true;
                reportes_btn.Enabled = true;

                entradaProductos_btn.Enabled = true;

                facturacion_btn.Enabled = true;

                cuadreDiario_btn.Enabled = true;
                activado_lbl.Visible = false;
                
                activar_btn.Visible = false;


            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            RevisarActivado();
            timer2.Start();
        }

        public void CerrarForms()
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {

                if (f.Name != "Form1" && f.Name != "LoginForm" && f.Name != "ActivarSoftwareForm")
                    f.Close();
            }
        }
    }
}
