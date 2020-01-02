using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Gravity
{
	public partial class AgeAndWeightWindow : Window
	{
		Planet selectedPlanet = new Planet();

		public Log log = new Log();


		ObservableCollection<Planet> planets = null; // kolekcja musi być zainicjowana jako pusta, dopiero później się ją zapełnia. Inaczej będzie błąd kompilacji.

		public AgeAndWeightWindow()
		{
			InitializeComponent();
			fillComboBox();
		}

		void fillComboBox()
		{
			planets = new ObservableCollection<Planet>();
			planets.Add(new Planet("Merkury", 87.29, 3.70));
			planets.Add(new Planet("Wenus", 224.70, 8.87));
			planets.Add(new Planet("Ziemia", 365.26, 9.80));
			planets.Add(new Planet("Mars", 686.68, 3.71));
			planets.Add(new Planet("Jowisz", 4328.98, 24.79));
			planets.Add(new Planet("Saturn", 10760.55, 10.44));
			planets.Add(new Planet("Uran", 30685.49, 8.87));
			planets.Add(new Planet("Neptun", 60191.19, 11.15));
			cmbPlanets.ItemsSource = planets;
		}

		void cmbPlanets_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			selectedPlanet = ((sender as ComboBox).SelectedItem as Planet);
		}

		void btnOblicz_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrEmpty(txtImie.Text) && !string.IsNullOrEmpty(txtWiek.Text) && !string.IsNullOrEmpty(txtWaga.Text) && !string.IsNullOrEmpty(selectedPlanet.PlanetName))
			{
				User user = new User(txtImie.Text);

				try
				{
					if (!log.users.Contains(new User(txtImie.Text)))
					{
						log.users.Add(user);
					}

					user.UserAge = Convert.ToDouble(txtWiek.Text);
					user.UserWeight = Convert.ToDouble(txtWaga.Text);

					MessageBox.Show(log.NewResult(user, selectedPlanet), "Wynik", MessageBoxButton.OK);
				}
				catch (FormatException)
				{
					MessageBox.Show("Wiek i/lub waga niepoprawne. Popraw na wartości liczbowe.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
				}
			}
			else
				MessageBox.Show("Brak danych, uzupełnij wszystkie pola i wybierz planetę.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
		}

		void btnWyniki_Click(object sender, RoutedEventArgs e)
		{
			AgeAndWeightResultWindow ageAndWeightResult = new AgeAndWeightResultWindow();
			ageAndWeightResult.Show();

			if (!string.IsNullOrEmpty(log.ShowAllResults()))
			{
				MessageBox.Show(log.ShowAllResults(), "Lista wyników", MessageBoxButton.OK);
			}
			else
				MessageBox.Show("Lista wyników jest pusta", "Lista wyników", MessageBoxButton.OK);
		}

		void btnWyczysc_Click(object sender, RoutedEventArgs e)
		{
			log.ClearAllResults();
			MessageBox.Show("Lista wyników pusta", "Wyczyść", MessageBoxButton.OK);
		}
	}
}
