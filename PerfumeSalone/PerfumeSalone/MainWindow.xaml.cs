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

namespace PerfumeSalone
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

        private void authorizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.ProductPage productpage = new Windows.ProductPage();
            this.Hide();
            productpage.Show();
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
