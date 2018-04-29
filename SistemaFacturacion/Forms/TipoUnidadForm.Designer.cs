namespace SistemaFacturacion.Forms
{
    partial class TipoUnidadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoUnidadForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unidad_txt = new System.Windows.Forms.TextBox();
            this.Descripción = new System.Windows.Forms.Label();
            this.descripcion_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guardarUnidad_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "AGREGAR/EDITAR UNIDADES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unidad_txt
            // 
            this.unidad_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidad_txt.Location = new System.Drawing.Point(141, 56);
            this.unidad_txt.Name = "unidad_txt";
            this.unidad_txt.Size = new System.Drawing.Size(213, 24);
            this.unidad_txt.TabIndex = 2;
            // 
            // Descripción
            // 
            this.Descripción.AutoSize = true;
            this.Descripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripción.Location = new System.Drawing.Point(29, 110);
            this.Descripción.Name = "Descripción";
            this.Descripción.Size = new System.Drawing.Size(103, 18);
            this.Descripción.TabIndex = 3;
            this.Descripción.Text = "Descripción:";
            // 
            // descripcion_txt
            // 
            this.descripcion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_txt.Location = new System.Drawing.Point(141, 110);
            this.descripcion_txt.Name = "descripcion_txt";
            this.descripcion_txt.Size = new System.Drawing.Size(213, 24);
            this.descripcion_txt.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(439, 165);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // guardarUnidad_btn
            // 
            this.guardarUnidad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarUnidad_btn.Image = global::SistemaFacturacion.Properties.Resources.guardar;
            this.guardarUnidad_btn.Location = new System.Drawing.Point(141, 150);
            this.guardarUnidad_btn.Name = "guardarUnidad_btn";
            this.guardarUnidad_btn.Size = new System.Drawing.Size(213, 45);
            this.guardarUnidad_btn.TabIndex = 6;
            this.guardarUnidad_btn.Text = "Registrar Cambios";
            this.guardarUnidad_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardarUnidad_btn.UseVisualStyleBackColor = true;
            this.guardarUnidad_btn.Click += new System.EventHandler(this.guardarUnidad_btn_Click);
            // 
            // TipoUnidadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 389);
            this.Controls.Add(this.guardarUnidad_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.descripcion_txt);
            this.Controls.Add(this.Descripción);
            this.Controls.Add(this.unidad_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoUnidadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TIPOS DE UNIDADES";
            this.Load += new System.EventHandler(this.TipoUnidadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unidad_txt;
        private System.Windows.Forms.Label Descripción;
        private System.Windows.Forms.TextBox descripcion_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guardarUnidad_btn;
    }
}