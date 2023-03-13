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
    /// Логика взаимодействия для PagePW1.xaml
    /// </summary>
    public partial class PagePW1 : Page
    {
        private double sin;

        public PagePW1()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            double y= Convert.ToDouble(TxtInputY.Text);
            double z= Convert.ToDouble(TxtInputZ.Text);
            double x; 
            if (double.TryParse(TxtInputX.Text, out x) !=true)
                {
                MessageBox.Show("Error Input");
                TxtInputX.Text = string.Empty;
                TxtInputX.Focus();
                return;
                }
            try
            {
                double a = (Math.Log(Math.Pow(y, -Math.Sqrt(Math.Abs(x)))) * (x - (y / 2) + Math.Pow(sin, 2)*Math.Atan(z)));
                LstResult.Items.Clear();
                LstResult.Items.Add("Пр.раб.№1, МДК.01.01, ИСП.21.1 Глазкова, Труфанова");
                LstResult.Items.Add($"x = {x}");
                LstResult.Items.Add($"y = {y}");
                LstResult.Items.Add($"z = {z}");
                LstResult.Items.Add($"Результат a ={a}");
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Проверьте ввод исходных данных {ex.Message}");
            }
        }
    }
}
