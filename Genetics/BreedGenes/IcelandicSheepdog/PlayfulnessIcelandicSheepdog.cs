using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's playfulness level.
/// </summary>
public class PlayfulnessIcelandicSheepdog : Playfulness
{
    public override bool EthicalToBreed(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 'c' ||
            b.Representation == 'c';
    }

    public override bool IdealDog(char c)
    {
        return c == 'c';
    }
}