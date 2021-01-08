using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Klasa reprezentująca lekarza specjalistę, dziedzicząca po klasie Lekarz
    /// </summary>
    [Serializable]
    public class LekarzSpecjalista : Lekarz, ICloneable, IComparable<LekarzSpecjalista>, IEquatable<LekarzSpecjalista>
    {
        Specjalizacja _typSpecjalizacji;
        /// <summary>
        /// Pole określające typ sepcjalizacji lekarza
        /// </summary>
        public Specjalizacja TypSpecjalizacji { get => _typSpecjalizacji; set => _typSpecjalizacji = value; }
        /// <summary>
        /// Konstruktor domyślny, dziedziczący po klasie Lekarz
        /// </summary>
        public LekarzSpecjalista() : base()
        {

        }
        /// <summary>
        /// Konstruktor parametryczny, dziedziczacy po klasie Lekarz
        /// </summary>
        /// <param name="imie">Imię lekarza</param>
        /// <param name="nazwisko">Nazwisko lekarza</param>
        /// <param name="dataUrodzenia">Data urodzenia lekarza</param>
        /// <param name="specjalizacja">Typ specjalizacji lekarza</param>
        public LekarzSpecjalista(string imie, string nazwisko, string dataUrodzenia, Specjalizacja specjalizacja) : base(imie, nazwisko, dataUrodzenia)
        {
            TypSpecjalizacji = specjalizacja;
        }
        /// <summary>
        /// Metoda wypisująca podstowowe informacje o lekarzu specjaliście
        /// </summary>
        /// <returns>Opis lekarza specjalisty</returns>
        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, Specjalizacja: {TypSpecjalizacji}"; ;
        }
        /// <summary>
        /// Metoda porównująca dwóch lekarzy pod względem nazwiska i imienia
        /// </summary>
        /// <param name="other">Drugi lekarz</param>
        /// <returns>1 jeśli lekarze, mają takie same imiona i nazwiska, w przeciwnym razie 0</returns>
        public int CompareTo(LekarzSpecjalista other)
        {
            if (Nazwisko.CompareTo(other.Nazwisko) != 0) { return Nazwisko.CompareTo(other.Nazwisko); }
            return Imie.CompareTo(other.Imie);
        }
        /// <summary>
        /// Metoda tworząca kopię lekarza
        /// </summary>
        /// <returns>Kopia lekarza</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
        /// <summary>
        /// Metoda sprawdazjąca czy dwa obiekty lekarzy są takie same
        /// </summary>
        /// <param name="other">Drugi lekarz</param>
        /// <returns>Prawda, jeśli lekarze mają takie samo imię i nazwisko</returns>
        public bool Equals(LekarzSpecjalista other)
        {
            return (Imie.Equals(other.Imie) & Nazwisko.Equals(other.Nazwisko));
        }
    }
}
