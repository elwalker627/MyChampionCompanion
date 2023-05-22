using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for disc.
/// </summary>
public class AffinityForDisc : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('d', "Loves Disc", Dominant));
        this.AddAllele(new('i', "Indifferent to Disc", Recessive));
    }
}

