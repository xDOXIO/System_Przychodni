using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Klasa opisująca przychodnię
    /// </summary>
    [Serializable]
    public class Przychodnia : ICloneable
    {
        string _nazwa;
        List<LekarzSpecjalista> lekarze;
        List<Usluga> uslugi;
        List<Wizyta> wizyty;
        List<Pacjent> pacjenci;
        /// <summary>
        /// Pole opisujące nazwę przychodni
        /// </summary>
        public string Nazwa { get => _nazwa; set => _nazwa = value; }
        /// <summary>
        /// Lista lekarzy
        /// </summary>
        public List<LekarzSpecjalista> Lekarze { get => lekarze; set => lekarze = value; }
        /// <summary>
        /// Lista usług
        /// </summary>
        public List<Usluga> Uslugi { get => uslugi; set => uslugi = value; }
        /// <summary>
        /// Lista wizyt
        /// </summary>
        public List<Wizyta> Wizyty { get => wizyty; set => wizyty = value; }
        /// <summary>
        /// Lista pacjentów
        /// </summary>
        public List<Pacjent> Pacjenci { get => pacjenci; set => pacjenci = value; }

        /// <summary>
        /// Konstruktor nieparametryczny przychodni
        /// </summary>
        public Przychodnia()
        {
            Lekarze = new List<LekarzSpecjalista>();
            Uslugi = new List<Usluga>();
            Wizyty = new List<Wizyta>();
            Pacjenci = new List<Pacjent>();
        }
        /// <summary>
        /// Konstruktor parametryczny przychodni
        /// </summary>
        public Przychodnia(string nazwa)
        {
            Nazwa = nazwa;
            Lekarze = new List<LekarzSpecjalista>();
            Uslugi = new List<Usluga>();
            Wizyty = new List<Wizyta>();
            Pacjenci = new List<Pacjent>();
        }
        /// <summary>
        /// Metoda dodająca lekarza do listy lekarze
        /// </summary>
        /// <param name="l">Lekarz</param>
        public void DodajLekarza(LekarzSpecjalista l)
        {
            foreach(LekarzSpecjalista lek in Lekarze)
            {
                if(lek.Equals(l))
                {
                    throw new FormatException();
                }
            }
            Lekarze.Add(l);
        }
        /// <summary>
        /// Metoda dodająca usługę do listy uslugi
        /// </summary>
        /// <param name="u">Usługa</param>
        public void DodajUsluge(Usluga u)
        {
            foreach(Usluga usl in Uslugi)
            {
                if(u.Equals(usl))
                {
                    throw new FormatException();
                }
            }
            Uslugi.Add(u);
        }
        /// <summary>
        /// Metoda dodająca wizytę do listy wizyty
        /// </summary>
        /// <param name="w">Wizyta</param>
        public void UmowWizyte(Wizyta w)
        {
            if (Uslugi.Contains(w.Usluga) & Lekarze.Contains(w.LekarzSpecjalista) & Pacjenci.Contains(w.Pacjent))
            {
                foreach (Wizyta wiz in Wizyty)
                {
                    if (wiz.Equals(w)) { throw new FormatException(); } //Sprawdzenie, czy taka wizyta jest juz w systemie
                }
                if (w.Usluga is PodstawowaOpiekaZdrowotna) //Jesli wizyta jest z POZ kazdy lekarz moze byc
                {
                    Wizyty.Add(w);
                }
                else
                {
                    //Jesli usluga to pracownia diagnostyczna i lekarz ma odpowiednia specjalizacje to mozna dodac wizyte
                    if (w.Usluga is PracowniaDiagnostyczna & (w.LekarzSpecjalista.TypSpecjalizacji == Specjalizacja.Kardiolog | w.LekarzSpecjalista.TypSpecjalizacji == Specjalizacja.Chirurg))
                    {
                        Wizyty.Add(w);
                    }
                    else if (w.Usluga is AmbulatoryjnaOpiekaSpecjalistyczna & (w.LekarzSpecjalista.TypSpecjalizacji == Specjalizacja.Okulista | w.LekarzSpecjalista.TypSpecjalizacji == Specjalizacja.Laryngolog))
                    {
                        Wizyty.Add(w);
                    }
                    else //W przeciwnym wypadku wyrzucamy wyjatek LekarzBezSpecjalizacji
                    {
                        throw new DoctorWithoutSpecializationException();
                    }
                }
            }
            else //Jesli lekarza nie ma liscie lekarzy, nie ma takiej uslugi lub nie ma takiego pacjenta wyrzucamy wyjatek UslugaNiedostepna
            {
                throw new ServiceUnavailableException();
            }
        }
        /// <summary>
        /// Metoda dodająca pacjenta do listy pacjenci
        /// </summary>
        /// <param name="p">Pacjent</param>
        public void DodajPacjenta(Pacjent p)
        {
            foreach(Pacjent pac in Pacjenci)
            {
                if(p.Equals(pac))
                {
                    throw new FormatException();
                }
            }
            Pacjenci.Add(p);
        }
        /// <summary>
        /// Metoda sortująca lekarzy alfabetycznie
        /// </summary>
        public void SortujLekarzyAlfabetycznie()
        {
            Lekarze.Sort();
        }
        /// <summary>
        /// Metoda wypisująca listę lekarzy
        /// </summary>
        public void WypiszLekarzy()
        {
            foreach(LekarzSpecjalista l in Lekarze)
            {
                Console.WriteLine(l.ToString());
            }
        }
        /// <summary>
        /// Metoda sortująca pacjentów alfabetycznie
        /// </summary>
        public void SortujPacjentowAlfabetycznie()
        {
            Pacjenci.Sort();
        }
        /// <summary>
        /// Metoda wypisująca wszystkich pacjentów
        /// </summary>
        public void WypiszPacjentow()
        {
            foreach(Pacjent p in Pacjenci)
            {
                Console.WriteLine(p.ToString());
            }
        }
        /// <summary>
        /// Metoda sortująca usługi alfabetycznie
        /// </summary>
        public void SortujUslugiAlfabetycznie()
        {
            Uslugi.Sort();
        }
        /// <summary>
        /// Metoda wypisująca wszystkie usługi
        /// </summary>
        public void WypiszUslugi()
        {
            foreach(Usluga u in Uslugi)
            {
                Console.WriteLine(u.ToString());
            }
        }
        /// <summary>
        /// Metoda sortująca wizyty po dacie
        /// </summary>
        public void SortujWizytyPoDacie()
        {
            Wizyty.Sort();
        }
        /// <summary>
        /// Metoda wypisująca wszystkie wizyty
        /// </summary>
        public void WypiszWizyty()
        {
            foreach(Wizyta w in Wizyty)
            {
                Console.WriteLine(w.ToString());
            }
        }
        /// <summary>
        /// Metoda sortująca usługi po cenie
        /// </summary>
        public void SortujUslugiPoCenie()
        {
            Uslugi.Sort((x, y) => x.Cena.CompareTo(y.Cena));
        }
        /// <summary>
        /// Metoda tworząca kopię przychodni
        /// </summary>
        public object Clone()
        {
            Przychodnia p = new Przychodnia(Nazwa);
            foreach (LekarzSpecjalista l in Lekarze)
            {
                p.DodajLekarza((LekarzSpecjalista)l.Clone());
            }
            foreach (Pacjent pacjent in Pacjenci)
            {
                p.DodajPacjenta((Pacjent)pacjent.Clone());
            }
            foreach(Usluga u in Uslugi)
            {
                p.DodajUsluge((Usluga)u.Clone());
            }
            
            foreach (Wizyta wizyta in Wizyty)
            {
                p.UmowWizyte((Wizyta)wizyta.Clone());
            }
            return p;
        }
        /// <summary>
        /// Metoda zapisująca klasę przychodnia do pliku xml
        /// </summary>
        /// <param name="plik">plik z rozszerzeniem xml</param>
        public void ZapiszXML(string plik)
        {
            using (StreamWriter file2 = new StreamWriter(plik))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Przychodnia));
                xml.Serialize(file2, this);
            }
        }
        /// <summary>
        /// Metoda odczytująca z pliku xml klasę przychodnia
        /// </summary>
        /// <param name="plik">plik z rozszerzeniem xml</param>
        /// <returns>Klasa przychodnia</returns>
        public static Przychodnia OdczytajXML(string plik)
        {
            if (!File.Exists(plik)) { return null; }
            using (StreamReader file2 = new StreamReader(plik))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Przychodnia));
                return (Przychodnia)xml.Deserialize(file2);
            }
        }

    }
}
