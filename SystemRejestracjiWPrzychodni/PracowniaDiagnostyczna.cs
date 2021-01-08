using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Klasa reprezentująca usługę pracowni diagnostycznej, dziedzicząca po klasie Usluga
    /// </summary>
    [Serializable]
    public class PracowniaDiagnostyczna : Usluga
    {
        /// <summary>
        /// Konstruktor domyślny klasy pracownia diagnostyczna
        /// </summary>
        public PracowniaDiagnostyczna()
        {

        }
        /// <summary>
        /// Konstruktor parametryczny klasy PracowniaDiagnostyczna
        /// </summary>
        /// <param name="nazwa">Nazwa usługi</param>
        /// <param name="cena">Cena usługi</param>
        /// <param name="czasTrwania">Czas trwania usługi</param>
        public PracowniaDiagnostyczna(string nazwa, decimal cena, int czasTrwania) : base(nazwa, cena, czasTrwania)
        {

        }
    }
}
