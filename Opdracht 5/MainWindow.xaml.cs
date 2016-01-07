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

namespace Opdracht_5
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
            int getal1 =int.Parse(textBox1.Text);
            int getal2 = int.Parse(textBox2.Text);
            lblUitkomst.Content = getal1 + getal2;
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = int.Parse(textBox1.Text);
            int getal2 = int.Parse(textBox2.Text);
            lblUitkomst.Content = getal1 - getal2;
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = int.Parse(textBox1.Text);
            int getal2 = int.Parse(textBox2.Text);
            lblUitkomst.Content = getal1 * getal2;
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = int.Parse(textBox1.Text);
            int getal2 = int.Parse(textBox2.Text);
            lblUitkomst.Content = getal1 / getal2;
        }
    }
}
