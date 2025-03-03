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
    /// Логика взаимодействия для Task29Page.xaml
    /// </summary>
    public partial class Task29Page : Page
    {
        public Task29Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(Tba.Text);
            int N = Convert.ToInt32(TbN.Text);

            if (N <= 0)
            {
                TbA.Text = "N должен быть больше 0";
            }
            else
            {
                Task29 task29 = new Task29(a, N);

                TbA.Text = task29.DiffirentSquares();
            }
            Tba.Text = string.Empty;
            TbN.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task30Page());
        }
    }
}
