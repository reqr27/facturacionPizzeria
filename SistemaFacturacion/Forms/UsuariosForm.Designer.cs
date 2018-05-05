namespace SistemaFacturacion.Forms
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.label2 = new System.Windows.Forms.Label();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.clave_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmarClave_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.tipoUsuario_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.estado_chbx = new System.Windows.Forms.CheckBox();
            this.reporteSalida_chbx = new System.Windows.Forms.CheckBox();
            this.reporteEntrada_chbx = new System.Windows.Forms.CheckBox();
            this.ingredientes_chbx = new System.Windows.Forms.CheckBox();
            this.salidaProductos_chbx = new System.Windows.Forms.CheckBox();
            this.repVentas_chbx = new System.Windows.Forms.CheckBox();
            this.repCuadre_chbx = new System.Windows.Forms.CheckBox();
            this.repExistencia_chbx = new System.Windows.Forms.CheckBox();
            this.historialFacturas_chbx = new System.Windows.Forms.CheckBox();
            this.Entrada_chbx = new System.Windows.Forms.CheckBox();
            this.facturacion_chbx = new System.Windows.Forms.CheckBox();
            this.crearUnidad_chbx = new System.Windows.Forms.CheckBox();
            this.crearTipoProducto_chbx = new System.Windows.Forms.CheckBox();
            this.crearUsuario_chbx = new System.Windows.Forms.CheckBox();
            this.crearProductos_chbx = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usuarios_dtg = new System.Windows.Forms.DataGridView();
            this.agregarEditarUsuario_btn = new System.Windows.Forms.Button();
            this.activos_radiobtn = new System.Windows.Forms.RadioButton();
            this.inactivo_radiobtn = new System.Windows.Forms.RadioButton();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.eliminarFactura_radiobtn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_dtg)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario: ";
            // 
            // usuario_txt
            // 
            this.usuario_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_txt.Location = new System.Drawing.Point(156, 104);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(186, 22);
            this.usuario_txt.TabIndex = 2;
            // 
            // clave_txt
            // 
            this.clave_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_txt.Location = new System.Drawing.Point(156, 138);
            this.clave_txt.Name = "clave_txt";
            this.clave_txt.PasswordChar = '*';
            this.clave_txt.Size = new System.Drawing.Size(186, 22);
            this.clave_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clave:";
            // 
            // confirmarClave_txt
            // 
            this.confirmarClave_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClave_txt.Location = new System.Drawing.Point(156, 173);
            this.confirmarClave_txt.Name = "confirmarClave_txt";
            this.confirmarClave_txt.PasswordChar = '*';
            this.confirmarClave_txt.Size = new System.Drawing.Size(186, 22);
            this.confirmarClave_txt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirmar Clave:";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_txt.Location = new System.Drawing.Point(156, 72);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(186, 22);
            this.nombre_txt.TabIndex = 1;
            // 
            // tipoUsuario_txt
            // 
            this.tipoUsuario_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_txt.Location = new System.Drawing.Point(156, 214);
            this.tipoUsuario_txt.Name = "tipoUsuario_txt";
            this.tipoUsuario_txt.Size = new System.Drawing.Size(186, 22);
            this.tipoUsuario_txt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo Usuario: ";
            // 
            // estado_chbx
            // 
            this.estado_chbx.AutoSize = true;
            this.estado_chbx.Checked = true;
            this.estado_chbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estado_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_chbx.Location = new System.Drawing.Point(3, 3);
            this.estado_chbx.Name = "estado_chbx";
            this.estado_chbx.Size = new System.Drawing.Size(129, 18);
            this.estado_chbx.TabIndex = 6;
            this.estado_chbx.Text = "Activar Usuario";
            this.estado_chbx.UseVisualStyleBackColor = true;
            // 
            // reporteSalida_chbx
            // 
            this.reporteSalida_chbx.AutoSize = true;
            this.reporteSalida_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteSalida_chbx.Location = new System.Drawing.Point(363, 51);
            this.reporteSalida_chbx.Name = "reporteSalida_chbx";
            this.reporteSalida_chbx.Size = new System.Drawing.Size(121, 18);
            this.reporteSalida_chbx.TabIndex = 20;
            this.reporteSalida_chbx.Text = "Reporte Salida";
            this.reporteSalida_chbx.UseVisualStyleBackColor = true;
            // 
            // reporteEntrada_chbx
            // 
            this.reporteEntrada_chbx.AutoSize = true;
            this.reporteEntrada_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteEntrada_chbx.Location = new System.Drawing.Point(363, 27);
            this.reporteEntrada_chbx.Name = "reporteEntrada_chbx";
            this.reporteEntrada_chbx.Size = new System.Drawing.Size(133, 18);
            this.reporteEntrada_chbx.TabIndex = 19;
            this.reporteEntrada_chbx.Text = "Reporte Entrada";
            this.reporteEntrada_chbx.UseVisualStyleBackColor = true;
            // 
            // ingredientes_chbx
            // 
            this.ingredientes_chbx.AutoSize = true;
            this.ingredientes_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientes_chbx.Location = new System.Drawing.Point(363, 3);
            this.ingredientes_chbx.Name = "ingredientes_chbx";
            this.ingredientes_chbx.Size = new System.Drawing.Size(180, 18);
            this.ingredientes_chbx.TabIndex = 18;
            this.ingredientes_chbx.Text = "Ingredientes Productos";
            this.ingredientes_chbx.UseVisualStyleBackColor = true;
            // 
            // salidaProductos_chbx
            // 
            this.salidaProductos_chbx.AutoSize = true;
            this.salidaProductos_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaProductos_chbx.Location = new System.Drawing.Point(192, 123);
            this.salidaProductos_chbx.Name = "salidaProductos_chbx";
            this.salidaProductos_chbx.Size = new System.Drawing.Size(137, 18);
            this.salidaProductos_chbx.TabIndex = 17;
            this.salidaProductos_chbx.Text = "Salida Productos";
            this.salidaProductos_chbx.UseVisualStyleBackColor = true;
            // 
            // repVentas_chbx
            // 
            this.repVentas_chbx.AutoSize = true;
            this.repVentas_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repVentas_chbx.Location = new System.Drawing.Point(192, 99);
            this.repVentas_chbx.Name = "repVentas_chbx";
            this.repVentas_chbx.Size = new System.Drawing.Size(126, 18);
            this.repVentas_chbx.TabIndex = 16;
            this.repVentas_chbx.Text = "Reporte Ventas";
            this.repVentas_chbx.UseVisualStyleBackColor = true;
            // 
            // repCuadre_chbx
            // 
            this.repCuadre_chbx.AutoSize = true;
            this.repCuadre_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repCuadre_chbx.Location = new System.Drawing.Point(192, 75);
            this.repCuadre_chbx.Name = "repCuadre_chbx";
            this.repCuadre_chbx.Size = new System.Drawing.Size(76, 18);
            this.repCuadre_chbx.TabIndex = 15;
            this.repCuadre_chbx.Text = "Cuadre ";
            this.repCuadre_chbx.UseVisualStyleBackColor = true;
            // 
            // repExistencia_chbx
            // 
            this.repExistencia_chbx.AutoSize = true;
            this.repExistencia_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repExistencia_chbx.Location = new System.Drawing.Point(192, 51);
            this.repExistencia_chbx.Name = "repExistencia_chbx";
            this.repExistencia_chbx.Size = new System.Drawing.Size(151, 18);
            this.repExistencia_chbx.TabIndex = 14;
            this.repExistencia_chbx.Text = "Reporte Existencia";
            this.repExistencia_chbx.UseVisualStyleBackColor = true;
            // 
            // historialFacturas_chbx
            // 
            this.historialFacturas_chbx.AutoSize = true;
            this.historialFacturas_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialFacturas_chbx.Location = new System.Drawing.Point(192, 27);
            this.historialFacturas_chbx.Name = "historialFacturas_chbx";
            this.historialFacturas_chbx.Size = new System.Drawing.Size(165, 18);
            this.historialFacturas_chbx.TabIndex = 13;
            this.historialFacturas_chbx.Text = "Historial de Facturas";
            this.historialFacturas_chbx.UseVisualStyleBackColor = true;
            // 
            // Entrada_chbx
            // 
            this.Entrada_chbx.AutoSize = true;
            this.Entrada_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrada_chbx.Location = new System.Drawing.Point(192, 3);
            this.Entrada_chbx.Name = "Entrada_chbx";
            this.Entrada_chbx.Size = new System.Drawing.Size(149, 18);
            this.Entrada_chbx.TabIndex = 11;
            this.Entrada_chbx.Text = "Entrada Productos";
            this.Entrada_chbx.UseVisualStyleBackColor = true;
            // 
            // facturacion_chbx
            // 
            this.facturacion_chbx.AutoSize = true;
            this.facturacion_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturacion_chbx.Location = new System.Drawing.Point(3, 123);
            this.facturacion_chbx.Name = "facturacion_chbx";
            this.facturacion_chbx.Size = new System.Drawing.Size(154, 18);
            this.facturacion_chbx.TabIndex = 12;
            this.facturacion_chbx.Text = "Acceso Facturación";
            this.facturacion_chbx.UseVisualStyleBackColor = true;
            // 
            // crearUnidad_chbx
            // 
            this.crearUnidad_chbx.AutoSize = true;
            this.crearUnidad_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearUnidad_chbx.Location = new System.Drawing.Point(3, 99);
            this.crearUnidad_chbx.Name = "crearUnidad_chbx";
            this.crearUnidad_chbx.Size = new System.Drawing.Size(139, 18);
            this.crearUnidad_chbx.TabIndex = 10;
            this.crearUnidad_chbx.Text = "Agregar Unidades";
            this.crearUnidad_chbx.UseVisualStyleBackColor = true;
            // 
            // crearTipoProducto_chbx
            // 
            this.crearTipoProducto_chbx.AutoSize = true;
            this.crearTipoProducto_chbx.Enabled = false;
            this.crearTipoProducto_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearTipoProducto_chbx.Location = new System.Drawing.Point(3, 75);
            this.crearTipoProducto_chbx.Name = "crearTipoProducto_chbx";
            this.crearTipoProducto_chbx.Size = new System.Drawing.Size(183, 18);
            this.crearTipoProducto_chbx.TabIndex = 9;
            this.crearTipoProducto_chbx.Text = "Agregar  Tipo productos";
            this.crearTipoProducto_chbx.UseVisualStyleBackColor = true;
            // 
            // crearUsuario_chbx
            // 
            this.crearUsuario_chbx.AutoSize = true;
            this.crearUsuario_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearUsuario_chbx.Location = new System.Drawing.Point(3, 51);
            this.crearUsuario_chbx.Name = "crearUsuario_chbx";
            this.crearUsuario_chbx.Size = new System.Drawing.Size(130, 18);
            this.crearUsuario_chbx.TabIndex = 7;
            this.crearUsuario_chbx.Text = "Agregar Usuario";
            this.crearUsuario_chbx.UseVisualStyleBackColor = true;
            // 
            // crearProductos_chbx
            // 
            this.crearProductos_chbx.AutoSize = true;
            this.crearProductos_chbx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearProductos_chbx.Location = new System.Drawing.Point(3, 27);
            this.crearProductos_chbx.Name = "crearProductos_chbx";
            this.crearProductos_chbx.Size = new System.Drawing.Size(146, 18);
            this.crearProductos_chbx.TabIndex = 8;
            this.crearProductos_chbx.Text = "Agregar Productos";
            this.crearProductos_chbx.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Permisos del Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre y Apellido:";
            // 
            // usuarios_dtg
            // 
            this.usuarios_dtg.AllowUserToAddRows = false;
            this.usuarios_dtg.AllowUserToDeleteRows = false;
            this.usuarios_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.usuarios_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.usuarios_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarios_dtg.Location = new System.Drawing.Point(12, 271);
            this.usuarios_dtg.MultiSelect = false;
            this.usuarios_dtg.Name = "usuarios_dtg";
            this.usuarios_dtg.ReadOnly = true;
            this.usuarios_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarios_dtg.Size = new System.Drawing.Size(780, 192);
            this.usuarios_dtg.TabIndex = 13;
            this.usuarios_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarios_dtg_CellDoubleClick);
            // 
            // agregarEditarUsuario_btn
            // 
            this.agregarEditarUsuario_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.agregarEditarUsuario_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarEditarUsuario_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarEditarUsuario_btn.Image = global::SistemaFacturacion.Properties.Resources.anadir;
            this.agregarEditarUsuario_btn.Location = new System.Drawing.Point(99, 473);
            this.agregarEditarUsuario_btn.Name = "agregarEditarUsuario_btn";
            this.agregarEditarUsuario_btn.Size = new System.Drawing.Size(171, 63);
            this.agregarEditarUsuario_btn.TabIndex = 17;
            this.agregarEditarUsuario_btn.Text = "Registrar";
            this.agregarEditarUsuario_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.agregarEditarUsuario_btn.UseVisualStyleBackColor = false;
            this.agregarEditarUsuario_btn.Click += new System.EventHandler(this.agregarEditarUsuario_btn_Click);
            // 
            // activos_radiobtn
            // 
            this.activos_radiobtn.AutoSize = true;
            this.activos_radiobtn.Checked = true;
            this.activos_radiobtn.Location = new System.Drawing.Point(178, 248);
            this.activos_radiobtn.Name = "activos_radiobtn";
            this.activos_radiobtn.Size = new System.Drawing.Size(104, 17);
            this.activos_radiobtn.TabIndex = 18;
            this.activos_radiobtn.TabStop = true;
            this.activos_radiobtn.Text = "Usuarios Activos";
            this.activos_radiobtn.UseVisualStyleBackColor = true;
            this.activos_radiobtn.CheckedChanged += new System.EventHandler(this.activos_radiobtn_CheckedChanged);
            // 
            // inactivo_radiobtn
            // 
            this.inactivo_radiobtn.AutoSize = true;
            this.inactivo_radiobtn.Location = new System.Drawing.Point(420, 248);
            this.inactivo_radiobtn.Name = "inactivo_radiobtn";
            this.inactivo_radiobtn.Size = new System.Drawing.Size(134, 17);
            this.inactivo_radiobtn.TabIndex = 19;
            this.inactivo_radiobtn.Text = "Usuarios Desactivados";
            this.inactivo_radiobtn.UseVisualStyleBackColor = true;
            this.inactivo_radiobtn.CheckedChanged += new System.EventHandler(this.inactivo_radiobtn_CheckedChanged);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.cancelar_btn.Enabled = false;
            this.cancelar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelar_btn.Image = global::SistemaFacturacion.Properties.Resources.boton_x;
            this.cancelar_btn.Location = new System.Drawing.Point(538, 473);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(169, 63);
            this.cancelar_btn.TabIndex = 20;
            this.cancelar_btn.Text = "Cancelar Editar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelar_btn.UseVisualStyleBackColor = false;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
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
            this.panel3.Size = new System.Drawing.Size(813, 48);
            this.panel3.TabIndex = 92;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SistemaFacturacion.Properties.Resources.minimize__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(742, 3);
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
            this.button2.Location = new System.Drawing.Point(774, 3);
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
            this.label27.Size = new System.Drawing.Size(127, 24);
            this.label27.TabIndex = 28;
            this.label27.Text = "USUARIOS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.estado_chbx);
            this.flowLayoutPanel1.Controls.Add(this.crearProductos_chbx);
            this.flowLayoutPanel1.Controls.Add(this.crearUsuario_chbx);
            this.flowLayoutPanel1.Controls.Add(this.crearTipoProducto_chbx);
            this.flowLayoutPanel1.Controls.Add(this.crearUnidad_chbx);
            this.flowLayoutPanel1.Controls.Add(this.facturacion_chbx);
            this.flowLayoutPanel1.Controls.Add(this.Entrada_chbx);
            this.flowLayoutPanel1.Controls.Add(this.historialFacturas_chbx);
            this.flowLayoutPanel1.Controls.Add(this.repExistencia_chbx);
            this.flowLayoutPanel1.Controls.Add(this.repCuadre_chbx);
            this.flowLayoutPanel1.Controls.Add(this.repVentas_chbx);
            this.flowLayoutPanel1.Controls.Add(this.salidaProductos_chbx);
            this.flowLayoutPanel1.Controls.Add(this.ingredientes_chbx);
            this.flowLayoutPanel1.Controls.Add(this.reporteEntrada_chbx);
            this.flowLayoutPanel1.Controls.Add(this.reporteSalida_chbx);
            this.flowLayoutPanel1.Controls.Add(this.eliminarFactura_radiobtn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(361, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(431, 161);
            this.flowLayoutPanel1.TabIndex = 93;
            // 
            // eliminarFactura_radiobtn
            // 
            this.eliminarFactura_radiobtn.AutoSize = true;
            this.eliminarFactura_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarFactura_radiobtn.Location = new System.Drawing.Point(363, 75);
            this.eliminarFactura_radiobtn.Name = "eliminarFactura_radiobtn";
            this.eliminarFactura_radiobtn.Size = new System.Drawing.Size(145, 18);
            this.eliminarFactura_radiobtn.TabIndex = 21;
            this.eliminarFactura_radiobtn.Text = "Eliminar Facturas";
            this.eliminarFactura_radiobtn.UseVisualStyleBackColor = true;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 548);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.inactivo_radiobtn);
            this.Controls.Add(this.activos_radiobtn);
            this.Controls.Add(this.agregarEditarUsuario_btn);
            this.Controls.Add(this.usuarios_dtg);
            this.Controls.Add(this.tipoUsuario_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmarClave_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clave_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usuario_txt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Facturación";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UsuariosForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_dtg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.TextBox clave_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmarClave_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.TextBox tipoUsuario_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox estado_chbx;
        private System.Windows.Forms.CheckBox repVentas_chbx;
        private System.Windows.Forms.CheckBox repCuadre_chbx;
        private System.Windows.Forms.CheckBox repExistencia_chbx;
        private System.Windows.Forms.CheckBox historialFacturas_chbx;
        private System.Windows.Forms.CheckBox Entrada_chbx;
        private System.Windows.Forms.CheckBox facturacion_chbx;
        private System.Windows.Forms.CheckBox crearUnidad_chbx;
        private System.Windows.Forms.CheckBox crearTipoProducto_chbx;
        private System.Windows.Forms.CheckBox crearUsuario_chbx;
        private System.Windows.Forms.CheckBox crearProductos_chbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView usuarios_dtg;
        private System.Windows.Forms.Button agregarEditarUsuario_btn;
        private System.Windows.Forms.RadioButton activos_radiobtn;
        private System.Windows.Forms.RadioButton inactivo_radiobtn;
        private System.Windows.Forms.CheckBox salidaProductos_chbx;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.CheckBox ingredientes_chbx;
        private System.Windows.Forms.CheckBox reporteSalida_chbx;
        private System.Windows.Forms.CheckBox reporteEntrada_chbx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox eliminarFactura_radiobtn;
    }
}