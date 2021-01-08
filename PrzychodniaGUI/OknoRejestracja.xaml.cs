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
    /// Logika interakcji dla klasy OknoRejestracja.xaml
    /// </summary>
    public partial class OknoRejestracja : Window
    {
        Pacjent _pacjent;
        Przychodnia p;
        public OknoRejestracja()
        {
            InitializeComponent();
            p = Przychodnia.OdczytajXML("przychodnia.xml");
        }

        public OknoRejestracja(Pacjent pacjent) : this()
        {
            _pacjent = pacjent;
            if(pacjent is Pacjent)
            {
                txtPesel.Text = pacjent.Pesel;
                txtImie.Text = pacjent.Imie;
                txtNazwisko.Text = pacjent.Nazwisko;
                txtDataUrodzenia.Text = pacjent.DataUrodzeniaPacjenta.ToString("dd-MMM-yyyy");
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool ret = false;
            if (txtPesel.Text != "" && txtImie.Text != "" && txtNazwisko.Text != "" && txtDataUrodzenia.Text != "")
            {
                _pacjent.Imie = txtImie.Text;
                _pacjent.Nazwisko = txtNazwisko.Text;
                _pacjent.Pesel = txtPesel.Text;
                string[] fdate = { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy, dd-MMM-yyyy" };
                DateTime.TryParseExact(txtDataUrodzenia.Text, fdate, null, DateTimeStyles.None, out DateTime date);
                _pacjent.DataUrodzeniaPacjenta = date;
                ret = true;
            }
            DialogResult = ret;
        }

        private void BtnZamknij_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
