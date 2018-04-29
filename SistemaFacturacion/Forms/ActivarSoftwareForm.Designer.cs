namespace SistemaFacturacion.Forms
{
    partial class ActivarSoftwareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivarSoftwareForm));
            this.activado_lbl = new System.Windows.Forms.Label();
            this.activar_btn = new System.Windows.Forms.Button();
            this.sn_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activado_lbl
            // 
            this.activado_lbl.AutoSize = true;
            this.activado_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activado_lbl.Location = new System.Drawing.Point(29, 56);
            this.activado_lbl.Name = "activado_lbl";
            this.activado_lbl.Size = new System.Drawing.Size(281, 25);
            this.activado_lbl.TabIndex = 7;
            this.activado_lbl.Text = "Software ya fue Activado!";
            this.activado_lbl.Visible = false;
            // 
            // activar_btn
            // 
            this.activar_btn.BackColor = System.Drawing.SystemColors.Info;
            this.activar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.activar_btn.FlatAppearance.BorderSize = 2;
            this.activar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activar_btn.Location = new System.Drawing.Point(120, 84);
            this.activar_btn.Name = "activar_btn";
            this.activar_btn.Size = new System.Drawing.Size(100, 41);
            this.activar_btn.TabIndex = 6;
            this.activar_btn.Text = "ACTIVAR SOFTWARE";
            this.activar_btn.UseVisualStyleBackColor = false;
            this.activar_btn.Click += new System.EventHandler(this.activar_btn_Click);
            // 
            // sn_txt
            // 
            this.sn_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sn_txt.Location = new System.Drawing.Point(155, 27);
            this.sn_txt.Name = "sn_txt";
            this.sn_txt.PasswordChar = '*';
            this.sn_txt.Size = new System.Drawing.Size(171, 26);
            this.sn_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CODIGO ACTIVACION:";
            // 
            // ActivarSoftwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 155);
            this.Controls.Add(this.activado_lbl);
            this.Controls.Add(this.activar_btn);
            this.Controls.Add(this.sn_txt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActivarSoftwareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Facturación";
            this.Load += new System.EventHandler(this.ActivarSoftwareForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activado_lbl;
        private System.Windows.Forms.Button activar_btn;
        private System.Windows.Forms.TextBox sn_txt;
        private System.Windows.Forms.Label label1;
    }
}