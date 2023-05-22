using GeneralGenes;
using Genetics;

namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's adaptability levels.
/// </summary>
public class AdaptabilityIcelandicSheepdog : Adaptability
{
    public override bool EthicalToBreed(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 'a' ||
            b.Representation == 'a';
    }
}

