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
using System.Globalization;


namespace SistemaFacturacion.Forms
{
    public partial class ProductoForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public bool Evento = false;
        public int idProducto;
        TipoProducto TP = new TipoProducto();
        TipoUnidad TU = new TipoUnidad();
        Productos P = new Productos();
        public int index;
        public ProductoForm()
        {
            InitializeComponent();
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            
            costo_txt.Text = "0";
            precio_txt.Text = "0";
            alerta_txt.Text = "0";
            costo_txt.Enabled = false;
            precio_txt.Enabled = false;
            alerta_txt.Enabled = false;
            LlenarItbisCombo();
            LlenaTipoUnidadCombo();
            
            
            LlenarTipoProductoCombo();
            LlenarDatagrid();
        }

        public void LlenarTipoProductoCombo()
        {
            tipoProducto_cb.DataSource = null;
            
            DataTable dt = new DataTable();
            dt = TP.ObtenerTipoProducto();
            tipoProducto_cb.DataSource = dt;
            tipoProducto_cb.DisplayMember = "TIPO";
            tipoProducto_cb.ValueMember = "IDENTIFICADOR";
            tipoProducto_cb.SelectedIndex = 0;
            
        }

        public void LlenarItbisCombo()
        {
            itbis_cb.DataSource = null;

            DataTable dt = new DataTable();
            dt = P.ObtenerItbis();
            itbis_cb.DataSource = dt;
            itbis_cb.DisplayMember = "ITBIS";
            itbis_cb.ValueMember = "ID";
            itbis_cb.SelectedIndex = -1;

        }

        public void LlenaTipoUnidadCombo()
        {
            unidad_cb.DataSource = null;
            DataTable dt = new DataTable();
            dt = TU.ObtenerTipoUnidad();
            unidad_cb.DataSource = dt;
            unidad_cb.DisplayMember = "UNIDAD";
            unidad_cb.ValueMember = "IDENTIFICADOR";
            unidad_cb.SelectedIndex = -1;

        }

        private void tipoProducto_cb_DropDown(object sender, EventArgs e)
        {
            //LlenarTipoProductoCombo();
        }

        private void unidad_cb_DropDown(object sender, EventArgs e)
        {
           // LlenaTipoUnidadCombo();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento = true;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Ingrediente")
            {
                idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                nombreProducto_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tipoProducto_cb.SelectedIndex = 0;/*SelectedText = dataGridView1.CurrentRow.Cells[3].Value.ToString();*/
                unidad_cb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                costo_txt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                precio_txt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                alerta_txt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                precio_txt.Text = "0";
                precio_txt.Enabled = false;
                costo_txt.Enabled = true;
                alerta_txt.Enabled = true;
                itbis_cb.SelectedIndex = -1;
                itbis_cb.Enabled = false;
                index = 0;
            }
            else if(dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Producto Terminado")
            {
                idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                nombreProducto_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //tipoProducto_cb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                tipoProducto_cb.SelectedIndex = 1;
                unidad_cb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                costo_txt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                precio_txt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                itbis_cb.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                alerta_txt.Text = "0";
                costo_txt.Enabled = false;
                precio_txt.Enabled = true;
                alerta_txt.Enabled = false;
                itbis_cb.Enabled = true;
                index = 1;
            }
            else 
            {
                idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                nombreProducto_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //tipoProducto_cb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                tipoProducto_cb.SelectedIndex = 2;
                unidad_cb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                costo_txt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                precio_txt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                itbis_cb.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                alerta_txt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                costo_txt.Enabled = true;
                alerta_txt.Enabled = true;
                precio_txt.Enabled = true;
                itbis_cb.Enabled = true;
                index = 2;
            }
            
            
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            string msj = ValidarCampos();
            if (Evento == false)
            {
                if(msj == "OK")
                {
                    AgregarProducto();
                    if (tipoProducto_cb.SelectedIndex == 0)
                    {
                        LlenarGridIngredientes();
                    }

                    else if (tipoProducto_cb.SelectedIndex == 1)
                    {
                        LlenarGridTerminados();
                    }
                    else
                    {
                        LlenarGridBebidas();
                    }
                }
                else
                {
                    MessageBox.Show(msj, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                if (msj == "OK")
                {
                    ActulizarProducto();
                    //LlenarDatagrid();
                }
                else
                {
                    MessageBox.Show(msj, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string ValidarCampos()
        {
            double n;
            bool costoNum = double.TryParse(costo_txt.Text, out n);
            bool precioNum = double.TryParse(precio_txt.Text, out n);
            bool alertaNum = double.TryParse(alerta_txt.Text, out n);
            string msj = "OK";

            if (nombreProducto_txt.Text.Trim() == "")
            {
                msj = "Campo nombre producto debe ser completado";
            }

            else if (tipoProducto_cb.SelectedIndex == -1)
            {
                msj = "Campo Tipo Producto debe ser completado";
            }

            else if (unidad_cb.SelectedIndex == -1)
            {
                msj = "Campo Unidad debe ser completado";
            }

            else if (unidad_cb.SelectedIndex == -1)
            {
                msj = "Campo Unidad debe ser completado";
            }

            else if (!alertaNum)
            {
                msj = "Campo Alerta Existencia debe ser Numérico";
                alerta_txt.Text = "0";
            }

            else if (!costoNum)
            {
                msj = "Campo Costo debe ser Numérico";
                costo_txt.Text = "0";
            }

            else if (!precioNum)
            {
                msj = "Campo Precio debe ser Numérico";
                precio_txt.Text = "0";
            }
            else
            {
                msj = "OK";
            }

            return msj;
        }

        public void AgregarProducto()
        {
            try
            {
                if (itbis_cb.Text == "")
                {
                    P.Itbis = 0;
                }
                else
                {
                    P.Itbis = Convert.ToDouble(itbis_cb.Text);
                }
                 
                P.Producto = nombreProducto_txt.Text;
                P.idTipoProducto = Convert.ToInt32(tipoProducto_cb.SelectedValue);
                P.idTipoUnidad = Convert.ToInt32(unidad_cb.SelectedValue);
                P.Alerta = Math.Abs(Convert.ToDouble(alerta_txt.Text));
                P.Costo = Math.Abs(Convert.ToDouble(costo_txt.Text));
                P.Precio = Math.Abs(Convert.ToDouble(precio_txt.Text));
                string msj = P.Registrar();
                if (msj == "1")
                {
                    clearFields();
                    MessageBox.Show("Producto Registrado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no fue registrado.Verifique que producto no existe actualmente", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void ActulizarProducto()
        {
            try
            {
                P.idProducto = idProducto;
                P.Producto = nombreProducto_txt.Text;
                P.idTipoProducto = Convert.ToInt32(tipoProducto_cb.SelectedValue);
                P.idTipoUnidad = Convert.ToInt32(unidad_cb.SelectedValue);
                P.Alerta = Math.Abs(Convert.ToDouble(alerta_txt.Text));
                P.Costo = Math.Abs(Convert.ToDouble(costo_txt.Text));
                P.Precio = Math.Abs(Convert.ToDouble(precio_txt.Text));
                if (itbis_cb.Text == "")
                {
                    P.Itbis = 0;
                }
                else
                {
                    P.Itbis = Convert.ToDouble(itbis_cb.Text);
                }
                string msj = P.Actualizar();
                if (msj == "1")
                {
                    clearFields();
                    MessageBox.Show("Producto Actualizado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no pudo ser actualizado", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void LlenarDatagrid()
        {
            
            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            P.TipoProducto = "ingredientes";
            dt = P.ObtenerProducto();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";

        }

        public void clearFields()
        {
            Evento = false;
            nombreProducto_txt.Text = "";
            tipoProducto_cb.SelectedIndex = index;
            unidad_cb.SelectedIndex = -1;
            costo_txt.Text = "0";
            precio_txt.Text = "0";
            alerta_txt.Text = "0";
            if (index == 0)
            {
                LlenarGridIngredientes();
            } 
            else if (index == 1)
            {
                LlenarGridTerminados();
            }
            else
            {
                LlenarGridBebidas();
            }


        }

        public void LlenarGridIngredientes()
        {
            precio_txt.Text = "0";
            precio_txt.Enabled = false;
            costo_txt.Enabled = true;
            alerta_txt.Enabled = true;

            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            P.TipoProducto = "ingredientes";
            dt = P.ObtenerProducto();
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            }

            itbis_cb.SelectedIndex = -1;
            itbis_cb.Enabled = false;
            index = 0;
        }

        public void LlenarGridTerminados()
        {
            costo_txt.Text = "0";
            costo_txt.Enabled = false;
            precio_txt.Enabled = true;
            alerta_txt.Enabled = false;

            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            P.TipoProducto = "terminado";
            dt = P.ObtenerProducto();
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            }
            
            itbis_cb.SelectedIndex = 0;
            itbis_cb.Enabled = true;
            index = 1;
        }

        public void LlenarGridBebidas()
        {
            precio_txt.Text = "0";
            costo_txt.Enabled = true;
            alerta_txt.Enabled = true;
            precio_txt.Enabled = true;


            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            P.TipoProducto = "bebida";
            dt = P.ObtenerProducto();
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            }
            itbis_cb.SelectedIndex = 0;
            itbis_cb.Enabled = true;
            index = 2;
        }

        private void tipoProducto_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Evento == false)
            {
                if (tipoProducto_cb.SelectedIndex == 0)
                {
                    LlenarGridIngredientes();

                }
                else if (tipoProducto_cb.SelectedIndex == 1)
                {
                    LlenarGridTerminados();
                }

                else //if (tipoProducto_cb.SelectedIndex == 2)
                {
                    LlenarGridBebidas();
                }

               
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
    }
}
