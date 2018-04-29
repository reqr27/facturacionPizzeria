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
    public partial class ActivarSoftwareForm : Form
    {
        FuncionesGLobales FG = new FuncionesGLobales();
        Usuarios U = new Usuarios();
        public ActivarSoftwareForm()
        {
            InitializeComponent();
        }

        private void activar_btn_Click(object sender, EventArgs e)
        {
            if (sn_txt.Text == FG.serial())
            {
                string mensaje = U.ActivarSoftware();
                if (mensaje == "1")
                {
                    Program.SoftwareActivated = true;
                    MessageBox.Show("Activación Correcta", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se pudo activar el Software", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se pudo activar el Software", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActivarSoftwareForm_Load(object sender, EventArgs e)
        {
            string mensaje = U.RevisarSoftwareActivado();
            if (mensaje == "1")
            {
                label1.Visible = false;
                activar_btn.Visible = false;
                sn_txt.Visible = false;
                activado_lbl.Visible = true;
            }
        }
    }
}
