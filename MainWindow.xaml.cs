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

namespace zadanieSlidery
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

        private void ezR_Checked(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();
            START.SetValue(UidProperty, rng.NextInt64(100));
        }

        private void meR_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void haR_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
