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

namespace Ex5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_00(object sender, RoutedEventArgs e)
        {
            if (B00.Content.ToString() == "" || B00.Content.ToString() == "0")
            {
                B00.Content = "X";
            }
            else
            {
                B00.Content = "0";
            }
        }
        private void Button_Click_01(object sender, RoutedEventArgs e)
        {
            if (B01.Content.ToString() == "" || B01.Content.ToString() == "0")
            {
                B01.Content = "X";
            }
            else
            {
                B01.Content = "0";
            }
        }
        private void Button_Click_02(object sender, RoutedEventArgs e)
        {
            if (B02.Content.ToString() == "" || B02.Content.ToString() == "0")
            {
                B02.Content = "X";
            }
            else
            {
                B02.Content = "0";
            }
        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (B10.Content.ToString() == "" || B10.Content.ToString() == "0")
            {
                B10.Content = "X";
            }
            else
            {
                B10.Content = "0";
            }
        }
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (B11.Content.ToString() == "" || B11.Content.ToString() == "0")
            {
                B11.Content = "X";
            }
            else
            {
                B11.Content = "0";
            }
        }
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (B12.Content.ToString() == "" || B12.Content.ToString() == "0")
            {
                B12.Content = "X";
            }
            else
            {
                B12.Content = "0";
            }
        }
        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            if (B20.Content.ToString() == "" || B20.Content.ToString() == "0")
            {
                B20.Content = "X";
            }
            else
            {
                B20.Content = "0";
            }
        }
        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            if (B21.Content.ToString() == "" || B21.Content.ToString() == "0")
            {
                B21.Content = "X";
            }
            else
            {
                B21.Content = "0";
            }
        }
        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            if (B22.Content.ToString() == "" || B22.Content.ToString() == "0")
            {
                B22.Content = "X";
            }
            else
            {
                B22.Content = "0";
            }
        }
    }
}
