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
using System.Runtime.InteropServices;
using Microsoft.PointOfService;


namespace SistemaFacturacion.Forms
{
    public partial class FacturarForm : Form
    {
        CashDrawer myCashDrawer;
        PosExplorer explorer;

        Productos P = new Productos();
        Facturas F = new Facturas();
        double cantidadOrden;
        public FacturarForm()

        {
            InitializeComponent();
        }

        private void FacturarForm_Load(object sender, EventArgs e)
        {
            //explorer = new PosExplorer();
            //DeviceInfo ObjDevicesInfo = explorer.GetDevice("CashDrawer");
            //myCashDrawer = (CashDrawer)explorer.CreateInstance(ObjDevicesInfo);

            numeroFactura_txt.Text = (Convert.ToInt32(F.NumeroFacturaSiguiente())).ToString("0000000");
            cant_numtxt.Minimum = 1;
            cant_numtxt.Maximum = 100;
            //CrearDatagrid();
            CalcularTotalOrden();
            LlenarDataGrid();
            
        }

        public void LlenarDataGrid()
        {
            productos_dtg.DataSource = null;
            DataTable dt = new DataTable();
            P.Producto = buscar_producto_txt.Text;
            dt = P.BuscarProductosTerminadosFacturar();
            
            productos_dtg.DataSource = dt;
            productos_dtg.Columns[3].DefaultCellStyle.Format = "N2";
            productos_dtg.Columns[4].Visible = false;
            productos_dtg.Columns[5].Visible = false;
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
           
            //if (this.orden_dtg.IsCurrentCellDirty)
            //{
            //    // This fires the cell value changed handler below
            //    orden_dtg.CommitEdit(DataGridViewDataErrorContexts.Commit);
            //}
        }

        private void orden_dtg_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            //if(e.ColumnIndex == 0)
            //{
            //    DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)orden_dtg.Rows[e.RowIndex].Cells[0];
            //    if (cb.Value != null)
            //    {
            //        fillDatagrid();
            //        CalcularTotalOrden();
            //        orden_dtg.Invalidate();
            //    }
            //}
            
            
                
        }

        public void CalcularTotalOrden()
        {
            double total = 0;
            double porcentage = 0;
            
            if(descuento_txt.Text.Trim() != "")
            {
                porcentage = (Convert.ToDouble(descuento_txt.Text) / 100);
            }
            if (orden_dtg.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in orden_dtg.Rows)
                {
                    total += Convert.ToDouble(row.Cells[3].Value);

                }
                total_lbl.Text = total.ToString("N2");
                

                totalPagar_lbl.Text = (total - (total * porcentage)).ToString("N2");
                totalPagar2_lbl.Text = totalPagar_lbl.Text;
                efectivo_txt.Text = totalPagar_lbl.Text;
                devuelta_lbl.Text = (Convert.ToDouble(totalPagar_lbl.Text) - Convert.ToDouble(efectivo_txt.Text)).ToString("N2");

            }
            else
            {
                total_lbl.Text = "0.00";
                totalPagar2_lbl.Text = "0.00";
                efectivo_txt.Text = "0.00";
                devuelta_lbl.Text = "0.00";
                totalPagar_lbl.Text = "0.00";
                descuento_lbl.Text = "0.00";
            }

            double descuento_dinero = Convert.ToDouble(total_lbl.Text) * Convert.ToDouble(descuento_txt.Text) / 100;
            descuento_lbl.Text = descuento_dinero.ToString("N2");
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
            bool descuento = double.TryParse(descuento_txt.Text, out n);
            string msj = "OK";

            if (cliente_txt.Text.Trim() == "")
            {
                msj = "Nombre del Cliente es Necesario";

            }
            else if (orden_dtg.Rows.Count == 0)
            {
                msj = "No hay productos para facturar";
            }
            else if (!efectivo)
            {
                msj = "Campo Efectivo debe ser numérico";
            }

            else if (!descuento)
            {
                msj = "Campo Descuentp debe ser numérico";
            }

            else if (Convert.ToDouble(efectivo_txt.Text) - Convert.ToDouble(totalPagar_lbl.Text) < 0)
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
            F.Descuento = Convert.ToDouble(descuento_txt.Text);
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
            for(int i = 0; i < orden_dtg.Rows.Count;i++ )
            {
                F.idProducto = Convert.ToInt32(orden_dtg.Rows[i].Cells[5].Value);
                F.Cantidad = Convert.ToDouble(orden_dtg.Rows[i].Cells[1].Value);
                F.idTipoUnidad = Convert.ToInt32(orden_dtg.Rows[i].Cells[6].Value);
                F.Precio = Convert.ToDouble(orden_dtg.Rows[i].Cells[2].Value);
                F.SubTotal = Convert.ToDouble(orden_dtg.Rows[i].Cells[3].Value);
                msj = F.RegistrarFacturaDetalles();
                if(msj != "0" )
                {
                    msj = "OK";
                    Program.GtipoProductoId = Convert.ToInt32(orden_dtg.Rows[i].Cells[7].Value);
                    string restarMsj = RestarInventario(Convert.ToInt32(orden_dtg.Rows[i].Cells[5].Value) , Convert.ToDouble(orden_dtg.Rows[i].Cells[1].Value));
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
                P.idProducto = Convert.ToInt32(row.Cells[5].Value);
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
            
           
            if (orden_dtg.CurrentRow.Cells[7].Value.ToString() == "3")
            {
                DataTable dt = new DataTable();
                string bebida = orden_dtg.CurrentRow.Cells[0].Value.ToString();
                foreach (DataGridViewRow row in orden_dtg.Rows)
                {
                    if (row.Cells[0].Value.ToString() == bebida)
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
                    devuelta_lbl.Text = (efectivo - Convert.ToDouble(totalPagar_lbl.Text)).ToString("N2");
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

            cantidadProd = Convert.ToDouble(cant_numtxt.Value);
            P.idProducto = Convert.ToInt32(productos_dtg.CurrentRow.Cells[0].Value);

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
            double agregado = Convert.ToDouble(cant_numtxt.Value);
            if (productos_dtg.CurrentRow.Cells[5].Value.ToString() == "3")
            {
                DataTable dt = new DataTable();
                

                P.idProducto = Convert.ToInt32(productos_dtg.CurrentRow.Cells[0].Value);
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

        private void descuento_txt_TextChanged(object sender, EventArgs e)
        {
            if(descuento_txt.Text.Length == 0)
            {
                descuento_txt.Text = "0";
                descuento_txt.SelectionStart = descuento_txt.Text.Length + 1;
            }
            CalcularTotalOrden();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buscar_producto_txt_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }


        public void AgregarItemOrden()
        {
            orden_dtg.Rows.Add();

            int row = orden_dtg.Rows.Count;
            orden_dtg.Rows[row - 1].Cells[5].Value = productos_dtg.CurrentRow.Cells[0].Value.ToString(); // idproducto
            orden_dtg.Rows[row - 1].Cells[0].Value = productos_dtg.CurrentRow.Cells[1].Value.ToString();// producto
            orden_dtg.Rows[row - 1].Cells[1].Value = cant_numtxt.Value; // cantidad
            orden_dtg.Rows[row - 1].Cells[2].Value = productos_dtg.CurrentRow.Cells[3].Value.ToString(); // precio unidad

            orden_dtg.Rows[row - 1].Cells[3].Value = Convert.ToDouble(productos_dtg.CurrentRow.Cells[3].Value.ToString()) * Convert.ToDouble(cant_numtxt.Value); // precio total
            orden_dtg.Rows[row - 1].Cells[6].Value = productos_dtg.CurrentRow.Cells[4].Value.ToString(); // idUnidad
            orden_dtg.Rows[row - 1].Cells[7].Value = productos_dtg.CurrentRow.Cells[5].Value.ToString(); // idTipo

            orden_dtg.Columns[1].DefaultCellStyle.Format = "N2";
            orden_dtg.Columns[2].DefaultCellStyle.Format = "N2";
            orden_dtg.Columns[3].DefaultCellStyle.Format = "N2";

            CalcularTotalOrden();
        }

        private void orden_dtg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == orden_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == orden_dtg.Columns["dataGridViewDeleteButton"].Index)
            {
                var image = Properties.Resources.eliminar; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            bool repeated = false;
            foreach (DataGridViewRow row in orden_dtg.Rows)
            {
                int idProducto = Convert.ToInt32(productos_dtg.CurrentRow.Cells[0].Value);
                if(idProducto == Convert.ToInt32(row.Cells[5].Value))
                {
                    repeated = true;
                }
            }
            if (!repeated)
            {
                string msj = RevisarExistenciaComponentesOrden();
                string msj1 = RevisarExistenciaBebidasOrden();
                if (msj == "" && msj1 == "")
                {
                    AgregarItemOrden();
                }
                else
                {
                    MessageBox.Show(msj + msj1, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


            }
            else
            {
                MessageBox.Show("Ya se existe este item en la orden actual", "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

               
        }

        private void orden_dtg_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == orden_dtg.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == orden_dtg.Columns["dataGridViewDeleteButton"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                orden_dtg.Rows.RemoveAt(e.RowIndex);
                CalcularTotalOrden();
            }
        }

        private void openCashDrawer()
        {
            //Metodo 1
            byte[] codeOpenCashDrawer = new byte[] { 27, 112, 48, 55, 121 };
            IntPtr pUnmanagedBytes = new IntPtr(0);
            pUnmanagedBytes = Marshal.AllocCoTaskMem(5);
            Marshal.Copy(codeOpenCashDrawer, 0, pUnmanagedBytes, 5);
            RawPrinterHelper.SendBytesToPrinter("EPSON TM-T88V Receipt Invoice", pUnmanagedBytes, 5);
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            

        }

        public void openCashDrawer2()
        {
            myCashDrawer.Open();
            myCashDrawer.Claim(1000);
            myCashDrawer.DeviceEnabled = true;
            myCashDrawer.OpenDrawer();
            myCashDrawer.DeviceEnabled = false;
            myCashDrawer.Release();
            myCashDrawer.Close();
            //myCashDrawer.CapStatus
        }

        private void productos_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            agregar_btn_Click(sender, e);
        }
    }

}
