using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

/// <summary>
/// A dog's confidence level.
/// </summary>
public class CuriosityIcelandicSheepdog : Curiosity
{
    public CuriosityIcelandicSheepdog() : base()
    {

    }

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

