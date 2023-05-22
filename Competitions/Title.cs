using System;
namespace Competitions;

/// <summary>
/// Represents a title for a dog.
/// </summary>
public class Title
{
    public String TitleName { get; private set; }
    public String TitleAbbreviation { get; private set; }
    public int Points { get; private set; }

	/// <summary>
	/// Creates a title with the given name, abbreviation, and points.
	/// </summary>
	/// <param name="name">The name of the title.</param>
	/// <param name="points">The number of points that winning this title is
	/// worth.</param>
	/// <param name="abbreviation">The abbreviation that gets added to the dog's
	/// name.</param>
	public Title(String name, int points, String abbreviation)
	{
		this.TitleName = name;
		this.Points = points;
		this.TitleAbbreviation = abbreviation;
	}
}

