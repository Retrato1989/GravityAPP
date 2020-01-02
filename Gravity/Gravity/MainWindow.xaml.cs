using System;
using System.Windows;

namespace Gravity
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPendulum_Click(object sender, RoutedEventArgs e)
        {
            PendulumWindow pendulumWindow = new PendulumWindow();
            pendulumWindow.Show();
        }

        private void btnAgeAndWeight_Click(object sender, RoutedEventArgs e)
        {
            AgeAndWeightWindow ageAndWeightWindow = new AgeAndWeightWindow();
            ageAndWeightWindow.Show();
        }
    }
    /*
    *  Przerzucić zasoby do app (np lista użytkowników)
    * zrobić log dla każdego użytkownika
    * zrobić resultswindow zamiast messageboxów
    * poprawić czytelność 
    */
}
