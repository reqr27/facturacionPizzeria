namespace SistemaFacturacion.Forms
{
    partial class VentanaReportesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaReportesForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.ventasReporte_btn = new System.Windows.Forms.Button();
            this.salidaProductoReporte_btn = new System.Windows.Forms.Button();
            this.entradaProductosReporte_btn = new System.Windows.Forms.Button();
            this.historialFacturas_btn = new System.Windows.Forms.Button();
            this.existenciaReporte_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(547, 48);
            this.panel3.TabIndex = 89;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label27.Location = new System.Drawing.Point(12, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(134, 24);
            this.label27.TabIndex = 28;
            this.label27.Text = "REPORTES\r\n";
            // 
            // ventasReporte_btn
            // 
            this.ventasReporte_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ventasReporte_btn.FlatAppearance.BorderSize = 0;
            this.ventasReporte_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventasReporte_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasReporte_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.ventasReporte_btn.Image = global::SistemaFacturacion.Properties.Resources.line_chart;
            this.ventasReporte_btn.Location = new System.Drawing.Point(16, 65);
            this.ventasReporte_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ventasReporte_btn.Name = "ventasReporte_btn";
            this.ventasReporte_btn.Size = new System.Drawing.Size(166, 136);
            this.ventasReporte_btn.TabIndex = 94;
            this.ventasReporte_btn.Text = "Reporte Ventas ";
            this.ventasReporte_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ventasReporte_btn.UseVisualStyleBackColor = false;
            this.ventasReporte_btn.Click += new System.EventHandler(this.ventasReporte_btn_Click);
            // 
            // salidaProductoReporte_btn
            // 
            this.salidaProductoReporte_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.salidaProductoReporte_btn.FlatAppearance.BorderSize = 0;
            this.salidaProductoReporte_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salidaProductoReporte_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaProductoReporte_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.salidaProductoReporte_btn.Image = global::SistemaFacturacion.Properties.Resources.periodico;
            this.salidaProductoReporte_btn.Location = new System.Drawing.Point(190, 209);
            this.salidaProductoReporte_btn.Margin = new System.Windows.Forms.Padding(4);
            this.salidaProductoReporte_btn.Name = "salidaProductoReporte_btn";
            this.salidaProductoReporte_btn.Size = new System.Drawing.Size(166, 136);
            this.salidaProductoReporte_btn.TabIndex = 93;
            this.salidaProductoReporte_btn.Text = "Reporte Salida Productos";
            this.salidaProductoReporte_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.salidaProductoReporte_btn.UseVisualStyleBackColor = false;
            this.salidaProductoReporte_btn.Click += new System.EventHandler(this.salidaProductoReporte_btn_Click);
            // 
            // entradaProductosReporte_btn
            // 
            this.entradaProductosReporte_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.entradaProductosReporte_btn.FlatAppearance.BorderSize = 0;
            this.entradaProductosReporte_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entradaProductosReporte_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaProductosReporte_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.entradaProductosReporte_btn.Image = global::SistemaFacturacion.Properties.Resources.informe_de_progreso;
            this.entradaProductosReporte_btn.Location = new System.Drawing.Point(364, 65);
            this.entradaProductosReporte_btn.Margin = new System.Windows.Forms.Padding(4);
            this.entradaProductosReporte_btn.Name = "entradaProductosReporte_btn";
            this.entradaProductosReporte_btn.Size = new System.Drawing.Size(166, 136);
            this.entradaProductosReporte_btn.TabIndex = 91;
            this.entradaProductosReporte_btn.Text = "Reporte Entrada Productos";
            this.entradaProductosReporte_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.entradaProductosReporte_btn.UseVisualStyleBackColor = false;
            this.entradaProductosReporte_btn.Click += new System.EventHandler(this.entradaProductosReporte_btn_Click);
            // 
            // historialFacturas_btn
            // 
            this.historialFacturas_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.historialFacturas_btn.FlatAppearance.BorderSize = 0;
            this.historialFacturas_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historialFacturas_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialFacturas_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.historialFacturas_btn.Image = global::SistemaFacturacion.Properties.Resources.bill__1_;
            this.historialFacturas_btn.Location = new System.Drawing.Point(190, 65);
            this.historialFacturas_btn.Margin = new System.Windows.Forms.Padding(4);
            this.historialFacturas_btn.Name = "historialFacturas_btn";
            this.historialFacturas_btn.Size = new System.Drawing.Size(166, 136);
            this.historialFacturas_btn.TabIndex = 92;
            this.historialFacturas_btn.Text = "Historial Facturas";
            this.historialFacturas_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.historialFacturas_btn.UseVisualStyleBackColor = false;
            this.historialFacturas_btn.Click += new System.EventHandler(this.historialFacturas_btn_Click);
            // 
            // existenciaReporte_btn
            // 
            this.existenciaReporte_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.existenciaReporte_btn.FlatAppearance.BorderSize = 0;
            this.existenciaReporte_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.existenciaReporte_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existenciaReporte_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.existenciaReporte_btn.Image = global::SistemaFacturacion.Properties.Resources.fabrica_casa_con_inventario;
            this.existenciaReporte_btn.Location = new System.Drawing.Point(16, 209);
            this.existenciaReporte_btn.Margin = new System.Windows.Forms.Padding(4);
            this.existenciaReporte_btn.Name = "existenciaReporte_btn";
            this.existenciaReporte_btn.Size = new System.Drawing.Size(166, 136);
            this.existenciaReporte_btn.TabIndex = 90;
            this.existenciaReporte_btn.Text = "Reporte Existencia Actual";
            this.existenciaReporte_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.existenciaReporte_btn.UseVisualStyleBackColor = false;
            this.existenciaReporte_btn.Click += new System.EventHandler(this.existenciaReporte_btn_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SistemaFacturacion.Properties.Resources.minimize__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(472, 4);
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
            this.button2.Location = new System.Drawing.Point(504, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 30;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VentanaReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 394);
            this.Controls.Add(this.ventasReporte_btn);
            this.Controls.Add(this.salidaProductoReporte_btn);
            this.Controls.Add(this.entradaProductosReporte_btn);
            this.Controls.Add(this.historialFacturas_btn);
            this.Controls.Add(this.existenciaReporte_btn);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaReportesForm";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.VentanaReportesForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button ventasReporte_btn;
        private System.Windows.Forms.Button salidaProductoReporte_btn;
        private System.Windows.Forms.Button entradaProductosReporte_btn;
        private System.Windows.Forms.Button historialFacturas_btn;
        private System.Windows.Forms.Button existenciaReporte_btn;
    }
}