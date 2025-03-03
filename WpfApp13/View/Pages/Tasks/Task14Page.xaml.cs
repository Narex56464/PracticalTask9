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
    /// Логика взаимодействия для Task14Page.xaml
    /// </summary>
    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(Tbx.Text);
            int N = Convert.ToInt32(TbN.Text);

            if (N <= 0)
            {
                TbA.Text = "N должен быть больше 0";
            }
            else if(Math.Abs(x) > 1)
            {
                TbA.Text = "Абсолютное значения X должно быть меньше 1";
            }
            else
            {
                Task14 task14 = new Task14(x, N);

                TbA.Text = $"{task14.FindValue()}\n{task14.EqualInValue()}";
            }
            Tbx.Text = string.Empty;
            TbN.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task15Page());
        }
    }
}
