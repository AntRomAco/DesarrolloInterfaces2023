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

namespace LetraNIF
{
    /// <summary>
    /// Lógica de interacción para CalcularLetraNIF.xaml
    /// </summary>
    public partial class CalcularLetraNIF : Page
    {
        public CalcularLetraNIF()
        {
            InitializeComponent();
        }
        private void CalcularClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtDNI.Text, out var dniNumeros))
            {
                char letraNIF = OperacionLetraNIF(dniNumeros);
                blockNIF.Text = letraNIF.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, introduce números válidos de DNI.");
            }
        }
        private char OperacionLetraNIF(int dniNumeros)
        {
            string letrasNIF = "TRWAGMYFPDXBNJZSQVHLCKE";
            int resto = dniNumeros % 23;
            return letrasNIF[resto];
        }
    }
}
