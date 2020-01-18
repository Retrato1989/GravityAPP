using System;

namespace Gravity
{
	public class Pendulum
	{
		double PendulumLength { get; set; }
		double PendulumSwingTime { get; set; }
		double PendulumSwingCycle { get; set; }

		public string PendulumAuthors { get; set; }
		public double PendulumMeasuredG { get; set; }

		public Pendulum(string authors, double length, double time)
		{
			this.PendulumAuthors = authors;
			this.PendulumLength = length;
			this.PendulumSwingTime = time;
			this.PendulumSwingCycle = MeasureSwingCycle(this);
			this.PendulumMeasuredG = MeasureG(this);
		}

		double MeasureSwingCycle(Pendulum pendulum)
		{
			double swingCycle = Math.Round(Math.Pow(pendulum.PendulumSwingTime / 10, 2), 2);
			return swingCycle;
		}

		double MeasureG(Pendulum pendulum)
		{
			double measuredG = Math.Round(4 * Math.Round(Math.PI, 2) * pendulum.PendulumLength / Math.Pow(pendulum.PendulumSwingCycle, 2), 2);
			return measuredG;
		}
	}
}
