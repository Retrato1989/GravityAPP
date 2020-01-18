using System;

namespace Gravity
{
	public class ResultPendulum
	{
		string Authors { get; set; }
		double MeasuredG { get; set; }
		double Difference { get; set; }

		public ResultPendulum(Pendulum pendulum)
		{
			this.Authors = pendulum.PendulumAuthors;
			this.MeasuredG = pendulum.PendulumMeasuredG;
			this.Difference = Math.Abs(this.MeasuredG - PlanetEarth.EarthG);
		}
	}
}
