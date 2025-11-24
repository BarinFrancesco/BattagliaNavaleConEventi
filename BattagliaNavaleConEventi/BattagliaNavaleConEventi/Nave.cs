using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaNavaleConEventi
{
    class Nave
    {
        public (int x, int y) Coordinate { get; private set; }
        public Direzione direzione { get; private set; }
        public int Lunghezza { get; private set; }
        public int ID { get; private set; }

        Random Generatore = new Random();

        //costruttore per l'inserimento manuale
        public Nave( int id, (int x, int y)coordinate, int length, Direzione direction, int[,] mappa)
        {
            ID = id;
            Coordinate = coordinate;
            direzione = direction;
            Lunghezza = length;

            //Aggiorno la mappa
            for (int i = 0; i < length; i++)
            {
                mappa[Coordinate.y, Coordinate.x] = ID;
                switch (direzione)
                {
                    case Direzione.Nord:
                        Coordinate = (Coordinate.y - 1, Coordinate.x);
                        break;
                    case Direzione.Est:
                        Coordinate = (Coordinate.y, Coordinate.x + 1);
                        break;
                    case Direzione.Sud:
                        Coordinate = (Coordinate.y + 1, Coordinate.x);
                        break;
                    default:
                        Coordinate = (Coordinate.y, Coordinate.x - 1);
                        break;
                }
            }
        }

        //costruttore per l'inserimento randomico
        public Nave(int id, int length, int[,] mappa)
        {
            ID = id;
            Lunghezza = length;
            Coordinate = (Generatore.Next(0, 10), Generatore.Next(0, 10));
            direzione = (Direzione)Generatore.Next(0, 4);
            bool approved = false;

            while (!approved)
            {

                switch (direzione)
                {
                    case Direzione.Nord:
                        //vado a verificare che la nave possa esistere, controllo che sia dentro la matrice, e controllo che non collida con altre navi
                        if (Coordinate.y - length >= 0)
                        {

                            for (int i = 0; i < length; i++)
                            {
                                if (mappa[(Coordinate.y - i), Coordinate.x] == 0)
                                {
                                    approved = true;
                                }
                                else
                                {
                                    Coordinate = (Generatore.Next(0, 10), Generatore.Next(0, 10));
                                    approved = false;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            direzione = Direzione.Est;
                        }
                        break;

                    case Direzione.Est:
                        if (Coordinate.x + length <= 10)
                        {

                            for (int i = 0; i < length; i++)
                            {
                                if (mappa[Coordinate.y, (Coordinate.x + i)] == 0)
                                {
                                    approved = true;
                                }
                                else
                                {
                                    Coordinate = (Generatore.Next(0, 10), Generatore.Next(0, 10));
                                    approved = false;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            direzione = Direzione.Sud;
                        }
                        break;

                    case Direzione.Sud:
                        if (Coordinate.y + length <= 10)
                        {

                            for (int i = 0; i < length; i++)
                            {
                                if (mappa[(Coordinate.y + i), Coordinate.x] == 0)
                                {
                                    approved = true;
                                }
                                else
                                {
                                    Coordinate = (Generatore.Next(0, 10), Generatore.Next(0, 10));
                                    approved = false;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            direzione = Direzione.Ovest;
                        }
                        break;

                    default:
                        if (Coordinate.x - length >= 0)
                        {

                            for (int i = 0; i < length; i++)
                            {
                                if (mappa[Coordinate.y, (Coordinate.x - i)] == 0)
                                {
                                    approved = true;
                                }
                                else
                                {
                                    Coordinate = (Generatore.Next(0, 10), Generatore.Next(0, 10));
                                    approved = false;
                                    break;
                                }
                            }

                        }
                        else
                        {
                            direzione = Direzione.Nord;
                        }
                        break;
                }

                //Aggiorno la mappa
                for (int i = 0; i < length; i++)
                {
                    mappa[Coordinate.y, Coordinate.x] = ID;
                    switch (direzione)
                    {
                        case Direzione.Nord:
                            Coordinate = (Coordinate.y - 1, Coordinate.x);
                            break;
                        case Direzione.Est:
                            Coordinate = (Coordinate.y, Coordinate.x + 1);
                            break;
                        case Direzione.Sud:
                            Coordinate = (Coordinate.y + 1, Coordinate.x);
                            break;
                        default:
                            Coordinate = (Coordinate.y, Coordinate.x - 1);
                            break;
                    }
                }

            }
        }

        //la funzione colpita toglie un pezzo alla nave, poi mi ritorna true se la nave è stata affondata 
        public bool Colpita()
        {
            Lunghezza--;
            return Lunghezza > 0 ? false : true;
        }
    }
}
