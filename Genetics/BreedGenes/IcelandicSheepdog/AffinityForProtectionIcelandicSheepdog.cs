using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

public class AffinityForProtectionIcelandicSheepdog : AffinityForProtection
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    protected override bool IsNaturallyOcurring(char character)
    {
        return character == 'i';
    }
}

