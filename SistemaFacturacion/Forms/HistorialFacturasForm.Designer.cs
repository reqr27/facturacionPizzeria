namespace SistemaFacturacion.Forms
{
    partial class HistorialFacturasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialFacturasForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.activas_radiobtn = new System.Windows.Forms.RadioButton();
            this.eliminadas_radiobtn = new System.Windows.Forms.RadioButton();
            this.historialFacturas_dtg = new System.Windows.Forms.DataGridView();
            this.noFactura_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cliente_txt = new System.Windows.Forms.TextBox();
            this.desde_dtp = new System.Windows.Forms.DateTimePicker();
            this.hasta_dtp = new System.Windows.Forms.DateTimePicker();
            this.verDetalles_btn = new System.Windows.Forms.Button();
            this.buscarFactura_btn = new System.Windows.Forms.Button();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historialFacturas_dtg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta:";
            // 
            // activas_radiobtn
            // 
            this.activas_radiobtn.AutoSize = true;
            this.activas_radiobtn.Checked = true;
            this.activas_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activas_radiobtn.Location = new System.Drawing.Point(445, 92);
            this.activas_radiobtn.Margin = new System.Windows.Forms.Padding(4);
            this.activas_radiobtn.Name = "activas_radiobtn";
            this.activas_radiobtn.Size = new System.Drawing.Size(135, 18);
            this.activas_radiobtn.TabIndex = 9;
            this.activas_radiobtn.TabStop = true;
            this.activas_radiobtn.Text = "Facturas Activas";
            this.activas_radiobtn.UseVisualStyleBackColor = true;
            this.activas_radiobtn.CheckedChanged += new System.EventHandler(this.activas_radiobtn_CheckedChanged);
            // 
            // eliminadas_radiobtn
            // 
            this.eliminadas_radiobtn.AutoSize = true;
            this.eliminadas_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminadas_radiobtn.Location = new System.Drawing.Point(643, 92);
            this.eliminadas_radiobtn.Margin = new System.Windows.Forms.Padding(4);
            this.eliminadas_radiobtn.Name = "eliminadas_radiobtn";
            this.eliminadas_radiobtn.Size = new System.Drawing.Size(159, 18);
            this.eliminadas_radiobtn.TabIndex = 10;
            this.eliminadas_radiobtn.Text = "Facturas Canceladas";
            this.eliminadas_radiobtn.UseVisualStyleBackColor = true;
            this.eliminadas_radiobtn.CheckedChanged += new System.EventHandler(this.eliminadas_radiobtn_CheckedChanged);
            // 
            // historialFacturas_dtg
            // 
            this.historialFacturas_dtg.AllowUserToAddRows = false;
            this.historialFacturas_dtg.AllowUserToDeleteRows = false;
            this.historialFacturas_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historialFacturas_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.historialFacturas_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialFacturas_dtg.Location = new System.Drawing.Point(19, 225);
            this.historialFacturas_dtg.Margin = new System.Windows.Forms.Padding(4);
            this.historialFacturas_dtg.MultiSelect = false;
            this.historialFacturas_dtg.Name = "historialFacturas_dtg";
            this.historialFacturas_dtg.ReadOnly = true;
            this.historialFacturas_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historialFacturas_dtg.Size = new System.Drawing.Size(849, 245);
            this.historialFacturas_dtg.TabIndex = 12;
            // 
            // noFactura_txt
            // 
            this.noFactura_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noFactura_txt.Location = new System.Drawing.Point(105, 135);
            this.noFactura_txt.Margin = new System.Windows.Forms.Padding(4);
            this.noFactura_txt.Name = "noFactura_txt";
            this.noFactura_txt.Size = new System.Drawing.Size(157, 22);
            this.noFactura_txt.TabIndex = 13;
            this.noFactura_txt.Text = "0";
            this.noFactura_txt.TextChanged += new System.EventHandler(this.noFactura_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "No. Factura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cliente:";
            // 
            // cliente_txt
            // 
            this.cliente_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_txt.Location = new System.Drawing.Point(105, 178);
            this.cliente_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cliente_txt.Name = "cliente_txt";
            this.cliente_txt.Size = new System.Drawing.Size(157, 22);
            this.cliente_txt.TabIndex = 18;
            this.cliente_txt.TextChanged += new System.EventHandler(this.cliente_txt_TextChanged);
            // 
            // desde_dtp
            // 
            this.desde_dtp.CustomFormat = "dd/MM/yyyy";
            this.desde_dtp.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desde_dtp.Location = new System.Drawing.Point(105, 57);
            this.desde_dtp.Name = "desde_dtp";
            this.desde_dtp.Size = new System.Drawing.Size(107, 22);
            this.desde_dtp.TabIndex = 19;
            this.desde_dtp.Value = new System.DateTime(2017, 9, 15, 8, 0, 0, 0);
            this.desde_dtp.ValueChanged += new System.EventHandler(this.desde_dtp_ValueChanged);
            // 
            // hasta_dtp
            // 
            this.hasta_dtp.CustomFormat = "dd/MM/yyyy";
            this.hasta_dtp.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hasta_dtp.Location = new System.Drawing.Point(105, 94);
            this.hasta_dtp.Name = "hasta_dtp";
            this.hasta_dtp.Size = new System.Drawing.Size(107, 22);
            this.hasta_dtp.TabIndex = 20;
            this.hasta_dtp.Value = new System.DateTime(2017, 9, 15, 22, 0, 0, 0);
            this.hasta_dtp.ValueChanged += new System.EventHandler(this.desde_dtp_ValueChanged);
            // 
            // verDetalles_btn
            // 
            this.verDetalles_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.verDetalles_btn.FlatAppearance.BorderSize = 0;
            this.verDetalles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verDetalles_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verDetalles_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.verDetalles_btn.Image = global::SistemaFacturacion.Properties.Resources.ojo__1_;
            this.verDetalles_btn.Location = new System.Drawing.Point(532, 138);
            this.verDetalles_btn.Margin = new System.Windows.Forms.Padding(4);
            this.verDetalles_btn.Name = "verDetalles_btn";
            this.verDetalles_btn.Size = new System.Drawing.Size(157, 80);
            this.verDetalles_btn.TabIndex = 16;
            this.verDetalles_btn.Text = "Ver Detalles";
            this.verDetalles_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.verDetalles_btn.UseVisualStyleBackColor = false;
            this.verDetalles_btn.Click += new System.EventHandler(this.verDetalles_btn_Click);
            // 
            // buscarFactura_btn
            // 
            this.buscarFactura_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.buscarFactura_btn.FlatAppearance.BorderSize = 0;
            this.buscarFactura_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarFactura_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarFactura_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.buscarFactura_btn.Image = global::SistemaFacturacion.Properties.Resources.lupa_para_buscar__1_;
            this.buscarFactura_btn.Location = new System.Drawing.Point(353, 138);
            this.buscarFactura_btn.Margin = new System.Windows.Forms.Padding(4);
            this.buscarFactura_btn.Name = "buscarFactura_btn";
            this.buscarFactura_btn.Size = new System.Drawing.Size(157, 80);
            this.buscarFactura_btn.TabIndex = 15;
            this.buscarFactura_btn.Text = "Buscar";
            this.buscarFactura_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buscarFactura_btn.UseVisualStyleBackColor = false;
            this.buscarFactura_btn.Click += new System.EventHandler(this.buscarFactura_btn_Click);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.eliminar_btn.FlatAppearance.BorderSize = 0;
            this.eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.eliminar_btn.Image = global::SistemaFacturacion.Properties.Resources.actualizar_pagina_opcion;
            this.eliminar_btn.Location = new System.Drawing.Point(711, 138);
            this.eliminar_btn.Margin = new System.Windows.Forms.Padding(4);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(157, 80);
            this.eliminar_btn.TabIndex = 11;
            this.eliminar_btn.Text = "Cancelar Factura";
            this.eliminar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.eliminar_btn.UseVisualStyleBackColor = false;
            this.eliminar_btn.Click += new System.EventHandler(this.eliminar_btn_Click);
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
            this.panel3.Size = new System.Drawing.Size(893, 48);
            this.panel3.TabIndex = 91;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SistemaFacturacion.Properties.Resources.minimize__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(831, 3);
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
            this.button2.Location = new System.Drawing.Point(863, 3);
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
            this.label27.Size = new System.Drawing.Size(264, 24);
            this.label27.TabIndex = 28;
            this.label27.Text = "HISTORIAL FACTURAS";
            // 
            // HistorialFacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 485);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.hasta_dtp);
            this.Controls.Add(this.desde_dtp);
            this.Controls.Add(this.cliente_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.verDetalles_btn);
            this.Controls.Add(this.buscarFactura_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noFactura_txt);
            this.Controls.Add(this.historialFacturas_dtg);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.eliminadas_radiobtn);
            this.Controls.Add(this.activas_radiobtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HistorialFacturasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema Facturación";
            this.Load += new System.EventHandler(this.HistorialFacturasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historialFacturas_dtg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton activas_radiobtn;
        private System.Windows.Forms.RadioButton eliminadas_radiobtn;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.DataGridView historialFacturas_dtg;
        private System.Windows.Forms.TextBox noFactura_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buscarFactura_btn;
        private System.Windows.Forms.Button verDetalles_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cliente_txt;
        private System.Windows.Forms.DateTimePicker desde_dtp;
        private System.Windows.Forms.DateTimePicker hasta_dtp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
    }
}