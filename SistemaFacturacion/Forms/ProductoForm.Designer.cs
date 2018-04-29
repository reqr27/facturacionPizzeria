namespace SistemaFacturacion.Forms
{
    partial class ProductoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itbis_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.precio_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.costo_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.alerta_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tipoProducto_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unidad_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreProducto_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itbis_cb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.guardar_btn);
            this.groupBox1.Controls.Add(this.precio_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.costo_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.alerta_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tipoProducto_cb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.unidad_cb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nombreProducto_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 364);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Producto";
            // 
            // itbis_cb
            // 
            this.itbis_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itbis_cb.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itbis_cb.FormattingEnabled = true;
            this.itbis_cb.Location = new System.Drawing.Point(134, 232);
            this.itbis_cb.Name = "itbis_cb";
            this.itbis_cb.Size = new System.Drawing.Size(85, 22);
            this.itbis_cb.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Itbis: ";
            // 
            // guardar_btn
            // 
            this.guardar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.guardar_btn.FlatAppearance.BorderSize = 0;
            this.guardar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar_btn.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.guardar_btn.Image = global::SistemaFacturacion.Properties.Resources.guardar;
            this.guardar_btn.Location = new System.Drawing.Point(100, 290);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(185, 45);
            this.guardar_btn.TabIndex = 8;
            this.guardar_btn.Text = "Guardar Cambios";
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardar_btn.UseVisualStyleBackColor = false;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // precio_txt
            // 
            this.precio_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_txt.Location = new System.Drawing.Point(134, 200);
            this.precio_txt.Name = "precio_txt";
            this.precio_txt.Size = new System.Drawing.Size(232, 22);
            this.precio_txt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Precio Total($RD):";
            // 
            // costo_txt
            // 
            this.costo_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo_txt.Location = new System.Drawing.Point(134, 170);
            this.costo_txt.Name = "costo_txt";
            this.costo_txt.Size = new System.Drawing.Size(232, 22);
            this.costo_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Costo ($RD):";
            // 
            // alerta_txt
            // 
            this.alerta_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alerta_txt.Location = new System.Drawing.Point(134, 136);
            this.alerta_txt.Name = "alerta_txt";
            this.alerta_txt.Size = new System.Drawing.Size(232, 22);
            this.alerta_txt.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Alerta Existencia:";
            // 
            // tipoProducto_cb
            // 
            this.tipoProducto_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoProducto_cb.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoProducto_cb.FormattingEnabled = true;
            this.tipoProducto_cb.Location = new System.Drawing.Point(134, 68);
            this.tipoProducto_cb.Name = "tipoProducto_cb";
            this.tipoProducto_cb.Size = new System.Drawing.Size(232, 22);
            this.tipoProducto_cb.TabIndex = 2;
            this.tipoProducto_cb.DropDown += new System.EventHandler(this.tipoProducto_cb_DropDown);
            this.tipoProducto_cb.SelectedIndexChanged += new System.EventHandler(this.tipoProducto_cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Producto:";
            // 
            // unidad_cb
            // 
            this.unidad_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unidad_cb.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidad_cb.FormattingEnabled = true;
            this.unidad_cb.Location = new System.Drawing.Point(134, 100);
            this.unidad_cb.Name = "unidad_cb";
            this.unidad_cb.Size = new System.Drawing.Size(232, 22);
            this.unidad_cb.TabIndex = 3;
            this.unidad_cb.DropDown += new System.EventHandler(this.unidad_cb_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidad: ";
            // 
            // nombreProducto_txt
            // 
            this.nombreProducto_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProducto_txt.Location = new System.Drawing.Point(136, 36);
            this.nombreProducto_txt.Name = "nombreProducto_txt";
            this.nombreProducto_txt.Size = new System.Drawing.Size(230, 22);
            this.nombreProducto_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Producto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(414, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 364);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos Registrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(528, 317);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.panel3.Size = new System.Drawing.Size(985, 48);
            this.panel3.TabIndex = 91;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SistemaFacturacion.Properties.Resources.minimize__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(919, 3);
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
            this.button2.Location = new System.Drawing.Point(951, 3);
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
            this.label27.Size = new System.Drawing.Size(190, 24);
            this.label27.TabIndex = 28;
            this.label27.Text = "Buscar Producto";
            // 
            // ProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 448);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.ProductoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tipoProducto_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox unidad_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreProducto_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.TextBox precio_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox costo_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox alerta_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox itbis_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
    }
}