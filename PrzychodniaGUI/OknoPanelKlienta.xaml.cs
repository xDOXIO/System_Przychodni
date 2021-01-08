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
using System.Windows.Shapes;
using SystemRejestracjiWPrzychodni;

namespace PrzychodniaGUI
{
    /// <summary>
    /// Logika interakcji dla klasy OknoPanelKlienta.xaml
    /// </summary>
    public partial class OknoPanelKlienta : Window
    {
        Przychodnia p;
        public OknoPanelKlienta()
        {
            InitializeComponent();
            p = Przychodnia.OdczytajXML("przychodnia.xml");
        }

        private void btLekarze_Click(object sender, RoutedEventArgs e)
        {
            OknoListaLekarzy llw = new OknoListaLekarzy();
            bool? ret = llw.ShowDialog();
        }

        private void btUslugi_Click(object sender, RoutedEventArgs e)
        {
            OknoListaUslug llw = new OknoListaUslug();
            bool? ret = llw.ShowDialog();
        }

        private void btUmow_Click(object sender, RoutedEventArgs e)
        {
            Wizyta w = new Wizyta();
            OknoUmowWizyte wiz = new OknoUmowWizyte(w);

            bool? ret = wiz.ShowDialog();
            if (ret == true)
            { 
                p.UmowWizyte(w);
                p.ZapiszXML("przychodnia.xml");
            }
        }
        private void btWyjdz_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
