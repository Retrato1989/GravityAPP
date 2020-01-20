using System;
using System.Windows;
using System.Collections.ObjectModel;
using System.Collections.Generic;

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
		private Planet planet = null;
		
		public SolarSystem solarSystem = new SolarSystem();
		public TableColors tableColors = new TableColors();
		public List<int> swingCount = new List<int>() { 5, 10, 15, 20 };

		public MainWindow()
		{
			InitializeComponent();
			CreateBindings();
		}

		
		private void CreateBindings()
		{
			resultsPendulum = new ObservableCollection<Pendulum>();
			gridPendulumResults.ItemsSource = resultsPendulum;

			resultsAgeAndWeight = new ObservableCollection<AgeAndWeight>();
			gridAgeAndWeightResults.ItemsSource = resultsAgeAndWeight;

			cmbPlanets.ItemsSource = solarSystem.SolarSystemPlanets;

			cmbLiczbaWahniec.ItemsSource = swingCount;

			cmbWahadloKolorTla1.ItemsSource = tableColors.BackgroundColors;
			cmbWahadloKolorTla2.ItemsSource = tableColors.BackgroundColors;
			cmbWiekIWagaKolorTla1.ItemsSource = tableColors.BackgroundColors;
			cmbWiekIWagaKolorTla2.ItemsSource = tableColors.BackgroundColors;

			cmbWahadloKolorCzcionki1.ItemsSource = tableColors.ForegroundColors;
			cmbWahadloKolorCzcionki2.ItemsSource = tableColors.ForegroundColors;
			cmbWiekIWagaKolorCzcionki1.ItemsSource = tableColors.ForegroundColors;
			cmbWiekIWagaKolorCzcionki2.ItemsSource = tableColors.ForegroundColors;
		}

		private void btnWahadloOblicz_Click(object sender, RoutedEventArgs e)
		{
			Pendulum p = new Pendulum(txtAutorzy.Text, Convert.ToDouble(txtDlugosc.Text), Convert.ToDouble(txtCzas.Text));
			resultsPendulum.Add(p);
		}

		private void btnWiekIWagaOblicz_Click(object sender, RoutedEventArgs e)
		{
			AgeAndWeight a = new AgeAndWeight(txtImie.Text, Convert.ToDouble(txtWiek.Text), Convert.ToDouble(txtWaga.Text), planet);
			resultsAgeAndWeight.Add(a);
		}

		private void cmbPlanets_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			planet = cmbPlanets.SelectedItem as Planet;
		}

		private void btnWahadloWyczysc_Click(object sender, RoutedEventArgs e)
		{
			resultsPendulum.Clear();
		}
		private void btnWiekIWagaWyczysc_Click(object sender, RoutedEventArgs e)
		{
			resultsAgeAndWeight.Clear();
		}
	}
}

// Dodać liczbę wahnięć do menu