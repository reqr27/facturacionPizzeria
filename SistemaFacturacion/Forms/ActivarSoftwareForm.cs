﻿using System;
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
            
        }

        private void ActivarSoftwareForm_Load(object sender, EventArgs e)
        {
            txt1.MaxLength = 4;
            textBox1.MaxLength = 4;
            textBox2.MaxLength = 4;
            txt1.Focus();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(txt1.Text);
                if (txt1.Text.Length == 4)
                {
                    textBox1.Focus();
                }




            }
            catch
            {

                if (txt1.Text.Length > 1)
                {
                    txt1.Text = txt1.Text.Remove(txt1.Text.Length - 1);
                    txt1.SelectionStart = txt1.Text.Length;
                }
                else
                {
                    txt1.Text = "";
                }

            }
            if (textBox1.Text.Length + txt1.Text.Length + textBox2.Text.Length == 12)
            {
                activar_btn.Enabled = true;
            }
            else
            {
                activar_btn.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(textBox2.Text);

            }
            catch
            {

                if (textBox2.Text.Length > 1)
                {
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                    textBox2.SelectionStart = textBox2.Text.Length;
                }
                else
                {
                    textBox2.Text = "";
                }

            }
            if (textBox1.Text.Length + txt1.Text.Length + textBox2.Text.Length == 12)
            {
                activar_btn.Enabled = true;
            }
            else
            {
                activar_btn.Enabled = false;
            }
        }

        private void activar_btn_Click_1(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(txt1.Text) + Convert.ToInt32(textBox2.Text);
            if (FG.serialKeyActivation(total) != "none")
            {
                U.TipoActivacion = FG.serialKeyActivation(total);
                string msj = U.ActivarSoftware();
                if (msj == "1")
                {
                    MessageBox.Show("Software Activado", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Software no pudo ser activado, intente nuevamente más tarde", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Código incorrecto", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
