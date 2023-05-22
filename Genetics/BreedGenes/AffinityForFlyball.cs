using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for flyball.
/// </summary>
public class AffinityForFlyball : PersonalityTrait
{
    public AffinityForFlyball() : base("How well the dog enjoys flyball.",
        "Affinity for Flyball")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('b', "Loves Flyball", Dominant));
        this.AddAllele(new('i', "Indifferent to Flyball", Recessive));
    }
}

