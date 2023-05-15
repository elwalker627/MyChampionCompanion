using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

public class FriendlinessIcelandicSheepdog : Friendliness
{
    public override bool EthicalToBreed(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 'f' ||
            b.Representation == 'f';
    }
}

