using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's level of affection.
/// </summary>
public class AffectionLevel : PersonalityTrait
{
    public AffectionLevel() : base("How affectionate the a dog is.", "Affection Level")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('a', "Affectionate", Dominant));
        this.AddAllele(new('f', "Aloof", Recessive));
    }
}

