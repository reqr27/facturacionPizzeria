namespace SistemaFacturacion.Forms
{
    partial class EntradaProductosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaProductosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.proveedor_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.costo_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.unidad2_lbl = new System.Windows.Forms.Label();
            this.cantidadEntrada_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unidad_lbl = new System.Windows.Forms.Label();
            this.existenciaActual_txt = new System.Windows.Forms.TextBox();
            this.producto_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.entrada_radiobtn = new System.Windows.Forms.RadioButton();
            this.salida_radiobtn = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada/Salida Productos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 323);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fecha:";
            // 
            // buscar_btn
            // 
            this.buscar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.buscar_btn.FlatAppearance.BorderSize = 0;
            this.buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.buscar_btn.Image = global::SistemaFacturacion.Properties.Resources.lupa_para_buscar__1_;
            this.buscar_btn.Location = new System.Drawing.Point(12, 93);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Size = new System.Drawing.Size(157, 56);
            this.buscar_btn.TabIndex = 18;
            this.buscar_btn.Text = "Buscar Producto";
            this.buscar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscar_btn.UseVisualStyleBackColor = false;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // proveedor_txt
            // 
            this.proveedor_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.proveedor_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.proveedor_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedor_txt.Location = new System.Drawing.Point(160, 293);
            this.proveedor_txt.Name = "proveedor_txt";
            this.proveedor_txt.Size = new System.Drawing.Size(216, 22);
            this.proveedor_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "Suplidor:";
            // 
            // guardar_btn
            // 
            this.guardar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.guardar_btn.FlatAppearance.BorderSize = 0;
            this.guardar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.guardar_btn.Image = global::SistemaFacturacion.Properties.Resources.portafolios_con_lapiz__1_;
            this.guardar_btn.Location = new System.Drawing.Point(169, 373);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(157, 45);
            this.guardar_btn.TabIndex = 7;
            this.guardar_btn.Text = "Registrar";
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar_btn.UseVisualStyleBackColor = false;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // costo_txt
            // 
            this.costo_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo_txt.Location = new System.Drawing.Point(160, 258);
            this.costo_txt.Name = "costo_txt";
            this.costo_txt.Size = new System.Drawing.Size(72, 22);
            this.costo_txt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Costo ($RD) :";
            // 
            // unidad2_lbl
            // 
            this.unidad2_lbl.AutoSize = true;
            this.unidad2_lbl.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidad2_lbl.Location = new System.Drawing.Point(238, 230);
            this.unidad2_lbl.Name = "unidad2_lbl";
            this.unidad2_lbl.Size = new System.Drawing.Size(0, 14);
            this.unidad2_lbl.TabIndex = 14;
            // 
            // cantidadEntrada_txt
            // 
            this.cantidadEntrada_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadEntrada_txt.Location = new System.Drawing.Point(160, 227);
            this.cantidadEntrada_txt.Name = "cantidadEntrada_txt";
            this.cantidadEntrada_txt.Size = new System.Drawing.Size(72, 22);
            this.cantidadEntrada_txt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad :";
            // 
            // unidad_lbl
            // 
            this.unidad_lbl.AutoSize = true;
            this.unidad_lbl.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidad_lbl.Location = new System.Drawing.Point(238, 199);
            this.unidad_lbl.Name = "unidad_lbl";
            this.unidad_lbl.Size = new System.Drawing.Size(0, 14);
            this.unidad_lbl.TabIndex = 11;
            // 
            // existenciaActual_txt
            // 
            this.existenciaActual_txt.Enabled = false;
            this.existenciaActual_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existenciaActual_txt.Location = new System.Drawing.Point(160, 196);
            this.existenciaActual_txt.Name = "existenciaActual_txt";
            this.existenciaActual_txt.Size = new System.Drawing.Size(72, 22);
            this.existenciaActual_txt.TabIndex = 2;
            // 
            // producto_txt
            // 
            this.producto_txt.Enabled = false;
            this.producto_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto_txt.Location = new System.Drawing.Point(160, 165);
            this.producto_txt.Name = "producto_txt";
            this.producto_txt.Size = new System.Drawing.Size(196, 22);
            this.producto_txt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Existencia Actual:";
            // 
            // entrada_radiobtn
            // 
            this.entrada_radiobtn.AutoSize = true;
            this.entrada_radiobtn.Checked = true;
            this.entrada_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrada_radiobtn.Location = new System.Drawing.Point(121, 54);
            this.entrada_radiobtn.Name = "entrada_radiobtn";
            this.entrada_radiobtn.Size = new System.Drawing.Size(111, 23);
            this.entrada_radiobtn.TabIndex = 11;
            this.entrada_radiobtn.TabStop = true;
            this.entrada_radiobtn.Text = "ENTRADA";
            this.entrada_radiobtn.UseVisualStyleBackColor = true;
            this.entrada_radiobtn.Click += new System.EventHandler(this.entrada_radiobtn_Click);
            // 
            // salida_radiobtn
            // 
            this.salida_radiobtn.AutoSize = true;
            this.salida_radiobtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salida_radiobtn.Location = new System.Drawing.Point(296, 54);
            this.salida_radiobtn.Name = "salida_radiobtn";
            this.salida_radiobtn.Size = new System.Drawing.Size(91, 23);
            this.salida_radiobtn.TabIndex = 12;
            this.salida_radiobtn.Text = "SALIDA";
            this.salida_radiobtn.UseVisualStyleBackColor = true;
            this.salida_radiobtn.Click += new System.EventHandler(this.salida_radiobtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 48);
            this.panel2.TabIndex = 29;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SistemaFacturacion.Properties.Resources.minimize__1_;
            this.button3.Location = new System.Drawing.Point(429, 3);
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
            this.button2.Location = new System.Drawing.Point(461, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 32;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EntradaProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 439);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salida_radiobtn);
            this.Controls.Add(this.buscar_btn);
            this.Controls.Add(this.proveedor_txt);
            this.Controls.Add(this.entrada_radiobtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costo_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.producto_txt);
            this.Controls.Add(this.unidad2_lbl);
            this.Controls.Add(this.existenciaActual_txt);
            this.Controls.Add(this.cantidadEntrada_txt);
            this.Controls.Add(this.unidad_lbl);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntradaProductosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrada Productos";
            this.Load += new System.EventHandler(this.EntradaProductosForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.TextBox costo_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label unidad2_lbl;
        private System.Windows.Forms.TextBox cantidadEntrada_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label unidad_lbl;
        private System.Windows.Forms.TextBox existenciaActual_txt;
        private System.Windows.Forms.TextBox producto_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.TextBox proveedor_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton entrada_radiobtn;
        private System.Windows.Forms.RadioButton salida_radiobtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}