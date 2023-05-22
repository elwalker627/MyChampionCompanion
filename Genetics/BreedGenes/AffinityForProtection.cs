using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for protection.
/// </summary>
public class AffinityForProtection : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('p', "Loves Protection", Dominant));
        this.AddAllele(new('i', "Indifferent to Protection", Recessive));
    }
}

