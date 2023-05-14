using Genetics;
namespace GeneralGenes;

public class Curiosity : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('c', "Curious", Dominant));
        this.AddAllele(new('n', "Not Curious", Recessive));
    }
}

