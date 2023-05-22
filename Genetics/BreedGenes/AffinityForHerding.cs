using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for herding.
/// </summary>
public class AffinityForHerding : PersonalityTrait
{
    public AffinityForHerding() : base("How well the dog enjoys herding.",
        "Affinity for Herding")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "Loves Herding", Dominant));
        this.AddAllele(new('i', "Indifferent to Herding", Recessive));
    }
}

