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

namespace Wpf2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 按消去鍵消除Text
        private void goddamnDelete_Click(object sender, RoutedEventArgs e)
        {
            heightText.Text = "0";
        }

        private void fuckshitDelete_Click(object sender, RoutedEventArgs e)
        {
            weightText.Text = "0";
        }

        // 計算BMI
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 去除輸入數字以外的情況
            try
            {
                double h = double.Parse(heightText.Text) / 100;

                double w = double.Parse(weightText.Text);

                FinalShit.Text =(w/(h* h)).ToString();
            }
            catch
            {
                MessageBox.Show("Goddamn it 輸入數字好嗎");

                heightText.Text = "0";

                weightText.Text = "0";
            }
        }
        
        
        private void Hbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            heightText.Text = Hbar.Value.ToString();

            double h = double.Parse(heightText.Text) / 100;

            double w = double.Parse(weightText.Text);

            FinalShit.Text = (w / (h * h)).ToString();
        }

        private void Wbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            weightText.Text = Wbar.Value.ToString();

            double h = double.Parse(heightText.Text) / 100;

            double w = double.Parse(weightText.Text);

            FinalShit.Text = (w / (h * h)).ToString();
        }
    }
}
