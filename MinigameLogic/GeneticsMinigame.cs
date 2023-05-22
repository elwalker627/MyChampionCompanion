using Dog;
using IcelandicSheepdog;
using Genetics;
using Vocabulary;
using Person;

namespace GeneticsMinigame;

public class GeneticsMinigame
{
    public Person.Person player;
    protected GeneticsOptionsAbstract options;
    protected GeneNameListAbstract geneNameList;
    protected String breed;
    protected Names names;

    public GeneticsMinigame(String breed, String name)
    {
        this.breed = breed;
        this.names = new();

        switch(breed)
        {
            case "Icelandic Sheepdog":
                this.geneNameList = new GeneNameListIcelandicSheepdog();
                this.options = new GeneticOptionsIcelandicSheepdog(geneNameList);
                break;
            case "Rottweiler":
                throw new Exception("Rottweiler breed information not implemented yet.");
            default:
                throw new Exception("Invalid breed name.");
        }

        this.player = new(name);
    }

    /// <summary>
    /// Breeds the mother and father together, getting the resulting litter.
    /// </summary>
    /// <param name="mother">The mother of the litter.</param>
    /// <param name="father">The father of the litter.</param>
    /// <returns>A list of the resulting puppies.</returns>
    /// <exception cref="Exception">If the breed is not supported.</exception>
    public List<Dog.Dog> BreedDogs(Dog.Dog mother, Dog.Dog father)
    {
        List<Dog.Dog> returner = new();

        switch(this.breed)
        {
            case "Icelandic Sheepdog":
                for (int i = 0; i < mother.LowAverageLitterSize; i++)
                    returner.Add(new Dog.IcelandicSheepdog((Dog.IcelandicSheepdog)mother, (Dog.IcelandicSheepdog)father, $"Puppy {i+1}", true));
                break;
            default:
                throw new Exception("Breed not supported.");
        }

        return returner;
    }

    /// <summary>
    /// Gets a set of dog choices. There are three choices.
    /// </summary>
    /// <returns>A set of dog choices, with three choices.</returns>
    public HashSet<Dog.Dog> DogChoices()
    {
        HashSet<Dog.Dog> returner = new();
        int numberOfChoices = 3;

        switch(this.breed)
        {
            case "Icelandic Sheepdog":
                for(int i = 0; i < numberOfChoices; i++)
                    returner.Add(new Dog.IcelandicSheepdog(true, options, names));
                break;
            default:
                throw new Exception("Breed not supported.");
        }

        return returner;
    }
}

