using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using System.Windows.Shapes;
using SystemRejestracjiWPrzychodni;

namespace PrzychodniaGUI
{
    /// <summary>
    /// Logika interakcji dla klasy OknoUmowWizyte.xaml
    /// </summary>
    public partial class OknoUmowWizyte : Window
    {
        Wizyta _wizyta;
        Przychodnia p;
        public OknoUmowWizyte()
        {
            InitializeComponent();
            p = Przychodnia.OdczytajXML("przychodnia.xml");
            lstLekarze.ItemsSource = new ObservableCollection<LekarzSpecjalista>(p.Lekarze);
            lstUslugi.ItemsSource = new ObservableCollection<Usluga>(p.Uslugi);
        }
        public OknoUmowWizyte(Wizyta w) : this()
        {
            _wizyta = w;
        }

        private void btUmow_Click(object sender, RoutedEventArgs e)
        {
            bool? ret = false;
            bool czyblad = false;
            if (txtImie.Text != "" & txtNazwisko.Text != "" & txtData.Text != "" & lstLekarze.SelectedIndex > -1 & lstUslugi.SelectedIndex > -1)
            {
                foreach (Pacjent pacj in p.Pacjenci)
                {
                    if (pacj.Imie == txtImie.Text & pacj.Nazwisko == txtNazwisko.Text)
                    {
                        _wizyta.Pacjent = pacj;
                        _wizyta.LekarzSpecjalista = (LekarzSpecjalista)lstLekarze.SelectedItem;
                        _wizyta.Usluga = (Usluga)lstUslugi.SelectedItem;
                        DateTime d = new DateTime();
                        DateTime.TryParseExact(txtData.Text, new[] { "MM/dd/yyyy H:mm", "yyyy-MM-dd H:mm", "yyyy/MM/dd H:mm", "dd-MMM-yy H:mm", "dd.MM.yyyy H:mm" }, null, DateTimeStyles.None, out d);
                        DateTime dzis = DateTime.Now;
                        TimeSpan result = d - dzis;
                        _wizyta.DataGodzinaWizyty = d;
                        foreach(Wizyta wiz in p.Wizyty)
                        {
                            if(_wizyta.Equals(wiz))
                            {
                                czyblad = true;
                                OknoBladUmow obu = new OknoBladUmow();
                                bool? ret2 = obu.ShowDialog();
                            }
                        }
                        if (result.TotalDays < 1)
                        {
                            czyblad = true;
                            OknoBladUmow obu = new OknoBladUmow();
                            bool? ret2 = obu.ShowDialog();
                        }
                        else
                        {
                            
                            ret = true;
                        } 
                    }
                }
            }
            if(!czyblad)
            {
                OknoWizytaUmowiona obl = new OknoWizytaUmowiona();
                bool? ret1 = obl.ShowDialog();
                DialogResult = ret;
            }
        }

        private void btAnuluj_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
