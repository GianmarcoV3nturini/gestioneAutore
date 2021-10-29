using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneAutore
{
    class Brano
    {
        private string _titolo;
        private string _autore;
        private int _durata;

        public Brano(string titolo, string autore, int durata)
        {

        }
        public int Durata
        {
            get { return _durata; }
            set
            {
                if (value<0)
                    throw new Exception("durata non valido");
                _durata = value;
            }
        }
        public string Autore
        {
            get { return _autore; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("autore non valido");
                _autore = value;
            }
        }
        public string Titolo
        {
            get { return _titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("titolo non valido");
                _titolo = value;
            }
        }
        public override string ToString()
        {
            return Titolo + ", " + Autore + ", " + Durata;
        }
        public bool ShortSong(int d)
        {
            bool durataInferiore= false;
            if (Durata < d)
                durataInferiore = true;
            return durataInferiore;
        }
    }
}
