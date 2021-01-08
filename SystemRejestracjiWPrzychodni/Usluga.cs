using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Klasa reprezentująca usługę
    /// </summary>
    [XmlInclude(typeof(PodstawowaOpiekaZdrowotna))] //Zezwala na rozpoznawanie danego typu przy serializacji
    [XmlInclude(typeof(PracowniaDiagnostyczna))]
    [XmlInclude(typeof(AmbulatoryjnaOpiekaSpecjalistyczna))]
    [Serializable]
    public class Usluga : IEquatable<Usluga>, IComparable<Usluga>, ICloneable
    {
        string _nazwa;
        decimal _cena;
        int _czasTrwania;
        /// <summary>
        /// Pole zawierające nazwę usługi
        /// </summary>
        public string Nazwa { get => _nazwa; set => _nazwa = value; }
        /// <summary>
        /// Pole zawierające cenę usługi
        /// </summary>
        public decimal Cena { get => _cena; set => _cena = value; }
        /// <summary>
        /// Pole opisujące czas trwania usługi
        /// </summary>
        public int CzasTrwania { get => _czasTrwania; set => _czasTrwania = value; }
        /// <summary>
        /// Konstruktor domyślny klasy usługa
        /// </summary>
        public Usluga()
        {

        }
        /// <summary>
        /// Konstruktor parametryczny klasy Usluga
        /// </summary>
        /// <param name="nazwa">Nazwa usługi</param>
        /// <param name="cena">Cena usługi</param>
        /// <param name="czasTrwania">Czas trwania usługi</param>

        public Usluga(string nazwa, decimal cena, int czasTrwania)
        {
            Nazwa = nazwa;
            Cena = cena;
            CzasTrwania = czasTrwania;
        }
        /// <summary>
        /// Metoda sprawdzająca, czy dwie usługi są takie same
        /// </summary>
        /// <param name="other">Druga usługa</param>
        /// <returns>Prawda, jeśli usługi mają takie same nazwy</returns>
        public bool Equals(Usluga other)
        {
            return Nazwa.Equals(other.Nazwa);
        }
        /// <summary>
        /// Metoda porównująca dwie usługi pod względem nazwy
        /// </summary>
        /// <param name="other">Druga usługa</param>
        /// <returns>1, jeśli usługi są takie same, w przeciwnym razie 0</returns>
        public int CompareTo(Usluga other)
        {
            return Nazwa.CompareTo(other.Nazwa);
        }
        /// <summary>
        /// Metoda wypisująca podstawowe informacje o usłudze
        /// </summary>
        /// <returns>Opis usługi</returns>
        public override string ToString()
        {
            return $"{Nazwa}, {Cena:C}, {CzasTrwania} minut";
        }
        /// <summary>
        /// Metoda tworząca kopię usługi
        /// </summary>
        /// <returns>Kopia usługi</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
