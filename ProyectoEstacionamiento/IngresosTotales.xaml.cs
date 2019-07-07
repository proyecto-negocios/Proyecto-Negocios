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
    /// Lógica de interacción para IngresosTotales.xaml
    /// </summary>
    public partial class IngresosTotales : Window
    {
        public IngresosTotales()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow regresar = new MainWindow();
            regresar.Show();
            this.Close();
        }
    }
}
