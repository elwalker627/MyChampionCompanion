using Genetics;
namespace GeneralGenes;

public class Friendliness : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('f', "Friendly", Dominant));
        this.AddAllele(new('u', "Unfriendly", Recessive));
    }
}