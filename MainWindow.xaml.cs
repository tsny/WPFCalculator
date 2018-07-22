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

namespace CSharpCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator calculator;

        public MainWindow()
        {
            calculator = new Calculator();
            InitializeComponent();
            UpdateInputBox();
        }

        private void UpdateInputBox()
        {
            InputBox.Text = calculator.currentInput.StringValue;
        }

        private void DigitClick(Object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button == null) return;

            calculator.currentInput.AddDigit(int.Parse(button.Content.ToString()));
            UpdateInputBox();
        }

        private void DecimalClick(object sender, RoutedEventArgs e)
        {
            calculator.currentInput.AddDecimal();
        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            calculator.Clear();
        }
    }
}
