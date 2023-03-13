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
    /// Логика взаимодействия для PagePW3.xaml
    /// </summary>
    public partial class PagePW3 : Page
    {
        public PagePW3()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, RoutedEventArgs e)
        {
            double X0 = Convert.ToDouble(txtInputX0.Text);
            double Xk = Convert.ToDouble(txtInputXk.Text);
            double Dx = Convert.ToDouble(txtInputDx.Text);
            double D = Convert.ToDouble(txtInputD.Text);

            if (double.TryParse(txtInputX0.Text, out D) !=true)
            {
                MessageBox.Show("Error Input");
                txtInputX0.Text = string.Empty;
                txtInputX0.Focus();
                return;
            }
            try
            {
                for (double x = X0; x <= Xk; x += Dx)
                {
                    double y = Math.Pow(x, 4) + Math.Cos(2 + Math.Pow(x, 3) - D);
                    lstResult.Items.Add($"x={Math.Round(x, 2)} y= {Math.Round(y, 3)}");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проверьте ввод исходных данных {ex.Message}");
            }
            }
        }
    }