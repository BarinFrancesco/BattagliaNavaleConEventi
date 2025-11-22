using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battaglia_navale
{
    class CNave
    {
        int x;
        int y;
        int direzione;
        int length;
        public CNave(int lunghezza, Random Generatore, int[,] mappa, int Idnave)
        {
            length = lunghezza;
            y = Generatore.Next(0, 10);
            x = Generatore.Next(0, 10);
            direzione = new Random().Next(1,5);
            bool approved = false;

            while (!approved)
            {
                
                switch (direzione)
                {
                    case 1:
                        //vado a verificare che la nave possa esistere, controllo che sia dentro la matrice, e controllo che non collida con altre navi
                        if (y - length >= 0)
                        {

                            for (int i = 0; i < length; i++)
                            {
                                if(mappa[(y - i), x] == 0)
                                {
                                    approved = true;
                                } else
                                {
                                    y = Generatore.Next(0, 10);
                                    x = Generatore.Next(0, 10);
                                    approved = false;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            direzione = 2;
                        }
                        break;

                    case 2:
                        if (x + length <= 10)
                        {

                            for (int i = 0; i < length; i++)
                            {
                                if (mappa[y , (x + i)] == 0)
                                {
                                    approved = true;
                                }
                                else
                                {
                                    y = Generatore.Next(0, 10);
                                    x = Generatore.Next(0, 10);
                                    approved = false;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            direzione = 3;
                        }
                        break;

                    case 3:
                        if (y + length <= 10)
                        {

                            for (int i = 0; i < length; i++)
                            {
                                if (mappa[(y + i), x] == 0)
                                {
                                    approved = true;
                                }
                                else
                                {
                                    y = Generatore.Next(0, 10);
                                    x = Generatore.Next(0, 10);
                                    approved = false;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            direzione = 4;
                        }
                        break;

                    default:
                        if (x - length >= 0)
                        {

                            for (int i = 0; i < length; i++)
                            {
                                if (mappa[y, (x - i)] == 0)
                                {
                                    approved = true;
                                }
                                else
                                {
                                    y = Generatore.Next(0, 10);
                                    x = Generatore.Next(0, 10);
                                    approved = false;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            direzione = 1;
                        }
                        break;
                }

            }
            //vado a segnare questa aggiunta anceh nella mappa
            for(int i = 0; i<length; i++)
            {
                mappa[y, x] = Idnave;
                switch (direzione)
                {
                    case 1:
                        y --;
                        break;
                    case 2:
                        x ++;
                        break;
                    case 3:
                        y ++;
                        break;
                    default:
                        x --;
                        break;
                }
            }
        }

        //funzione che toglie alla nave i pezzi colpiti, ritorna true se la nave è affondata
        public bool colpita()
        {
            length--;
            if (length == 0)
            {
                return true;
            }
            return false;
        }
    }
}
