using Genetics;
namespace Vocabulary;

public class HeartHealth : GeneInformationAbstract
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "Healthy Heart", Recessive));
        this.AddAllele(new('u', "Unhealthy Heart", Dominant));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 'h';
    }
}

