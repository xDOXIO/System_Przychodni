using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRejestracjiWPrzychodni
{
    /// <summary>
    /// Typ wyliczeniowy zawierający specjalizacje lekarzy
    /// </summary>
    public enum Specjalizacja { 
        /// <summary>
        /// Specjalizacja chirurg
        /// </summary>
        Chirurg, 
        /// <summary>
        /// Specjalizacja dentysta
        /// </summary>
        Dentysta, 
        /// <summary>
        /// Specjalizacja kardiolog
        /// </summary>
        Kardiolog, 
        /// <summary>
        /// Specjalizacja okulista
        /// </summary>
        Okulista, 
        /// <summary>
        /// Specjalizacja pediatra
        /// </summary>
        Pediatra, 
        /// <summary>
        /// Specjalizacja laryngolog
        /// </summary>
        Laryngolog, 
        /// <summary>
        /// brak specjalizacji
        /// </summary>
        BRAK}
    class Program
    {
        static void LekarzeIUslugi()
        {

            Pacjent pp1 = new Pacjent("Robert", "Dziwak", "12345678910", "12.05.2000");
            Pacjent pp2 = new Pacjent("Kornel", "Makuszyński", "0021504582", "12.02.1996");
            PacjentZagraniczny pp3 = new PacjentZagraniczny("Pablo", "Escobar", "582752197519521", "15.06.1982");
            LekarzSpecjalista l3 = new LekarzSpecjalista("Jan", "Janowski", "15.03.1982", Specjalizacja.Okulista);
            LekarzSpecjalista l4 = new LekarzSpecjalista("Jan", "But", "16.05.1974", Specjalizacja.Kardiolog);
            LekarzSpecjalista l5 = new LekarzSpecjalista("Beata", "Nowak", "22.11.1966", Specjalizacja.BRAK);
            LekarzSpecjalista l6 = new LekarzSpecjalista("Anna", "Mysza", "22.07.1970", Specjalizacja.Dentysta);
            LekarzSpecjalista l7 = new LekarzSpecjalista("Krzysztof", "Ratajski", "17.05.1975", Specjalizacja.Pediatra);
            LekarzSpecjalista l8 = new LekarzSpecjalista("Pawel", "Paczul", "01.03.1977", Specjalizacja.Chirurg);
            LekarzSpecjalista l9 = new LekarzSpecjalista("Wojciech", "Kowalczyk", "12.10.1969", Specjalizacja.Laryngolog);

            PodstawowaOpiekaZdrowotna poz1 = new PodstawowaOpiekaZdrowotna("Poradnia internistyczna dla doroslych", (decimal)50, 30);
            PodstawowaOpiekaZdrowotna poz2 = new PodstawowaOpiekaZdrowotna("Poradnia pediatryczna", (decimal)60, 30);

            AmbulatoryjnaOpiekaSpecjalistyczna aos1 = new AmbulatoryjnaOpiekaSpecjalistyczna("Poradnia laryngologiczna", (decimal)100, 60);
            AmbulatoryjnaOpiekaSpecjalistyczna aos2 = new AmbulatoryjnaOpiekaSpecjalistyczna("Poradnia okulistyczna", (decimal)100, 60);

            PracowniaDiagnostyczna pd1 = new PracowniaDiagnostyczna("EKG", (decimal)40, 10);
            PracowniaDiagnostyczna pd2 = new PracowniaDiagnostyczna("USG", (decimal)40, 10);

            Przychodnia p1 = new Przychodnia("Zdrowko");

            p1.DodajLekarza(l3);
            p1.DodajLekarza(l4);
            p1.DodajLekarza(l5);
            p1.DodajLekarza(l6);
            p1.DodajLekarza(l7);
            p1.DodajLekarza(l8);
            p1.DodajLekarza(l9);

            p1.DodajUsluge(poz1);
            p1.DodajUsluge(poz2);
            p1.DodajUsluge(aos1);
            p1.DodajUsluge(aos2);
            p1.DodajUsluge(pd1);
            p1.DodajUsluge(pd2);

            p1.DodajPacjenta(pp1);
            p1.DodajPacjenta(pp2);
            p1.DodajPacjenta(pp3);

            Wizyta w1 = new Wizyta(pp1, l4, poz1, "2021-02-10 10:30");
            Wizyta w2 = new Wizyta(pp2, l6, poz2, "2021-02-11 15:15");

            p1.UmowWizyte(w1);
            p1.UmowWizyte(w2);

            p1.ZapiszXML("przychodnia.xml");
            Przychodnia p3 = Przychodnia.OdczytajXML("przychodnia.xml");
            p1.WypiszLekarzy();
            p3.WypiszLekarzy();
        }
        static void Main(string[] args)
        {
            LekarzeIUslugi();
        }
    }
}
