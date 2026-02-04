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
            int wartosc_klucza_ = int.Parse(wartosc_klucza.Text);
            string text_do_szyfru_ = text_do_szyfru.Text;

            MessageBox.Show(text_do_szyfru_+", "+ wartosc_klucza_);
        }

        private void zapisz_w_txt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}