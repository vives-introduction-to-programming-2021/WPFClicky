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

namespace WPFClicky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random generator = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void rollDie_Click(object sender, RoutedEventArgs e)
        {
            int value = generator.Next(1, 7);
            dieValue.Text = "" + value;
        }
    }
}
