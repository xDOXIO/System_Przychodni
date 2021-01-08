using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SystemRejestracjiWPrzychodni;

namespace PrzychodniaGUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Przychodnia _przychodnia;
        public MainWindow()
        {
            InitializeComponent();
            _przychodnia = Przychodnia.OdczytajXML("przychodnia.xml");
        }

        private void BtnZaloguj_Click(object sender, RoutedEventArgs e)
        {
            bool torf = true;
            foreach(Pacjent pacj in _przychodnia.Pacjenci)
            {
                if(pacj.Imie == txtImie.Text & pacj.Nazwisko == txtNazwisko.Text)
                {
                    torf = false;
                    this.Hide();
                    OknoPanelKlienta panel = new OknoPanelKlienta();
                    panel.Show();
                }
            }
            if(torf)
            {
                OknoBladLogowania obl = new OknoBladLogowania();
                bool? ret = obl.ShowDialog();
            }
        }

        private void btnZarejestruj_Click(object sender, RoutedEventArgs e)
        {
            Pacjent p = new Pacjent();
            OknoRejestracja o = new OknoRejestracja(p);
            
            bool? ret = o.ShowDialog();
            if(ret==true)
            {
                _przychodnia = Przychodnia.OdczytajXML("przychodnia.xml");
                _przychodnia.DodajPacjenta(p);
                _przychodnia.ZapiszXML("przychodnia.xml");
            }
            
        }

        private void btnRejestracjaZagraniczna_Click(object sender, RoutedEventArgs e)
        {
            PacjentZagraniczny pz = new PacjentZagraniczny();
            OknoRejestracjaZagraniczna o = new OknoRejestracjaZagraniczna(pz);
            bool? ret = o.ShowDialog();
            if (ret == true)
            {
                _przychodnia = Przychodnia.OdczytajXML("przychodnia.xml");
                _przychodnia.DodajPacjenta(pz);
                _przychodnia.ZapiszXML("przychodnia.xml");
            }
        }

        private void btnWyjdz_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
