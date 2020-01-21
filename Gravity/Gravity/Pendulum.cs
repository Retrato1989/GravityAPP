using System;

namespace Gravity
{
	public class Pendulum
	{
		double SwingCycle { get; set; }

		double SwingTime { get; set; }
		double SwingLength { get; set; }
		double SwingG { get; set; }
		int SwingCount { get; set; }

		public string Authors { get; set; }
		public string MeasuredG { get; set; }
		public string Length { get; set; }
		public string Time { get; set; }
		public string EarthG { get; set; }
		public string Swings { get; set; }
		public double SwingDifference { get; set; }

		public Pendulum()
		{
		}
		public Pendulum(string authors, double length, double time, int swings)
		{
			this.Authors = authors;
			this.SwingLength = length / 100;
			this.Length = String.Format("{0} cm", length);
			this.SwingTime = time;
			this.Time = String.Format("{0} s", time);
			this.SwingCount = swings;
			this.Swings = String.Format("{0} wahnięć", swings);
			this.EarthG = String.Format("{0} m/s2", SolarSystem.EarthG);

			MeasureSwingCycle();
			MeasureG();
			MeasureDifference();
		}

		private void MeasureSwingCycle()
		{
			double sc = this.SwingTime / this.SwingCount;
			this.SwingCycle = Math.Round(sc, 2);
		}

		private void MeasureG()
		{
			double a = (4 * Math.Pow(Math.PI, 2)) * this.SwingLength;
			double b = Math.Pow(this.SwingCycle, 2);
			double g = a / b;
			this.SwingG = Math.Round(g, 2);
			this.MeasuredG = String.Format("{0} m/s2", SwingG);
		}

		private void MeasureDifference()
		{
			double d = Math.Abs(0 - (this.SwingG - SolarSystem.EarthG));
			this.SwingDifference = Math.Round(d, 2);
		}
	}
}