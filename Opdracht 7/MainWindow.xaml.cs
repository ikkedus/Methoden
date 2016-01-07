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

namespace Opdracht_7
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int graden = int.Parse(textBox.Text);
            if ((bool)radioButton.IsChecked)
            {
                uitkomst.Content = Celsius2Kelvin(graden);
            }
            if ((bool)radioButton1.IsChecked)
            {
                uitkomst.Content = Celsius2Fahrenheit(graden);
            }
            if ((bool)radioButton2.IsChecked)
            {
                uitkomst.Content = Fahrenheit2Celsius(graden);
            }
        }

        private object Fahrenheit2Celsius(int graden)
        {
            return ((graden - 32)*5/9);
        }

        private object Celsius2Fahrenheit(int graden)
        {
            return (graden * 9 / 5 + 32);
        }

        private int Celsius2Kelvin(int graden)
        {
            return (graden + 273);
        }
    }
}
