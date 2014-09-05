using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Wwc.TryProgressWindow.View;
using Wwc.TryProgressWindow.Model;

namespace Wwc.TryProgressWindow.ViewModel
{
    public class MainWindowViewModel
    {
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new ProgressWindow();
            DataService.Load(window.ViewModel);
            window.ShowDialog();

            var nextWindow = new NextWindow();
            nextWindow.Show();
        }
    }
}
