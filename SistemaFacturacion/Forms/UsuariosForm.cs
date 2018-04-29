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
    public partial class UsuariosForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        Usuarios U = new Usuarios();
        public bool Evento = false;
        public int idUsuario;
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            
            LLenarDtgUsuarios();
        }
        public void LLenarDtgUsuarios()
        {
            usuarios_dtg.DataSource = null;
            U.Filtro = activos_radiobtn.Checked;
            DataTable dt = new DataTable();
            dt = U.ObtenerUsuarios();
            usuarios_dtg.DataSource = dt;
            //usuarios_dtg.Columns[4].Visible = false;
            //usuarios_dtg.Columns[5].Visible = false;
            //usuarios_dtg.Columns[6].Visible = false;
            //usuarios_dtg.Columns[7].Visible = false;
            //usuarios_dtg.Columns[8].Visible = false;
            //usuarios_dtg.Columns[9].Visible = false;
            //usuarios_dtg.Columns[10].Visible = false;
            //usuarios_dtg.Columns[11].Visible = false;
            //usuarios_dtg.Columns[12].Visible = false;
            //usuarios_dtg.Columns[13].Visible = false;
            //usuarios_dtg.Columns[14].Visible = false;
            usuarios_dtg.Columns[15].Visible = false;
            usuarios_dtg.Columns[16].Visible = false;





        }

        private void activos_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            LLenarDtgUsuarios();
        }

        private void inactivo_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            LLenarDtgUsuarios();
        }

        public string ValidarInsertarUsuario()
        {
            string msj = "OK";
            if (nombre_txt.Text.Trim() == "")
            {
                msj = "Campo Nombre y Apellido es necesario";
            }
            else if (usuario_txt.Text.Trim() == "")
            {
                msj = "Campo Usuario es necesario";
            }

            else if (clave_txt.Text.Trim() == "")
            {
                msj = "Campo Clave es necesario";
            }

            else if (clave_txt.Text.Trim() != confirmarClave_txt.Text.Trim()) 
            {
                msj = "Campo Claves no coinciden";
            }
            else if (tipoUsuario_txt.Text.Trim() == "")
            {
                msj = "Campo Tipo Usuario es necesario";
            }
            else
            {
                msj = "OK";
            }



            return msj;
        }

        private void agregarEditarUsuario_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string msj = ValidarInsertarUsuario();
                if(msj == "OK")
                {
                    if (!Evento)
                    {
                        InsertarUsuario();
                    }
                    else
                    {
                        ActualizarUsuario();
                    }
                    
                }
                else
                {
                    MessageBox.Show(msj, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertarUsuario()
        {
            string msj = "";
            U.Estado = estado_chbx.Checked;
            U.Usuario = usuario_txt.Text;
            U.TipoUsuario = tipoUsuario_txt.Text;
            U.Nombre = nombre_txt.Text;
            U.Clave = clave_txt.Text;
            U.CrearUsuario = crearUsuario_chbx.Checked;
            U.CrearProducto = crearProductos_chbx.Checked;
            U.CrearTipoProducto = crearTipoProducto_chbx.Checked;
            U.CrearTipoUnidad = crearUnidad_chbx.Checked;
            U.Facturacion = facturacion_chbx.Checked;
            U.HistorialFacturas = historialFacturas_chbx.Checked;
            U.EntradaProductos = Entrada_chbx.Checked;
            U.SalidaProductos = salidaProductos_chbx.Checked;
            U.RepExistencia = repExistencia_chbx.Checked;
            U.RepCuadre = repCuadre_chbx.Checked;
            U.RepVentas = repVentas_chbx.Checked;
            U.ComponentesProductos = ingredientes_chbx.Checked;
            U.ReporteEntrada = reporteEntrada_chbx.Checked;
            U.ReporteSalida = reporteSalida_chbx.Checked;
            msj = U.Registrar();
            if(msj == "1")
            {
                MessageBox.Show("Usuario Agregado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LLenarDtgUsuarios();
                ResetearCampos();
            }
            else
            {
                MessageBox.Show("Usuario no pudo ser Agregado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void ActualizarUsuario()
        {
            string msj = "";
            U.idUsuario = idUsuario;
            U.Estado = estado_chbx.Checked;
            U.Usuario = usuario_txt.Text;
            U.TipoUsuario = tipoUsuario_txt.Text;
            U.Nombre = nombre_txt.Text;
            U.Clave = clave_txt.Text;
            U.CrearUsuario = crearUsuario_chbx.Checked;
            U.CrearProducto = crearProductos_chbx.Checked;
            U.CrearTipoProducto = crearTipoProducto_chbx.Checked;
            U.CrearTipoUnidad = crearUnidad_chbx.Checked;
            U.Facturacion = facturacion_chbx.Checked;
            U.HistorialFacturas = historialFacturas_chbx.Checked;
            U.EntradaProductos = Entrada_chbx.Checked;
            U.SalidaProductos = salidaProductos_chbx.Checked;
            U.RepExistencia = repExistencia_chbx.Checked;
            U.RepCuadre = repCuadre_chbx.Checked;
            U.RepVentas = repVentas_chbx.Checked;
            U.ComponentesProductos = ingredientes_chbx.Checked;
            U.ReporteEntrada = reporteEntrada_chbx.Checked;
            U.ReporteSalida = reporteSalida_chbx.Checked;
            msj = U.Actualizar();
            if (msj == "1")
            {
                MessageBox.Show("Usuario Actualizado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LLenarDtgUsuarios();
                ResetearCampos();
            }
            else
            {
                MessageBox.Show("Usuario no pudo ser Actualizado!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void ResetearCampos()
        {
            nombre_txt.Text = "";
            usuario_txt.Text = "";
            clave_txt.Text = "";
            confirmarClave_txt.Text = "";
            tipoUsuario_txt.Text = "";
            estado_chbx.Checked = true;
            crearTipoProducto_chbx.Checked = false;
            crearProductos_chbx.Checked = false;
            crearUnidad_chbx.Checked = false;
            crearUsuario_chbx.Checked = false;
            Entrada_chbx.Checked = false;
            facturacion_chbx.Checked = false;
            historialFacturas_chbx.Checked = false;
            repCuadre_chbx.Checked = false;
            repExistencia_chbx.Checked = false;
            repVentas_chbx.Checked = false;
            salidaProductos_chbx.Checked = false;
            cancelar_btn.Enabled = false;
            ingredientes_chbx.Checked = false;
            reporteEntrada_chbx.Checked = false;
            reporteSalida_chbx.Checked = false;
            agregarEditarUsuario_btn.Text = "Registrar";
            Evento = false;
        }

        private void usuarios_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento = true;
            idUsuario = Convert.ToInt32(usuarios_dtg.CurrentRow.Cells[0].Value);
            usuario_txt.Text =  usuarios_dtg.CurrentRow.Cells[1].Value.ToString();
            tipoUsuario_txt.Text = usuarios_dtg.CurrentRow.Cells[2].Value.ToString();
            nombre_txt.Text = usuarios_dtg.CurrentRow.Cells[3].Value.ToString();
            crearUsuario_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[4].Value);
            crearProductos_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[5].Value);
            crearTipoProducto_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[6].Value);
            crearUnidad_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[7].Value);
            facturacion_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[8].Value);
            historialFacturas_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[9].Value);
            Entrada_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[10].Value);
            salidaProductos_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[11].Value);
            repExistencia_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[12].Value);
            repCuadre_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[13].Value);
            repVentas_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[14].Value);
            clave_txt.Text = usuarios_dtg.CurrentRow.Cells[15].Value.ToString();
            confirmarClave_txt.Text = usuarios_dtg.CurrentRow.Cells[15].Value.ToString();
            estado_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[16].Value);
            ingredientes_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[17].Value);
            reporteEntrada_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[18].Value);
            reporteSalida_chbx.Checked = Convert.ToBoolean(usuarios_dtg.CurrentRow.Cells[19].Value);

            cancelar_btn.Enabled = true;
            agregarEditarUsuario_btn.Text = "Actualizar";
            

        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            ResetearCampos();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuariosForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
    }
}
