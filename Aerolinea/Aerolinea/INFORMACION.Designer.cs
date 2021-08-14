namespace Aerolinea
{
    partial class INFORMACION
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
            this.DgInformación = new System.Windows.Forms.DataGridView();
            this.Label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgInformación)).BeginInit();
            this.SuspendLayout();
            // 
            // DgInformación
            // 
            this.DgInformación.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgInformación.Location = new System.Drawing.Point(12, 81);
            this.DgInformación.Name = "DgInformación";
            this.DgInformación.Size = new System.Drawing.Size(743, 150);
            this.DgInformación.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(241, 43);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(266, 25);
            this.Label6.TabIndex = 141;
            this.Label6.Text = "Registro de Datos General";
            // 
            // INFORMACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 347);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.DgInformación);
            this.Name = "INFORMACION";
            this.Text = "INFORMACION";
            this.Load += new System.EventHandler(this.INFORMACION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgInformación)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DgInformación;
        internal System.Windows.Forms.Label Label6;
    }
}