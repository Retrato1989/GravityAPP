using System;

namespace Gravity
{
	public class AgeAndWeight
	{
		public string Name { get; set; }
		public Planet SelectedPlanet { get; set; }

		double Age { get; set; }
		double Weight { get; set; }

		public AgeAndWeight(string name, double age, double weight, Planet planet)
		{
			this.Name = name;
			this.Age = age;
			this.Weight = weight;
			this.SelectedPlanet = planet;
		}

		public double AgeOnPlanet(Planet planet)
		{
			double ageOnPlanet = Math.Round(planet.YearLength() * this.Age, 2);
			return ageOnPlanet;
		}

		public double WeightOnPlanet(Planet planet)
		{
			double weightOnPlanet = Math.Round(planet.CompareGravity() * this.Weight, 2);
			return weightOnPlanet;
		}
	}
}
