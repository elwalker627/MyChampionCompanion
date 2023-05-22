using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's friendliness level.
/// </summary>
public class Friendliness : PersonalityTrait
{
    public Friendliness() : base("The friendliness of the dog.", "Friendliness")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('f', "Friendly", Dominant));
        this.AddAllele(new('u', "Unfriendly", Recessive));
    }
}