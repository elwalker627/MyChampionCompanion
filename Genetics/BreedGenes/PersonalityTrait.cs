using Genetics;
namespace GeneralGenes;

public abstract class PersonalityTrait : GeneInformationAbstract
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return true;
    }

    protected override bool IsNaturallyOcurring(char character)
    {
        return true;
    }
}

