using Genetics;
using Vocabulary;

namespace IcelandicSheepdog;

public class DogGeneticsIcelandicSheepdog : DogGeneticsAbstract
{
    public DogGeneticsIcelandicSheepdog(GeneticsOptionsAbstract options,
        bool isEthical, GeneNameListAbstract geneNameList) :
        base(options, isEthical, geneNameList)
    {
    }

    public DogGeneticsIcelandicSheepdog(DogGeneticsIcelandicSheepdog parentA,
        DogGeneticsIcelandicSheepdog parentB, GeneNameListAbstract geneNameList)
        : base(parentA, parentB, geneNameList)
    {
    }
}

