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

using Wwc.TryProgressWindow.ViewModel;

namespace Wwc.TryProgressWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ViewModel = new MainWindowViewModel();
            DataContext = ViewModel;
            InitializeComponent();
        }

        public MainWindowViewModel ViewModel { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Button_Click(sender, e);
        }
    }
}
