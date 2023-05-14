using Genetics;
namespace GeneralGenes;

public class AffinityForAgility : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('a', "Loves Agility", Dominant));
        this.AddAllele(new('i', "Indifferent to Agility", Recessive));
    }
}

