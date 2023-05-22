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

    /// <summary>
    /// Creates a person with a name and no dogs.
    /// </summary>
    /// <param name="name"></param>
    public Person(String name)
    {
        this.Name = name;
        this.dogs = new();
    }

    /// <summary>
    /// Determines if the name is already in use with this player.
    /// </summary>
    /// <param name="name">The name of a dog.</param>
    /// <returns>True if the name is already in use by a current dog, false
    /// otherwise.</returns>
    public bool NameUsed(String name)
    {
        return this.dogs.ContainsKey(name);
    }

    /// <summary>
    /// Adds a dog. Adds zeros to the end of the name if the name is already in
    /// use.
    /// </summary>
    /// <param name="dog">The dog to be added.</param>
    /// <param name="name">The name of the dog to be added.</param>
    public void AddDog(Dog.Dog dog, String name)
    {
        while (this.NameUsed(name))
        {
            name += "0";
        }

        this.dogs.Add(name, dog);
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

