using Genetics;
namespace GeneralGenes;

public class AffectionLevel : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('a', "Affectionate", Dominant));
        this.AddAllele(new('f', "Aloof", Recessive));
    }
}

