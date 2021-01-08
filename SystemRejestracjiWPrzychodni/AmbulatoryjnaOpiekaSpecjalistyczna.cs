using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Klasa reprezentująca usługę ambulatoryjnej opieki specjalnej, dziedzicząca po klasie Usluga
    /// </summary>
    [Serializable]
    public class AmbulatoryjnaOpiekaSpecjalistyczna : Usluga
    {
        /// <summary>
        /// Konstruktor domyślny klasy ambulatoryjna opieka specjalistyczna
        /// </summary>
        public AmbulatoryjnaOpiekaSpecjalistyczna()
        {

        }
        /// <summary>
        /// Konstruktor domyślny klasy AmbulatoryjnaOpiekaSpecjalistyczna
        /// </summary>
        /// <param name="nazwa">Nazwa usługi</param>
        /// <param name="cena">Cena usługi</param>
        /// <param name="czasTrwania">Czas trwania usługi</param>
        public AmbulatoryjnaOpiekaSpecjalistyczna(string nazwa, decimal cena, int czasTrwania) : base(nazwa, cena, czasTrwania)
        {

        }
    }
}
