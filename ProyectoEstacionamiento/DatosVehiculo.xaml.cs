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
using System.Windows.Shapes;

namespace ProyectoEstacionamiento
{
    /// <summary>
    /// Lógica de interacción para DatosVehiculo.xaml
    /// </summary>
    public partial class DatosVehiculo : Window
    {
        public DatosVehiculo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }
    }
}
