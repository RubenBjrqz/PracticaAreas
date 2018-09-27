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

namespace PracticaAreas
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

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelConfiguracion.Children.Clear();
            switch(cbTipoFigura.SelectedIndex)
            {
                case 0: //Rectangulo
                    panelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;
                case 1: //Triangulo
                    panelConfiguracion.Children.Add(new ControlAreasTriangulo());
                    break;
                case 2: //Circulo
                    panelConfiguracion.Children.Add(new ControlAreaCirculo());
                    break;
                case 3: //Trapecio
                    panelConfiguracion.Children.Add(new ControlAreaTrapecio());
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //Rectangulo
                   
                    break;
                case 1: //Triangulo
                  
                    break;
                case 2: //Circulo
                   
                    break;
                case 3: //Trapecio
                 
                    break;
                default:
                    break;
            }
            lblResultadoArea.Text = area.ToString();
        }

    }
   
}
