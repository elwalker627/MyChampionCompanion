using Vocabulary;
namespace Genetics;

/// <summary>
/// An abstract version of a gene's information.
/// </summary>
public abstract class GeneInformationAbstract
{
    /// <summary>
    /// A dictionary of the alleles for this gene. The char must be the
    /// representation for the allele.
    /// </summary>
    protected Dictionary<int, AlleleBasic> alleles;

    public String Name { get; protected set; }
    protected int Recessive { get { return 0; } }
    protected int Dominant { get { return 100; } }
    public String Description { get; protected set; }

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
    public GeneInformationAbstract(String description, String name)
    {
        this.alleles = new();
        this.GenerateAlleles();
        this.Description = description;
        this.Name = name;
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
        AlleleBasic[] array = this.alleles.Values.ToArray();
        RandomOrder<AlleleBasic>(array);
        foreach (AlleleBasic allele in array)
            if (!IsUnethical(allele.Representation))
                return allele;

        throw new Exception("No ethical allele found.");
    }

    private void RandomOrder<T>(T[] array)
    {
        Random random = new();
        for (int i = 0; i < array.Count(); i++)
            Swap<T>(array, i, random.Next(array.Count()));
    }

    private void Swap<T>(T[] array, int indexA, int indexB)
    {
        T temp = array[indexA];
        array[indexA] = array[indexB];
        array[indexB] = temp;
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

    /// <summary>
    /// Determines if the ideal dog of this breed has this gene.
    /// </summary>
    /// <param name="c">The character representation of the allele.</param>
    /// <returns>True if the gene is in the ideal dog.</returns>
    public virtual bool IdealDog(char c)
    {
        return IsStandard(c);
    }
}