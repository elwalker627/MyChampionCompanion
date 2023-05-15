using Genetics;
namespace GeneralGenes;

public class Reactivity : PersonalityTrait
{
    public override bool EthicalToBreed(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 'n' ||
            b.Representation == 'n';
    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 'n' ||
            b.Representation == 'n';
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('n', "Non-Reactive", Dominant));
        this.AddAllele(new('r', "Reactive", Recessive));
    }
}

