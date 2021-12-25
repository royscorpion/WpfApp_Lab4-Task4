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

namespace WpfApp_Lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text);
            double sumEuro = Convert.ToDouble(sum2.Text);
            double resDouble2 = rateEuro * sumEuro;
            resSum2.Text = resDouble2.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateUAH = Convert.ToDouble(rate3.Text);
            double sumUAH = Convert.ToDouble(sum3.Text);
            double resDouble3 = rateUAH * sumUAH;
            resSum3.Text = resDouble3.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateAMD = Convert.ToDouble(rate4.Text);
            double sumAMD = Convert.ToDouble(sum4.Text);
            double resDouble4 = rateAMD * sumAMD;
            resSum4.Text = resDouble4.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double inch = Convert.ToDouble(inches.Text);
            resMeter.Text = (inch * 0.0254).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double foot = Convert.ToDouble(foots.Text);
            resMeter2.Text = (foot * 0.3048).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double mile = Convert.ToDouble(miles.Text);
            resMeter3.Text = (mile * 1609.344).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double verst = Convert.ToDouble(versts.Text);
            resMeter4.Text = (verst * 1066.8).ToString();
        }
    }
}
