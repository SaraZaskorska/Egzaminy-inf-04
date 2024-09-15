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

namespace Styczen_2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imie2= imie.Text;
            string numer2=numer.Text;
            string nazwisko2=nazwisko.Text;
            string kolorOczu="";
            if(niebieskie.IsChecked == true)
            {
                kolorOczu = "niebieskie";
            }
            if(zielone.IsChecked == true)
            {
                kolorOczu = "zielone";
            }
            if(piwne.IsChecked == true)
            {
                kolorOczu = "piwne";
            }
            if(imie2 == "" || nazwisko2 == "")
            {
                MessageBox.Show("wprowadz dane");
            }
            else
            {
                MessageBox.Show(imie2 +" "+ nazwisko2 + " kolor oczu " + kolorOczu);
            }
        }
    }
}
