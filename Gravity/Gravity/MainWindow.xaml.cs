using System;
using System.Windows;
using System.Collections.ObjectModel;

namespace Gravity
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// 
	public partial class MainWindow : Window
	{
		private ObservableCollection<Pendulum> resultsPendulum = null;
		private ObservableCollection<AgeAndWeight> resultsAgeAndWeight = null;

		Planet planet = new Planet("Szczur", 100, 16);

		public MainWindow()
		{
			InitializeComponent();
			PrzygotujWiazanie();
		}
		private void PrzygotujWiazanie()
		{
			resultsPendulum = new ObservableCollection<Pendulum>();
			resultsPendulum.Add(new Pendulum("Stasiek", 30, 12));
			gridPendulumResults.ItemsSource = resultsPendulum;

			resultsAgeAndWeight = new ObservableCollection<AgeAndWeight>();
			resultsAgeAndWeight.Add(new AgeAndWeight("Mietek", 12, 100, planet));
			gridAgeAndWeightResults.ItemsSource = resultsAgeAndWeight;
		}

		private void btnWahadloOblicz_Click(object sender, RoutedEventArgs e)
		{
			Pendulum p = new Pendulum(txtAutorzy.Text, Convert.ToDouble(txtDlugosc.Text), Convert.ToDouble(txtCzas.Text));
			resultsPendulum.Add(p);
		}

		private void btnWiekIWagaOblicz_Click(object sendner, RoutedEventArgs e)
		{
			AgeAndWeight a = new AgeAndWeight(txtImie.Text, Convert.ToDouble(txtWiek.Text), Convert.ToDouble(txtWaga.Text), planet);
			resultsAgeAndWeight.Add(a);
		}
	}
}