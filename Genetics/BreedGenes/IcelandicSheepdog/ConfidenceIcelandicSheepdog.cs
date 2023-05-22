using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's confidence level.
/// </summary>
public class ConfidenceIcelandicSheepdog : Confidence
{
    public override bool EthicalToBreed(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 'c' ||
            b.Representation == 'c';
    }
}

