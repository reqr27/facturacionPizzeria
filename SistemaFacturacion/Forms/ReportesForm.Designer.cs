namespace SistemaFacturacion.Forms
{
    partial class ReportesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesForm));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.filtros_panel = new System.Windows.Forms.Panel();
            this.limpiaFiltros = new System.Windows.Forms.Button();
            this.producto_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proveedor_txt = new System.Windows.Forms.TextBox();
            this.proveedor_lbl = new System.Windows.Forms.Label();
            this.hasta_dtp = new System.Windows.Forms.DateTimePicker();
            this.desde_dtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.filtros_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 58);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(836, 402);
            this.reportViewer1.TabIndex = 0;
            // 
            // filtros_panel
            // 
            this.filtros_panel.Controls.Add(this.limpiaFiltros);
            this.filtros_panel.Controls.Add(this.producto_cb);
            this.filtros_panel.Controls.Add(this.label2);
            this.filtros_panel.Controls.Add(this.proveedor_txt);
            this.filtros_panel.Controls.Add(this.proveedor_lbl);
            this.filtros_panel.Controls.Add(this.hasta_dtp);
            this.filtros_panel.Controls.Add(this.desde_dtp);
            this.filtros_panel.Controls.Add(this.label3);
            this.filtros_panel.Controls.Add(this.label1);
            this.filtros_panel.Controls.Add(this.buscar_btn);
            this.filtros_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filtros_panel.Location = new System.Drawing.Point(0, 0);
            this.filtros_panel.Name = "filtros_panel";
            this.filtros_panel.Size = new System.Drawing.Size(836, 58);
            this.filtros_panel.TabIndex = 1;
            // 
            // limpiaFiltros
            // 
            this.limpiaFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiaFiltros.Image = global::SistemaFacturacion.Properties.Resources.boton_x;
            this.limpiaFiltros.Location = new System.Drawing.Point(708, 3);
            this.limpiaFiltros.Name = "limpiaFiltros";
            this.limpiaFiltros.Size = new System.Drawing.Size(116, 52);
            this.limpiaFiltros.TabIndex = 29;
            this.limpiaFiltros.Text = "Limpiar Filtros";
            this.limpiaFiltros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.limpiaFiltros.UseVisualStyleBackColor = true;
            this.limpiaFiltros.Click += new System.EventHandler(this.limpiaFiltros_Click);
            // 
            // producto_cb
            // 
            this.producto_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.producto_cb.FormattingEnabled = true;
            this.producto_cb.Location = new System.Drawing.Point(264, 31);
            this.producto_cb.Name = "producto_cb";
            this.producto_cb.Size = new System.Drawing.Size(189, 21);
            this.producto_cb.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Producto: ";
            // 
            // proveedor_txt
            // 
            this.proveedor_txt.Location = new System.Drawing.Point(264, 7);
            this.proveedor_txt.Name = "proveedor_txt";
            this.proveedor_txt.Size = new System.Drawing.Size(189, 20);
            this.proveedor_txt.TabIndex = 26;
            // 
            // proveedor_lbl
            // 
            this.proveedor_lbl.AutoSize = true;
            this.proveedor_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedor_lbl.Location = new System.Drawing.Point(195, 10);
            this.proveedor_lbl.Name = "proveedor_lbl";
            this.proveedor_lbl.Size = new System.Drawing.Size(73, 13);
            this.proveedor_lbl.TabIndex = 25;
            this.proveedor_lbl.Text = "Proveedor: ";
            // 
            // hasta_dtp
            // 
            this.hasta_dtp.CustomFormat = "dd/MM/yyyy";
            this.hasta_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hasta_dtp.Location = new System.Drawing.Point(67, 30);
            this.hasta_dtp.Name = "hasta_dtp";
            this.hasta_dtp.Size = new System.Drawing.Size(103, 20);
            this.hasta_dtp.TabIndex = 24;
            this.hasta_dtp.Value = new System.DateTime(2017, 9, 15, 22, 0, 0, 0);
            // 
            // desde_dtp
            // 
            this.desde_dtp.CustomFormat = "dd/MM/yyyy";
            this.desde_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desde_dtp.Location = new System.Drawing.Point(67, 3);
            this.desde_dtp.Name = "desde_dtp";
            this.desde_dtp.Size = new System.Drawing.Size(103, 20);
            this.desde_dtp.TabIndex = 23;
            this.desde_dtp.Value = new System.DateTime(2017, 9, 15, 8, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Desde:";
            // 
            // buscar_btn
            // 
            this.buscar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.Image = global::SistemaFacturacion.Properties.Resources.lupa_para_buscar;
            this.buscar_btn.Location = new System.Drawing.Point(563, 3);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(116, 52);
            this.buscar_btn.TabIndex = 2;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscar_btn.UseVisualStyleBackColor = true;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 460);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.filtros_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportesForm";
            this.Text = "ReportesForm";
            this.Load += new System.EventHandler(this.ReportesForm_Load);
            this.filtros_panel.ResumeLayout(false);
            this.filtros_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel filtros_panel;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.DateTimePicker hasta_dtp;
        private System.Windows.Forms.DateTimePicker desde_dtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proveedor_txt;
        private System.Windows.Forms.Label proveedor_lbl;
        private System.Windows.Forms.ComboBox producto_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button limpiaFiltros;
    }
}