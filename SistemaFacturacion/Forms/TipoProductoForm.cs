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
    public partial class TipoProductoForm : Form
    {
        public int idTipoProducto;
        public bool evento;
        TipoProducto TP = new TipoProducto();

        public TipoProductoForm()
        {
            InitializeComponent();
        }

        private void TipoProducto_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = TP.ObtenerTipoProducto() ;
            dataGridView1.DataSource = dt;
        }

        private void guardarUnidad_btn_Click(object sender, EventArgs e)
        {
            if (tipoProducto_txt.Text.Trim() != "")
            {
                if (evento == false)
                {
                    TP.Tipo = tipoProducto_txt.Text;
                    string mensaje = TP.Registrar();
                    if (mensaje == "1")
                    {
                        tipoProducto_txt.Clear();
                        MessageBox.Show("Tipo Producto Registrado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        DataTable dt = new DataTable();
                        dt =TP.ObtenerTipoProducto();
                        dataGridView1.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar Tipo Producto. Compruebe que no esta unidad no exista actualmente", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    evento = false;
                    TP.Tipo = tipoProducto_txt.Text;
                    TP.idTipoProducto = idTipoProducto;
                    string mensaje = TP.Actualizar();
                    if (mensaje == "1")
                    {
                        tipoProducto_txt.Clear();
                        
                        MessageBox.Show("Tipo Producto Actualizado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        DataTable dt = new DataTable();
                        dt = TP.ObtenerTipoProducto();
                        dataGridView1.DataSource = dt;

                    }
                    else
                    {
                        
                        MessageBox.Show("No se pudo actualizar el tipo de producto deseado.", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            else
            {
                MessageBox.Show("Campo Tipo Producto debe ser completado", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            evento = true;
            idTipoProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            tipoProducto_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            tipoProducto_txt.Focus();
        }
    }
}
