using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for agility.
/// </summary>
public class AffinityForAgility : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('a', "Loves Agility", Dominant));
        this.AddAllele(new('i', "Indifferent to Agility", Recessive));
    }
}

