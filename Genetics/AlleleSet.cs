namespace Genetics;

	/// <summary>
	/// Represents a set of two alleles.
	/// </summary>
	public class AlleleSet
	{
		public AlleleBasic alleleA { get; private set; }
		public AlleleBasic alleleB { get; private set; }
    private GeneInformationAbstract geneInfo;

		/// <summary>
		/// Creates an allele set with the given alleles.
		/// </summary>
		/// <param name="alleleA">One of the alleles for the set.</param>
		/// <param name="alleleB">One of the alleles for the set.</param>
		public AlleleSet(AlleleBasic alleleA, AlleleBasic alleleB,
        GeneInformationAbstract geneInfo)
		{
			this.alleleA = alleleA;
			this.alleleB = alleleB;
        this.geneInfo = geneInfo;
    }

    public string Phenotype()
    {
        return this.geneInfo.Phenotype(alleleA, alleleB);
    }

    /// <summary>
    /// Returns the genotype of this gene. If one is dominant and the other is
    /// recessive, the more dominant gene is shown as uppercase. If they are
    /// equally dominant with a dominance score less than or equal to 50, then
    /// they are shown alphabetically lowercase. If they are equally dominant
    /// with a dominance score greater than 50, they they are shown
    /// alphabetically uppercase.
    /// </summary>
    /// <returns>The genotype of this gene.</returns>
    public string Genotype()
    {
        int comparison = alleleA.CompareTo(alleleB);

        //One is dominant one is recessive
        if (comparison > 0)
            return (alleleA.Representation + 'A' - 'a')
                + alleleB.Representation + "";
        else if (comparison < 0)
            return (alleleB.Representation + 'A' - 'a')
                + alleleA.Representation + "";

        //Equal dominance (>50)
        if (alleleA.Dominance > 50)
            return AlphabeticalOrder(alleleA.Representation,
                alleleB.Representation, true);

        //Equal recessiveness (<=50)
        else
            return AlphabeticalOrder(alleleA.Representation,
                alleleB.Representation, false);

    }

    /// <summary>
    /// Returns the chars in alphabetical order. It is assumed that they are
    /// both lowercase.
    /// </summary>
    /// <param name="a">The first char.</param>
    /// <param name="b">The second char.</param>
    /// <param name="uppercase">True if the chars need to be uppercase, false
    /// if the chars are to remain lowercase..</param>
    /// <returns>The chars in alphabetical order.</returns>
    private String AlphabeticalOrder(char a, char b, bool uppercase)
    {
        int offset = 0;
        if (uppercase)
            offset = 'A' - 'a';
        if (a - b > 0)
            return (b + offset) + (a + offset) + "";
        else
            return (a + offset) + (b + offset) + "";
    }

    /// <summary>
    /// Determines if the given character is lowercase.
    /// </summary>
    /// <param name="character">The character that's being determined if it's
    /// lowercase.</param>
    /// <returns>True if the character is lowercase, false otherwise.</returns>
    private bool IsLowercase(char character)
    {
        return character >= 'a' && character <= 'z';
    }

    /// <summary>
    /// Determines if the given character is uppercase.
    /// </summary>
    /// <param name="character">The character that's being determined if it's
    /// uppercase.</param>
    /// <returns>True if the character is uppercase, false otherwise.</returns>
    private bool IsUppercase(char character)
    {
        return character >= 'A' && character <= 'Z';
    }
}

