using System;
using System.Collections.Generic;

namespace Gravity
{	public class User
	{
		public string UserName { get; set; }
		public double UserAge { get; set; }
		public double UserWeight { get; set; }

		public List<UserResult> Results = new List<UserResult>();

		public User(string name)
		{
			this.UserName = name;
		}

		public double AgeOnPlanet(Planet planet)
		{
			double ageOnPlanet = (planet.YearLength() * this.UserAge);
			return ageOnPlanet;
		}

		public double WeightOnPlanet(Planet planet)
		{
			double weightOnPlanet = (planet.CompareGravity() * this.UserWeight);
			return weightOnPlanet;
		}
	}
}
