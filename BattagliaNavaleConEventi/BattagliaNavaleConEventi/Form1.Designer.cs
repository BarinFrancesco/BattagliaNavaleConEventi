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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grd_Playground = new System.Windows.Forms.DataGridView();
            this.btn_Rotate = new System.Windows.Forms.Button();
            this.Img_Direction = new System.Windows.Forms.PictureBox();
            this.Lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Playground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Direction)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Playground
            // 
            this.grd_Playground.AllowUserToAddRows = false;
            this.grd_Playground.AllowUserToDeleteRows = false;
            this.grd_Playground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Playground.ColumnHeadersVisible = false;
            this.grd_Playground.Location = new System.Drawing.Point(143, 4);
            this.grd_Playground.Margin = new System.Windows.Forms.Padding(4);
            this.grd_Playground.Name = "grd_Playground";
            this.grd_Playground.ReadOnly = true;
            this.grd_Playground.RowHeadersVisible = false;
            this.grd_Playground.RowHeadersWidth = 51;
            this.grd_Playground.Size = new System.Drawing.Size(533, 492);
            this.grd_Playground.TabIndex = 0;
            // 
            // btn_Rotate
            // 
            this.btn_Rotate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Rotate.BackgroundImage")));
            this.btn_Rotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rotate.Location = new System.Drawing.Point(720, 118);
            this.btn_Rotate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Rotate.Name = "btn_Rotate";
            this.btn_Rotate.Size = new System.Drawing.Size(100, 92);
            this.btn_Rotate.TabIndex = 1;
            this.btn_Rotate.UseVisualStyleBackColor = true;
            this.btn_Rotate.Click += new System.EventHandler(this.btn_Rotate_Click);
            // 
            // Img_Direction
            // 
            this.Img_Direction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Img_Direction.BackgroundImage")));
            this.Img_Direction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Img_Direction.Location = new System.Drawing.Point(828, 118);
            this.Img_Direction.Margin = new System.Windows.Forms.Padding(4);
            this.Img_Direction.Name = "Img_Direction";
            this.Img_Direction.Size = new System.Drawing.Size(100, 92);
            this.Img_Direction.TabIndex = 4;
            this.Img_Direction.TabStop = false;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(715, 22);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(211, 92);
            this.Lbl_Title.TabIndex = 5;
            this.Lbl_Title.Text = "PREMI PER POSIZIONARE LE NAVI";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Img_Direction);
            this.Controls.Add(this.btn_Rotate);
            this.Controls.Add(this.grd_Playground);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Playground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Direction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Playground;
        private System.Windows.Forms.Button btn_Rotate;
        private System.Windows.Forms.PictureBox Img_Direction;
        private System.Windows.Forms.Label Lbl_Title;
    }
}

