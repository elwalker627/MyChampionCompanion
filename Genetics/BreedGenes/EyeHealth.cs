using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's eye health.
/// </summary>
public class EyeHealth : GeneInformationAbstract
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) ||
            IsNaturallyOcurring(b.Representation);
    }

    public override bool EthicalToBreed(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 'h' || b.Representation == 'h';
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "Healthy Eyes", Dominant));
        this.AddAllele(new('u', "Unhealthy Eyes", Recessive));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return true;
    }
}

