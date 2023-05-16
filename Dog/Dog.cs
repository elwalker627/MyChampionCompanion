using Genetics;
using Competitions;
using Vocabulary;
namespace Dog;

public abstract class Dog
{
	public DogGeneticsAbstract genetics;
	protected Dictionary<String, Title> titles;
	public String Name { get; set; }
    public bool EthicalToBreed { get; protected set; }
    public BasicPedigree pedigree { get; protected set; }

    public Dog(String name)
    {
        this.Name = name;
        this.titles = new();
    }

    public Dog()
    {
        this.Name = Names.GetRandomName();
        this.titles = new();
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
}

