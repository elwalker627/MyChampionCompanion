using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for FastCAT.
/// </summary>
public class AffinityForFastCAT : PersonalityTrait
{
    public AffinityForFastCAT() : base("How well the dog enjoys fast CAT.",
        "Affinity for FastCAT")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('f', "Loves FastCAT", Dominant));
        this.AddAllele(new('i', "Indifferent to FastCAT", Recessive));
    }
}

