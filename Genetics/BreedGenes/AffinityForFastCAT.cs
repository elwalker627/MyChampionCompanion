using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for FastCAT.
/// </summary>
public class AffinityForFastCAT : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('f', "Loves FastCAT", Dominant));
        this.AddAllele(new('i', "Indifferent to FastCAT", Recessive));
    }
}

