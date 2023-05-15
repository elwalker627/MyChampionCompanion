using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

public class ConfidenceIcelandicSheepdog : Confidence
{
    public override bool EthicalToBreed(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 'c' ||
            b.Representation == 'c';
    }
}

