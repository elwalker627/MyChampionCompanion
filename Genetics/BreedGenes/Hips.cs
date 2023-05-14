using Genetics;
namespace BasicGenes;

public class Hips : GeneInformationAbstract
{
    private Dictionary<char, int> hipsScores;
    private Dictionary<int, char> scoresHips;
    private const int EthicalCutoff = 3;

    /// <inheritdoc/>
    public Hips() : base()
    {
        this.IsIncompletelyDominant = true;
        hipsScores = new();
        scoresHips = new();
    }

    /// <summary>
    /// Determines the hip score phenotype.
    /// </summary>
    /// <param name="a">One of the alleles in the genotype.</param>
    /// <param name="b">One of the alleles in the genotype.</param>
    /// <returns>The hip score, with a range [0,5].</returns>
    private int HipScore(AlleleBasic a, AlleleBasic b)
    {
        return (hipsScores[a.Representation] +
            hipsScores[b.Representation]) / 2;
    }

    public override string Phenotype(AlleleBasic alleleA, AlleleBasic alleleB)
    {
        int score = HipScore(alleleA, alleleB);
        char character = scoresHips[score];
        return this.alleles[character].Description;
    }

    protected override void GenerateAlleles()
    {
        this.AddAlleleAndScore(new('e', "Excellent hips", Recessive), 5);
        this.AddAlleleAndScore(new('g', "Good hips", Dominant), 4);
        this.AddAlleleAndScore(new('a', "Acceptable hips", Dominant), 3);
        this.AddAlleleAndScore(new('f', "Fair hips", Recessive), 2);
        this.AddAlleleAndScore(new('p', "Poor hips", Recessive), 1);
        this.AddAlleleAndScore(new('b', "Bad hips", Recessive), 0);
    }

    /// <summary>
    /// Adds the specified allele to the dictionary and adds the scores as
    /// needed.
    /// </summary>
    /// <param name="toAdd">The allele to add.</param>
    /// <param name="score">The hip score of the allele.</param>
    protected void AddAlleleAndScore(AlleleBasic toAdd, int score)
    {
        this.AddAllele(toAdd);
        this.hipsScores.Add(toAdd.Representation, score);
        this.scoresHips.Add(score, toAdd.Representation);
    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return HipScore(a, b) >= EthicalCutoff;
    }

    protected override bool IsNaturallyOcurring(char character)
    {
        return this.hipsScores[character] >= EthicalCutoff;
    }
}