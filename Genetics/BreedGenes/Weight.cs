using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's weight.
/// </summary>
public class Weight : GeneInformationAbstract
{
    protected int MinWeight { get; set; }
    protected int MaxWeight { get; set; }
    protected int IdealWeight { get; set; }

    public Weight(int min, int max, int ideal) : base("The height of the dog.", "Height")
    {
        this.MinWeight = min;
        this.MaxWeight = max;
        this.IdealWeight = ideal;
        this.IsIncompletelyDominant = true;
    }

    public override string Phenotype(AlleleBasic alleleA, AlleleBasic alleleB)
    {
        return Phenotype(alleleA.Representation, alleleB.Representation) + " pounds.";
    }

    protected int Phenotype(char a, char b)
    {
        return (a + b - 2 * 'a' + 1) * 5;
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
        return Phenotype(a, b) <= MaxWeight &&
            Phenotype(a, b) >= MinWeight;
    }

    public override bool IdealDog(char c)
    {
        return (char)(IdealWeight/5 - 1 + 'a') == c;
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return EthicalPhenotype(character, character);
    }

    protected override void GenerateAlleles()
    {
        for (int i = 1; i < 27; i++)
            this.AddAllele((char)('a' + i - 1), $"{i*5} pounds", Dominant);
    }
}