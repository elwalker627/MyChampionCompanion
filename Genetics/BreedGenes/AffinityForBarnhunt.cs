using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for barnhunt.
/// </summary>
public class AffinityForBarnhunt : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "Loves Barnhunt", Dominant));
        this.AddAllele(new('i', "Indifferent to Barnhunt", Recessive));
    }
}

