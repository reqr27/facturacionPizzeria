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
    public partial class TipoUnidadForm : Form
    {
        public bool evento = false;
        public int idTipoUnidad;
        TipoUnidad U = new TipoUnidad();
        public TipoUnidadForm()
        {
            InitializeComponent();
        }

        private void guardarUnidad_btn_Click(object sender, EventArgs e)
        {
            if (unidad_txt.Text.Trim() != "")
            {
                if(evento == false)
                {
                    U.Unidad = unidad_txt.Text;
                    U.Descripcion = descripcion_txt.Text;
                    string mensaje = U.Registrar();
                    if (mensaje == "1")
                    {
                        unidad_txt.Clear();
                        descripcion_txt.Clear();
                        MessageBox.Show("Unidad Registrada!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        DataTable dt = new DataTable();
                        dt = U.ObtenerTipoUnidad();
                        dataGridView1.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar unidad. Compruebe que no esta unidad no exista actualmente", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    evento = false;
                    U.Unidad = unidad_txt.Text;
                    U.Descripcion = descripcion_txt.Text;
                    U.idTipoUnidad = idTipoUnidad;
                    string mensaje = U.Actualizar();
                    if (mensaje == "1")
                    {
                        unidad_txt.Clear();
                        descripcion_txt.Clear();
                        MessageBox.Show("Unidad Actualizada!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        DataTable dt = new DataTable();
                        dt = U.ObtenerTipoUnidad();
                        dataGridView1.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la unidad deseada.", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Campo Unidad debe ser completado", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TipoUnidadForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = U.ObtenerTipoUnidad();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            evento = true;
            idTipoUnidad = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            unidad_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            descripcion_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            unidad_txt.Focus();
        }
    }
}
