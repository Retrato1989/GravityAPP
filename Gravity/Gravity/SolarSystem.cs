using System;
using System.Collections.Generic;

namespace Gravity
{
	public class SolarSystem
	{
		public const double EarthG = 9.80665;
		public const double EarthYearLength = 365.26;

		public List<Planet> SolarSystemPlanets = new List<Planet>
		{
			new Planet("Merkury", 87.29, 3.70),
			new Planet("Wenus", 224.70, 8.87),
			new Planet("Ziemia", 365.26, 9.80),
			new Planet("Mars", 686.68, 3.71),
			new Planet("Jowisz", 4328.98, 24.79),
			new Planet("Saturn", 10760.55, 10.44),
			new Planet("Uran", 30685.49, 8.87),
			new Planet("Neptun", 60191.19, 11.15)
		};
	}
}