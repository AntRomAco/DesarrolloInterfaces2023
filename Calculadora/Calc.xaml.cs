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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para Calc.xaml
    /// </summary>
    public partial class Calc : Page
    {
        private string input = string.Empty;
        private string opSimbol = string.Empty;
        private double result = 0;
        public Calc()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Content.ToString();

            if (buttonText == "C")
            {
                input = string.Empty;
                opSimbol = string.Empty;
                result = 0;
                Display.Text = "";
                Simbol.Text = "";
            } else if (buttonText == "=") { CalculateResult(); }
            else if (buttonText == ",") { if (!input.Contains(",")) { input += buttonText; } }
            else if (buttonText == "+" || buttonText == "-" || buttonText == "*" || buttonText == "/")
            {
                if (!string.IsNullOrEmpty(opSimbol)) { CalculateResult(); }
                Simbol.Text = buttonText;
                opSimbol = buttonText;
                result = double.Parse(input);
                input = string.Empty;
            } else if (buttonText == "<<") {
                if (input.Length > 0)
                {
                    input = input.Substring(0, input.Length - 1);
                    Display.Text = input;
                }
            } else {
                input += buttonText;
                Display.Text = input;
            }
        }

        private void CalculateResult()
        {
            if (!string.IsNullOrEmpty(opSimbol) && !string.IsNullOrEmpty(input))
            {
                double operand = double.Parse(input);
                switch (opSimbol)
                {
                    case "+": result += operand; break;
                    case "-": result -= operand; break;
                    case "*": result *= operand; break;
                    case "/": if (operand != 0) { result /= operand; }
                        else { MessageBox.Show("División por cero no permitida."); }
                        break;
                }
            }

            opSimbol = string.Empty;
            input = result.ToString();
            Display.Text = input;
            Simbol.Text = "";
        }
    }
}
