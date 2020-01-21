using System;
using System.Windows;
using System.Windows.Media;
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

		private int numberOfSwings { get; set; }

		int counterPendulum = 0;
		int counterAgeAndWeight = 0;

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

			numberOfSwings = Convert.ToInt32(cmbLiczbaWahniec.SelectedItem);

			cmbPlanets.ItemsSource = solarSystem.SolarSystemPlanets;

			cmbLiczbaWahniec.ItemsSource = swingCount;

			cmbKolorTla1.ItemsSource = tableColors.BackgroundColors;
			cmbKolorTla2.ItemsSource = tableColors.BackgroundColors;

			lblWahadloLiczbaWynikow.Content = String.Format("Wahadło: {0}", counterPendulum);
			lblWiekIWagaLiczbaWynikow.Content = String.Format("Wiek i waga: {0}", counterAgeAndWeight);
		}

		private void btnWahadloOblicz_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				numberOfSwings = Convert.ToInt32(cmbLiczbaWahniec.SelectedItem);
				Pendulum p = new Pendulum(txtAutorzy.Text, Convert.ToDouble(txtDlugosc.Text), Convert.ToDouble(txtCzas.Text), numberOfSwings);
				resultsPendulum.Add(p);
				lblWahadloLiczbaWynikow.Content = String.Format("Wahadło: {0}", ++counterPendulum);
			}
			catch (Exception)
			{
				MessageBox.Show("Popraw lub uzupełnij formularze.\n\nAutorzy - tekst\n\nDługość - liczba dziesiętna\n\n Czas - liczba dziesiętna", "Błędne dane", MessageBoxButton.OK);
			}
		}

		private void btnWiekIWagaOblicz_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				AgeAndWeight a = new AgeAndWeight(txtImie.Text, Convert.ToDouble(txtWiek.Text), Convert.ToDouble(txtWaga.Text), planet);
				resultsAgeAndWeight.Add(a);
				lblWiekIWagaLiczbaWynikow.Content = String.Format("Wiek i waga: {0}", ++counterAgeAndWeight);
			}
			catch (Exception)
			{
				MessageBox.Show("Popraw lub uzupełnij formularze.\n\nImię - tekst\n\nWiek - liczba dziesiętna\n\n Waga - liczba dziesiętna", "Błędne dane", MessageBoxButton.OK);
			}
		}

		private void cmbPlanets_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			planet = cmbPlanets.SelectedItem as Planet;
		}

		private void btnWahadloWyczysc_Click(object sender, RoutedEventArgs e)
		{
			resultsPendulum.Clear();
			counterPendulum = 0;
			lblWahadloLiczbaWynikow.Content = String.Format("Wahadło: {0}", counterPendulum);
		}
		private void btnWiekIWagaWyczysc_Click(object sender, RoutedEventArgs e)
		{
			resultsAgeAndWeight.Clear();
			counterAgeAndWeight = 0;
			lblWiekIWagaLiczbaWynikow.Content = String.Format("Wiek i waga: {0}", counterAgeAndWeight);
		}
		void CmbKolorTla1_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			gridPendulumResults.RowBackground = (Brush)cmbKolorTla1.SelectedItem;
			gridAgeAndWeightResults.RowBackground = (Brush)cmbKolorTla1.SelectedItem;
		}
		void CmbKolorTla2_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			gridPendulumResults.AlternatingRowBackground = (Brush)cmbKolorTla2.SelectedItem;
			gridAgeAndWeightResults.AlternatingRowBackground = (Brush)cmbKolorTla2.SelectedItem;
		}
		void CmbLiczbaWahniec_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			numberOfSwings = Convert.ToInt32(cmbLiczbaWahniec.SelectedItem);
		}
	}
}
// Ustawić formatowanie tabelek w wynikach
// Dodać tooltipy