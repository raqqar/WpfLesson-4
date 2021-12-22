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

namespace WpfLesson_4
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
            try
            {
                double rateDollar = Convert.ToDouble(rate.Text);
                double sumDollar = Convert.ToDouble(sum.Text);
                double resDollar = rateDollar * sumDollar;
                resSum.Text = resDollar.ToString();
            }
            catch (Exception)
            {
    
            }

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double rateEuro = Convert.ToDouble(rate1.Text);
                double sumEuro = Convert.ToDouble(sum1.Text);
                double resEuro = rateEuro * sumEuro;
                resSum1.Text = resEuro.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                double rateGrivn = Convert.ToDouble(rate2.Text);
                double sumGrivn = Convert.ToDouble(sum2.Text);
                double resGrivn = rateGrivn * sumGrivn;
                resSum2.Text = resGrivn.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                double rateDram = Convert.ToDouble(rate3.Text);
                double sumDram = Convert.ToDouble(sum3.Text);
                double resDram = rateDram * sumDram;
                resSum3.Text = resDram.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                double valueMili = Convert.ToDouble(valueM.Text);
                double resMili = valueMili * 1609.34;
                resM.Text = resMili.ToString();
            }
            catch (Exception)
            {
  
            }
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                double valueFut = Convert.ToDouble(valueF.Text);
                double resFut = valueFut / 3.28084;
                resF.Text = resFut.ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                double valueInch = Convert.ToDouble(valueD.Text);
                double resInch = valueInch / 39.37;
                resD.Text = resInch.ToString();
            }
            catch (Exception)
            {

             
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            try
            {
                double valueVerst = Convert.ToDouble(valueV.Text);
                double resVerst = valueVerst / 0.000937382827146607;
                resV.Text = resVerst.ToString();
            }
            catch (Exception)
            {

                
            }
        }
    }
}
