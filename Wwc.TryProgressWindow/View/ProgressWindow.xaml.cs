﻿using System;
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
using System.Windows.Shapes;

using Wwc.TryProgressWindow.ViewModel;

namespace Wwc.TryProgressWindow.View
{
    /// <summary>
    /// Interaction logic for ProgressWindow.xaml
    /// </summary>
    public partial class ProgressWindow : Window
    {
        public ProgressWindow()
        {
            ViewModel = new ProgressWindowViewModel();
            DataContext = ViewModel;
            InitializeComponent();
        }
        public ProgressWindowViewModel ViewModel { get; set; }
    }
}
