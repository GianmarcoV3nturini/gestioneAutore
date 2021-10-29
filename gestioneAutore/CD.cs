using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneAutore
{
    class CD
    {
        protected List<Brano> _listaBrani;
        protected string _titolo, _autore;

        public List<Brano> ListaBrani
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("Stringa vuota");
                }
                _listaBrani = value;
            }
            get
            {
                return _listaBrani;
            }
        }

        public string Titolo
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("Stringa vuota");
                }
                _titolo = value;
            }
            get
            {
                return _titolo;
            }
        }

        public string Autore
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("Stringa vuota");
                }
                _autore = value;
            }
            get
            {
                return _autore;
            }
        }

        public CD(List<Brano> listaBrani, string titolo, string autore)
        {
            ListaBrani = listaBrani;
            Titolo = titolo;
            Autore = autore;
        }

        public override string ToString()
        {
            return ListaBrani.ToString();
        }

        public int Durata()
        {
            int durataTotale=0;

            foreach (Brano b in _listaBrani)
            {
                durataTotale += b.Durata;
            }

            return durataTotale;
        }
    }
}
