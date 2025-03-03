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
    /// Логика взаимодействия для Task17Page.xaml
    /// </summary>
    public partial class Task17Page : Page
    {
        public Task17Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(TbN.Text);
            double a, b;

            a = Convert.ToDouble(Tba.Text);
            b = Convert.ToDouble(Tbb.Text);

            if (N <= 2)
            {
                TbA.Text = "N должен быть больше 0";
            }
            else if (a > b)
            {
                TbA.Text = "A должен быть меньше B";
            }
            else
            {
                Task17 task17 = new Task17(N, a, b);

                var result = task17.ValuesF();

                TbA.Text = "\nx = [";
                foreach (var item in result.result)
                {
                    TbA.Text += $"{item}, ";
                }
                TbA.Text += "]";

                TbA.Text += "\nF(x) = [";
                foreach (var item in result.function)
                {
                    TbA.Text += $"{item}, ";
                }
                TbA.Text += "]";
            }
            Tba.Text = string.Empty;
            Tbb.Text = string.Empty;
            TbN.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task18Page());
        }
    }
}
