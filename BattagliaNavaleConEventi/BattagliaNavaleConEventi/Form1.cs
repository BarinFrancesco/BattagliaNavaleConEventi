using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

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
        SoundPlayer SoundHit = new SoundPlayer(@"..\..\..\sounds\Cannon sound.wav");
        SoundPlayer SoundMiss = new SoundPlayer(@"..\..\..\sounds\HitSound.wav");
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
        int countmosse;
        int[] DimensioneBarche = new int[] { 4, 3, 3, 2, 2, 1 };
        Nave[] flotta = new Nave[10];
        Direzione direzione = new Direzione();
        bool avversario;


        private void Form1_Load(object sender, EventArgs e)
        {
            count =0;
            countmosse = 0;
            direzione = Direzione.Nord;
            Modalità();
            CreazioneCampoDigioco();
            PiazzaNavi();
        }

        private void Modalità()
        {
            using (FormIniziale form = new FormIniziale())
            {
                form.ShowDialog();
                if(form.DialogResult == DialogResult.OK)
                {
                    avversario = true;
                } else if(form.DialogResult == DialogResult.Yes)
                {
                    
                    //modalità 1v1
                }
                else
                {
                    avversario = false;
                }
            }
        }


        public void PiazzaNavi()
        {
            pnlPlay.Location = new Point(430, 500);
            pnl_rotate.Location = new Point(430, 100);
            grd_Playground.CellClick+= Grd_Playground_Piazzanave; 
        }

        private void Grd_Playground_Piazzanave(object sender, DataGridViewCellEventArgs e)
        {

            int x = e.ColumnIndex;
            int y = e.RowIndex;

            if (count == DimensioneBarche.Length)
            {
                MessageBox.Show("Hai inserito tutte le barche");
                grd_Playground.CellClick -= Grd_Playground_Piazzanave; 
                GetReadyToPlay();
                //rendi tutto blu e aggoingi l'evento dello sparo  

                return;
            }

            int dimensione = DimensioneBarche[count];
            bool approvato;
            //controlla la direzione, poi per ongi caso controlla col ciclo giusto che non ci siano altre navi nel percorso
            switch (direzione)
            {
                case Direzione.Nord:
                     //aggiungo o tolgo 1 dalla coordinata della cella perché la lunghezza va da 1-x e l'indice va da 0-x, quindi mi serve renderli(compatibili)
                    if (y - (dimensione-1) >= 0)
                    {
                        approvato = true;

                        for (int i = 0; i < dimensione; i++)
                        {
                            if (GrigliaDiGioco[y - i , x] != 0)
                            {
                                approvato = false;
                                break;
                            }
                        }

                        if (approvato)
                        {
                            flotta[count] = new Nave(count + 1, (x, y), dimensione, direzione, GrigliaDiGioco);

                            for (int i = 0; i < dimensione; i++)
                                grd_Playground.Rows[y - i].Cells[x].Style.BackColor = Color.Gray;

                            count++;
                        }
                        else MessageBox.Show("C'è una nave di mezzo");
                    }
                    else MessageBox.Show("Non puoi mettere la barca qui orientata in questa direzione");

                    break;


                case Direzione.Est:

                    if (x + (dimensione-1) < 10)
                    {
                        approvato = true;

                        for (int i = 0; i < dimensione; i++)
                        {
                            if (GrigliaDiGioco[y, x + i] != 0)
                            {
                                approvato = false;
                                break;
                            }
                        }

                        if (approvato)
                        {
                            flotta[count] = new Nave(count + 1, (x, y), dimensione, direzione, GrigliaDiGioco);

                            for (int i = 0; i < dimensione; i++)
                                grd_Playground.Rows[y].Cells[x + i].Style.BackColor = Color.Gray;

                            count++;
                        }
                        else MessageBox.Show("C'è una nave di mezzo");
                    }
                    else MessageBox.Show("Non puoi mettere la barca qui orientata in questa direzione");

                    break;


                case Direzione.Sud:

                    if (y + (dimensione-1) < 10)
                    {
                        approvato = true;

                        for (int i = 0; i < dimensione; i++)
                        {
                            if (GrigliaDiGioco[y + i, x] != 0)
                            {
                                approvato = false;
                                break;
                            }
                        }

                        if (approvato)
                        {
                            flotta[count] = new Nave(count + 1, (x, y), dimensione, direzione, GrigliaDiGioco);

                            for (int i = 0; i < dimensione; i++)
                                grd_Playground.Rows[y + i].Cells[x].Style.BackColor = Color.Gray;

                            count++;
                        }
                        else MessageBox.Show("C'è una nave di mezzo");
                    }
                    else MessageBox.Show("Non puoi mettere la barca qui orientata in questa direzione");

                    break;


                case Direzione.Ovest:

                    if (x - (dimensione-1) >= 0)
                    {
                        approvato = true;

                        for (int i = 0; i < dimensione; i++)
                        {
                            if (GrigliaDiGioco[y, x - i] != 0)
                            {
                                approvato = false;
                                break;
                            }
                        }

                        if (approvato)
                        {
                            flotta[count] = new Nave(count + 1, (x, y), dimensione, direzione, GrigliaDiGioco);

                            for (int i = 0; i < dimensione; i++)
                                grd_Playground.Rows[y].Cells[x - i].Style.BackColor = Color.Gray;

                            count++;
                        }
                        else MessageBox.Show("C'è una nave di mezzo");
                    }
                    else MessageBox.Show("Non puoi mettere la barca qui orientata in questa direzione");

                    break;
            }
            
        }


        private async Task GetReadyToPlay()
        {
            pnl_rotate.Location = new Point(430, 500);
            pnlPlay.Location = new Point(430, 100);
            grd_Playground.CellClick += Grd_Playground_Shootcell;
            CreazioneCampoDigioco();
            Thread.Sleep(2000);
            if (avversario)
            {
                Lbl_Title.Text = "SPARA ALLE CELLE";
            }
            else
            {
                Lbl_Title.Text = "IL COMPUTER STA SPARANDO ALLE CELLE";
                await ComputerSpara();
            }

        }


        private async Task ComputerSpara()
        {
            Random generatore = new Random(Environment.TickCount);
            while (count > 0)
            {
                int x = generatore.Next(10);
                int y = generatore.Next(10);

                grd_Playground.CurrentCell = grd_Playground.Rows[y].Cells[x];
                grd_Playground.Rows[y].Cells[x].Selected = true;

                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(x, y);

                // Richiama manualmente l'evento CellClick
                Grd_Playground_Shootcell(grd_Playground, args);
                await Task.Delay(500);
            }
        }


        private void Grd_Playground_Shootcell(object sender, DataGridViewCellEventArgs e)
        {
            
            int x = e.ColumnIndex;
            int y = e.RowIndex;
            int cellvalue = GrigliaDiGioco[y, x];
            countmosse++;
            lbl_Moves.Text = $"Mosse:\n {countmosse}";

            if ( cellvalue == -1)
            {
                lst_Mosse.Items.Add($"Cella:({x},{y}) già colpita");
            } else if(cellvalue == 0)
            {
                SoundMiss.Play();
                lst_Mosse.Items.Add("ACQUA!!");
                grd_Playground.Rows[y].Cells[x].Style.BackColor = Color.DarkBlue;
                GrigliaDiGioco[y, x] = -1;
            } else
            {
                SoundHit.Play();
                grd_Playground.Rows[y].Cells[x].Style.BackColor = Color.IndianRed;

                int index = cellvalue - 1;

                if (flotta[index].Colpita())
                {
                    //in questo ciclo faccio il movimento al contrario di quello della creazione,
                    //perché esso mi aveva puntato l'ultima cella 
                    for(int i = 0; i < DimensioneBarche[index]; i++)
                    {
                        switch (flotta[index].direzione)
                        {
                            
                            case Direzione.Nord:
                                grd_Playground.Rows[flotta[index].Coordinate.y + i].Cells[flotta[index].Coordinate.x].Style.BackColor = Color.Black;
                                break;
                            case Direzione.Est:
                                grd_Playground.Rows[flotta[index].Coordinate.y].Cells[flotta[index].Coordinate.x - i].Style.BackColor = Color.Black;
                                break;
                            case Direzione.Sud:
                                grd_Playground.Rows[flotta[index].Coordinate.y - i].Cells[flotta[index].Coordinate.x].Style.BackColor = Color.Black;
                                break;
                            case Direzione.Ovest:
                                grd_Playground.Rows[flotta[index].Coordinate.y].Cells[flotta[index].Coordinate.x + i].Style.BackColor = Color.Black;
                                break;
                        }
                    }
                        
                    MessageBox.Show("Colpita ed affondata");
                    count--;
                    lbl_Navirimaste.Text = lbl_Navirimaste.Text = $"Navi Rimaste: \n{count}";
                    //aggiungi i suoni
                    if (count == 0)
                    {
                        MessageBox.Show("Hai vinto");
                    }
                }
                else
                {
                    lst_Mosse.Items.Add($"Colpito in posizione({x},{y})");
                }

                GrigliaDiGioco[y, x] = -1;
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
            //MessageBox.Show("creo campo");
            int idnave = 1;
        }

        private void btn_Rotate_Click(object sender, EventArgs e)
        {

            direzione = (Direzione)(((int)direzione + 1) % 4);
            switch (direzione)
            {
                case Direzione.Nord:
                    Img_Direction.BackgroundImage = Image.FromFile(@"..\..\..\img\Nord.png");
                    break;
                case Direzione.Est:
                    Img_Direction.BackgroundImage = Image.FromFile(@"..\..\..\img\Est.png");
                    break;
                case Direzione.Sud:
                    Img_Direction.BackgroundImage = Image.FromFile(@"..\..\..\img\Sud.png");
                    break;
                case Direzione.Ovest:
                    Img_Direction.BackgroundImage = Image.FromFile(@"..\..\..\img\Ovest.png");
                    break;
            }
        } 
    }
}
