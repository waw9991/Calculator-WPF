using Kuznetsov.Calculator.Logic;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Kuznetsov.Calculator.WPF
{
    public partial class MainWindow : Window
    {
        private readonly Kuznetsov.Calculator.Logic.Calculator _calculator = new Kuznetsov.Calculator.Logic.Calculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOperation_Click(object sender, RoutedEventArgs e)
        {
            txtError.Text = "";
            txtResult.Text = "";

            try
            {
                double a = double.Parse(txtFirst.Text);
                double b = double.Parse(txtSecond.Text);
                string op = ((Button)sender).Tag?.ToString() ?? "";
                double result = op switch
                {
                    "+" => _calculator.Add(a, b),
                    "-" => _calculator.Subtract(a, b),
                    "*" => _calculator.Multiply(a, b),
                    "/" => _calculator.Divide(a, b),
                    "^" => _calculator.Power(a, b),
                    _ => throw new InvalidOperationException("Неизвестная операция")
                };

                txtResult.Text = result.ToString("F4");
            }
            catch (FormatException)
            {
                txtError.Text = "Ошибка: введите корректные числа";
            }
            catch (DivideByZeroException ex)
            {
                txtError.Text = $"Ошибка: {ex.Message}";
            }
            catch (Exception ex)
            {
                txtError.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}