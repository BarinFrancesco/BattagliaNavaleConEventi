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
            this.btn_Position = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Playground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // btn_Rotate
            // 
            this.btn_Rotate.Location = new System.Drawing.Point(594, 114);
            this.btn_Rotate.Name = "btn_Rotate";
            this.btn_Rotate.Size = new System.Drawing.Size(75, 75);
            this.btn_Rotate.TabIndex = 1;
            this.btn_Rotate.Text = "Ruota";
            this.btn_Rotate.UseVisualStyleBackColor = true;
            this.btn_Rotate.Click += new System.EventHandler(this.btn_Rotate_Click);
            // 
            // btn_Position
            // 
            this.btn_Position.Location = new System.Drawing.Point(594, 218);
            this.btn_Position.Name = "btn_Position";
            this.btn_Position.Size = new System.Drawing.Size(75, 75);
            this.btn_Position.TabIndex = 2;
            this.btn_Position.Text = "Posiziona";
            this.btn_Position.UseVisualStyleBackColor = true;
            this.btn_Position.Click += new System.EventHandler(this.btn_Position_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(676, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Position);
            this.Controls.Add(this.btn_Rotate);
            this.Controls.Add(this.grd_Playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Playground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Playground;
        private System.Windows.Forms.Button btn_Rotate;
        private System.Windows.Forms.Button btn_Position;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

