﻿using System;
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
    /// Logika interakcji dla klasy OknoWizytaUmowiona.xaml
    /// </summary>
    public partial class OknoWizytaUmowiona : Window
    {
        public OknoWizytaUmowiona()
        {
            InitializeComponent();
        }

        private void btWroc_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
