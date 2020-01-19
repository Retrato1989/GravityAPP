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
		ObservableCollection<ResultPendulum> resultsPendulum;
		ObservableCollection<ResultAgeAndWeight> resultsAgeAndWeight;

		public MainWindow()
		{
			InitializeComponent();
			BindDataGridsData();
		}

		private void BindDataGridsData()
		{
			resultsPendulum = new ObservableCollection<ResultPendulum>();
			resultsAgeAndWeight = new ObservableCollection<ResultAgeAndWeight>();
		}
	}
}