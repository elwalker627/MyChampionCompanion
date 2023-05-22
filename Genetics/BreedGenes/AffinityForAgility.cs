using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for agility.
/// </summary>
public class AffinityForAgility : PersonalityTrait
{
    public AffinityForAgility() : base("How well the dog enjoys agility.",
        "Affinity for Agility")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('a', "Loves Agility", Dominant));
        this.AddAllele(new('i', "Indifferent to Agility", Recessive));
    }
}

