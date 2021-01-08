using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Klasa opisująca wizytę
    /// </summary>
    [Serializable]
    public class Wizyta : IEquatable<Wizyta>, IComparable<Wizyta>, ICloneable
    {
        Pacjent _pacjent;
        LekarzSpecjalista _lekarzspecjalista;
        Usluga _usluga;
        DateTime _dataGodzinaWizyty;
        /// <summary>
        /// Pole zawierające pacjenta
        /// </summary>
        public Pacjent Pacjent { get => _pacjent; set => _pacjent = value; }
        /// <summary>
        /// Pole zawierające lekarza
        /// </summary>
        public LekarzSpecjalista LekarzSpecjalista { get => _lekarzspecjalista; set => _lekarzspecjalista = value; }
        /// <summary>
        /// Pole zawierające datę oraz godzinę wizyty
        /// </summary>
        public DateTime DataGodzinaWizyty { get => _dataGodzinaWizyty; set => _dataGodzinaWizyty = value; }
        /// <summary>
        /// Pole zawierjące usługę
        /// </summary>
        public Usluga Usluga { get => _usluga; set => _usluga = value; }
        /// <summary>
        /// Konstruktor domyślny klasy wizyta
        /// </summary>
        public Wizyta()
        {

        }
        /// <summary>
        /// Konstruktor parametryczny Wizyty
        /// </summary>
        /// <param name="pacjent">Pacjent</param>
        /// <param name="lekarz">Lekarz</param>
        /// <param name="usluga">Usługa</param>
        /// <param name="dataWizyty">Data i godzina wizyty</param>

        public Wizyta(Pacjent pacjent, LekarzSpecjalista lekarz, Usluga usluga, string dataWizyty)
        {
            Pacjent = pacjent;
            LekarzSpecjalista = lekarz;
            DateTime d = new DateTime();
            DateTime dzis = DateTime.Now;
            DateTime.TryParseExact(dataWizyty, new[] { "MM/dd/yyyy H:mm", "yyyy-MM-dd H:mm", "yyyy/MM/dd H:mm", "dd-MMM-yy H:mm", "dd.MM.yyyy H:mm" }, null, DateTimeStyles.None, out d);
            TimeSpan result = d - dzis;
            if(result.TotalDays < 1)
            {
                throw new WrongDateException();
            }
            DataGodzinaWizyty = d;
            Usluga = usluga;
        }
        /// <summary>
        /// Metoda wypisująca podstawowe informacje o wizycie
        /// </summary>
        /// <returns>Opis wizyty</returns>
        public override string ToString()
        {
            return $"Lekarz: {LekarzSpecjalista.ToString()}, {Usluga.ToString()}, {DataGodzinaWizyty}";
        }
        /// <summary>
        /// Metoda sprawdzajaca, czy dwie usługi są takie same
        /// </summary>
        /// <param name="other">Druga wizyta</param>
        /// <returns>Prawda, jeśli 2 wizyty są takie same</returns>
        public bool Equals(Wizyta other)
        {
            return (DataGodzinaWizyty.Equals(other.DataGodzinaWizyty) & Usluga.Equals(other.Usluga));
        }
        /// <summary>
        /// Metoda porównująca dwie wizyty pod względem daty i godziny
        /// </summary>
        /// <param name="other">Druga wizyta</param>
        /// <returns>1, jeśli terminy wizyt są takie same, w przeciwnym wypadku 0</returns>
        public int CompareTo(Wizyta other)
        {
            return DataGodzinaWizyty.CompareTo(other.DataGodzinaWizyty);
        }
        /// <summary>
        /// Metoda tworząca kopię wizyty
        /// </summary>
        /// <returns>Kopia wizyty</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
