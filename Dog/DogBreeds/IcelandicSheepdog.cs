using Genetics;
using Vocabulary;
using IcelandicSheepdog;
namespace Dog;

/// <summary>
/// A dog of the breed Icelandic Sheepdog.
/// </summary>
public class IcelandicSheepdog : Dog
{
    /// <summary>
    /// Creates an Icelandic Sheepdog with the specified options.
    /// </summary>
    /// <param name="isEthical">Whether or not the dog is bred from an ethical
    /// breeder.</param>
    /// <param name="options">The options of the genetics.</param>
    public IcelandicSheepdog(bool isEthical, GeneticsOptionsAbstract options,
        Names names) : base(names)
    {
        GeneNameListAbstract geneNameList = new GeneNameListIcelandicSheepdog();

        this.UnethicalToBreedAndEthicalBreeder = IsEthicalToBreed(this.genetics,
            geneNameList.GeneNames) && isEthical;
    }

    /// <summary>
    /// Creates an Icelandic Sheepdog with the given parents.
    /// </summary>
    /// <param name="mother">The mother.</param>
    /// <param name="father">The father.</param>
    /// <param name="name">The name of the dog.</param>
    public IcelandicSheepdog(IcelandicSheepdog mother,
        IcelandicSheepdog father, String name, bool isEthical)
        : base(name)
    {
        this.Pedigree = new Pedigree(mother.Pedigree, father.Pedigree, this);

        GeneNameListAbstract geneNameList = new GeneNameListIcelandicSheepdog();
        this.genetics = new DogGeneticsIcelandicSheepdog((DogGeneticsIcelandicSheepdog)mother.genetics,
            (DogGeneticsIcelandicSheepdog)father.genetics, geneNameList);

        this.UnethicalToBreedAndEthicalBreeder = IsEthicalToBreed(this.genetics,
            geneNameList.GeneNames) && isEthical;
    }

    protected override void SetConstants()
    {
        this.LowAverageLitterSize = 4;
        this.HighAverageLitterSize = 8;

        this.LowAverageAge = 12;
        this.HighAverageAge = 14;
    }
}