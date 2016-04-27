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

namespace FyndDyne
{
    /// <summary>
    /// Interaction logic for Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void LogoutButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.User = null;
            MainWindow.Type = null;
            new MainWindow().Show();
            this.Close();
        }

        private void RemoveItem(object sender, RoutedEventArgs e)
        {

        }
    }
}
