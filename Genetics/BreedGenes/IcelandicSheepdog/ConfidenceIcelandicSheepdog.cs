using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

public class ConfidenceIcelandicSheepdog : Confidence
{
    protected override bool IsStandard(char character)
    {
        return character == 'c';
    }
}

