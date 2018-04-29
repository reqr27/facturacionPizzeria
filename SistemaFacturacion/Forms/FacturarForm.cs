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
    public partial class FacturarForm : Form
    {
        Productos P = new Productos();
        Facturas F = new Facturas();
        double cantidadOrden;
        public FacturarForm()

        {
            InitializeComponent();
        }

        private void FacturarForm_Load(object sender, EventArgs e)
        {
            numeroFactura_txt.Text = (Convert.ToInt32(F.NumeroFacturaSiguiente())).ToString("0000000");
            
            CrearDatagrid();
            CalcularTotalOrden();
        }

        public void CrearDatagrid()
        {
            DataTable dt = new DataTable();
            dt = P.ObtenerProductosTerminados();
            

            // Adding  Producto

            DataGridViewComboBoxColumn ColumnProducto = new DataGridViewComboBoxColumn();

            ColumnProducto.DataPropertyName = "Producto";
            ColumnProducto.Name = "Producto";

            ColumnProducto.HeaderText = "Producto";
            //ColumnProducto.AutoSizeMode= DataGridViewAutoSizeColumnMode.AllCells;
            ColumnProducto.Width = 250;

            ColumnProducto.DataSource = dt;
            ColumnProducto.ValueMember = "PRODUCTO";
            ColumnProducto.DisplayMember = "PRODUCTO";

            orden_dtg.Columns.Add(ColumnProducto);


            //Adding  Cantidad TextBox

            DataGridViewTextBoxColumn ColumnCantidad = new DataGridViewTextBoxColumn();
            ColumnCantidad.HeaderText = "Cantidad";
            ColumnCantidad.Name = "Cantidad";
            ColumnCantidad.Width = 80;
            ColumnCantidad.DataPropertyName = "Cantidad";

            orden_dtg.Columns.Add(ColumnCantidad);

            //Adding  Precio TextBox

            DataGridViewTextBoxColumn ColumnPrecio = new DataGridViewTextBoxColumn();
            ColumnPrecio.HeaderText = "Precio";
            ColumnPrecio.Width = 80;
            ColumnPrecio.DataPropertyName = "Precio";
            ColumnPrecio.ReadOnly = true;
            orden_dtg.Columns.Add(ColumnPrecio);

            //Adding  id TextBox

            DataGridViewTextBoxColumn ColumnidProducto = new DataGridViewTextBoxColumn();
            ColumnidProducto.HeaderText = "Id";
            ColumnidProducto.Width = 80;
            ColumnidProducto.DataPropertyName = "Id";
            ColumnidProducto.Visible = false;
            orden_dtg.Columns.Add(ColumnidProducto);

            //Adding  idUnidad TextBox

            DataGridViewTextBoxColumn ColumnidUnidad = new DataGridViewTextBoxColumn();
            ColumnidUnidad.HeaderText = "Id";
            ColumnidUnidad.Width = 80;
            ColumnidUnidad.DataPropertyName = "Id";
            ColumnidUnidad.Visible = false;
            orden_dtg.Columns.Add(ColumnidUnidad);

            //Adding  PrecioUnidad TextBox

            DataGridViewTextBoxColumn ColumnPrecioUnidad = new DataGridViewTextBoxColumn();
            ColumnPrecioUnidad.HeaderText = "PrecioUnidad";
            ColumnPrecioUnidad.Width = 80;
            ColumnPrecioUnidad.DataPropertyName = "PrecioUnidad";
            ColumnPrecioUnidad.Visible = false;
            orden_dtg.Columns.Add(ColumnPrecioUnidad);

            //Adding  idtipoProducto TextBox
            DataGridViewTextBoxColumn ColumnidTipoProducto = new DataGridViewTextBoxColumn();
            ColumnidTipoProducto.HeaderText = "idTipoProducto";
            ColumnidTipoProducto.Width = 80;
            ColumnidTipoProducto.DataPropertyName = "idTipoProducto";
            ColumnidTipoProducto.Visible = false;
            orden_dtg.Columns.Add(ColumnidTipoProducto);

           orden_dtg.CellValueChanged +=
             new DataGridViewCellEventHandler(orden_dtg_CellValueChanged);
            orden_dtg.CurrentCellDirtyStateChanged +=
                 new EventHandler(orden_dtg_CurrentCellDirtyStateChanged);


        }

        void orden_dtg_CurrentCellDirtyStateChanged(object sender,
        EventArgs e)
        {
           
            if (this.orden_dtg.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                orden_dtg.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void orden_dtg_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            if(e.ColumnIndex == 0)
            {
                DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)orden_dtg.Rows[e.RowIndex].Cells[0];
                if (cb.Value != null)
                {
                    fillDatagrid();
                    CalcularTotalOrden();
                    orden_dtg.Invalidate();
                }
            }
            
            
                
        }

        public void CalcularTotalOrden()
        {
            double total = 0;
            if (orden_dtg.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in orden_dtg.Rows)
                {
                    total += Convert.ToDouble(row.Cells[2].Value);

                }
                total_lbl.Text = total.ToString("N2");
                efectivo_txt.Text = total.ToString("N2");
                devuelta_lbl.Text = "0.00";
            }
            else
            {
                total_lbl.Text = "0.00";
                efectivo_txt.Text = "0.00";
                devuelta_lbl.Text = "0.00";
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            if(orden_dtg.Rows.Count > 0)
            {
                int index = orden_dtg.CurrentCell.RowIndex;
                orden_dtg.Rows.RemoveAt(index);
                CalcularTotalOrden();
            }
            
        }

        private void crear_factura_btn_Click(object sender, EventArgs e)
        {
            crear_factura_btn.Enabled = false;
            try
            {
                string msj = ValidarFacturar();
                if (msj == "OK")
                {
                    InsertarFactura();
                }

                else
                {
                    MessageBox.Show(msj, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    crear_factura_btn.Enabled = true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public string ValidarFacturar()
        {
            double n;
            bool efectivo = double.TryParse(efectivo_txt.Text, out n);
            
            string msj = "OK";

            if (cliente_txt.Text.Trim() == "")
            {
                msj = "Nombre del Cliente es Necesario";

            }
            else if (orden_dtg.Rows.Count == 1)
            {
                msj = "No hay productos para facturar";
            }
            else if (!efectivo)
            {
                msj = "Campo Efectivo debe ser numérico";
            }

            else if (Convert.ToDouble(efectivo_txt.Text) - Convert.ToDouble(total_lbl.Text) < 0)
            {
                msj = "Efectivo debe ser mayor o igual que total a pagar";
            }
            else
            {
                msj = "OK";
            }

            return msj;
        }
        public void InsertarFactura()
        {

            string msj = "";
            string msj2 = "";
            F.Cliente = cliente_txt.Text;
            F.idUsuario = Program.GidUsuario;
            F.Total = Convert.ToDouble(total_lbl.Text);
            F.Efectivo = Convert.ToDouble(efectivo_txt.Text);
            msj = F.RegistrarFactura();
            if(msj == "1")
            {
                msj2 = InsertarFacturaDetalles();
                if(msj2 == "OK")
                {

                    orden_dtg.Rows.Clear();
                    cliente_txt.Text = "";
                    CalcularTotalOrden();
                    crear_factura_btn.Enabled = true;
                    //MessageBox.Show("Factura Creada!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numeroFactura_txt.Text = (Convert.ToInt32(F.NumeroFacturaSiguiente())).ToString("0000000");
                    Program.GfacturaId = 0;
                    Program.ReporteMetodo = "FacturaCliente";
                    ReportesForm form = new ReportesForm();
                    form.Show();
                    

                }
                else
                {
                    F.idFactura = Convert.ToInt32(msj2);
                    msj = F.EliminarRegistroFallido();
                    if(msj == "1")
                    {
                        MessageBox.Show("Factura no pudo ser Creada!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Algunos datos no fueron guardados, elimine esta factura", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    crear_factura_btn.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Factura no pudo ser Creada!", "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public string InsertarFacturaDetalles()
        {
            string msj = "";
            for(int i = 0; i < orden_dtg.Rows.Count - 1;i++ )
            {
                F.idProducto = Convert.ToInt32(orden_dtg.Rows[i].Cells[3].Value);
                F.Cantidad = Convert.ToDouble(orden_dtg.Rows[i].Cells[1].Value);
                F.idTipoUnidad = Convert.ToInt32(orden_dtg.Rows[i].Cells[4].Value);
                F.Precio = Convert.ToDouble(orden_dtg.Rows[i].Cells[5].Value);
                F.SubTotal = Convert.ToDouble(orden_dtg.Rows[i].Cells[2].Value);
                msj = F.RegistrarFacturaDetalles();
                if(msj != "0" )
                {
                    msj = "OK";
                    Program.GtipoProductoId = Convert.ToInt32(orden_dtg.Rows[i].Cells[6].Value);
                    string restarMsj = RestarInventario(Convert.ToInt32(orden_dtg.Rows[i].Cells[3].Value) , Convert.ToDouble(orden_dtg.Rows[i].Cells[1].Value));
                    if (restarMsj != "1")
                    {
                        MessageBox.Show(restarMsj, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    return msj;
                }

            }
            return msj;
        
        }

        public string RevisarExistenciaIngredientesProductoAgregado()
        {
            List<int> idIngredienteArray = new List<int>();
            List<double> cantidadArray = new List<double>();
            string msj = "";
            string mensaje = "";
            int idIngrediente = 0;
            double cantidadProd;
            int index;
            DataTable dt = new DataTable();
            foreach (DataGridViewRow row in orden_dtg.Rows)
            {
                cantidadProd = Convert.ToDouble(row.Cells[1].Value);
                P.idProducto = Convert.ToInt32(row.Cells[3].Value);
                dt = P.ObtenerComponentesProducto();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    idIngrediente = Convert.ToInt32(dt.Rows[i]["ID_INGREDIENTE"]);
                    if (idIngredienteArray.Contains(idIngrediente))
                    {
                        index = idIngredienteArray.IndexOf(idIngrediente);
                        cantidadArray[index] += (Convert.ToDouble(dt.Rows[i]["CANTIDAD"]) * cantidadProd);
                    }else
                    {
                        idIngredienteArray.Add(idIngrediente);
                        cantidadArray.Add(Convert.ToInt32(dt.Rows[i]["CANTIDAD"]) * cantidadProd);
                    }

                }


            }
            string nombre = "";

            for (int i = 0; i <idIngredienteArray.Count; i++)
            {
                idIngrediente = idIngredienteArray[i];
                cantidadProd = cantidadArray[i];

                P.idIngrediente = idIngrediente;
                P.CantidadEntradaSalida = cantidadProd;
                msj = P.ValidarExistenciaIngrediente();
                if (msj != "1")
                {
                    P.idIngrediente = idIngrediente;
                    nombre = P.ObtenerNombreIngrediente();
                    mensaje += "No existe en inventario suficiente ingrediente: " + nombre + "\n";
                }

            }

            return mensaje;
            
        }

        public string RevisarExistenciaBebidas()
        {
            string msj = "";
            int agregado = 0;
            
            string Prod;
            if (orden_dtg.CurrentRow.Cells[5].Value.ToString() == "3")
            {
                DataTable dt = new DataTable();
                string bebida = orden_dtg.CurrentRow.Cells[1].Value.ToString();
                foreach (DataGridViewRow row in orden_dtg.Rows)
                {
                    if (row.Cells[1].Value.ToString() == bebida)
                    {
                        agregado = Convert.ToInt32(row.Cells[1].Value);
                        break;
                    }
                }

                P.idProducto = Convert.ToInt32(orden_dtg.CurrentRow.Cells[0].Value);
                dt = P.ObtenerExistenciaBebidas();
                if (dt.Rows.Count > 0)
                {
                    int existencia = Convert.ToInt32(dt.Rows[0]["EXISTENCIA"]);
                    string nombre = dt.Rows[0]["NOMBRE"].ToString(); ;
                    int agregar = Convert.ToInt32("0");
                    if (agregar + agregado > existencia)
                    {
                        msj += "No existe en inventario suficiente Bebida: " + nombre + "\n";
                    }
                }

            }



            return msj;
        }
        public string RestarInventario(int idProducto, double cant)
        {
            string msj ="";
            string mensaje = "";
            int idIngrediente = 0;
            P.idProducto = idProducto;
            DataTable dt = new DataTable();
            dt = P.ObtenerComponentesProducto();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    idIngrediente = Convert.ToInt32(dt.Rows[i]["ID_INGREDIENTE"]);
                    P.idProducto = idProducto;
                    P.idIngrediente = idIngrediente;
                    P.CantidadEntradaSalida = cant;
                    msj = P.RestarExistenciaComponente();
                    if (msj == "2")
                    {
                        mensaje += "Ingrediente : " + dt.Rows[i]["INGREDIENTE"] + " está por debajo de la existencia minima configurada \n";
                    }
                    else if (msj == "1")
                    {
                        mensaje = "1";
                    }

                    else
                    {
                        mensaje += "Error, no se pudo descontar del inventario Ingrediente: " + dt.Rows[i]["INGREDIENTE"] + "\n";
                    }
                }
                if (dt.Rows.Count <= 0)
                {
                    mensaje = "1";
                }
                return mensaje;
            }

            else
            {
              
                if(Program.GtipoProductoId == 3)
                {
                    P.idProducto = idProducto;
                    P.CantidadEntradaSalida = cant;
                    msj = P.RestarExistenciaBebidas();
                    if (msj == "2")
                    {
                        mensaje += "Bebida : " + " " + " está por debajo de la existencia minima configurada \n";
                    }
                    else if (msj == "1")
                    {
                        mensaje = "1";
                    }

                    else
                    {
                        mensaje += "Error, no se pudo descontar del inventario Bebida: " + "" + "\n";
                    }
                    return mensaje;
                }
                
                return "1";
            }
            
        }

        public double obtenerCantidadTotalProductoIndividual()
        {
            double cant = Convert.ToInt16("0");
            foreach (DataGridViewRow row in orden_dtg.Rows)
            {
                
                if (Convert.ToInt32(row.Cells[3].Value) == Convert.ToInt32(orden_dtg.CurrentRow.Cells[0].Value))
                {
                   cant += Convert.ToDouble(row.Cells[1].Value);
                }
              
            }
            return cant;
        }

        private void efectivo_txt_TextChanged(object sender, EventArgs e)
        {

            if (efectivo_txt.Text.Trim() != "")
            {
                
                try
                {
                    double efectivo = Convert.ToDouble(efectivo_txt.Text);
                    //efectivo_txt.Text = efectivo.ToString("N2");
                    devuelta_lbl.Text = (efectivo - Convert.ToDouble(total_lbl.Text)).ToString("N2");
                }
                catch (Exception ex)
                {
                    
                }
            }
            else
            {
                devuelta_lbl.Text = "0.00";
            }
        }

        private void orden_dtg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (orden_dtg.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                try
                {
                    double cant2 = Convert.ToDouble(orden_dtg.CurrentRow.Cells[1].Value);
                    if (cant2 == 0)
                    {
                        orden_dtg.CurrentRow.Cells[1].Value = cantidadOrden;
                    }
                    else
                    {
                        string msj = RevisarExistenciaComponentesOrden();
                        string msj1 = RevisarExistenciaBebidasOrden();
                        if (msj == "" && msj1 == "")
                        {
                            cant2 = Convert.ToDouble(orden_dtg.CurrentRow.Cells[1].Value);
                            orden_dtg.CurrentRow.Cells[2].Value = (Convert.ToDouble(orden_dtg.CurrentRow.Cells[5].Value) * cant2).ToString("N2");
                            CalcularTotalOrden();
                        }
                        else
                        {
                            orden_dtg.CurrentRow.Cells[1].Value = cantidadOrden.ToString("N2");
                            MessageBox.Show(msj + "\n" + msj1, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }


                }
                catch
                {
                    orden_dtg.CurrentRow.Cells[1].Value = cantidadOrden.ToString("N2");
                }

            }
           
        }

        private void orden_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            cantidadOrden = Convert.ToDouble(orden_dtg.CurrentRow.Cells[1].Value);
        }

        public string RevisarExistenciaComponentesOrden()
        {
            List<int> idIngredienteArray = new List<int>();
            List<double> cantidadArray = new List<double>();
            string msj = "";
            string mensaje = "";
            int idIngrediente = 0;
            double cantidadProd;
            int index;
            DataTable dt = new DataTable();
            foreach (DataGridViewRow row in orden_dtg.Rows)
            {
                cantidadProd = Convert.ToDouble(row.Cells[1].Value);
                P.idProducto = Convert.ToInt32(row.Cells[3].Value);
                dt = P.ObtenerComponentesProducto();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    idIngrediente = Convert.ToInt32(dt.Rows[i]["ID_INGREDIENTE"]);
                    if (idIngredienteArray.Contains(idIngrediente))
                    {
                        index = idIngredienteArray.IndexOf(idIngrediente);
                        cantidadArray[index] += (Convert.ToDouble(dt.Rows[i]["CANTIDAD"]) * cantidadProd);
                    }
                    else
                    {
                        idIngredienteArray.Add(idIngrediente);
                        cantidadArray.Add(Convert.ToInt32(dt.Rows[i]["CANTIDAD"]) * cantidadProd);
                    }

                }
            }

            string nombre = "";

            for (int i = 0; i < idIngredienteArray.Count; i++)
            {
                idIngrediente = idIngredienteArray[i];
                cantidadProd = cantidadArray[i];

                P.idIngrediente = idIngrediente;
                P.CantidadEntradaSalida = cantidadProd;
                msj = P.ValidarExistenciaIngrediente();
                if (msj != "1")
                {
                    P.idIngrediente = idIngrediente;
                    nombre = P.ObtenerNombreIngrediente();
                    mensaje += "No existe en inventario suficiente ingrediente: " + nombre + "\n";
                }

            }

            return mensaje;


        }

        public string RevisarExistenciaBebidasOrden()
        {
            string msj = "";
            double agregado = 0;
            if (orden_dtg.CurrentRow.Cells[6].Value.ToString() == "3")
            {
                DataTable dt = new DataTable();
                string bebida = orden_dtg.CurrentRow.Cells[0].Value.ToString();
                foreach (DataGridViewRow row in orden_dtg.Rows)
                {
                    if (row.Cells[0].Value.ToString() == bebida)
                    {
                        agregado = Convert.ToDouble(row.Cells[1].Value);
                        break;
                    }
                }

                P.idProducto = Convert.ToInt32(orden_dtg.CurrentRow.Cells[3].Value);
                dt = P.ObtenerExistenciaBebidas();
                if (dt.Rows.Count > 0)
                {
                    int existencia = Convert.ToInt32(dt.Rows[0]["EXISTENCIA"]);
                    string nombre = dt.Rows[0]["NOMBRE"].ToString(); ;
                    if (agregado > existencia)
                    {
                        msj += "No existe en inventario suficiente Bebida: " + nombre + "\n";
                    }
                }

            }



            return msj;
        }

        public void fillDatagrid()
        {
            int check = 0;
            string productoSeleccionado = orden_dtg.CurrentRow.Cells[0].Value.ToString();
            for (int i = 0; i < orden_dtg.Rows.Count - 1; i++)
            
            {
                
                string productoEnOrden = (orden_dtg.Rows[i].Cells[0].Value).ToString();
                if(productoEnOrden == productoSeleccionado)
                {
                    check++;
                }
            }

            if(check <= 1)
            {
                DataTable dt = new DataTable();
                dt = P.ObtenerProductosTerminados();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string producto = (dt.Rows[i]["PRODUCTO"]).ToString();
                    if (producto == (orden_dtg.CurrentRow.Cells[0].Value).ToString())
                    {
                        orden_dtg.CurrentRow.Cells[3].Value = (dt.Rows[i]["ID"]).ToString();
                        orden_dtg.CurrentRow.Cells[4].Value = (dt.Rows[i]["IDUNIDAD"]).ToString();
                        orden_dtg.CurrentRow.Cells[5].Value = (dt.Rows[i]["PRECIO($RD)"]).ToString();
                        orden_dtg.CurrentRow.Cells[6].Value = (dt.Rows[i]["IDTIPO"]).ToString();

                        try
                        {
                            orden_dtg.CurrentRow.Cells[1].Value.ToString().Trim();

                        }
                        catch
                        {
                            if(orden_dtg.Rows.Count > 1)
                            {
                                orden_dtg.CurrentRow.Cells[1].Value = "1";
                                orden_dtg.CurrentRow.Cells[2].Value = (dt.Rows[i]["PRECIO($RD)"]).ToString();
                            }
                            else
                            {
                                orden_dtg.CurrentRow.Cells[1].Value = "";
                                orden_dtg.CurrentRow.Cells[2].Value = "";
                            }
                           
                        }
                        if(orden_dtg.Rows.Count > 1)
                        {
                            string msj = RevisarExistenciaComponentesOrden();
                            string msj1 = RevisarExistenciaBebidasOrden();
                            if (msj == "" && msj1 == "")
                            {
                                
                            }
                            else
                            {
                                int index = orden_dtg.CurrentCell.RowIndex;
                                orden_dtg.Rows.RemoveAt(index);
                                CalcularTotalOrden();
                                MessageBox.Show(msj + msj1, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        

                        break;


                    }

                }
                
            }

            else
            {
                int index = orden_dtg.CurrentCell.RowIndex;
                orden_dtg.Rows.RemoveAt(index);
                CalcularTotalOrden();
            }
            
        }

        private void orden_dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orden_dtg.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                cantidadOrden = Convert.ToDouble(orden_dtg.CurrentRow.Cells[1].Value);
            }
        }
    }

}
