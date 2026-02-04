using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace egzamin26czer2
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

        private void zaszyfruj_Click(object sender, RoutedEventArgs e)
        {
            /*
            int wartosc_klucza_ = int.Parse(wartosc_klucza.Text);
            string text_do_szyfru_ = text_do_szyfru.Text;
            string zaszyfrowany_text_ = "mial";

            MessageBox.Show("text: "+text_do_szyfru_+", klucz: "+ wartosc_klucza_+", szyfr: "+zaszyfrowany_text_);
            */

            int wartosc_klucza_cs = int.Parse(wartosc_klucza.Text);
            string text_do_szyfru_cs = text_do_szyfru.Text;

            string wynik = "";

            foreach (char c in text_do_szyfru_cs)
            {
                if (char.IsLetter(c))
                {
                    char start = char.IsUpper(c) ? 'A' : 'a';
                    char zaszyfrowany = (char)((c - start + wartosc_klucza_cs) % 26 + start);
                    wynik += zaszyfrowany;
                }
                else
                {
                    wynik += c; // spacje, znaki specjalne
                }
            }

            zaszyfrowany_text.Text = wynik;

        }

        private void zapisz_w_txt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}