using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace CSharpCalculator
{
    public partial class MainWindow : Window
    {
        Calculator calculator;

        public MainWindow()
        {
            calculator = new Calculator();
            InitializeComponent();
        }

        private void DigitClick(Object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button)) return;

            calculator.ParseInput(button.Content.ToString());

            InputBox.Text = calculator.currentInput.StringValue;
        }
    }
}
