using System;
using System.Windows;
using AutoIt;

namespace Aide.Desktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var handle = AutoItX.WinGetHandle("Lineage II");
            AutoItX.ControlSend("Lineage II", "", "", "7");
        }
    }
}
