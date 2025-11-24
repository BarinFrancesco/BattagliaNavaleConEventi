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
    //enum per la direzione della nave
    public enum Direzione
    {
        Est,
        Sud,
        Ovest,
        Nord
    }

     

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
        int[] DimensioneBarche = new int[] { 4, 3, 3, 2, 2, 1 };
        Nave[] flotta = new Nave[10];
        Random generatore = new Random();



        private void Form1_Load(object sender, EventArgs e)
        {
            Modalità();
            CreazioneCampoDigioco();
        }

        private int Modalità()
        {
            using (FormIniziale form = new FormIniziale())
            {
                form.ShowDialog();
                if(form.DialogResult == DialogResult.OK)
                {
                    return 1;
                    //modalità metti e trova
                } else if(form.DialogResult == DialogResult.Yes)
                {
                    return 2;
                    //modalità 1v1
                }
                else
                {
                    return 3;
                    //modalità 1vscpu
                }
            }
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
            /*
            for (int i = 0; i < DimensioneBarche.Length; i++)
            {
                flotta[i] = new Nave(DimensioneBarche[i], generatore, GrigliaDiGioco, idnave);
                idnave++;
            }
            */
        }
    }
}
