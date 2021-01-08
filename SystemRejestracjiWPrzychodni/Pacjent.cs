using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Klasa opisująca pacjenta
    /// </summary>
    [XmlInclude(typeof(PacjentZagraniczny))]
    [Serializable]
    public class Pacjent : IEquatable<Pacjent>, IComparable<Pacjent>, ICloneable
    {
        string _imie;
        string _nazwisko;
        string _pesel;
        DateTime _dataUrodzeniaPacjenta;
        /// <summary>
        /// pole zawierajace imie pacjenta
        /// </summary>
        public string Imie { get => _imie; set => _imie = value; }
        /// <summary>
        /// pole zawierajace nazwisko
        /// </summary>
        public string Nazwisko { get => _nazwisko; set => _nazwisko = value; }
        /// <summary>
        /// pole zawierajace pesel
        /// </summary>
        public string Pesel { get => _pesel; set => _pesel = value; }
        /// <summary>
        /// Pole zawierające datę urodzenia pacjenta
        /// </summary>
        public DateTime DataUrodzeniaPacjenta { get => _dataUrodzeniaPacjenta; set => _dataUrodzeniaPacjenta = value; }

        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public Pacjent()
        {
            Imie = String.Empty;
            Nazwisko = String.Empty;
            Pesel = new string('0', 11);
        }
        /// <summary>
        /// Konstruktor parametryczny wykorzystujący podstawowe dane
        /// </summary>
        /// <param name="imie">imie</param>
        /// <param name="nazwisko">nazwisko</param>
        public Pacjent(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
        /// <summary>
        /// konstuktor parametryczny z peselem oraz z data urodzenia
        /// </summary>
        /// <param name="imie"></param>
        /// <param name="nazwisko"></param>
        /// <param name="pesel"></param>
        /// <param name="dataUrodzenia"></param>
        public Pacjent(string imie, string nazwisko, string pesel, string dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            DateTime d = new DateTime();
            DateTime.TryParseExact(dataUrodzenia, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy", "yyyy.MM.dd", "dd-MM-yyyy", "dd.MM.yyyy" }, null, DateTimeStyles.None, out d);
            DataUrodzeniaPacjenta = d;
        }
        /// <summary>
        /// Metoda wypisująca podstawowe informacje o pacjencie
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, PESEL: {Pesel}";
        }
        /// <summary>
        /// Metoda sprawdzająca czy dwaj pacjenci są tacy sami
        /// </summary>
        /// <param name="other">Drugi pacjent</param>
        /// <returns>Prawda, jeśli pacjenci mają taki sam numer PESEL</returns>
        public bool Equals(Pacjent other)
        {
            return DataUrodzeniaPacjenta.Equals(other.DataUrodzeniaPacjenta);
        }
        /// <summary>
        /// Metoda porównująca dwóch pacjentów pod względem nazwiska i imienia
        /// </summary>
        /// <param name="other">Drugi pacjent</param>
        /// <returns>1, jesli pacjenci mają takie samo imie i nazwisko, w przeciwnym razie 0</returns>
        public int CompareTo(Pacjent other)
        {
            if (Nazwisko.CompareTo(other.Nazwisko) != 0) { return Nazwisko.CompareTo(other.Nazwisko); }
            return Imie.CompareTo(other.Imie);
        }
        /// <summary>
        /// Metoda tworząca kopię pacjenta
        /// </summary>
        /// <returns>Kopia pacjenta</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
