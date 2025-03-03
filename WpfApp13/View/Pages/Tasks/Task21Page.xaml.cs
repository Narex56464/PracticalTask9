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
    /// Логика взаимодействия для Task21Page.xaml
    /// </summary>
    public partial class Task21Page : Page
    {
        public Task21Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            TbA.Text = string.Empty;

            Task21 task21 = new Task21();

            foreach(var item in task21.Sqares())
            {
                TbA.Text += $"{item} ";
            }
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task22Page());
        }
    }
}
