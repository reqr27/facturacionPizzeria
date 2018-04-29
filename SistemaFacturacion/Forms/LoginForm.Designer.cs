namespace SistemaFacturacion.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.clave_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.salir_btn = new System.Windows.Forms.Button();
            this.entrar_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistema Facturación";
            // 
            // usuario_txt
            // 
            this.usuario_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_txt.Location = new System.Drawing.Point(257, 115);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(209, 29);
            this.usuario_txt.TabIndex = 8;
            this.usuario_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usuario_txt_KeyDown);
            // 
            // clave_txt
            // 
            this.clave_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_txt.Location = new System.Drawing.Point(257, 185);
            this.clave_txt.Name = "clave_txt";
            this.clave_txt.PasswordChar = '*';
            this.clave_txt.Size = new System.Drawing.Size(209, 29);
            this.clave_txt.TabIndex = 9;
            this.clave_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clave_txt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Inicio de Sesión";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 58);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::SistemaFacturacion.Properties.Resources.error;
            this.pictureBox3.Location = new System.Drawing.Point(636, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // salir_btn
            // 
            this.salir_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.salir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.salir_btn.Image = global::SistemaFacturacion.Properties.Resources.salida__1_;
            this.salir_btn.Location = new System.Drawing.Point(382, 246);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(88, 51);
            this.salir_btn.TabIndex = 11;
            this.salir_btn.UseVisualStyleBackColor = false;
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // entrar_btn
            // 
            this.entrar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.entrar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.entrar_btn.Image = global::SistemaFacturacion.Properties.Resources.entrar;
            this.entrar_btn.Location = new System.Drawing.Point(202, 246);
            this.entrar_btn.Name = "entrar_btn";
            this.entrar_btn.Size = new System.Drawing.Size(96, 51);
            this.entrar_btn.TabIndex = 10;
            this.entrar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.entrar_btn.UseVisualStyleBackColor = false;
            this.entrar_btn.Click += new System.EventHandler(this.entrar_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaFacturacion.Properties.Resources.llave_de_una_casa;
            this.pictureBox2.Location = new System.Drawing.Point(202, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 37);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaFacturacion.Properties.Resources.usuario_hombre;
            this.pictureBox1.Location = new System.Drawing.Point(202, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 313);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.entrar_btn);
            this.Controls.Add(this.clave_txt);
            this.Controls.Add(this.usuario_txt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Facturación Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.TextBox clave_txt;
        private System.Windows.Forms.Button entrar_btn;
        private System.Windows.Forms.Button salir_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}