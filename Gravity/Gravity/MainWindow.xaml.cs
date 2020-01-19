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
		Pendulum pendulum;
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
		}

		private void btnWahadloOblicz_Click(object sender, RoutedEventArgs e)
		{
			Pendulum p = new Pendulum(txtAutorzy.Text, Convert.ToDouble(txtDlugosc.Text), Convert.ToDouble(txtCzas.Text));
			resultsPendulum.Add(p);
		}
	}
}