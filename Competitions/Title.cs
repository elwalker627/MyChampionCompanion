using System;
namespace Competitions
{
	public class Title
	{
		public String TitleName { get; private set; }
		public int Points { get; private set; }

		public Title(String name, int points)
		{
			this.TitleName = name;
			this.Points = points;
		}
	}
}

