using System.Windows;
using Vraag2.Library;

namespace Vraag1.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // pad naar de JSON-bestanden
        private const string dataFolder = @"C:\temp\movies\";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            // knop "load movies" disablen, zodat de gebruiker dit proces niet meerdere keren kan starten
            BtnLoad.IsEnabled = false;

            Helper.LoadMovies(dataFolder);
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
  

            // deze regel geeft de lijst van zoekresultaten weer in de GUI
            TxtResults.Text = string.Join("\n", Helper.SearchMovies(TxtSearchTerm.Text));
        }


    }
}
