
using GeneralGenes;
using Genetics;

namespace IcelandicSheepdog;

public class AdaptabilityIcelandicSheepdog : Adaptability
{
    public override bool EthicalToBreed(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 'a' ||
            b.Representation == 'a';
    }
}

