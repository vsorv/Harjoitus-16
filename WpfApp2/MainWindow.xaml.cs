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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int calculator = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            calculator++;

            tb_Calculator.Text = "Final = " + calculator;
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            calculator--;

            tb_Calculator.Text = "Final = " + calculator;
        }
        private void btn_ChangeInput_Click(object sender, RoutedEventArgs e)
        {
            string ChangeInput = input_ChangeKilometers.Text;
            double kilometers = double.Parse(ChangeInput);
            double miles = kilometers * 0.621371;

            tb_input.Text = "Miles: " + miles;
        }

    }
}
