using Battaglia_navale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattagliaNavaleConEventi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grd_Playground.RowHeadersVisible = false;
            grd_Playground.ScrollBars = ScrollBars.None;
        }

        int[,] GrigliaDiGioco = new int[10, 10];
        int count;
        int naviaffondate;
        int[] dimensionebarche = { 1, 1, 1, 1, 2, 2, 3, 3, 4, 5 };
        CNave[] flotta = new CNave[10];
        Random generatore = new Random();



        private void Form1_Load(object sender, EventArgs e)
        {
            CreazioneCampoDigioco();
        }

        private void CreazioneCampoDigioco()
        {
            grd_Playground.Columns.Clear();
            grd_Playground.Rows.Clear();
            grd_Playground.RowTemplate.Height = 40;
            grd_Playground.ColumnHeadersHeight = 40;

            // Crea 10 colonne larghe 40 px
            for (int c = 0; c < 10; c++)
            {
                var col = new DataGridViewTextBoxColumn();
                col.Name = $"col{c}";
                col.Width = 40;
                grd_Playground.Columns.Add(col);
            }
            grd_Playground.Rows.Add(10);

            foreach (DataGridViewRow r in grd_Playground.Rows)
            {
                r.Height = 40;
            }

            for(int c = 0; c< 10; c++)
            {
                for (int i = 0; i < 10; i++)
                {
                    grd_Playground.Rows[i].Cells[c].Style.BackColor = Color.LightBlue;
                }
            }

            int idnave = 1;

            for (int i = 0; i < dimensionebarche.Length; i++)
            {
                flotta[i] = new CNave(dimensionebarche[i], generatore, GrigliaDiGioco, idnave);
                idnave++;
            }

        }
    }
}
