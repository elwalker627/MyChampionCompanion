using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for protection.
/// </summary>
public class AffinityForProtection : PersonalityTrait
{
    public AffinityForProtection() : base("How well the dog enjoys protection work.",
        "Affinity for Protection")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('p', "Loves Protection", Dominant));
        this.AddAllele(new('i', "Indifferent to Protection", Recessive));
    }
}

