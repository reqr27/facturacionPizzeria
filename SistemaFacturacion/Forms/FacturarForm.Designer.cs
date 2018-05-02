namespace SistemaFacturacion.Forms
{
    partial class FacturarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturarForm));
            this.devuelta_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.efectivo_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.numeroFactura_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.crear_factura_btn = new System.Windows.Forms.Button();
            this.cliente_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descuento_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPagar_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.buscar_producto_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productos_dtg = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cant_numtxt = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.agregar_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.totalPagar2_lbl = new System.Windows.Forms.Label();
            this.orden_dtg = new System.Windows.Forms.DataGridView();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGOUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idtipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.descuento_lbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productos_dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_numtxt)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // devuelta_lbl
            // 
            this.devuelta_lbl.AutoSize = true;
            this.devuelta_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devuelta_lbl.ForeColor = System.Drawing.Color.Blue;
            this.devuelta_lbl.Location = new System.Drawing.Point(773, 81);
            this.devuelta_lbl.Name = "devuelta_lbl";
            this.devuelta_lbl.Size = new System.Drawing.Size(38, 22);
            this.devuelta_lbl.TabIndex = 9;
            this.devuelta_lbl.Text = "dev";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(605, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Devuelta($RD): ";
            // 
            // efectivo_txt
            // 
            this.efectivo_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivo_txt.Location = new System.Drawing.Point(774, 43);
            this.efectivo_txt.Name = "efectivo_txt";
            this.efectivo_txt.Size = new System.Drawing.Size(100, 29);
            this.efectivo_txt.TabIndex = 7;
            this.efectivo_txt.TextChanged += new System.EventHandler(this.efectivo_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Efectivo($RD): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total($RD): ";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.ForeColor = System.Drawing.Color.Red;
            this.total_lbl.Location = new System.Drawing.Point(194, 18);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(47, 22);
            this.total_lbl.TabIndex = 5;
            this.total_lbl.Text = "total";
            // 
            // numeroFactura_txt
            // 
            this.numeroFactura_txt.Enabled = false;
            this.numeroFactura_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroFactura_txt.Location = new System.Drawing.Point(609, 102);
            this.numeroFactura_txt.Name = "numeroFactura_txt";
            this.numeroFactura_txt.Size = new System.Drawing.Size(79, 22);
            this.numeroFactura_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "No. Factura: ";
            // 
            // crear_factura_btn
            // 
            this.crear_factura_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear_factura_btn.Image = global::SistemaFacturacion.Properties.Resources.efectivo;
            this.crear_factura_btn.Location = new System.Drawing.Point(826, 398);
            this.crear_factura_btn.Name = "crear_factura_btn";
            this.crear_factura_btn.Size = new System.Drawing.Size(126, 86);
            this.crear_factura_btn.TabIndex = 7;
            this.crear_factura_btn.Text = "Facturar";
            this.crear_factura_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.crear_factura_btn.UseVisualStyleBackColor = true;
            this.crear_factura_btn.Click += new System.EventHandler(this.crear_factura_btn_Click);
            // 
            // cliente_txt
            // 
            this.cliente_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_txt.Location = new System.Drawing.Point(609, 130);
            this.cliente_txt.Name = "cliente_txt";
            this.cliente_txt.Size = new System.Drawing.Size(109, 22);
            this.cliente_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente/Mesa:";
            // 
            // descuento_txt
            // 
            this.descuento_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuento_txt.Location = new System.Drawing.Point(850, 102);
            this.descuento_txt.Name = "descuento_txt";
            this.descuento_txt.Size = new System.Drawing.Size(51, 22);
            this.descuento_txt.TabIndex = 11;
            this.descuento_txt.Text = "0";
            this.descuento_txt.TextChanged += new System.EventHandler(this.descuento_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(739, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descuento(%): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Pagar($RD): ";
            // 
            // totalPagar_lbl
            // 
            this.totalPagar_lbl.AutoSize = true;
            this.totalPagar_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPagar_lbl.ForeColor = System.Drawing.Color.Red;
            this.totalPagar_lbl.Location = new System.Drawing.Point(193, 84);
            this.totalPagar_lbl.Name = "totalPagar_lbl";
            this.totalPagar_lbl.Size = new System.Drawing.Size(47, 22);
            this.totalPagar_lbl.TabIndex = 13;
            this.totalPagar_lbl.Text = "total";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(968, 48);
            this.panel3.TabIndex = 93;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SistemaFacturacion.Properties.Resources.minimize__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(902, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 31;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::SistemaFacturacion.Properties.Resources.borrar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(934, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 30;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label27.Location = new System.Drawing.Point(12, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(175, 24);
            this.label27.TabIndex = 28;
            this.label27.Text = "FACTURACION";
            // 
            // buscar_producto_txt
            // 
            this.buscar_producto_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_producto_txt.Location = new System.Drawing.Point(79, 107);
            this.buscar_producto_txt.Name = "buscar_producto_txt";
            this.buscar_producto_txt.Size = new System.Drawing.Size(356, 22);
            this.buscar_producto_txt.TabIndex = 96;
            this.buscar_producto_txt.TextChanged += new System.EventHandler(this.buscar_producto_txt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 95;
            this.label8.Text = "Buscar: ";
            // 
            // productos_dtg
            // 
            this.productos_dtg.AllowUserToAddRows = false;
            this.productos_dtg.AllowUserToDeleteRows = false;
            this.productos_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productos_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productos_dtg.Location = new System.Drawing.Point(16, 166);
            this.productos_dtg.Name = "productos_dtg";
            this.productos_dtg.ReadOnly = true;
            this.productos_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productos_dtg.Size = new System.Drawing.Size(448, 214);
            this.productos_dtg.TabIndex = 94;
            this.productos_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productos_dtg_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(158, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 97;
            this.label9.Text = "PRODUCTOS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(697, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 98;
            this.label10.Text = "ORDEN";
            // 
            // cant_numtxt
            // 
            this.cant_numtxt.Location = new System.Drawing.Point(89, 134);
            this.cant_numtxt.Name = "cant_numtxt";
            this.cant_numtxt.Size = new System.Drawing.Size(63, 20);
            this.cant_numtxt.TabIndex = 99;
            this.cant_numtxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 14);
            this.label11.TabIndex = 100;
            this.label11.Text = "Cantidad:";
            // 
            // agregar_btn
            // 
            this.agregar_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_btn.Image = global::SistemaFacturacion.Properties.Resources.anadir;
            this.agregar_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregar_btn.Location = new System.Drawing.Point(16, 386);
            this.agregar_btn.Name = "agregar_btn";
            this.agregar_btn.Size = new System.Drawing.Size(126, 86);
            this.agregar_btn.TabIndex = 101;
            this.agregar_btn.Text = "Añadir";
            this.agregar_btn.UseVisualStyleBackColor = true;
            this.agregar_btn.Click += new System.EventHandler(this.agregar_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.descuento_lbl);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.totalPagar2_lbl);
            this.panel2.Controls.Add(this.devuelta_lbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.efectivo_txt);
            this.panel2.Controls.Add(this.totalPagar_lbl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.total_lbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 116);
            this.panel2.TabIndex = 102;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(606, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Total Pagar($RD): ";
            // 
            // totalPagar2_lbl
            // 
            this.totalPagar2_lbl.AutoSize = true;
            this.totalPagar2_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPagar2_lbl.ForeColor = System.Drawing.Color.Red;
            this.totalPagar2_lbl.Location = new System.Drawing.Point(774, 17);
            this.totalPagar2_lbl.Name = "totalPagar2_lbl";
            this.totalPagar2_lbl.Size = new System.Drawing.Size(47, 22);
            this.totalPagar2_lbl.TabIndex = 15;
            this.totalPagar2_lbl.Text = "total";
            // 
            // orden_dtg
            // 
            this.orden_dtg.AllowUserToAddRows = false;
            this.orden_dtg.AllowUserToDeleteRows = false;
            this.orden_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.orden_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.orden_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orden_dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoPago,
            this.PAGORD,
            this.PAGOUSD,
            this.detalles,
            this.dataGridViewDeleteButton,
            this.idtipoPago,
            this.Column1,
            this.Column2});
            this.orden_dtg.Location = new System.Drawing.Point(490, 166);
            this.orden_dtg.MultiSelect = false;
            this.orden_dtg.Name = "orden_dtg";
            this.orden_dtg.ReadOnly = true;
            this.orden_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orden_dtg.Size = new System.Drawing.Size(462, 214);
            this.orden_dtg.TabIndex = 106;
            this.orden_dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orden_dtg_CellClick_1);
            this.orden_dtg.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.orden_dtg_CellPainting);
            // 
            // TipoPago
            // 
            this.TipoPago.HeaderText = "PRODUCTO";
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.ReadOnly = true;
            this.TipoPago.Width = 93;
            // 
            // PAGORD
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.PAGORD.DefaultCellStyle = dataGridViewCellStyle1;
            this.PAGORD.HeaderText = "CANTIDAD";
            this.PAGORD.Name = "PAGORD";
            this.PAGORD.ReadOnly = true;
            this.PAGORD.Width = 87;
            // 
            // PAGOUSD
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.PAGOUSD.DefaultCellStyle = dataGridViewCellStyle2;
            this.PAGOUSD.HeaderText = "PRECIO UNIDAD";
            this.PAGOUSD.Name = "PAGOUSD";
            this.PAGOUSD.ReadOnly = true;
            this.PAGOUSD.Width = 107;
            // 
            // detalles
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.detalles.DefaultCellStyle = dataGridViewCellStyle3;
            this.detalles.HeaderText = "PRECIO TOTAL";
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            this.detalles.Width = 101;
            // 
            // dataGridViewDeleteButton
            // 
            this.dataGridViewDeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewDeleteButton.HeaderText = "ELIMINAR";
            this.dataGridViewDeleteButton.Name = "dataGridViewDeleteButton";
            this.dataGridViewDeleteButton.ReadOnly = true;
            this.dataGridViewDeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewDeleteButton.Width = 83;
            // 
            // idtipoPago
            // 
            this.idtipoPago.HeaderText = "IDPRODUCTO";
            this.idtipoPago.Name = "idtipoPago";
            this.idtipoPago.ReadOnly = true;
            this.idtipoPago.Width = 104;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IDUNIDAD";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 85;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "IDTIPOPRODUCTO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 129;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Descuento($RD): ";
            // 
            // descuento_lbl
            // 
            this.descuento_lbl.AutoSize = true;
            this.descuento_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuento_lbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.descuento_lbl.Location = new System.Drawing.Point(194, 49);
            this.descuento_lbl.Name = "descuento_lbl";
            this.descuento_lbl.Size = new System.Drawing.Size(47, 22);
            this.descuento_lbl.TabIndex = 17;
            this.descuento_lbl.Text = "total";
            // 
            // FacturarForm
            // 
            this.AcceptButton = this.crear_factura_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 607);
            this.Controls.Add(this.orden_dtg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.agregar_btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cant_numtxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buscar_producto_txt);
            this.Controls.Add(this.descuento_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productos_dtg);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.crear_factura_btn);
            this.Controls.Add(this.numeroFactura_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cliente_txt);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FacturarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Facturación";
            this.Load += new System.EventHandler(this.FacturarForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productos_dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cant_numtxt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cliente_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button crear_factura_btn;
        private System.Windows.Forms.TextBox numeroFactura_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label devuelta_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox efectivo_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descuento_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalPagar_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox buscar_producto_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView productos_dtg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown cant_numtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button agregar_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalPagar2_lbl;
        private System.Windows.Forms.DataGridView orden_dtg;
        private System.Windows.Forms.Label descuento_lbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGOUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalles;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewDeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}