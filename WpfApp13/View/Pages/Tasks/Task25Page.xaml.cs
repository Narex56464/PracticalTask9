﻿using System;
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
    /// Логика взаимодействия для Task25Page.xaml
    /// </summary>
    public partial class Task25Page : Page
    {
        public Task25Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(TbN.Text);

            if (N <= 10)
            {
                TbA.Text = "N должен быть больше 0";
            }
            else
            {
                Task25 task25 = new Task25(N);

                TbA.Text = $"{task25.Numbers()}";
            }
            TbN.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task26Page());
        }
    }
}
