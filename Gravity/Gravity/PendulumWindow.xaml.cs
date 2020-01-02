using System;
using System.Windows;

namespace Gravity
{
    /// <summary>
    /// Logika interakcji dla klasy PendulumWindow.xaml
    /// </summary>
    public partial class PendulumWindow : Window
    {
        public PendulumWindow()
        {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnWyniki_Click(object sender, RoutedEventArgs e)
        {
            PendulumResultWindow pendulumResultWindow = new PendulumResultWindow();
            pendulumResultWindow.Show();
        }
    }
}
