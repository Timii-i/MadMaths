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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MadMaths.pages
{
    /// <summary>
    /// Interaktionslogik für challengeAuswahl.xaml
    /// </summary>
    public partial class challengeAuswahl : Page
    {
        public challengeAuswahl()
        {
            InitializeComponent();
        }
        private void ThemenBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); // Bei Klick zurück auf die Startseite;
        }
        private void StufenClick(object sender, RoutedEventArgs e)
        {
            Controller.currentPage = (sender as Button).Content.ToString();     // speichert den Namen des geclickten Buttons
            NavigationService.Navigate(new ThemenAuswahl()); // Bei Klick Änderung der Page auf die Themenauswahl
        }
    }
}