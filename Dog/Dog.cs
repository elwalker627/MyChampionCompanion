using Genetics;
using Competitions;
using Vocabulary;
namespace Dog;

/// <summary>
/// A dog.
/// </summary>
public abstract class Dog
{
    /// <summary>
    /// The dog's genetics. This is internal so that the pedigree has the
    /// pedigree can construct one from scratch using the great-grandparents.
    /// </summary>
	internal DogGeneticsAbstract genetics;
	protected Dictionary<String, Title> titles;
	public String Name { get; set; }
    public int LowAverageLitterSize { get; protected set; }
    public int HighAverageLitterSize { get; protected set; }
    public double AgeYears { get; protected set; }

    public int LowAverageAge { get; protected set; }
    public int HighAverageAge { get; protected set; }

    /// <summary>
    /// True if the dog is a female, false if the dog is a male.
    /// </summary>
    public bool IsFemale { get; private set; }

    /// <summary>
    /// True if unethical to breed and the breeder is an ethical breeder.
    /// False otherwise.
    /// </summary>
    public bool UnethicalToBreedAndEthicalBreeder { get; protected set; }
    public BasicPedigree Pedigree { get; protected set; }

    /// <summary>
    /// Sets the name and titles.
    /// </summary>
    /// <param name="name">The name of the dog.</param>
    /// <param name="isFemale">Whether or not the dog is female.</param>
    public Dog(String name)
    {
        this.Name = name;
        this.titles = new();
        this.IsFemale = new Random().Next() % 2 == 0;
        this.SetConstants();
    }

    /// <summary>
    /// Sets the name and titles. The name is a random name from a previously
    /// created list of names.
    /// </summary>
    /// <param name="names">A list of random names.</param>
    /// <param name="isFemale">Whether or not the dog is female.</param>
    public Dog(Names names)
    {
        this.Name = names.GetRandomName();
        this.titles = new();
        this.IsFemale = new Random().Next()%2 == 0;
        this.SetConstants();
    }

    /// <summary>
    /// Determines if this dog is ethical to breed.
    /// </summary>
    /// <param name="genetics">The genetics of the dog.</param>
    /// <param name="geneNames">The names of the genes.</param>
    /// <returns></returns>
    protected bool IsEthicalToBreed(DogGeneticsAbstract genetics, IEnumerable<String> geneNames)
    {
        foreach (String geneName in geneNames)
            if (!genetics.GetAlleleSet(geneName).EthicalToBreed)
                return false;

        return true;
    }

    /// <summary>
    /// Ages the dog according to a pre-determined timeline.
    /// If the youngest dog that the player owns is less than 12 weeks, the
    /// dog is ages by one week.
    /// If the youngest dog is less than six months old, it's aged to six months
    /// old.
    /// If the youngest dog is less than two years old, it's aged six months.
    /// The default is to age by one year.
    /// </summary>
    /// <returns>Whether or not the dog has died. True if the dog has died,
    /// false if the dog hasn't died.</returns>
    public bool Age(double youngestDog)
    {
        if (youngestDog < .24)
            this.AgeYears += .02;
        else if (youngestDog == .24)
            this.AgeYears = 0.5;
        else if (youngestDog < 2)
            this.AgeYears += 0.5;
        else
            this.AgeYears++;

        return HasDied();
    }

    /// <summary>
    /// Ages the dog by one year.
    /// </summary>
    /// <returns>Whether or not the dog has died. True if the dog has died,
    /// false if the dog hasn't died.</returns>
    public bool AgeMinigame()
    {
        this.AgeYears++;
        return HasDied();
    }

    /// <summary>
    /// Determines if the dog has died.
    /// </summary>
    /// <returns>True if the dog has died, false otherwise.</returns>
    protected bool HasDied()
    {
        if (this.AgeYears < this.LowAverageAge)
            return false;

        int probability = new Random().Next(100);
        int yearDifference = this.HighAverageAge - this.LowAverageAge;
        double yearInThreshold = this.AgeYears - this.LowAverageAge + 1;
        int threshold = (int)(100 / (yearDifference + 1) * yearInThreshold);

        return probability >= threshold;
    }

    /// <summary>
    /// Sets the average litter sizes and average ages.
    /// </summary>
    protected abstract void SetConstants();

    /// <summary>
    /// Determines if this dog is the ideal dog.
    /// </summary>
    /// <param name="geneNameList">A list of the gene names of this breed.</param>
    /// <param name="options">The genetic options of this breed.</param>
    /// <returns>True if this is the ideal dog, false otherwise.</returns>
    public bool IdealDog(GeneNameListAbstract geneNameList, GeneticsOptionsAbstract options)
    {
        foreach (String geneName in geneNameList.GeneNames)
        {
            AlleleSet set = genetics.GetAlleleSet(geneName);

            if (!options.GetGene(geneName).IdealDog(set.alleleA.Representation))
                return false;

            if (!options.GetGene(geneName).IdealDog(set.alleleB.Representation))
                return false;
        }

        return true;
    }
}

