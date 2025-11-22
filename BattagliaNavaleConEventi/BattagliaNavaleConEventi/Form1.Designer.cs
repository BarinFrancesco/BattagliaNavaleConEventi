namespace BattagliaNavaleConEventi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grd_Playground = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Playground)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Playground
            // 
            this.grd_Playground.AllowUserToAddRows = false;
            this.grd_Playground.AllowUserToDeleteRows = false;
            this.grd_Playground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Playground.ColumnHeadersVisible = false;
            this.grd_Playground.Location = new System.Drawing.Point(107, 3);
            this.grd_Playground.Name = "grd_Playground";
            this.grd_Playground.ReadOnly = true;
            this.grd_Playground.RowHeadersVisible = false;
            this.grd_Playground.Size = new System.Drawing.Size(400, 400);
            this.grd_Playground.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd_Playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Playground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Playground;
    }
}

