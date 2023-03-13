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

namespace Лабораторная_работа__1_Глазкова_Труфанова.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePW2.xaml
    /// </summary>
    public partial class PagePW2 : Page
    {
        public PagePW2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            double i = Convert.ToDouble(txti.Text);
            double x = Convert.ToDouble(txtX.Text);
            int n = 0;
            double k;
            if (double.TryParse(txtX.Text, out x) != true)
            {
                MessageBox.Show("Error Input");
                txtX.Text = string.Empty;
                txtX.Focus();
                return;
            }
            try
            {

                if (rbtCos.IsChecked == true) n = 1;
                else if (rbtExp.IsChecked == true) n = 2;
                switch (n)
                {
                    case 0:
                        if (x > 0 && i % 2 == 1)
                            k = i * Math.Sqrt(Math.Sin(x));
                        else if (x < 0 && i % 2 == 0) k = (i / 2) * Math.Sqrt(Math.Abs(Math.Sin(x)));
                        else k = Math.Sqrt(Math.Abs(i * Math.Sin(x)));
                        lstResult.Items.Add($"Результат k={k}");
                        break;
                    case 1:
                        if (x > 0 && i % 2 == 1) k = i * Math.Sqrt(Math.Cos(x));
                        else if (x < 0 && i % 2 == 0) k = (i / 2) * Math.Sqrt(Math.Abs(Math.Cos(x)));
                        else k = Math.Sqrt(Math.Abs(i * Math.Sqrt(Math.Cos(x))));
                        lstResult.Items.Add($"Результат k={k}");
                        break;
                    case 2:
                        if (x > 0 && i % 2 == 1) k = i * Math.Sqrt(Math.Exp(x));
                        else if (x < 0 && i % 2 == 0) k = (i / 2) * Math.Sqrt(Math.Abs(Math.Exp(x)));
                        else k = Math.Sqrt(Math.Abs(i * Math.Sqrt(Math.Exp(x))));
                        lstResult.Items.Add($"Результат k={k}");
                        break;
                    default:
                        lstResult.Items.Add("Решение не найдено");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проверьте ввод исходных данных {ex.Message}");
            }


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txti.Clear();
            lstResult.Items.Clear();
        }
    }
}
