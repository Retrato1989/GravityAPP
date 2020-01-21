using System;

namespace Gravity
{
	public class AgeAndWeight
	{
		public string Name { get; set; }
		public string PlanetName { get; set; }
		public string ResultAge { get; set; }
		public string ResultWeight { get; set; }
		public string AgeOnEarth { get; set; }
		public string WeightOnEarth { get; set; }

		double Age { get; set; }
		double Weight { get; set; }
		Planet SelectedPlanet { get; set; }

		public AgeAndWeight()
		{
		}
		public AgeAndWeight(string name, double age, double weight, Planet planet)
		{
			int years = (int)Math.Round(age);
			int months = (int)Math.Round((age - years) / 12);
			this.Name = name;
			this.Age = age;
			this.AgeOnEarth = String.Format("{0:F2}", years);
			this.Weight = weight;
			this.WeightOnEarth = String.Format("{0:F2} kg", weight);
			this.SelectedPlanet = planet;
			this.PlanetName = SelectedPlanet.PlanetName;

			AgeOnPlanet();
			WeightOnPlanet();
		}

		private void AgeOnPlanet()
		{
			double result = Math.Round(SelectedPlanet.YearLength() * this.Age, 2);
			this.ResultAge = String.Format("{0:F2} roku", result);
		}

		private void WeightOnPlanet()
		{
			double result = Math.Round(SelectedPlanet.CompareGravity() * this.Weight, 2);
			this.ResultWeight = String.Format("{0:F2} kg", result);
		}
	}
}