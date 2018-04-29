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
    public partial class LoginForm : Form
    {
        Usuarios U = new Usuarios();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                usuario_txt.Text = Properties.Settings.Default.user;
                U.PrimeraCorrida();
                
                if(usuario_txt.Text == "")
                {
                    usuario_txt.Focus();
                }
                else
                {
                    this.ActiveControl = clave_txt;
                }
                string mensaje =U.RevisarSoftwareActivado();
                if (mensaje == "1")
                {
                    Program.SoftwareActivated = true;
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void entrar_btn_Click(object sender, EventArgs e)
        {
            Program.Gusuario = usuario_txt.Text;
            Login();
        }

        public void Login()
        {
            try
            {

                U.Usuario = usuario_txt.Text;
                U.Clave = clave_txt.Text;
                string[] msj = U.Login();
                if (msj[0] == "1")
                {
                    Program.GidUsuario = Convert.ToInt32(msj[1]);
                    Program.GtipoUsuario = msj[2];
                    Program.GnombreUsuario = msj[3];
                    Program.Gusuario = usuario_txt.Text;
                    this.Hide();
                    Form1 form = new Form1();
                    form.ShowDialog();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña son incorrectos!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void usuario_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void clave_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
