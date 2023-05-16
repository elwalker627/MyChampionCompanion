﻿using Genetics;
using Vocabulary;
using System.Text;
using System.Drawing;
using System.Xml.Linq;

namespace PunnettSquareSpace;

public class PunnettSquare
{
	public String[,] Square { get; private set; }
	private int size;

	public PunnettSquare(DogGeneticsAbstract geneticsA,
		DogGeneticsAbstract geneticsB, IEnumerable<String> genesToWorryAbout)
	{
		if (genesToWorryAbout.Count() == 0 || genesToWorryAbout.Count() > 3)
			throw new ArgumentException("Can only worry about [1,3] genes.");

		size = (int)Math.Pow(2, genesToWorryAbout.Count()) + 1;
		this.Square = new String[size,size];

        List<AlleleSet> setsA = new();
        List<AlleleSet> setsB = new();
        foreach (String geneName in genesToWorryAbout)
        {
            setsA.Add(geneticsA.GetAlleleSet(geneName));
            setsB.Add(geneticsB.GetAlleleSet(geneName));
        }

		for(int i = 0; i < size; i++)
			for(int j = 0; j < size; j++)
				Square[i,j] = "";

		// The top-left entry should be empty
		for (int i = 0; i < genesToWorryAbout.Count(); i++)
		{
			int mod = (int)Math.Pow(2, genesToWorryAbout.Count() - 1 - i);
            bool alleleA = true;

            for (int j = 1; j < size; j++)
			{
				if ((j - 1) % mod == 0 && j != 1)
                    alleleA = !alleleA;

				if (alleleA)
                {
                    Square[0, j] += setsA[i].Genotype.ElementAt(0);
                    Square[j, 0] += setsB[i].Genotype.ElementAt(0);
                }
                else
                {
                    Square[0, j] += setsA[i].Genotype.ElementAt(1);
                    Square[j, 0] += setsB[i].Genotype.ElementAt(1);
                }

            }

        }

		for (int i = 1; i < size; i++)
			for (int j = 1; j < size; j++)
				Square[i, j] = AddColAndRow(i, j);
	}

	/// <summary>
	/// Combines the row and col.
	/// </summary>
	/// <param name="row">The row number.</param>
	/// <param name="col">The col number.</param>
	/// <returns>A string that's the combination of the row and col.</returns>
	private String AddColAndRow(int row, int col)
	{
		StringBuilder builder = new();
		for (int i = 0; i < Square[row, 0].Count(); i++)
			builder.Append(AlphabetizedString(Square[row,0].ElementAt(i) + "" +
				Square[0,col].ElementAt(i)));

		return builder.ToString();
	}

    /// <summary>
    /// Gets the coordinates of the parts of the punnett square that match the
    /// specified set.
    /// </summary>
    /// <param name="set">The set that's being looked for.</param>
    /// <returns>A list of the coordinates of the parts of the punnett square
	/// that match the specified set.</returns>
    public IEnumerable<Point> GetPointsOfAlleleSet(String set)
	{
		List<Point> points = new();
		String alphabetizedSet = AlphabetizedString(set);

		for (int i = 1; i < size; i++)
			for (int j = 1; j < size; j++)
				if (AlphabetizedString(Square[i, j]).Equals(alphabetizedSet))
					points.Add(new(i, j));

        return points;
	}

    /// <summary>
    /// Gets the string in alphabetical order.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>The string in alphabetical order.</returns>
    private String AlphabetizedString(String str)
	{
		char[] chars = str.ToArray();
		Array.Sort(chars);
		StringBuilder builder = new();

		foreach (char character in chars)
			builder.Append(character);

		return builder.ToString();
	}

    /// <summary>
    /// Finds the number of matches in the punnet square.
    /// </summary>
    /// <param name="set">The set that's being looked for.</param>
    /// <returns>The number of matches in the punnet square.</returns>
    public int NumberOfMatches(String set)
	{
		return GetPointsOfAlleleSet(set).Count();
	}

	/// <summary>
	/// Finds the percentage of 
	/// </summary>
	/// <param name="set"></param>
	/// <returns></returns>
	public float PercentThatMatch(String set)
	{
		return NumberOfMatches(set) / size;
	}

    public override string ToString()
    {
		StringBuilder builder = new();

		for (int i = 0; i < size; i++)
		{
			for (int j = 0; j < size; j++)
			{
                builder.Append(Square[i, j]);
				if (j == 0)
					builder.Append("\t");
				if(j < size - 1)
					builder.Append("\t");
            }
            if (i < size - 1)
                builder.Append("\n");
        }

		return builder.ToString();
    }
}