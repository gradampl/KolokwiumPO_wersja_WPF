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

namespace Wpf_KolokwiumW3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Azja azja = new Azja();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            string nazwa=nazwaKraju1.Text;
            string nazwaStolicy=stolica1.Text;
            int powierzchnia = -1;
            try
            {
                powierzchnia = Convert.ToInt32(powierzchnia1.Text);
            }
            catch(FormatException ex)
            {
                wypisz.Text=ex.ToString();
            }
            bool lotnisko;
            if (lotnisko1.Text=="Tak")
            {
                lotnisko=true;
            }
            else
            lotnisko=false;
          
            azja.Dodaj(nazwa, powierzchnia, nazwaStolicy, lotnisko);
        }

        private void usun_Click(object sender, RoutedEventArgs e)
        {
            string nazwa=krajDoUsuniecia1.Text;
            
            azja.Usun(nazwa);
        }

        private void usunPierwszy_Click(object sender, RoutedEventArgs e)
        {
            azja.Usun();
        }

        private void pokazKraje_Click(object sender, RoutedEventArgs e)
        {
            wypisz.Text=azja.Kraje();
        }

        private void pokazStolice_Click(object sender, RoutedEventArgs e)
        {
            wypisz.Text = azja.Stolice();
        }

        private void sprawdz_Click(object sender, RoutedEventArgs e)
        {
            string nazwa = nazwaDoSprawdzenia1.Text;
            if (azja.Sprawdz(nazwa))
                wypisz.Text = String.Format("Znaleziono! Jest kraj o nazwie {0}.", nazwa);
            else
                wypisz.Text = String.Format("Nie znaleziono {0}.", nazwa);
        }

        private void lotnisko1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        

        
        
    }
}
