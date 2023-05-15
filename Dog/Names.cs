namespace Dog
{
	public static class Names
	{
		private static HashSet<String> nameList = SetNames();

		public static String GetRandomName()
		{
			return nameList.ElementAt(new Random().Next(nameList.Count));
		}

		private static HashSet<String> SetNames()
		{
			HashSet<String> returner = new();

            returner.Add("Comet");
            returner.Add("Spunk");
            returner.Add("Fox");

            return returner;
		}
	}
}

