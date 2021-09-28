
namespace CapaVista.Forms_Extras
{
    partial class formCatalogos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgridExistencias = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridExistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalogos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgridExistencias
            // 
            this.dgridExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridExistencias.Location = new System.Drawing.Point(62, 159);
            this.dgridExistencias.Name = "dgridExistencias";
            this.dgridExistencias.RowHeadersWidth = 51;
            this.dgridExistencias.RowTemplate.Height = 24;
            this.dgridExistencias.Size = new System.Drawing.Size(676, 307);
            this.dgridExistencias.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto en existencia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // formCatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgridExistencias);
            this.Controls.Add(this.label1);
            this.Name = "formCatalogos";
            this.Text = "formCatalogos";
            this.Load += new System.EventHandler(this.formCatalogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridExistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgridExistencias;
        private System.Windows.Forms.Label label3;
    }
}