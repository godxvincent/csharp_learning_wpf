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

namespace WPF_09_ListBox_ListCurrentMatches
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid",  Score1 = 3, Score2 = 2, Completion=85});
            matches.Add(new Match() { Team1 = "PSG", Team2 = "Barca",  Score1 = 1, Score2 = 2, Completion=35});
            matches.Add(new Match() { Team1 = "BVB Dortmund", Team2 = "AS Roma",  Score1 = 2, Score2 = 2, Completion=15});
            matches.Add(new Match() { Team1 = "Man United", Team2 = "La Galaxy",  Score1 = 5, Score2 = 3, Completion=45});
            // Aqui agregamos la lista al listbox
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem != null)
            {
                var matchSelected = (lbMatches.SelectedItem as Match);
                MessageBox.Show(
                    "Selected Match => (" +
                    matchSelected.Team1 +
                    " [" +
                    matchSelected.Score1 +
                    "-" +
                    matchSelected.Score2 +
                    "] " +
                    matchSelected.Team2 +
                    ") Completion " +
                    matchSelected.Completion
                    );
            } else
            {
                MessageBox.Show("Por favor seleccione un match");
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }

    }
}
