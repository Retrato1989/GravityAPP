using System;

namespace Gravity
{
	class Pendulum
	{
		const double EarthG = 3.14;
		const double Pi = 3.14;

		double PendulumLength { get; set; }
		double PendulumSwingTime { get; set; }
		int PendulumSwingCount { get; set; }

		double PendulumSwingCycle { get; set; }
		double PendulumMeasuredG { get; set; }

		string PendulumAuthors { get; set; }

		public Pendulum(double length, double time, int swings, string authors)
		{
			this.PendulumLength = length;
			this.PendulumSwingTime = time;
			this.PendulumSwingCount = swings;
			this.PendulumAuthors = authors;
			this.PendulumSwingCycle = SetMeasureSwingCycle(this);
			this.PendulumMeasuredG = MeasureG(this);
		}

		double SetMeasureSwingCycle(Pendulum pendulum)
		{
			double swingCycle;
			swingCycle = Math.Round(Math.Pow(pendulum.PendulumSwingTime / pendulum.PendulumSwingCount, 2), 2);
			return pendulum.PendulumSwingCycle = swingCycle;
		}

		double SetExactSwingCycle(Pendulum pendulum)
		{
			double exactSwingCycle;
			exactSwingCycle = Math.Round(2 * Pi * Math.Round(Math.Sqrt(pendulum.PendulumLength / EarthG), 2), 2);
			return pendulum.PendulumSwingCycle = exactSwingCycle;
		}

		double MeasureG(Pendulum pendulum)
		{
			double measuredG = Math.Round(4 * Pi * pendulum.PendulumLength / Math.Pow(pendulum.PendulumSwingCycle, 2), 2);
			return pendulum.PendulumMeasuredG = measuredG;
		}

		public string Result(Pendulum pendulum)
		{
			string result;
			result = String.Format("{0}:\nOkres wahadła wynosi{1:F2}s. Zmierzone przyspieszenie grawitacyjne wyniosło {1:F2}m/s^2.", pendulum.PendulumAuthors, pendulum.PendulumSwingCycle, pendulum.PendulumMeasuredG);
			return result;
		}
	}
}