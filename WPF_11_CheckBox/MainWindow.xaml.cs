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

namespace WPF_11_CheckBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbAllTopings_Changed(object sender, RoutedEventArgs e)
        {
            var allTopings = (cbAllTopings.IsChecked == true);
            cbMozzarela.IsChecked = allTopings;
            cbMushrooms.IsChecked = allTopings;
            cbSalami.IsChecked = allTopings;
        }
        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllTopings.IsChecked = null;
            if (cbMozzarela.IsChecked == true && cbMushrooms.IsChecked == true && cbSalami.IsChecked == true)
            {
                cbAllTopings.IsChecked = true;
            } else if (cbMozzarela.IsChecked == false && cbMushrooms.IsChecked == false && cbSalami.IsChecked == false)
             {
                cbAllTopings.IsChecked = false;
            }
        }
    }
}
