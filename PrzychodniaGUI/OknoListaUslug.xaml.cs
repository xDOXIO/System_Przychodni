﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logika interakcji dla klasy OknoListaUslug.xaml
    /// </summary>
    public partial class OknoListaUslug : Window
    {
        Przychodnia p;
        public OknoListaUslug()
        {
            p = Przychodnia.OdczytajXML("przychodnia.xml");
            InitializeComponent();
            lstUslugi.ItemsSource = new ObservableCollection<Usluga>(p.Uslugi);
        }

        private void btWroc_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
