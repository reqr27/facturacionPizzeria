namespace SistemaFacturacion
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.msjNoActivado_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usuario_lbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fecha_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cerrarSesion_link = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cuadreDiario_btn = new System.Windows.Forms.Button();
            this.reportes_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.entradaProductos_btn = new System.Windows.Forms.Button();
            this.config_btn = new System.Windows.Forms.Button();
            this.agregarTipoProducto_btn = new System.Windows.Forms.Button();
            this.facturacion_btn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sistema Facturación";
            // 
            // msjNoActivado_lbl
            // 
            this.msjNoActivado_lbl.AutoSize = true;
            this.msjNoActivado_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.msjNoActivado_lbl.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msjNoActivado_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.msjNoActivado_lbl.Location = new System.Drawing.Point(3, 6);
            this.msjNoActivado_lbl.Name = "msjNoActivado_lbl";
            this.msjNoActivado_lbl.Size = new System.Drawing.Size(218, 14);
            this.msjNoActivado_lbl.TabIndex = 12;
            this.msjNoActivado_lbl.Text = "SOFTWARE NO HA SIDO ACTIVADO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.usuario_lbl);
            this.panel3.Location = new System.Drawing.Point(176, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 29);
            this.panel3.TabIndex = 3;
            // 
            // usuario_lbl
            // 
            this.usuario_lbl.AutoSize = true;
            this.usuario_lbl.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_lbl.Location = new System.Drawing.Point(20, 6);
            this.usuario_lbl.Name = "usuario_lbl";
            this.usuario_lbl.Size = new System.Drawing.Size(0, 23);
            this.usuario_lbl.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel4.Controls.Add(this.fecha_lbl);
            this.panel4.Controls.Add(this.cerrarSesion_link);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Location = new System.Drawing.Point(0, 455);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(971, 71);
            this.panel4.TabIndex = 13;
            // 
            // fecha_lbl
            // 
            this.fecha_lbl.AutoSize = true;
            this.fecha_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fecha_lbl.Location = new System.Drawing.Point(3, 44);
            this.fecha_lbl.Name = "fecha_lbl";
            this.fecha_lbl.Size = new System.Drawing.Size(60, 24);
            this.fecha_lbl.TabIndex = 0;
            this.fecha_lbl.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cerrarSesion_link
            // 
            this.cerrarSesion_link.ActiveLinkColor = System.Drawing.Color.Black;
            this.cerrarSesion_link.AutoSize = true;
            this.cerrarSesion_link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cerrarSesion_link.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion_link.ForeColor = System.Drawing.SystemColors.Control;
            this.cerrarSesion_link.LinkColor = System.Drawing.Color.White;
            this.cerrarSesion_link.Location = new System.Drawing.Point(857, 50);
            this.cerrarSesion_link.Name = "cerrarSesion_link";
            this.cerrarSesion_link.Size = new System.Drawing.Size(102, 16);
            this.cerrarSesion_link.TabIndex = 1;
            this.cerrarSesion_link.TabStop = true;
            this.cerrarSesion_link.Text = "Cerrar Sesión";
            this.cerrarSesion_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cerrarSesion_link_LinkClicked);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.msjNoActivado_lbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(971, 112);
            this.panel5.TabIndex = 14;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // cuadreDiario_btn
            // 
            this.cuadreDiario_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cuadreDiario_btn.FlatAppearance.BorderSize = 0;
            this.cuadreDiario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuadreDiario_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadreDiario_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuadreDiario_btn.Image = global::SistemaFacturacion.Properties.Resources.cashier;
            this.cuadreDiario_btn.Location = new System.Drawing.Point(770, 172);
            this.cuadreDiario_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cuadreDiario_btn.Name = "cuadreDiario_btn";
            this.cuadreDiario_btn.Size = new System.Drawing.Size(194, 177);
            this.cuadreDiario_btn.TabIndex = 16;
            this.cuadreDiario_btn.Text = "Cuadre Diario";
            this.cuadreDiario_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cuadreDiario_btn.UseVisualStyleBackColor = false;
            this.cuadreDiario_btn.Click += new System.EventHandler(this.cuadreDiario_btn_Click_1);
            // 
            // reportes_btn
            // 
            this.reportes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.reportes_btn.FlatAppearance.BorderSize = 0;
            this.reportes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportes_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportes_btn.Image = global::SistemaFacturacion.Properties.Resources.laptop__1_;
            this.reportes_btn.Location = new System.Drawing.Point(387, 172);
            this.reportes_btn.Margin = new System.Windows.Forms.Padding(4);
            this.reportes_btn.Name = "reportes_btn";
            this.reportes_btn.Size = new System.Drawing.Size(183, 177);
            this.reportes_btn.TabIndex = 15;
            this.reportes_btn.Text = "Reportes";
            this.reportes_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.reportes_btn.UseVisualStyleBackColor = false;
            this.reportes_btn.Click += new System.EventHandler(this.reportes_btn_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SistemaFacturacion.Properties.Resources.minimize__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(909, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 33;
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
            this.button2.Location = new System.Drawing.Point(941, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 32;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // entradaProductos_btn
            // 
            this.entradaProductos_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.entradaProductos_btn.FlatAppearance.BorderSize = 0;
            this.entradaProductos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entradaProductos_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaProductos_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.entradaProductos_btn.Image = global::SistemaFacturacion.Properties.Resources.storage;
            this.entradaProductos_btn.Location = new System.Drawing.Point(578, 172);
            this.entradaProductos_btn.Margin = new System.Windows.Forms.Padding(4);
            this.entradaProductos_btn.Name = "entradaProductos_btn";
            this.entradaProductos_btn.Size = new System.Drawing.Size(184, 177);
            this.entradaProductos_btn.TabIndex = 2;
            this.entradaProductos_btn.Text = "Inventario";
            this.entradaProductos_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.entradaProductos_btn.UseVisualStyleBackColor = false;
            this.entradaProductos_btn.Click += new System.EventHandler(this.entradaProductos_btn_Click);
            // 
            // config_btn
            // 
            this.config_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.config_btn.FlatAppearance.BorderSize = 0;
            this.config_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.config_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.config_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.config_btn.Image = global::SistemaFacturacion.Properties.Resources.ajustes__1_;
            this.config_btn.Location = new System.Drawing.Point(9, 172);
            this.config_btn.Margin = new System.Windows.Forms.Padding(4);
            this.config_btn.Name = "config_btn";
            this.config_btn.Size = new System.Drawing.Size(179, 177);
            this.config_btn.TabIndex = 14;
            this.config_btn.Text = "Configuración";
            this.config_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.config_btn.UseVisualStyleBackColor = false;
            this.config_btn.Click += new System.EventHandler(this.config_btn_Click);
            // 
            // agregarTipoProducto_btn
            // 
            this.agregarTipoProducto_btn.BackColor = System.Drawing.Color.Peru;
            this.agregarTipoProducto_btn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarTipoProducto_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarTipoProducto_btn.Image = global::SistemaFacturacion.Properties.Resources.examen_tipo_test;
            this.agregarTipoProducto_btn.Location = new System.Drawing.Point(149, 6);
            this.agregarTipoProducto_btn.Margin = new System.Windows.Forms.Padding(4);
            this.agregarTipoProducto_btn.Name = "agregarTipoProducto_btn";
            this.agregarTipoProducto_btn.Size = new System.Drawing.Size(39, 21);
            this.agregarTipoProducto_btn.TabIndex = 3;
            this.agregarTipoProducto_btn.Text = "Tipo Producto";
            this.agregarTipoProducto_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.agregarTipoProducto_btn.UseVisualStyleBackColor = false;
            this.agregarTipoProducto_btn.Visible = false;
            this.agregarTipoProducto_btn.Click += new System.EventHandler(this.agregarTipoProducto_btn_Click);
            // 
            // facturacion_btn
            // 
            this.facturacion_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.facturacion_btn.FlatAppearance.BorderSize = 0;
            this.facturacion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facturacion_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturacion_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facturacion_btn.Image = global::SistemaFacturacion.Properties.Resources.maquina_de_facturacion;
            this.facturacion_btn.Location = new System.Drawing.Point(196, 172);
            this.facturacion_btn.Margin = new System.Windows.Forms.Padding(4);
            this.facturacion_btn.Name = "facturacion_btn";
            this.facturacion_btn.Size = new System.Drawing.Size(183, 177);
            this.facturacion_btn.TabIndex = 2;
            this.facturacion_btn.Text = "Facturación";
            this.facturacion_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.facturacion_btn.UseVisualStyleBackColor = false;
            this.facturacion_btn.Click += new System.EventHandler(this.facturacion_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 526);
            this.Controls.Add(this.cuadreDiario_btn);
            this.Controls.Add(this.reportes_btn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.entradaProductos_btn);
            this.Controls.Add(this.config_btn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.agregarTipoProducto_btn);
            this.Controls.Add(this.facturacion_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA FACTURACION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button agregarTipoProducto_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button entradaProductos_btn;
        private System.Windows.Forms.Button facturacion_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label usuario_lbl;
        private System.Windows.Forms.Label msjNoActivado_lbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label fecha_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel cerrarSesion_link;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button config_btn;
        private System.Windows.Forms.Button reportes_btn;
        private System.Windows.Forms.Button cuadreDiario_btn;
    }
}

