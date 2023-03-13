using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PagePW6.xaml
    /// </summary>
    public partial class PagePW6 : Page
    {
        public PagePW6()
        {
            InitializeComponent();
        }

        private void btnListFromFile_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"строки.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                lstInput.Items.Add(sr.ReadLine());
            }
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {   
            string s = txtInputDes.Text;
            string[] ss = s.Split(' ');
            int cnt = ss.Count(f => Convert.ToInt32(f) % 2 == 0);
            lstInput.Items.Add(cnt);

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInputDes.Clear();
            lstInput.Items.Clear();
        }
    }
}
