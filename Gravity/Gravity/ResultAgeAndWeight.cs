using System;

namespace Gravity
{
	public class ResultAgeAndWeight
	{
		string Name { get; set; }
		Planet SelectedPlanet { get; set; }
		double ResultAge { get; set; }
		double ResultWeight { get; set; }

		public ResultAgeAndWeight()
		{

		}
		public ResultAgeAndWeight(AgeAndWeight ageAndWeight)
		{
			this.Name = ageAndWeight.Name;
			this.SelectedPlanet = ageAndWeight.SelectedPlanet;
			this.ResultAge = ageAndWeight.AgeOnPlanet(this.SelectedPlanet);
			this.ResultWeight = ageAndWeight.WeightOnPlanet(this.SelectedPlanet);
		}
	}
}
