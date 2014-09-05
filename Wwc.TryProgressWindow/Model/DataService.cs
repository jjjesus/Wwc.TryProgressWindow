using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Wwc.TryProgressWindow.ViewModel;

namespace Wwc.TryProgressWindow.Model
{
    public class DataService
    {
        public static void Load(ProgressWindowViewModel windowViewModel)
        {
            System.Threading.Thread thread = new Thread(DataService.LoadData);
            thread.Start(windowViewModel);
        }

        public static void LoadData(object data)
        {
            var windowViewModel = data as ProgressWindowViewModel;

            // Do some work
            System.Threading.Thread.Sleep(1000);
            windowViewModel.ProgressValue += 20;

            // Do some work
            System.Threading.Thread.Sleep(1000);
            windowViewModel.ProgressValue += 20;
            // Do some work
            System.Threading.Thread.Sleep(1000);
            windowViewModel.ProgressValue += 20;
            // Do some work
            System.Threading.Thread.Sleep(1000);
            windowViewModel.ProgressValue += 20;
            // Do some work
            System.Threading.Thread.Sleep(1000);
            windowViewModel.ProgressValue += 20;
        }
    }
}
