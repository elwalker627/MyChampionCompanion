using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's height.
/// </summary>
public class Height : GeneInformationAbstract
{
    protected int MinHeight { get; set; }
    protected int MaxHeight { get; set; }
    protected int IdealHeight { get; set; }

    public Height(int min, int max, int ideal) : base("The height of the dog.", "Height")
    {
        this.MinHeight = min;
        this.MaxHeight = max;
        this.IdealHeight = ideal;
        this.IsIncompletelyDominant = true;
    }

    public override string Phenotype(AlleleBasic alleleA, AlleleBasic alleleB)
    {
        return Phenotype(alleleA.Representation, alleleB.Representation) + " inches";
    }

    protected int Phenotype(char a, char b)
    {
        return (a + b - 2 * 'a') + 4;
    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return EthicalPhenotype(a.Representation, b.Representation);
    }

    /// <summary>
    /// Determines if the given characters are an ethical combination.
    /// </summary>
    /// <param name="a">The representation of one of the alleles.</param>
    /// <param name="b">The representation of one of the alleles.</param>
    /// <returns>True if the characters are an ethical combination, false
    /// otherwise.</returns>
    protected bool EthicalPhenotype(char a, char b)
    {
        return Phenotype(a, b) <= MaxHeight &&
            Phenotype(a, b) >= MinHeight;
    }

    public override bool IdealDog(char c)
    {
        return (char)(IdealHeight - 4 + 'a') == c;
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return EthicalPhenotype(character, character);
    }

    protected override void GenerateAlleles()
    {
        for (int i = 1; i < 27; i++)
            this.AddAllele((char)('a' + i), $"{i + 4} inches", Dominant);
    }
}