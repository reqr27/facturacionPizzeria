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
    public partial class ComponentesProductosForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        Productos P = new Productos();
        public int idUnidad = 0;
        public bool Evento = false;
        public ComponentesProductosForm()
        {
            InitializeComponent();
        }

        private void ComponentesProductosForm_Load(object sender, EventArgs e)
        {
            LlenarCbProductosTerminados();
            LlenarCbIngredientes();
            LlenarDtgComponentes();
            cantidad_txt.Text = "0";
        }

        public void LlenarCbProductosTerminados()
        {
            productoTerminado_cb.DataSource = null;

            DataTable dt = new DataTable();
            dt = P.ObtenerProductosTerminados();
            productoTerminado_cb.DataSource = dt;
            productoTerminado_cb.DisplayMember = "PRODUCTO";
            productoTerminado_cb.ValueMember = "ID";
            //productoTerminado_cb.SelectedIndex = -1;
        }

        public void LlenarCbIngredientes()
        {
            ingrediente_cb.DataSource = null;

            DataTable dt = new DataTable();
            dt = P.ObtenerProductosNoTerminados();
            
            ingrediente_cb.DataSource = dt;
            ingrediente_cb.DisplayMember = "PRODUCTO";
            ingrediente_cb.ValueMember = "ID";
            //ingrediente_cb.SelectedIndex = -1;

        }

        private void ingrediente_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ingrediente_cb.SelectedIndex != -1 && ingrediente_cb.SelectedValue.ToString()!="System.Data.DataRowView")
                {
                    DataTable dt = new DataTable();
                    P.idProducto = Convert.ToInt32(ingrediente_cb.SelectedValue);
                    dt = P.ObtenerUnidadComponente();
                    unidad_lbl.Text = dt.Rows[0][0].ToString();
                    idUnidad = Convert.ToInt32(dt.Rows[0][1].ToString());
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex. Message);
            }
            
        }

        public void LlenarDtgComponentes()
        {
            componentes_dtg.DataSource = null;
            DataTable dt = new DataTable();
            P.idProducto = Convert.ToInt32(productoTerminado_cb.SelectedValue);
            dt = P.ObtenerComponentesProducto();
            componentes_dtg.DataSource = dt;
            componentes_dtg.Columns[3].Visible = false;
            componentes_dtg.Columns[4].Visible = false;
            if (componentes_dtg.Rows.Count > 0)
            {
                eliminar_btn.Enabled = true;
            }
            else
            {
                eliminar_btn.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msj = ValidadAñadir();
            if (msj == "OK")
            {
                if (!Evento)
                {
                    AgregarComponentesProducto();
                }else
                {
                    ActualizarComponentesProducto();
                }
                
            }else
            {
                MessageBox.Show(msj, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ValidadAñadir()
        {
            string msj = "OK";
            double n;
            bool CantidadNum = double.TryParse(cantidad_txt.Text, out n);

            if(productoTerminado_cb.Text == "")
            {
                msj = "Seleccione un Producto";
            }
            else if (ingrediente_cb.Text == "")
            {
                msj = "Seleccione un Ingrediente";
            }
            else if (!CantidadNum)
            {
                msj = "Campo Cantidad solo permite valores Númericos";
                cantidad_txt.Text = "0";
            }
           
            return msj;

        }

        private void productoTerminado_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (productoTerminado_cb.SelectedIndex != -1 && productoTerminado_cb.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    producto_lbl.Text = productoTerminado_cb.Text.ToString();
                    LlenarDtgComponentes();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AgregarComponentesProducto()
        {
            P.idProducto = Convert.ToInt32(productoTerminado_cb.SelectedValue);
            P.idIngrediente = Convert.ToInt32(ingrediente_cb.SelectedValue);
            P.idTipoUnidad = idUnidad;
            P.CantidadEntradaSalida = Convert.ToDouble(cantidad_txt.Text);
            string mensaje = P.InsertarComponenteProducto();
            if (mensaje == "1")
            {

                MessageBox.Show("Ingrediente Agregado al Producto Seleccionado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cantidad_txt.Text = "0";
                LlenarDtgComponentes();
            }
            else if (mensaje == "2")
            {
                MessageBox.Show("Este ingrediente ya existe para el producto seleccionado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cantidad_txt.Text = "0";
            }
            else
            {
                MessageBox.Show("No se pudo agregar ingrediente al producto seleccionado", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        public void ActualizarComponentesProducto()
        {
            P.idProducto = Convert.ToInt32(productoTerminado_cb.SelectedValue);
            P.idIngrediente = Convert.ToInt32(ingrediente_cb.SelectedValue);
            P.CantidadEntradaSalida = Convert.ToDouble(cantidad_txt.Text);
            string mensaje = P.ActualizarComponenteProducto();
            if (mensaje == "1")
            {

                MessageBox.Show("Ingrediente Actualizado al Producto Seleccionado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cantidad_txt.Text = "0";
                
                ResetCampos();
                LlenarDtgComponentes();
            }
            
            else
            {
                MessageBox.Show("No se pudo actualizar ingrediente al producto seleccionado", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void componentes_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento = true;
            button1.Text = "Actualizar";
            cancelarEditar_btn.Enabled = true;
            ingrediente_cb.Text = componentes_dtg.CurrentRow.Cells[0].Value.ToString();
            cantidad_txt.Text = componentes_dtg.CurrentRow.Cells[2].Value.ToString();
            eliminar_btn.Enabled = false;
        }

        public void ResetCampos()
        {
            Evento = false;
            button1.Text = "Añadir";
            cancelarEditar_btn.Enabled = false;
            cantidad_txt.Text = "0";
            eliminar_btn.Enabled = true;
            
        }

        private void cancelarEditar_btn_Click(object sender, EventArgs e)
        {
            ResetCampos();
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            P.idProducto = Convert.ToInt32(productoTerminado_cb.SelectedValue);
            P.idIngrediente = Convert.ToInt32(componentes_dtg.CurrentRow.Cells[3].Value.ToString());
            
            string mensaje = P.EliminarComponenteProducto();
            if (mensaje == "1")
            {

                MessageBox.Show("Ingrediente Eliminado del Producto Seleccionado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ResetCampos();
                LlenarDtgComponentes();
            }

            else
            {
                MessageBox.Show("No se pudo eliminar ingrediente del producto seleccionado", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
