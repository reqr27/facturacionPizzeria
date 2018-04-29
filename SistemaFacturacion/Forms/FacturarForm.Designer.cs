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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturarForm));
            this.Orden = new System.Windows.Forms.GroupBox();
            this.orden_dtg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.devuelta_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.efectivo_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.numeroFactura_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.crear_factura_btn = new System.Windows.Forms.Button();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.cliente_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Orden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_dtg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Orden
            // 
            this.Orden.Controls.Add(this.orden_dtg);
            this.Orden.Controls.Add(this.panel1);
            this.Orden.Controls.Add(this.numeroFactura_txt);
            this.Orden.Controls.Add(this.label5);
            this.Orden.Controls.Add(this.crear_factura_btn);
            this.Orden.Controls.Add(this.eliminar_btn);
            this.Orden.Controls.Add(this.cliente_txt);
            this.Orden.Controls.Add(this.label3);
            this.Orden.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orden.Location = new System.Drawing.Point(12, 12);
            this.Orden.Name = "Orden";
            this.Orden.Size = new System.Drawing.Size(474, 419);
            this.Orden.TabIndex = 1;
            this.Orden.TabStop = false;
            this.Orden.Text = "Orden";
            // 
            // orden_dtg
            // 
            this.orden_dtg.Location = new System.Drawing.Point(6, 62);
            this.orden_dtg.MultiSelect = false;
            this.orden_dtg.Name = "orden_dtg";
            this.orden_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orden_dtg.Size = new System.Drawing.Size(455, 224);
            this.orden_dtg.TabIndex = 10;
            this.orden_dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orden_dtg_CellClick);
            this.orden_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orden_dtg_CellDoubleClick);
            this.orden_dtg.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.orden_dtg_CellEndEdit);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.devuelta_lbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.efectivo_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.total_lbl);
            this.panel1.Location = new System.Drawing.Point(6, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 115);
            this.panel1.TabIndex = 10;
            // 
            // devuelta_lbl
            // 
            this.devuelta_lbl.AutoSize = true;
            this.devuelta_lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devuelta_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.devuelta_lbl.Location = new System.Drawing.Point(143, 67);
            this.devuelta_lbl.Name = "devuelta_lbl";
            this.devuelta_lbl.Size = new System.Drawing.Size(38, 22);
            this.devuelta_lbl.TabIndex = 9;
            this.devuelta_lbl.Text = "dev";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Devuelta($RD): ";
            // 
            // efectivo_txt
            // 
            this.efectivo_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivo_txt.Location = new System.Drawing.Point(147, 35);
            this.efectivo_txt.Name = "efectivo_txt";
            this.efectivo_txt.Size = new System.Drawing.Size(100, 29);
            this.efectivo_txt.TabIndex = 7;
            this.efectivo_txt.TextChanged += new System.EventHandler(this.efectivo_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Efectivo($RD): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
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
            this.total_lbl.Location = new System.Drawing.Point(143, 10);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(47, 22);
            this.total_lbl.TabIndex = 5;
            this.total_lbl.Text = "total";
            // 
            // numeroFactura_txt
            // 
            this.numeroFactura_txt.Enabled = false;
            this.numeroFactura_txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroFactura_txt.Location = new System.Drawing.Point(95, 24);
            this.numeroFactura_txt.Name = "numeroFactura_txt";
            this.numeroFactura_txt.Size = new System.Drawing.Size(79, 22);
            this.numeroFactura_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "No. Factura: ";
            // 
            // crear_factura_btn
            // 
            this.crear_factura_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear_factura_btn.Image = global::SistemaFacturacion.Properties.Resources.efectivo;
            this.crear_factura_btn.Location = new System.Drawing.Point(335, 292);
            this.crear_factura_btn.Name = "crear_factura_btn";
            this.crear_factura_btn.Size = new System.Drawing.Size(126, 115);
            this.crear_factura_btn.TabIndex = 7;
            this.crear_factura_btn.Text = "Facturar";
            this.crear_factura_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.crear_factura_btn.UseVisualStyleBackColor = true;
            this.crear_factura_btn.Click += new System.EventHandler(this.crear_factura_btn_Click);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_btn.Image = global::SistemaFacturacion.Properties.Resources.eliminar;
            this.eliminar_btn.Location = new System.Drawing.Point(417, 17);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(38, 32);
            this.eliminar_btn.TabIndex = 6;
            this.eliminar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eliminar_btn.UseVisualStyleBackColor = true;
            this.eliminar_btn.Click += new System.EventHandler(this.eliminar_btn_Click);
            // 
            // cliente_txt
            // 
            this.cliente_txt.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_txt.Location = new System.Drawing.Point(306, 21);
            this.cliente_txt.Name = "cliente_txt";
            this.cliente_txt.Size = new System.Drawing.Size(109, 24);
            this.cliente_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre/Mesa:";
            // 
            // FacturarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 449);
            this.Controls.Add(this.Orden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FacturarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Facturación";
            this.Load += new System.EventHandler(this.FacturarForm_Load);
            this.Orden.ResumeLayout(false);
            this.Orden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_dtg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Orden;
        private System.Windows.Forms.TextBox cliente_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button crear_factura_btn;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.TextBox numeroFactura_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label devuelta_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox efectivo_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView orden_dtg;
    }
}