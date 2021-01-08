using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Klasa opisująca pacjenta zagranicznego
    /// </summary>
    [Serializable]
    public class PacjentZagraniczny : Pacjent
    {
        string _nrEKUZ;
        /// <summary>
        /// Pole zawierające numer EKUZ pacjenta
        /// </summary>
        public string NrEKUZ { get => _nrEKUZ; set => _nrEKUZ = value; }
        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public PacjentZagraniczny() :base()
        {

        }
        /// <summary>
        /// Kontruktor parametryczny z nr karty ekuz oraz data urodzenia
        /// </summary>
        /// <param name="imie"></param>
        /// <param name="nazwisko"></param>
        /// <param name="nrEKUZ"></param>
        /// <param name="dataUrodzenia"></param>
        public PacjentZagraniczny(string imie,string nazwisko, string nrEKUZ, string dataUrodzenia) : base(imie,nazwisko)
        {
            
            NrEKUZ = nrEKUZ;
            DateTime d =new DateTime();
            DateTime.TryParseExact(dataUrodzenia, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy", "yyyy.MM.dd", "dd-MM-yyyy", "dd.MM.yyyy" }, null, DateTimeStyles.None, out d);
            DataUrodzeniaPacjenta = d;
        }
        /// <summary>
        /// Metoda wypisująca informacje o pacjencie zagranicznym
        /// </summary>
        /// <returns>Opis pacjenta zagranicznego</returns>
        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, Numer Karty EKUZ: {NrEKUZ}";
        }
    }
}
