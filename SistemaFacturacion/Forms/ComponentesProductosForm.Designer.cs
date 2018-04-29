namespace SistemaFacturacion.Forms
{
    partial class ComponentesProductosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentesProductosForm));
            this.productoTerminado_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ingrediente_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidad_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unidad_lbl = new System.Windows.Forms.Label();
            this.componentes_dtg = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.producto_lbl = new System.Windows.Forms.Label();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.cancelarEditar_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.componentes_dtg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // productoTerminado_cb
            // 
            this.productoTerminado_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productoTerminado_cb.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoTerminado_cb.FormattingEnabled = true;
            this.productoTerminado_cb.Location = new System.Drawing.Point(105, 92);
            this.productoTerminado_cb.Name = "productoTerminado_cb";
            this.productoTerminado_cb.Size = new System.Drawing.Size(238, 22);
            this.productoTerminado_cb.TabIndex = 7;
            this.productoTerminado_cb.SelectedValueChanged += new System.EventHandler(this.productoTerminado_cb_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Producto:";
            // 
            // ingrediente_cb
            // 
            this.ingrediente_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ingrediente_cb.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingrediente_cb.FormattingEnabled = true;
            this.ingrediente_cb.Location = new System.Drawing.Point(105, 127);
            this.ingrediente_cb.Name = "ingrediente_cb";
            this.ingrediente_cb.Size = new System.Drawing.Size(238, 22);
            this.ingrediente_cb.TabIndex = 9;
            this.ingrediente_cb.SelectedValueChanged += new System.EventHandler(this.ingrediente_cb_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrediente:";
            // 
            // cantidad_txt
            // 
            this.cantidad_txt.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_txt.Location = new System.Drawing.Point(105, 166);
            this.cantidad_txt.Name = "cantidad_txt";
            this.cantidad_txt.Size = new System.Drawing.Size(182, 22);
            this.cantidad_txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad:";
            // 
            // unidad_lbl
            // 
            this.unidad_lbl.AutoSize = true;
            this.unidad_lbl.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidad_lbl.Location = new System.Drawing.Point(293, 177);
            this.unidad_lbl.Name = "unidad_lbl";
            this.unidad_lbl.Size = new System.Drawing.Size(0, 14);
            this.unidad_lbl.TabIndex = 11;
            // 
            // componentes_dtg
            // 
            this.componentes_dtg.AllowUserToAddRows = false;
            this.componentes_dtg.AllowUserToDeleteRows = false;
            this.componentes_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.componentes_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentes_dtg.Location = new System.Drawing.Point(365, 141);
            this.componentes_dtg.Name = "componentes_dtg";
            this.componentes_dtg.ReadOnly = true;
            this.componentes_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.componentes_dtg.Size = new System.Drawing.Size(375, 156);
            this.componentes_dtg.TabIndex = 13;
            this.componentes_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.componentes_dtg_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingredientes Producto:";
            // 
            // producto_lbl
            // 
            this.producto_lbl.AutoSize = true;
            this.producto_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto_lbl.Location = new System.Drawing.Point(361, 92);
            this.producto_lbl.Name = "producto_lbl";
            this.producto_lbl.Size = new System.Drawing.Size(0, 16);
            this.producto_lbl.TabIndex = 15;
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.eliminar_btn.FlatAppearance.BorderSize = 0;
            this.eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.eliminar_btn.Image = global::SistemaFacturacion.Properties.Resources.eliminar;
            this.eliminar_btn.Location = new System.Drawing.Point(642, 107);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(98, 28);
            this.eliminar_btn.TabIndex = 17;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eliminar_btn.UseVisualStyleBackColor = false;
            this.eliminar_btn.Click += new System.EventHandler(this.eliminar_btn_Click);
            // 
            // cancelarEditar_btn
            // 
            this.cancelarEditar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.cancelarEditar_btn.Enabled = false;
            this.cancelarEditar_btn.FlatAppearance.BorderSize = 0;
            this.cancelarEditar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarEditar_btn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarEditar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelarEditar_btn.Image = global::SistemaFacturacion.Properties.Resources.boton_x;
            this.cancelarEditar_btn.Location = new System.Drawing.Point(194, 237);
            this.cancelarEditar_btn.Name = "cancelarEditar_btn";
            this.cancelarEditar_btn.Size = new System.Drawing.Size(149, 60);
            this.cancelarEditar_btn.TabIndex = 16;
            this.cancelarEditar_btn.Text = "Cancelar Editar";
            this.cancelarEditar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cancelarEditar_btn.UseVisualStyleBackColor = false;
            this.cancelarEditar_btn.Click += new System.EventHandler(this.cancelarEditar_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::SistemaFacturacion.Properties.Resources.anadir;
            this.button1.Location = new System.Drawing.Point(16, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "Añadir";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel3.Size = new System.Drawing.Size(751, 48);
            this.panel3.TabIndex = 91;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SistemaFacturacion.Properties.Resources.minimize__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(686, 3);
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
            this.button2.Location = new System.Drawing.Point(718, 3);
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
            this.label27.Size = new System.Drawing.Size(332, 24);
            this.label27.TabIndex = 28;
            this.label27.Text = "COMPONENTES PRODUCTOS";
            // 
            // ComponentesProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 315);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.cancelarEditar_btn);
            this.Controls.Add(this.producto_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.componentes_dtg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unidad_lbl);
            this.Controls.Add(this.productoTerminado_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ingrediente_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidad_txt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComponentesProductosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Facturación";
            this.Load += new System.EventHandler(this.ComponentesProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.componentes_dtg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox productoTerminado_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ingrediente_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cantidad_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label unidad_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView componentes_dtg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label producto_lbl;
        private System.Windows.Forms.Button cancelarEditar_btn;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
    }
}