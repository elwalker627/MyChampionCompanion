using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for scent work.
/// </summary>
public class AffinityForScentwork : PersonalityTrait
{
    public AffinityForScentwork() : base("How well the dog enjoys scent work.",
        "Affinity for Scent Work")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('s', "Loves Scentwork", Dominant));
        this.AddAllele(new('i', "Indifferent to Scentwork", Recessive));
    }
}

