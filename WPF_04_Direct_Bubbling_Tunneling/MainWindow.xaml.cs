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

namespace WPF_04_Direct_Bubbling_Tunneling
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // El sender es una referencia al objeto que genera el evento.
            MessageBox.Show("Button was clicked - Direct Event");
        }

        // Los eventos bubbling van al final de la jerarquia de eventos en el arbol de componentes.
        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Button went up / was released - Bubbling Event");
        }

        // Los eventos tunneling van al inicio de la jerarquia de eventos en el arbol de componentes.
        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Button went up / was released - Tunneling Event");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Button_PreviewMouseLeftButtonDown");
        }

        private void Button_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse Button_PreviewMouseRightButtonDown");
        }
    }
}
