using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's friendliness level.
/// </summary>
public class FriendlinessIcelandicSheepdog : Friendliness
{
    public override bool EthicalToBreed(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 'f' ||
            b.Representation == 'f';
    }
}

