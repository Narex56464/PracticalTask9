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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
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
                Task5 task5 = new Task5(a, N);

                TbA.Text = $"{task5.PositiveExpression()}\n{task5.NegativeExpression()}";
            }
            Tba.Text = string.Empty;
            TbN.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task6Page());
        }
    }
}
