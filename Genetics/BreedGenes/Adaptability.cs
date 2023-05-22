using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's level of adaptability.
/// </summary>
public class Adaptability : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('a', "Adaptable", Dominant));
        this.AddAllele(new('r', "Routine-Loving", Recessive));
    }
}

