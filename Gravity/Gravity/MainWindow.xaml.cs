using System;
using System.Windows;
using System.Collections.ObjectModel;

namespace Gravity
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public MainWindow()
		{
			InitializeComponent();

			ObservableCollection<ResultPendulum> resultsPendulum = new ObservableCollection<ResultPendulum>();
			ObservableCollection<ResultAgeAndWeight> resultsAgeAndWeight = new ObservableCollection<ResultAgeAndWeight>();

			PendulumResults.DataContext = resultsPendulum;
			AgeAndWeightResults.DataContext = resultsAgeAndWeight;

			Planet m1 = new Planet("Merkury", 87.29, 3.70);
			Pendulum p1 = new Pendulum("Stachu", 30, 10);
			AgeAndWeight a1 = new AgeAndWeight("Mietek", 30, 80, m1);

			ResultPendulum pr1 = new ResultPendulum(p1);
			ResultAgeAndWeight awr1 = new ResultAgeAndWeight(a1);

			resultsPendulum.Add(pr1);
			resultsPendulum.Add(pr1);

			resultsAgeAndWeight.Add(awr1);
			resultsAgeAndWeight.Add(awr1);
		}
	}
}