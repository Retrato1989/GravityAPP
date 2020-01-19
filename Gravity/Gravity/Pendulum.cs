using System;

namespace Gravity
{
	public class Pendulum
	{
		double Length { get; set; }
		double SwingTime { get; set; }
		double SwingCycle { get; set; }

		public string Authors { get; set; }
		public double MeasuredG { get; set; }
		public double Difference { get; set; }

		public Pendulum()
		{
		}
		public Pendulum(string authors, double length, double time)
		{
			this.Authors = authors;
			this.Length = length;
			this.SwingTime = time;

			MeasureSwingCycle();
			MeasureG();
			MeasureDifference();
		}

		private void MeasureSwingCycle()
		{
			this.SwingCycle = Math.Round(Math.Pow(SwingTime / 10, 2), 2);
		}

		private void MeasureG()
		{
			this.MeasuredG = Math.Round(4 * Math.Round(Math.PI, 2) * Length / Math.Pow(SwingCycle, 2), 2);
		}

		private void MeasureDifference()
		{
			this.Difference = Math.Abs(this.MeasuredG - PlanetEarth.EarthG);
		}
	}
}
