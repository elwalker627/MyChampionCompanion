using Genetics;
namespace IcelandicSheepdog;

public class HeartHealthIcelandicSheepdog : GeneInformationAbstract
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

    protected override bool IsNaturallyOcurring(char character)
    {
        return character == 'h';
    }
}

