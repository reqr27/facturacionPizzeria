using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SistemaFacturacion.Classes;

namespace SistemaFacturacion.Forms
{
    public partial class ReportesForm : Form
    {
        Productos P = new Productos();
        public string rep = Program.ReporteMetodo;
        
        public ReportesForm()
        {
            InitializeComponent();
        }
        public LocalReport lc = new LocalReport();
        private void ReportesForm_Load(object sender, EventArgs e)
        {
            desde_dtp.Value = DateTime.Now.AddMonths(-1);
            hasta_dtp.Value = DateTime.Now;
            LlenarCbProducto();
            LlenarTxtProveedor();
            if (rep == "ExistenciaActual")
            {
                ExistenciaReporte();
                filtros_panel.Visible = false;
                
                this.Text = "Reporte - Existencia Productos";
            }
            else if(rep == "FacturaCliente")
            {
                FacturaCliente();
                filtros_panel.Visible = false;
                
                this.Text = "Factura Cliente";
            }
            else if(rep == "ReimprimirFacturaCliente")
            {
                ReimprimirFacturaCliente();
                filtros_panel.Visible = false;

                this.Text = "Factura Cliente";
            }

            else if (rep == "Reporte Entrada")
            {
               this.Text = "Reporte - Entrada Productos";
            }

            else if (rep == "Reporte Salida")
            {
                this.Text = "Reporte - Salida Productos";
                proveedor_txt.Enabled = false;
            }

            else if (rep == "Reporte Ventas")
            {
                this.Text = "Reporte - Ventas";
                proveedor_txt.Enabled = false;
            }

            else if (rep == "Cuadre Caja")
            {
                this.Text = "Cuadre Caja";
                filtros_panel.Visible = false;
                this.WindowState = FormWindowState.Maximized;
                CuadreCaja();
            }


        }

        public void ExistenciaReporte()
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteExistencia.rdlc";
            facturacionDataSet ds = new facturacionDataSet();
            facturacionDataSetTableAdapters.reporteExistenciaTableAdapter rds = new facturacionDataSetTableAdapters.reporteExistenciaTableAdapter();
            rds.Fill(ds.reporteExistencia);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporteExistencia"];
            reportViewer1.LocalReport.DataSources.Clear();
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void FacturaCliente()
        {
            ReportParameter[] parametros = new ReportParameter[1];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            //lc.ReportPath = "Reportes\\FacturaCliente.rdlc";
            lc.ReportPath = "Reportes\\FacturaCliente.rdlc";
            facturacionDataSet ds = new facturacionDataSet();
            facturacionDataSetTableAdapters.facturaClienteTableAdapter rds = new facturacionDataSetTableAdapters.facturaClienteTableAdapter();
            facturacionDataSetTableAdapters.obtenerFacturaTableAdapter rds1 = new facturacionDataSetTableAdapters.obtenerFacturaTableAdapter();
            rds.Fill(ds.facturaCliente, Program.GfacturaId);  //llenar reporte
            rds1.Fill(ds.obtenerFactura, Program.GfacturaId);
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["facturaCliente"];
            parametros[0] = new ReportParameter("RptCajero", Program.GnombreUsuario);
            ReportDataSource rd1 = new ReportDataSource();
            rd1.Name = "DataSet2";
            rd1.Value = ds.Tables["obtenerFactura"];

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            lc.DataSources.Add(rd1);

            AutoPrintCls atp = new AutoPrintCls(lc);
            atp.Print();
            //this.reportViewer1.RefreshReport();
            //lc.PrintToPrinter();
            this.Close();
        }

        public void ReimprimirFacturaCliente()
        {
            ReportParameter[] parametros = new ReportParameter[1];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            //lc.ReportPath = "Reportes\\FacturaCliente.rdlc";
            lc.ReportPath = "Reportes\\FacturaCliente.rdlc";
            facturacionDataSet ds = new facturacionDataSet();
            facturacionDataSetTableAdapters.facturaClienteTableAdapter rds = new facturacionDataSetTableAdapters.facturaClienteTableAdapter();
            facturacionDataSetTableAdapters.obtenerFacturaTableAdapter rds1 = new facturacionDataSetTableAdapters.obtenerFacturaTableAdapter();
            rds.Fill(ds.facturaCliente, Program.GfacturaId);  //llenar reporte
            rds1.Fill(ds.obtenerFactura, Program.GfacturaId);
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["facturaCliente"];
            parametros[0] = new ReportParameter("RptCajero", Program.GnombreUsuario);
            ReportDataSource rd1 = new ReportDataSource();
            rd1.Name = "DataSet2";
            rd1.Value = ds.Tables["obtenerFactura"];

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            lc.DataSources.Add(rd1);
            this.reportViewer1.RefreshReport();
           
        }

        public void EntradaReporte()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteEntradaProductos.rdlc";
            facturacionDataSet ds = new facturacionDataSet();
            facturacionDataSetTableAdapters.reporteEntradaProductosTableAdapter rds = new facturacionDataSetTableAdapters.reporteEntradaProductosTableAdapter();
            rds.Fill(ds.reporteEntradaProductos, desde_dtp.Value, hasta_dtp.Value, proveedor_txt.Text, Convert.ToInt32(producto_cb.SelectedValue));  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporteEntradaProductos"];
            string proveedor = proveedor_txt.Text;
            if (proveedor_txt.Text == "")
            {
                proveedor = "Todos";
            }
            string producto = producto_cb.Text;
            if (producto_cb.Text == "")
            {
                producto = "Todos";
            }
            parametros[0] = new ReportParameter("rptDesde", desde_dtp.Value.ToString("dd/MM/yyyy"));
            parametros[1] = new ReportParameter("rptHasta", hasta_dtp.Value.ToString("dd/MM/yyyy"));
            parametros[2] = new ReportParameter("rptProveedor",proveedor);
            parametros[3] = new ReportParameter("rptProducto", producto);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void SalidaReporte()
        {
            ReportParameter[] parametros = new ReportParameter[4];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteSalidaProductos.rdlc";
            facturacionDataSet ds = new facturacionDataSet();
            facturacionDataSetTableAdapters.reporteSalidaProductosTableAdapter rds =new facturacionDataSetTableAdapters.reporteSalidaProductosTableAdapter();
            rds.Fill(ds.reporteSalidaProductos, desde_dtp.Value, hasta_dtp.Value, proveedor_txt.Text, Convert.ToInt32(producto_cb.SelectedValue));  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporteSalidaProductos"];
            string proveedor = proveedor_txt.Text;
            if (proveedor_txt.Text == "")
            {
                proveedor = "Todos";
            }
            string producto = producto_cb.Text;
            if (producto_cb.Text == "")
            {
                producto = "Todos";
            }
            parametros[0] = new ReportParameter("rptDesde", desde_dtp.Value.ToString("dd/MM/yyyy"));
            parametros[1] = new ReportParameter("rptHasta", hasta_dtp.Value.ToString("dd/MM/yyyy"));
            parametros[2] = new ReportParameter("rptProveedor", proveedor);
            parametros[3] = new ReportParameter("rptProducto", producto);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void VentasReporte()
        {
            ReportParameter[] parametros = new ReportParameter[3];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\ReporteVentas.rdlc";
            facturacionDataSet ds = new facturacionDataSet();
            facturacionDataSetTableAdapters.reporteVentasTableAdapter rds = new facturacionDataSetTableAdapters.reporteVentasTableAdapter();
            rds.Fill(ds.reporteVentas, desde_dtp.Value, hasta_dtp.Value, Convert.ToInt32(producto_cb.SelectedValue));  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["reporteVentas"];
            
            string producto = producto_cb.Text;
            if (producto_cb.Text == "")
            {
                producto = "Todos";
            }
            parametros[0] = new ReportParameter("rptDesde", desde_dtp.Value.ToString("dd/MM/yyyy"));
            parametros[1] = new ReportParameter("rptHasta", hasta_dtp.Value.ToString("dd/MM/yyyy"));
            parametros[2] = new ReportParameter("rptProducto", producto);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        public void CuadreCaja()
        {
            ReportParameter[] parametros = new ReportParameter[2];
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            lc = reportViewer1.LocalReport;
            lc.ReportPath = "Reportes\\CuadreCaja.rdlc";
            facturacionDataSet ds = new facturacionDataSet();
            facturacionDataSetTableAdapters.cuadreDiarioTableAdapter rds = new facturacionDataSetTableAdapters.cuadreDiarioTableAdapter();
            rds.Fill(ds.cuadreDiario,DateTime.Now, Program.GidUsuario);  //llenar reporte
            ReportDataSource rd = new ReportDataSource();
            rd.Name = "DataSet1";
            rd.Value = ds.Tables["cuadreDiario"];

            parametros[0] = new ReportParameter("rptFecha", DateTime.Now.ToString("dd/MM/yyyy"));
            parametros[1] = new ReportParameter("rptCajero", Program.GnombreUsuario);
           
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.SetParameters(parametros);
            lc.DataSources.Add(rd);
            this.reportViewer1.RefreshReport();


        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            if (rep == "Reporte Entrada")
            {
                EntradaReporte();
                
            }

            if (rep == "Reporte Salida")
            {
                SalidaReporte();

            }

            if (rep == "Reporte Ventas")
            {
                VentasReporte();

            }
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
        public void LlenarCbProducto()
        {
            producto_cb.DataSource = null;
            DataTable dt = new DataTable();

            if (rep == "Reporte Ventas")
            {
                dt = P.ObtenerProductosTerminados();
                producto_cb.DataSource = dt;
                producto_cb.DisplayMember = "PRODUCTO";
                producto_cb.ValueMember = "ID";
                producto_cb.SelectedIndex = -1;
            }
            else
            {
                dt = P.ObtenerProductosNoTerminados();
                producto_cb.DataSource = dt;
                producto_cb.DisplayMember = "PRODUCTO";
                producto_cb.ValueMember = "ID";
                producto_cb.SelectedIndex = -1;
            }
            
           
        }

        private void limpiaFiltros_Click(object sender, EventArgs e)
        {
            producto_cb.SelectedIndex = -1;
            proveedor_txt.Text = "";
        }
    }
}
