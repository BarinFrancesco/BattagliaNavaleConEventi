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
                        Coordinate = (Coordinate.x, Coordinate.y - 1);
                        break;
                    case Direzione.Est:
                        Coordinate = (Coordinate.x + 1, Coordinate.y);
                        break;
                    case Direzione.Sud:
                        Coordinate = (Coordinate.x, Coordinate.y + 1);
                        break;
                    case Direzione.Ovest:
                        Coordinate = (Coordinate.x - 1, Coordinate.y);
                        break;
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
