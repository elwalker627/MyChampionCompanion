using Vocabulary;
namespace Genetics;

public abstract class GeneInformationAbstract
{
    /// <summary>
    /// A dictionary of the alleles for this gene. The char must be the
    /// representation for the allele.
    /// </summary>
    protected Dictionary<int, AlleleBasic> alleles;

    public GeneName Name { get; protected set; }
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
    public GeneInformationAbstract()
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
    public virtual String Phenotype(AlleleBasic alleleA, AlleleBasic alleleB)
    {
        if (alleleA.IsDominantTo(alleleB))
            return alleleA.Description;
        else
            return alleleB.Description;
    }

    /// <summary>
    /// Determines if the specified phenotype can result from an ethical breeder.
    /// </summary>
    /// <param name="allele">The allele whose ethicalness is being determined.
    /// </param>
    /// <returns>True if the phenotype is ethical, false otherwise.</returns>
    public abstract bool EthicalPhenotype(AlleleBasic a, AlleleBasic b);

    /// <summary>
    /// Determines if the specified genotype is ethical to breed.
    /// </summary>
    /// <param name="allele">The allele whose ethicalness is being determined.
    /// </param>
    /// <returns>True if the phenotype is ethical, false otherwise.</returns>
    public virtual bool EthicalToBreed(AlleleBasic a, AlleleBasic b)
    {
        return IsStandard(a.Representation) && IsStandard(b.Representation);
    }

    /// <summary>
    /// Gets an allele created from an ethical breeder. It is merely a single
    /// naturally ocurring allele, paired with itself may be unethical to breed
    /// from.
    /// </summary>
    /// <returns>An allele created from an ethical breeder.</returns>
    public AlleleBasic GetEthicalAllele()
    {
        Random random = new();
        AlleleBasic allele;
        do
        {
            allele = this.GetAnyAllele();
        } while (IsUnethical(allele.Representation));
        return allele;
    }

    /// <summary>
    /// Determines whether or not the allele associated with the character is
    /// unethical.
    /// </summary>
    /// <param name="character">The representation for the allele.</param>
    /// <returns>True if the allele associated with the character is unethical,
    /// false otherwise.</returns>
    public virtual bool IsUnethical(char character)
    {
        return !IsNaturallyOcurring(character);
    }

    /// <summary>
    /// Determines whether or not the allele associated with the character is
    /// standard.
    /// </summary>
    /// <param name="character">The representation for the allele.</param>
    /// <returns>True if the allele associated with the character is standard,
    /// false otherwise.</returns>
    public virtual bool IsStandard(char character)
    {
        return IsNaturallyOcurring(character);
    }

    /// <summary>
    /// Determines whether or not the allele associated with the character is
    /// naturally ocurring.
    /// </summary>
    /// <param name="character">The representation for the allele.</param>
    /// <returns>True if the allele associated with the character is naturally
    /// ocurring, false otherwise.</returns>
    public abstract bool IsNaturallyOcurring(char character);

    /// <summary>
    /// Gets any allele.
    /// </summary>
    /// <returns>An allele.</returns>
    public AlleleBasic GetAnyAllele()
    {
        return this.alleles.ElementAt(new Random().Next(this.alleles.Count)).Value;
    }

    /// <summary>
    /// Adds the specified allele to this gene.
    /// </summary>
    /// <param name="representation">The character representation of the allele.
    /// </param>
    /// <param name="description">The description of the allele.</param>
    /// <param name="dominance">The dominance of the allele.</param>
    protected void AddAllele(char representation, String description,
        int dominance)
    {
        this.alleles.Add(representation,
            new(representation, description, dominance));
    }

    /// <summary>
    /// Adds the specified allele to this gene.
    /// </summary>
    /// <param name="toAdd">The allele to add.</param>
    protected void AddAllele(AlleleBasic allele)
    {
        this.alleles.Add(allele.Representation, allele);
    }
}