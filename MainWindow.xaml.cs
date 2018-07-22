﻿using System;
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
            InputBox.Text = calculator.currentInput.stringValue;
        }

        private void DigitClick(Object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button == null) return;

            calculator.ParseInput(button.Content.ToString());
            UpdateInputBox();
        }
    }
}
