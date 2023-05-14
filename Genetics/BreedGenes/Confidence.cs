using Genetics;
namespace GeneralGenes;

public class Confidence : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('c', "Confident", Dominant));
        this.AddAllele(new('n', "Nervous", Recessive));
    }
}

