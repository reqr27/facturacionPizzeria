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
    public partial class BuscarProductoForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        Productos P = new Productos();
        public BuscarProductoForm()
        {
            InitializeComponent();
        }

        private void BuscarProductoForm_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void buscar_producto_txt_TextChanged(object sender, EventArgs e)
        {
            if (buscar_producto_txt.Text.Trim() == "")
            {
                LlenarDataGrid();
            }
            else
            {
                LlenarDatagridProductoBuscado();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.GproductoId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Program.Gproducto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Program.Gexistencia = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value);
            Program.Gunidad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.Gcosto = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value);
            Program.GidUnidad = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);
            this.Close();
        }


        public void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerProductosNoTerminados();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[7].Visible = false;
        }

        public void LlenarDatagridProductoBuscado()
        {
            try
            {
                dataGridView1.DataSource = null;
                DataTable dt = new DataTable();
                P.Producto = buscar_producto_txt.Text;
                dt = P.BuscarProductosNoTerminados();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[7].Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
