using Genetics;
namespace GeneralGenes;

public class Reactivity : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('n', "Non-Reactive", Dominant));
        this.AddAllele(new('r', "Reactive", Recessive));
    }
}

