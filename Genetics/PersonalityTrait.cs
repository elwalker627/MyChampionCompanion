namespace Genetics;

public abstract class PersonalityTrait : GeneInformationAbstract
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return true;
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return true;
    }
}