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
//Agregar los namespaces nesesarios para SQL Server
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Repaso_Ejercicio_Zoologico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variable miembro
        SqlConnection sqlconnection;

        //Constructor
        //RAMON HA ACTUALIZADO ESTE REPOSITORIO
        public MainWindow()
        {
            InitializeComponent();

            // ZoologicoConnectionString
            string connectionString = ConfigurationManager.ConnectionStrings["Repaso_Ejercicio_Zoologico.Properties.Settings.ZoologicoConnectionString"].ConnectionString;
            sqlconnection = new SqlConnection(connectionString);
        }

        private void BtnEliminarZoologico_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnRemoverAnimalZoologico_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEliminarAnimales_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAgregarZoologico_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAñadirAnimalZoologico_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnActualizarNombreAnimal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
