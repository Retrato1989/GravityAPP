using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Gravity
{
    public class TableColors
    {
        public List<SolidColorBrush> BackgroundColors = null;
        public List<SolidColorBrush> ForegroundColors = null;

		public TableColors()
		{
			FillListsWithColors();
		}

		private void FillListsWithColors()
		{
			SolidColorBrush beige = new SolidColorBrush();
			SolidColorBrush lavender = new SolidColorBrush();
			SolidColorBrush lightYellow = new SolidColorBrush();
			SolidColorBrush lightBlue = new SolidColorBrush();
			SolidColorBrush lightGreen = new SolidColorBrush();
			SolidColorBrush pink = new SolidColorBrush();
			SolidColorBrush white = new SolidColorBrush();
			SolidColorBrush blue = new SolidColorBrush();
			SolidColorBrush red = new SolidColorBrush();
			SolidColorBrush yellow = new SolidColorBrush();
			SolidColorBrush black = new SolidColorBrush();

			beige.Color = Colors.Beige;
			lavender.Color = Colors.Lavender;
			lightYellow.Color = Colors.LightYellow;
			lightBlue.Color = Colors.LightSkyBlue;
			lightGreen.Color = Colors.LightGreen;
			pink.Color = Colors.Pink;
			white.Color = Colors.White;
			blue.Color = Colors.Blue;
			red.Color = Colors.Red;
			yellow.Color = Colors.Yellow;
			black.Color = Colors.Black;

			BackgroundColors = new List<SolidColorBrush>()
			{
				white,
				beige,
				lavender,
				lightYellow,
				lightBlue,
				lightGreen,
				pink,
				black
			};

			ForegroundColors = new List<SolidColorBrush>()
			{
				black,
				blue,
				red,
				yellow,
				white
			};
		}
	}
}
