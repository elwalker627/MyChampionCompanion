using Genetics;
namespace GeneralGenes;

public class Playfulness : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('p', "Playful", Dominant));
        this.AddAllele(new('s', "Serious", Recessive));
    }
}

