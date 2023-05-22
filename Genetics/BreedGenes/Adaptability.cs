using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's level of adaptability.
/// </summary>
public class Adaptability : PersonalityTrait
{
    public Adaptability() : base("How well a dog adapts to change. A dog is " +
        "either adaptable or routine-loving.", "Adaptability")
    {

    }
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('a', "Adaptable", Dominant));
        this.AddAllele(new('r', "Routine-Loving", Recessive));
    }
}

