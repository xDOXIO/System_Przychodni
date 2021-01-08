using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Klasa reprezentująca usługę podstawowej opieki zdrowotnej, dziedzicząca po klasie Usluga
    /// </summary>
    [Serializable]
    public class PodstawowaOpiekaZdrowotna : Usluga
    {
        /// <summary>
        /// Konstruktor domyślny klasy podstawowa opieka zdrowotna
        /// </summary>
        public PodstawowaOpiekaZdrowotna()
        {

        }
        /// <summary>
        /// Konstruktor parametryczny klasy PodstawowaOpiekaZdrowotna
        /// </summary>
        /// <param name="nazwa">Nazwa usługi</param>
        /// <param name="cena">Cena usługi</param>
        /// <param name="czasTrwania">Czas trwania usługi</param>
        public PodstawowaOpiekaZdrowotna(string nazwa, decimal cena, int czasTrwania) : base(nazwa, cena, czasTrwania)
        {

        }
    }
}
