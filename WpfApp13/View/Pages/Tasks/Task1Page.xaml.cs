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
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int a, b;

            a = Convert.ToInt32(Tba.Text);
            b = Convert.ToInt32(Tbb.Text);

            if (a > b)
            {
                TbA.Text = "А должно быть меньше В";
            }
            else
            {
                Task1 task1 = new Task1(a, b);

                List<int> numbers = task1.FindNumbers();

                TbA.Text = $"{string.Join(", ", numbers)}\nКол-во N этих чисел = {task1.FindN()}";
            }
            Tba.Text = string.Empty;
            Tbb.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task2Page());
        }
    }
}
