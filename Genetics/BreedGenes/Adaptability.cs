using Genetics;
namespace GeneralGenes;

public class Adaptability : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('a', "Adaptable", Dominant));
        this.AddAllele(new('r', "Routine-Loving", Recessive));
    }
}

