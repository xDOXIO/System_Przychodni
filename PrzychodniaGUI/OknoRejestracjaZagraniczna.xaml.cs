using System;
using System.Collections.Generic;
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
    /// Logika interakcji dla klasy OknoRejestracjaZagraniczna.xaml
    /// </summary>
    public partial class OknoRejestracjaZagraniczna : Window
    {
        PacjentZagraniczny _pacjentz;
        public OknoRejestracjaZagraniczna(PacjentZagraniczny pacjent) : this()
        {
            _pacjentz = pacjent;
            if (pacjent is PacjentZagraniczny)
            {
                txtEkuz.Text = pacjent.NrEKUZ;
                txtImie.Text = pacjent.Imie;
                txtNazwisko.Text = pacjent.Nazwisko;
                txtDataUrodzenia.Text = pacjent.DataUrodzeniaPacjenta.ToString("dd-MMM-yyyy");
            }
        }
        public OknoRejestracjaZagraniczna()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool ret = false;
            if (txtEkuz.Text != "" && txtImie.Text != "" && txtNazwisko.Text != "" && txtDataUrodzenia.Text != "")
            {
                _pacjentz.Imie = txtImie.Text;
                _pacjentz.Nazwisko = txtNazwisko.Text;
                _pacjentz.NrEKUZ = txtEkuz.Text;
                string[] fdate = { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy" };
                DateTime.TryParseExact(txtDataUrodzenia.Text, fdate, null, DateTimeStyles.None, out DateTime date);
                _pacjentz.DataUrodzeniaPacjenta = date;
                ret = true;
            }
            DialogResult = ret;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
