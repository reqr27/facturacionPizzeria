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
    public partial class HistorialFacturasForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        FuncionesGLobales FG = new FuncionesGLobales();
        Facturas F = new Facturas();
        Productos P = new Productos();
        public HistorialFacturasForm()
        {
            InitializeComponent();
        }

        public void dtgHistorial()
        {
            try
            {
                historialFacturas_dtg.DataSource = null;
                F.Desde = desde_dtp.Value;
                F.Hasta = hasta_dtp.Value;
                F.idFactura = Convert.ToInt32(noFactura_txt.Text);
                F.Cliente = cliente_txt.Text;
                F.Estado = Convert.ToBoolean(activas_radiobtn.Checked);
                DataTable dt = F.HistorialFacturas();
                historialFacturas_dtg.DataSource = dt;
                historialFacturas_dtg.Columns[0].DefaultCellStyle.Format = "0000000";
                historialFacturas_dtg.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                historialFacturas_dtg.Columns[3].DefaultCellStyle.Format = "N2";
                if (historialFacturas_dtg.Rows.Count > 0)
                {
                    if(activas_radiobtn.Checked == true)
                    {
                        eliminar_btn.Enabled = true;
                    }
                    else
                    {
                        eliminar_btn.Enabled = false;
                    }
                    
                    verDetalles_btn.Enabled = true;
                }
                else
                {
                    verDetalles_btn.Enabled = false;
                    eliminar_btn.Enabled = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void HistorialFacturasForm_Load(object sender, EventArgs e)
        {
            desde_dtp.Value = DateTime.Now.AddDays(-1);
            hasta_dtp.Value = DateTime.Now;
            noFactura_txt.Text = "0";
            verDetalles_btn.Enabled = false;
            eliminar_btn.Enabled = false;
            dtgHistorial();
            
        }

        private void noFactura_txt_TextChanged(object sender, EventArgs e)
        {
          
            int n;
            bool factura = int.TryParse(noFactura_txt.Text, out n);
            if (!factura)
            {
                noFactura_txt.Text = "0";
            }

            dtgHistorial();
            
        }

        private void buscarFactura_btn_Click(object sender, EventArgs e)
        {
            dtgHistorial();
        }

        private void eliminadas_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            eliminar_btn.Text = "Activar Factura";
            eliminar_btn.Enabled = false;
            dtgHistorial();
        }

        private void activas_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            eliminar_btn.Text = "Cancelar Factura";

            dtgHistorial();
        }

        private void verDetalles_btn_Click(object sender, EventArgs e)
        {

            Program.ReporteMetodo = "ReimprimirFacturaCliente";
            Program.GfacturaId = Convert.ToInt32(historialFacturas_dtg.CurrentRow.Cells[0].Value);
            ReportesForm form = new ReportesForm();
            form.Show();
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            bool permiso = FG.ValidarPermisoTransaccion("ELIMINAR FACTURA");

            if (permiso)
            {
                DialogResult dialogResult = MessageBox.Show("Desea Cancelar esta factura?", "Sistema Facturacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string val = "";
                        if (activas_radiobtn.Checked)
                        {
                            Program.GfacturaId = Convert.ToInt32(historialFacturas_dtg.CurrentRow.Cells[0].Value);
                            F.idFactura = Convert.ToInt32(historialFacturas_dtg.CurrentRow.Cells[0].Value);
                            F.Estado = false;
                            val = "Factura Cancelada!";
                        }
                        else
                        {
                            F.idFactura = Convert.ToInt32(historialFacturas_dtg.CurrentRow.Cells[0].Value);
                            F.Estado = true;
                            val = "Factura Activada!";

                        }
                        string msj = F.ActivarDesactivarFactura();
                        if (msj == "1")
                        {
                            MessageBox.Show(val, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (val == "Factura Cancelada!")
                            {
                                SumarExistenciaProductos();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Factura no pudo ser modificada", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        dtgHistorial();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario no tiene permiso para esta acción", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }

        public void SumarExistenciaProductos()
        {
            string mensaje = "";

            int cantidadOrden;
            double cantidadComponente;
            int idComponente;
            DataTable dt = new DataTable();
            P.idFactura = Program.GfacturaId;
            dt = P.ObtenerDetallesFactura();
            if(dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cantidadOrden  = Convert.ToInt32(dt.Rows[i]["CANTIDAD"]);

                    P.idProducto = Convert.ToInt32(dt.Rows[i]["IDPRODUCTO"]);

                    P.Cantidad = cantidadOrden;
                    string msj5 = P.SumarExistenciaBebida();
                    if (msj5 =="0")
                    {
                        mensaje +=  "Producto Id = "+ Convert.ToInt32(dt.Rows[i]["IDPRODUCTO"]).ToString() + "no pudo ser sumado a existencia actual" + "\n";
                    }

                    DataTable dt2 = new DataTable();
                    dt2 = P.ObtenerComponentesProducto();
                    if(dt2.Rows.Count > 0)
                    {
                        for (int y = 0; y < dt2.Rows.Count; y++)
                        {
                            string NombreComponente = (dt2.Rows[i]["INGREDIENTE"]).ToString();
                            idComponente = Convert.ToInt32(dt2.Rows[i]["ID_INGREDIENTE"]);
                            cantidadComponente = Convert.ToDouble(dt2.Rows[i]["CANTIDAD"]);
                            P.idIngrediente = idComponente;
                            P.Cantidad = cantidadComponente * cantidadOrden;
                            string msj = P.SumarExistencia();
                            if(msj != "1")
                            {
                                mensaje += NombreComponente + " no pudo ser sumado a existencia actual" + "\n";
                            }
                        }
                    }
                }
            }
            if(mensaje != "")
            {
                MessageBox.Show(mensaje, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void desde_dtp_ValueChanged(object sender, EventArgs e)
        {
            dtgHistorial();
        }

        private void cliente_txt_TextChanged(object sender, EventArgs e)
        {
            dtgHistorial();
        }
    }

    
}
