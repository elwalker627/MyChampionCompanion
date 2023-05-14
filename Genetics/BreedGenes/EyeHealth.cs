using Genetics;
namespace GeneralGenes;

public class EyeHealth : GeneInformationAbstract
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) ||
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "Healthy Eyes", Dominant));
        this.AddAllele(new('u', "Unhealthy Eyes", Recessive));
    }

    protected override bool IsNaturallyOcurring(char character)
    {
        return character == 'h';
    }
}

