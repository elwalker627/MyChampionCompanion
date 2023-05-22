namespace Dog;

/// <summary>
/// A list of names.
/// </summary>
public class Names
{
	private HashSet<String> nameList;

	/// <summary>
	/// Sets the list of names.
	/// </summary>
	public Names()
	{
		this.nameList = SetNames();
	}

	/// <summary>
	/// Gets a random name.
	/// </summary>
	/// <returns>A random name.</returns>
	public String GetRandomName()
	{
		return nameList.ElementAt(new Random().Next(nameList.Count));
	}

	/// <summary>
	/// Sets the names available in this list.
	/// </summary>
	/// <returns>A list of names available in this list.</returns>
	private HashSet<String> SetNames()
	{
		HashSet<String> returner = new();

            returner.Add("Comet");
            returner.Add("Spunk");
            returner.Add("Fox");

            return returner;
	}
}

