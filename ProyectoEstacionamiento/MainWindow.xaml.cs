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

namespace ProyectoEstacionamiento
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
       
        private void BtnIngresaVehiculo_Click(object sender, RoutedEventArgs e)
        {
            Window1 TipoVehiculo = new Window1();
            TipoVehiculo.Show();
            this.Close();
        }

        private void BtnSacarVehiculo_Click(object sender, RoutedEventArgs e)
        {
            VentanaSacarVehiculo ventanaSacarVehiculo = new VentanaSacarVehiculo();
            ventanaSacarVehiculo.Show();
            this.Close();
        }
    }
}
