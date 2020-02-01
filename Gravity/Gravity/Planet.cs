using System;

namespace Gravity
{
	public class Planet
	{
		public string PlanetName { get; set; }

		double OrbitalPeriod { get; set; }
		double PlanetGravity { get; set; }

		public Planet(string planetName, double orbitalPeriod, double planetGravity)
		{
			this.PlanetName = planetName;
			this.OrbitalPeriod = orbitalPeriod;
			this.PlanetGravity = planetGravity;
		}

		public double YearLength()
		{
			double yearLength = Math.Round(SolarSystem.EarthYearLength / OrbitalPeriod, 2);
			return yearLength;
		}

		public double CompareGravity()
		{
			double gravity = Math.Round(PlanetGravity / SolarSystem.EarthG, 2);
			return gravity;
		}

		public double CalculateWeight()
		{
			double gForce = PlanetGravity;
			return gForce;
		}
	}
}
