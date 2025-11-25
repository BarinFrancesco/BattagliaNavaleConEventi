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

     //copia la logica del primo switch sul resto chiedi a chat
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grd_Playground.RowHeadersVisible = false;
            grd_Playground.ScrollBars = ScrollBars.None;
            grd_Playground.AllowUserToResizeColumns = false;
            grd_Playground.AllowUserToResizeRows = false;
        }

        int[,] GrigliaDiGioco = new int[10, 10];
        int count;
        int naviaffondate;
        int[] DimensioneBarche = new int[] { 3, 2, 2, 1, 1, 0 };
        Nave[] flotta = new Nave[10];
        Random generatore = new Random();
        Direzione direzione = new Direzione();
        Nave navegenerica;


        private void Form1_Load(object sender, EventArgs e)
        {
            count =0;
            direzione = Direzione.Nord;
            Modalità();
            CreazioneCampoDigioco();
            PiazzaNavi();
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


        public void PiazzaNavi()
        {
            grd_Playground.CellDoubleClick += Grd_Playground_CellDoubleClick;
            //foreach (int barca in DimensioneBarche) { }
        }

        private void Grd_Playground_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex;
            int y = e.RowIndex;

            int dimensione = DimensioneBarche[count];
            switch (direzione)
            {
                case Direzione.Nord:

                    if (y - (dimensione) >= 0)
                    {
                        bool approvato = true;
                        
                        for(int i =0; i < dimensione; i++)
                        {
                            if(GrigliaDiGioco[y - i, x] != 0)
                            {
                                approvato = false;
                                break;
                            }
                            
                        }

                        if (approvato)
                        {
                            flotta[count] = new Nave(count + 1, (x, y), dimensione, direzione, GrigliaDiGioco);
                            for (int i = 0; i <= dimensione; i++)
                            {
                                grd_Playground.Rows[y - i].Cells[x].Style.BackColor = Color.Gray;
                            }
                        } else
                        {
                            MessageBox.Show("C'è una nave di mezzo");
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("Non puoi mettere la barca qui orientata in questa direzione");
                    }

                    break;
                case Direzione.Est:

                    if (x + dimensione < 10)
                    {

                        for (int i = 0; i <= dimensione; i++)
                        {
                            grd_Playground.Rows[y].Cells[x + i].Style.BackColor = Color.Gray;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Non puoi mettere la barca qui orientata in questa direzione");
                    }

                    break;
                case Direzione.Sud:

                    if (y + dimensione < 10)
                    {

                        for (int i = 0; i <= dimensione; i++)
                        {
                            grd_Playground.Rows[y + i].Cells[x].Style.BackColor = Color.Gray;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Non puoi mettere la barca qui orientata in questa direzione");
                    }


                    break;
                case Direzione.Ovest:

                    if (x - dimensione >= 0)
                    {

                        for (int i = 0; i <= dimensione; i++)
                        {
                            grd_Playground.Rows[y].Cells[x - i].Style.BackColor = Color.Gray;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Non puoi mettere la barca qui orientata in questa direzione");
                    }

                    break;
            }

            count ++;
            //MessageBox.Show($"Hai fatto doppio clic sulla cella: Riga {e.RowIndex}, Colonna {e.ColumnIndex}\n Valore: {cellValue}");
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

        private void btn_Position_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rotate_Click(object sender, EventArgs e)
        {

            direzione = (Direzione)(((int)direzione + 1) % 4);
        }
    }
}
