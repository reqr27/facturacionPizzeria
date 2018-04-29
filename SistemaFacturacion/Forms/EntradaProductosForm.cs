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
    public partial class EntradaProductosForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public int idProducto;
        FuncionesGLobales FG = new FuncionesGLobales();
        Productos P = new Productos();
        public EntradaProductosForm()
        
        {
            InitializeComponent();
        }

        private void EntradaProductosForm_Load(object sender, EventArgs e)
        {
            
            LlenarTxtProveedor();
            RevisarPermisos();
        } 
        public void LlenarTxtProveedor()
        {
            proveedor_txt.AutoCompleteCustomSource = null;
            DataTable dt = new DataTable();
            dt = P.ObtenerProveedores();
            string[] postSource = dt
                                .AsEnumerable()
                                .Select<System.Data.DataRow, String>(x => x.Field<String>("Proveedor"))
                                .ToArray();

            var source = new AutoCompleteStringCollection();
            source.AddRange(postSource);
            proveedor_txt.AutoCompleteCustomSource = source;
            proveedor_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            proveedor_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            BuscarProductoForm form = new BuscarProductoForm();
            form.ShowDialog();
            producto_txt.Text = Program.Gproducto;
            existenciaActual_txt.Text = Program.Gexistencia.ToString();
            unidad2_lbl.Text = Program.Gunidad;
            unidad_lbl.Text = Program.Gunidad;
            costo_txt.Text = Program.Gcosto.ToString();
            LlenarTxtProveedor();


        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (entrada_radiobtn.Checked)
                {
                    EntradaProducto();
                    LlenarTxtProveedor();
                }else
                {
                    SalidaProducto();
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        public string ValidarCampos()
        {
            double n;
            bool costoNum = double.TryParse(costo_txt.Text, out n);
            bool cantidadEntradaSalida = double.TryParse(cantidadEntrada_txt.Text, out n);
            string msj = "OK";
            double existencia = Convert.ToDouble(existenciaActual_txt.Text);
            double salidaValor = Convert.ToDouble(cantidadEntrada_txt.Text);

            if (producto_txt.Text.Trim() == "")
            {
                msj = "Seleccione un Producto ";
            }

            else if (!cantidadEntradaSalida)
            {
                msj = "Campo Cantidad Entrada debe ser Numérico";
                cantidadEntrada_txt.Text = "0";
            }

            else if (!costoNum)
            {
                msj = "Campo Costo debe ser Numérico";
                costo_txt.Text = Program.Gcosto.ToString() ;
            }

            else if (proveedor_txt.Text.Trim() == "" && !salida_radiobtn.Checked)
            {
                msj = "Campo Proveedor debe ser Completado";
            }
            else if (salidaValor > existencia && salida_radiobtn.Checked)
            {
                msj = "Cantidad de Salida Excede Existencia";
            }

            else
            {
                msj = "OK";
            }

            return msj;
        }

        public string ValidarRestaExistencia()
        {
            string msj = "OK";
            

            return msj;


            
        }

        public void ClearFields()
        {
            producto_txt.Text = "";
            existenciaActual_txt.Text = "";
            cantidadEntrada_txt.Text = "";
            costo_txt.Text = "";
            proveedor_txt.Text = "";
            unidad2_lbl.Text = "";
            unidad_lbl.Text = "";
        }

        public void EntradaProducto()
        {
            string msj = ValidarCampos();
            if (msj == "OK")
            {
                P.idProducto = Program.GproductoId;
                P.CantidadEntradaSalida = Convert.ToDouble(cantidadEntrada_txt.Text);
                P.idTipoUnidad = Program.GidUnidad;
                P.Costo = Program.Gcosto;
                P.Proveedor = proveedor_txt.Text;
                P.Fecha = dateTimePicker1.Value;
                P.TipoTransaccion = "Entrada";
                string mensaje = P.EntradaSalidaProductos();
                if (mensaje == "1")
                {
                    ClearFields();
                    MessageBox.Show("Transacción Entrada Realizada!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    
                    MessageBox.Show("Transacción Entrada no pudo ser Realizada!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(msj, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SalidaProducto()
        {
            string msj = ValidarCampos();
            if (msj == "OK")
            {
                P.idProducto = Program.GproductoId;
                P.CantidadEntradaSalida = Convert.ToDouble(cantidadEntrada_txt.Text);
                P.idTipoUnidad = Program.GidUnidad;
                P.Costo = Program.Gcosto;
                P.Proveedor = proveedor_txt.Text;
                P.Fecha = dateTimePicker1.Value;
                P.TipoTransaccion = "Salida";
                string mensaje = P.EntradaSalidaProductos();
                if (mensaje == "1")
                {
                    ClearFields();
                    MessageBox.Show("Transacción Salida Realizada!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(mensaje == "2")
                {
                    ClearFields();
                    MessageBox.Show("Transacción Salida Realizada!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Existencia Actual está por debajo del mínimo programado para producto actualizado.", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
                else
                {
                    MessageBox.Show("Transacción Salida no pudo ser Realizada!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show(msj, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RevisarPermisos()
        {
            bool permisoentrada = FG.ValidarPermisoTransaccion("ENTRADA PRODUCTOS");
            bool permisosalida = FG.ValidarPermisoTransaccion("SALIDA PRODUCTOS");

            if (permisoentrada)
            {
                entrada_radiobtn.Checked = true;
                salida_radiobtn.Checked = false;
                proveedor_txt.Text = "";
                proveedor_txt.Enabled = true;
                costo_txt.Enabled = true;
            }
            else
            {
                entrada_radiobtn.Checked = false;
                salida_radiobtn.Checked = true;
                proveedor_txt.Text = "";
                proveedor_txt.Enabled = false;
                costo_txt.Enabled = false;
            }
        }

        private void entrada_radiobtn_Click(object sender, EventArgs e)
        {
            bool permisoentrada = FG.ValidarPermisoTransaccion("ENTRADA PRODUCTOS");
            bool permisosalida = FG.ValidarPermisoTransaccion("SALIDA PRODUCTOS");

            if (permisoentrada)
            {
                proveedor_txt.Text = "";
                proveedor_txt.Enabled = true;
                costo_txt.Enabled = true;
            }

            else
            {
                salida_radiobtn.Checked = true;
                entrada_radiobtn.Checked = false;
                MessageBox.Show("Usuario no tiene permiso para esta acción", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void salida_radiobtn_Click(object sender, EventArgs e)
        {
            bool permisoentrada = FG.ValidarPermisoTransaccion("ENTRADA PRODUCTOS");
            bool permisosalida = FG.ValidarPermisoTransaccion("SALIDA PRODUCTOS");

            if (permisosalida)
            {
                proveedor_txt.Text = "";
                proveedor_txt.Enabled = false;
                costo_txt.Enabled = false;
            }

            else
            {
                entrada_radiobtn.Checked = true;
                salida_radiobtn.Checked = false;
                MessageBox.Show("Usuario no tiene permiso para esta acción", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
    }
}
