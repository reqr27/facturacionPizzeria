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
    public partial class ConfiguracionesForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        FuncionesGLobales FG = new FuncionesGLobales();
        Usuarios U = new Usuarios();
        public ConfiguracionesForm()
        {
            InitializeComponent();
        }

        private void ConfiguracionesForm_Load(object sender, EventArgs e)
        {

        }

        private void agregarProducto_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("CREAR PRODUCTO");

            if (permiso)
            {
                ProductoForm form = new ProductoForm();
                form.ShowDialog();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso para esta acción", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void componentesProducto_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("INGREDIENTES PRODUCTOS"); ;  //
            if (permiso)
            {
                ComponentesProductosForm form = new ComponentesProductosForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuario no tiene permiso", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void agragarTipoUnidad_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("CREAR UNIDAD");

            if (permiso)
            {
                TipoUnidadForm form = new TipoUnidadForm();
                form.ShowDialog();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso para esta acción", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void usuarios_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("CREAR USUARIO");

            if (permiso)
            {
                UsuariosForm form = new UsuariosForm();
                form.Show();
            }

            else
            {
                MessageBox.Show("Usuario no tiene permiso para esta acción", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
