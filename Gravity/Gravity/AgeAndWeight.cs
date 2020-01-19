using System;

namespace Gravity
{
	public class AgeAndWeight
	{
		public string Name { get; set; }
		public string PlanetName { get; set; }
		public double ResultAge { get; set; }
		public double ResultWeight { get; set; }

		double Age { get; set; }
		double Weight { get; set; }
		Planet SelectedPlanet { get; set; }

		public AgeAndWeight()
		{
		}
		public AgeAndWeight(string name, double age, double weight, Planet planet)
		{
			this.Name = name;
			this.Age = age;
			this.Weight = weight;
			this.SelectedPlanet = planet;
			this.PlanetName = SelectedPlanet.PlanetName;
			AgeOnPlanet();
			WeightOnPlanet();
		}

		private void AgeOnPlanet()
		{
			this.ResultAge = Math.Round(SelectedPlanet.YearLength() * this.Age, 2);
		}

		private void WeightOnPlanet()
		{
			this.ResultWeight = Math.Round(SelectedPlanet.CompareGravity() * this.Weight, 2);
		}
	}
}
