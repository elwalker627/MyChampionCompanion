using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for barnhunt.
/// </summary>
public class AffinityForBarnhunt : PersonalityTrait
{
    public AffinityForBarnhunt() : base("How well the dog enjoys barnhunt.",
        "Affinity for Barnhunt")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "Loves Barnhunt", Dominant));
        this.AddAllele(new('i', "Indifferent to Barnhunt", Recessive));
    }
}

