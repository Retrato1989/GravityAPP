using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Gravity
{
	/// <summary>
	/// Logika interakcji dla klasy AgeAndWeightResultWindow.xaml
	/// </summary>
	public partial class AgeAndWeightResultWindow : Window
	{
		ObservableCollection<User> users = null;

		public AgeAndWeightResultWindow()
		{
			InitializeComponent();
			fillComboBox();
		}

		void fillComboBox()
		{
			users = new ObservableCollection<User>();
			cmbUsers.ItemsSource = users;
		}
	}
}
