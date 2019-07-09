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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        //Metodo Para  utilizar el ChekBox
        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
          
        }

        private void BtnContinuar_Click(object sender, RoutedEventArgs e)
        {

            if (cbLiviano.IsChecked == false && cbMediano.IsChecked == false && cbPesado.IsChecked == false)
            {
                MessageBox.Show("Debe Seleccionar una opción para continuar","Información",MessageBoxButton.OK,MessageBoxImage.Exclamation);
            }
            else
            {
                DatosVehiculo datosVehiculo = new DatosVehiculo();
                datosVehiculo.Show();
                this.Close();
            }
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
