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

namespace Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationViewModel avm;
        public MainWindow()
        {
            InitializeComponent();
            avm = new ApplicationViewModel();
            DataContext = avm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            avm.Phones.Add(new Phone { Title = "SonyX1", Company = "Sony", Price = 135000 });
        }
    }
}
