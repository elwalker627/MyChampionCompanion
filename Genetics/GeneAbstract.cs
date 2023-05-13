using Vocabulary;
namespace Genetics;

public abstract class GeneAbstract
{
    /// <summary>
    /// A dictionary of the alleles for this gene. The char must be the
    /// representation for the allele.
    /// </summary>
    protected Dictionary<char, AlleleBasic> alleles;

    protected int Recessive { get { return 0; } }
    protected int Dominant { get { return 100; } }

    /// <summary>
    /// Incomplete dominance is where two equally dominant genes mix their
    /// effects. For example, red and white make pink.
    /// </summary>
    public bool IsIncompletelyDominant { get; protected set; }

    /// <summary>
    /// Codominance is where two equally dominant genes express themselves on
    /// the same organism. For example, red and white make red and white stripes.
    /// </summary>
    public bool IsCodominant { get; protected set; }

    /// <summary>
    /// Creates a list of possible alleles for this gene, keeping track of
    /// codominance or incomplete dominance. A gene may not be incompletely
    /// dominant and codominant.
    /// </summary>
    /// <param name="isIncompletelyDominant">Whether the gene is incompletely
    /// cominant.</param>
    /// <param name="isCodominant">Whether the gene is codominant.</param>
    /// <exception cref="ArgumentException">When isIncompletelyDominant and
    /// isCodominant are both true.</exception>
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

    /// <summary>
    /// Returns the genotype of this gene. If one is dominant and the other is
    /// recessive, the more dominant gene is shown as uppercase. If they are
    /// equally dominant with a dominance score less than or equal to 50, then
    /// they are shown alphabetically lowercase. If they are equally dominant
    /// with a dominance score greater than 50, they they are shown
    /// alphabetically uppercase.
    /// </summary>
    /// <param name="alleleA">The first allele in the genotype.</param>
    /// <param name="alleleB">The second allele in the genotype.</param>
    /// <returns>The genotype of this gene.</returns>
    public string Genotype(AlleleBasic alleleA, AlleleBasic alleleB)
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

    /// <summary>
    /// Adds the specified allele to this gene.
    /// </summary>
    /// <param name="toAdd">The allele to add.</param>
    protected void AddAllele(AlleleBasic toAdd)
    {
        this.alleles.Add(toAdd.Representation, toAdd);
    }
}