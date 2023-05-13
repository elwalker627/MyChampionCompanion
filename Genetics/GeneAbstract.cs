namespace Genetics;

public abstract class GeneAbstract
{
    /// <summary>
    /// A dictionary of the alleles for this gene. The char must be the
    /// representation for the allele.
    /// </summary>
    private Dictionary<char, AlleleBasic> alleles;

    /// <summary>
    /// Creates a list of the possible alleles for this gene.
    /// </summary>
    public GeneAbstract()
    {
        this.alleles = new();
        this.GenerateAlleles();
    }

    /// <summary>
    /// Generates the alleles for this gene.
    /// </summary>
    protected abstract void GenerateAlleles();

    /// <summary>
    /// Gets the expressed phenotype for the allele combination.
    /// </summary>
    /// <param name="alleleA">One of the alleles in the genetics.</param>
    /// <param name="alleleB">One of the alleles in the genetics.</param>
    /// <returns>A string describing the phenotype.</returns>
    public abstract string Phenotype(AlleleBasic alleleA, AlleleBasic alleleB);
}