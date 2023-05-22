using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's level of affection.
/// </summary>
public class AffectionLevel : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('a', "Affectionate", Dominant));
        this.AddAllele(new('f', "Aloof", Recessive));
    }
}

