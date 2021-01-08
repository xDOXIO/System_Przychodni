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

namespace PrzychodniaGUI
{
    /// <summary>
    /// Logika interakcji dla klasy OknoBladUmow.xaml
    /// </summary>
    public partial class OknoBladUmow : Window
    {
        public OknoBladUmow()
        {
            InitializeComponent();
        }

        private void btWroc_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
