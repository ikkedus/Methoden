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

namespace Opdracht_6
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
            int getal = int.Parse(textBox.Text);
            Kwadraat_ByRefREF(ref getal);
        }

        private void Kwadraat_ByRefREF(ref int getal)
        {
            getal = (int)Math.Pow(getal, 2);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            int getal = int.Parse(textBox.Text);
            Kwadraad_ByRefOUT(out getal);
        }

        private void Kwadraad_ByRefOUT(out int getal)
        {
            getal = 0;
            getal = (int)Math.Pow(getal, 2);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int getal = int.Parse(textBox.Text);
            getal = Kwadraat_ByValue(getal);

        }

        private int Kwadraat_ByValue(int getal)
        {
            return (int)Math.Pow(getal, 2);
        }
    }
}
