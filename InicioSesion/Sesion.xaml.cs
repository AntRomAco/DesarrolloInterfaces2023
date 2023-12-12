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

namespace InicioSesion
{
    /// <summary>
    /// Lógica de interacción para Sesion.xaml
    /// </summary>
    public partial class Sesion : Page
    {
        public Sesion()
        {
            InitializeComponent();
        }
        private void LoginClick(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPswd.Password;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, introduzca un usuario y contraseña.");
            } else
            {
                MessageBox.Show("Bienvenido " + usuario);
            }
        }
        private void CancelarClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
