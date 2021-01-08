using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Klasa reprezentujaca lekarza
    /// </summary>
    [Serializable]
    public abstract class Lekarz
    {
        string _imie;
        string _nazwisko;
        DateTime _dataUrodzenia;
        /// <summary>
        /// Pole zawierajace imię lekarza
        /// </summary>
        public string Imie { get => _imie; set => _imie = value; }
        /// <summary>
        /// Pole zawierajace nazwisko lekarza
        /// </summary>
        public string Nazwisko { get => _nazwisko; set => _nazwisko = value; }
        /// <summary>
        /// Pole zawierajace datę urodzenia lekarza
        /// </summary>
        public DateTime DataUrodzenia { get => _dataUrodzenia; set => _dataUrodzenia = value; }
        /// <summary>
        /// Konstruktor domyslny klasy lekarz
        /// </summary>
        public Lekarz()
        {

        }
        /// <summary>
        /// Konstruktor parametryczny klasy lekarz
        /// </summary>
        /// <param name="imie">Imie lekarza</param>
        /// <param name="nazwisko">Nazwisko lekarza</param>
        /// <param name="dataUrodzenia">Data urodzenia lekarza</param>
        public Lekarz(string imie, string nazwisko, string dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DateTime d = new DateTime();
            DateTime.TryParseExact(dataUrodzenia, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy", "dd.MM.yyyy" }, null, DateTimeStyles.None, out d);
            DataUrodzenia = d;
        }
        /// <summary>
        /// Metoda wypisujaca podstawowe informacje o lekarzu
        /// </summary>
        /// <returns>Opis lekarza</returns>
        public override string ToString()
        {
            return $"{Imie} {Nazwisko} {DataUrodzenia.ToShortDateString()}";
        }
    }
}
