using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's affinity for protection.
/// </summary>
public class AffinityForProtectionIcelandicSheepdog : AffinityForProtection
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 'i';
    }

    public override bool IdealDog(char c)
    {
        return c == 'i';
    }
}

