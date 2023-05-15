using Genetics;
using Competitions;
using Vocabulary;
namespace Dog;

public abstract class Dog
{
	protected DogGeneticsAbstract genetics;
	protected Dictionary<String, Title> titles;
	public String Name { get; set; }
    public bool EthicalToBreed { get; protected set; }

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
    /// <param name="genetics"></param>
    /// <param name="geneNames"></param>
    /// <returns></returns>
    protected bool IsEthicalToBreed(DogGeneticsAbstract genetics, IEnumerable<GeneName> geneNames)
    {
        foreach (GeneName geneName in geneNames)
            if (!genetics.GetAlleleSet(geneName).EthicalToBreed)
                return false;

        return true;
    }
}

