using Dog;
namespace Person;

/// <summary>
/// A person, which could be the player or another breeder.
/// </summary>
public class Person
{
    public String Name { get; protected set;}
    protected Dictionary<String, Dog.Dog> dogs;
    public bool IsEthicalBreeder { get; private set; }

    public Person(String name)
    {
        this.Name = name;
        this.dogs = new();
    }

    /// <summary>
    /// Gets all the dogs owned by this person.
    /// </summary>
    /// <returns>All the dogs owned by this person.</returns>
    public IEnumerable<Dog.Dog> GetDogs()
    {
        return dogs.Values;
    }

    /// <summary>
    /// Gets a specific dog owned by this person.
    /// </summary>
    /// <param name="name">The name of the dog.</param>
    /// <returns>The dog whose name matches name.</returns>
    public Dog.Dog GetDog(String name)
    {
        return dogs[name];
    }
}

