namespace Genetics;

/// <summary>
/// A personality trait of a dog.
/// </summary>
public abstract class PersonalityTrait : GeneInformationAbstract
{
    public PersonalityTrait(String description, String name)
        : base(description, name)
    {

    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return true;
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return true;
    }

    public override bool IdealDog(char c)
    {
        return true;
    }
}