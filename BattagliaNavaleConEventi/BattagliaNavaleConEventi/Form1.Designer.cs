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
            this.lbl_Navirimaste = new System.Windows.Forms.Label();
            this.lbl_Moves = new System.Windows.Forms.Label();
            this.lst_Mosse = new System.Windows.Forms.ListBox();
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.pnl_rotate = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Playground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Direction)).BeginInit();
            this.pnlPlay.SuspendLayout();
            this.pnl_rotate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_Playground
            // 
            this.grd_Playground.AllowUserToAddRows = false;
            this.grd_Playground.AllowUserToDeleteRows = false;
            this.grd_Playground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Playground.ColumnHeadersVisible = false;
            this.grd_Playground.Location = new System.Drawing.Point(13, 13);
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
            this.btn_Rotate.Location = new System.Drawing.Point(11, 3);
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
            this.Img_Direction.Location = new System.Drawing.Point(119, 3);
            this.Img_Direction.Margin = new System.Windows.Forms.Padding(4);
            this.Img_Direction.Name = "Img_Direction";
            this.Img_Direction.Size = new System.Drawing.Size(100, 92);
            this.Img_Direction.TabIndex = 4;
            this.Img_Direction.TabStop = false;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(572, 12);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(211, 92);
            this.Lbl_Title.TabIndex = 5;
            this.Lbl_Title.Text = "PREMI PER POSIZIONARE LE NAVI";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Navirimaste
            // 
            this.lbl_Navirimaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Navirimaste.Location = new System.Drawing.Point(15, 21);
            this.lbl_Navirimaste.Name = "lbl_Navirimaste";
            this.lbl_Navirimaste.Size = new System.Drawing.Size(207, 102);
            this.lbl_Navirimaste.TabIndex = 6;
            this.lbl_Navirimaste.Text = "Navi rimaste:";
            this.lbl_Navirimaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Moves
            // 
            this.lbl_Moves.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Moves.Location = new System.Drawing.Point(10, 111);
            this.lbl_Moves.Name = "lbl_Moves";
            this.lbl_Moves.Size = new System.Drawing.Size(207, 86);
            this.lbl_Moves.TabIndex = 7;
            this.lbl_Moves.Text = "Mosse:";
            this.lbl_Moves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lst_Mosse
            // 
            this.lst_Mosse.FormattingEnabled = true;
            this.lst_Mosse.ItemHeight = 16;
            this.lst_Mosse.Location = new System.Drawing.Point(16, 218);
            this.lst_Mosse.Name = "lst_Mosse";
            this.lst_Mosse.Size = new System.Drawing.Size(201, 164);
            this.lst_Mosse.TabIndex = 8;
            // 
            // pnlPlay
            // 
            this.pnlPlay.Controls.Add(this.lbl_Navirimaste);
            this.pnlPlay.Controls.Add(this.lst_Mosse);
            this.pnlPlay.Controls.Add(this.lbl_Moves);
            this.pnlPlay.Location = new System.Drawing.Point(565, 275);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(250, 399);
            this.pnlPlay.TabIndex = 9;
            // 
            // pnl_rotate
            // 
            this.pnl_rotate.Controls.Add(this.Img_Direction);
            this.pnl_rotate.Controls.Add(this.btn_Rotate);
            this.pnl_rotate.Location = new System.Drawing.Point(566, 105);
            this.pnl_rotate.Name = "pnl_rotate";
            this.pnl_rotate.Size = new System.Drawing.Size(235, 109);
            this.pnl_rotate.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 554);
            this.Controls.Add(this.pnl_rotate);
            this.Controls.Add(this.pnlPlay);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.grd_Playground);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Playground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Direction)).EndInit();
            this.pnlPlay.ResumeLayout(false);
            this.pnl_rotate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Playground;
        private System.Windows.Forms.Button btn_Rotate;
        private System.Windows.Forms.PictureBox Img_Direction;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label lbl_Navirimaste;
        private System.Windows.Forms.Label lbl_Moves;
        private System.Windows.Forms.ListBox lst_Mosse;
        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.Panel pnl_rotate;
    }
}

