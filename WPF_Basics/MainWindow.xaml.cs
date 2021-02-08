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

namespace WPF_Basics
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Esto sobre escribe lo que este definido en el XAML file.
            // Aqui podemos agregar nuevos componentes.
            Grid grid = new Grid();
            // Agregamos una grid a la ventana.
            this.Content = grid;
            Button btn = new Button();
            btn.Content = "Button Created with C#";
            btn.FontSize = 16;
            btn.Height = 30;
            btn.Width = 300;

            WrapPanel wrapPanel = new WrapPanel();
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Contenido 1";
            textBlock.Foreground = Brushes.AliceBlue;
            wrapPanel.Children.Add(textBlock);

            textBlock = new TextBlock();
            textBlock.Text = "Contenido 2";
            textBlock.Foreground = Brushes.Aquamarine;
            wrapPanel.Children.Add(textBlock);

            textBlock = new TextBlock();
            textBlock.Text = "Contenido 3";
            textBlock.Foreground = Brushes.Beige;
            wrapPanel.Children.Add(textBlock);

            btn.Content = wrapPanel;

            grid.Children.Add(btn);

        }
    }
}
