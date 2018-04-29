namespace SistemaFacturacion.Forms
{
    partial class ConfiguracionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracionesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.usuarios_btn = new System.Windows.Forms.Button();
            this.componentesProducto_btn = new System.Windows.Forms.Button();
            this.agregarProducto_btn = new System.Windows.Forms.Button();
            this.agragarTipoUnidad_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 48);
            this.panel1.TabIndex = 28;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label27.Location = new System.Drawing.Point(12, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(164, 24);
            this.label27.TabIndex = 29;
            this.label27.Text = "Configuración";
            // 
            // usuarios_btn
            // 
            this.usuarios_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.usuarios_btn.FlatAppearance.BorderSize = 0;
            this.usuarios_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuarios_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarios_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usuarios_btn.Image = global::SistemaFacturacion.Properties.Resources.users;
            this.usuarios_btn.Location = new System.Drawing.Point(208, 210);
            this.usuarios_btn.Margin = new System.Windows.Forms.Padding(4);
            this.usuarios_btn.Name = "usuarios_btn";
            this.usuarios_btn.Size = new System.Drawing.Size(186, 147);
            this.usuarios_btn.TabIndex = 32;
            this.usuarios_btn.Text = "Usuarios";
            this.usuarios_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.usuarios_btn.UseVisualStyleBackColor = false;
            this.usuarios_btn.Click += new System.EventHandler(this.usuarios_btn_Click);
            // 
            // componentesProducto_btn
            // 
            this.componentesProducto_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.componentesProducto_btn.FlatAppearance.BorderSize = 0;
            this.componentesProducto_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.componentesProducto_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentesProducto_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.componentesProducto_btn.Image = global::SistemaFacturacion.Properties.Resources.recipe;
            this.componentesProducto_btn.Location = new System.Drawing.Point(13, 210);
            this.componentesProducto_btn.Margin = new System.Windows.Forms.Padding(4);
            this.componentesProducto_btn.Name = "componentesProducto_btn";
            this.componentesProducto_btn.Size = new System.Drawing.Size(186, 147);
            this.componentesProducto_btn.TabIndex = 31;
            this.componentesProducto_btn.Text = "Componentes Productos";
            this.componentesProducto_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.componentesProducto_btn.UseVisualStyleBackColor = false;
            this.componentesProducto_btn.Click += new System.EventHandler(this.componentesProducto_btn_Click);
            // 
            // agregarProducto_btn
            // 
            this.agregarProducto_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.agregarProducto_btn.FlatAppearance.BorderSize = 0;
            this.agregarProducto_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarProducto_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarProducto_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.agregarProducto_btn.Image = global::SistemaFacturacion.Properties.Resources.pizza1;
            this.agregarProducto_btn.Location = new System.Drawing.Point(13, 55);
            this.agregarProducto_btn.Margin = new System.Windows.Forms.Padding(4);
            this.agregarProducto_btn.Name = "agregarProducto_btn";
            this.agregarProducto_btn.Size = new System.Drawing.Size(186, 147);
            this.agregarProducto_btn.TabIndex = 29;
            this.agregarProducto_btn.Text = "Productos";
            this.agregarProducto_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.agregarProducto_btn.UseVisualStyleBackColor = false;
            this.agregarProducto_btn.Click += new System.EventHandler(this.agregarProducto_btn_Click);
            // 
            // agragarTipoUnidad_btn
            // 
            this.agragarTipoUnidad_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.agragarTipoUnidad_btn.FlatAppearance.BorderSize = 0;
            this.agragarTipoUnidad_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agragarTipoUnidad_btn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agragarTipoUnidad_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.agragarTipoUnidad_btn.Image = global::SistemaFacturacion.Properties.Resources.kilograms;
            this.agragarTipoUnidad_btn.Location = new System.Drawing.Point(208, 55);
            this.agragarTipoUnidad_btn.Margin = new System.Windows.Forms.Padding(4);
            this.agragarTipoUnidad_btn.Name = "agragarTipoUnidad_btn";
            this.agragarTipoUnidad_btn.Size = new System.Drawing.Size(187, 147);
            this.agragarTipoUnidad_btn.TabIndex = 30;
            this.agragarTipoUnidad_btn.Text = "Unidades";
            this.agragarTipoUnidad_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.agragarTipoUnidad_btn.UseVisualStyleBackColor = false;
            this.agragarTipoUnidad_btn.Click += new System.EventHandler(this.agragarTipoUnidad_btn_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SistemaFacturacion.Properties.Resources.minimize__1_;
            this.button3.Location = new System.Drawing.Point(354, 3);
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
            this.button2.Location = new System.Drawing.Point(386, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 32;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConfiguracionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 385);
            this.Controls.Add(this.usuarios_btn);
            this.Controls.Add(this.componentesProducto_btn);
            this.Controls.Add(this.agregarProducto_btn);
            this.Controls.Add(this.agragarTipoUnidad_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfiguracionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguracionesForm";
            this.Load += new System.EventHandler(this.ConfiguracionesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button componentesProducto_btn;
        private System.Windows.Forms.Button agregarProducto_btn;
        private System.Windows.Forms.Button agragarTipoUnidad_btn;
        private System.Windows.Forms.Button usuarios_btn;
    }
}