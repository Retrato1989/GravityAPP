using System;

namespace Gravity
{	public class Planet
	{
		public string PlanetName { get; set; }
		public double OrbitalPeriod { get; set; }
		public double PlanetGravity { get; set; }

		public Planet()
		{
		}

		public Planet(string planetName, double orbitalPeriod, double planetGravity)
		{
			this.PlanetName = planetName;
			this.OrbitalPeriod = orbitalPeriod;
			this.PlanetGravity = planetGravity;
		}


		public double YearLength()
		{
			double yearLength = 365.26 / OrbitalPeriod;
			return yearLength;
		}

		public double CompareGravity()
		{
			double gravity = PlanetGravity / 9.80;
			return gravity;
		}
	}
}
