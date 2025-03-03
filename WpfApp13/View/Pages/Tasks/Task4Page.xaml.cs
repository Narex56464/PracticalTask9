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
using WpfApp13.Core;
using WpfApp13.Core.Tasks;

namespace WpfApp13.View.Pages.Tasks
{
    /// <summary>
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int N;
            double a;
            a = Convert.ToDouble(Tba.Text);
            N = Convert.ToInt32(TbN.Text);

            if (N <= 0)
            {
                TbA.Text = "N должно быть больше 0";
            }
            else
            {
                Task4 task4 = new Task4(a, N);

                List<int> degree = task4.FindDegree();

                TbA.Text = $"{string.Join(", ", degree)}";
            }
            Tba.Text = string.Empty;
            TbN.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task5Page());
        }
    }
}
