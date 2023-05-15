using Genetics;
using Vocabulary;

namespace IcelandicSheepdog;

public class DogGeneticsIcelandicSheepdog : DogGeneticsAbstract
{
    public DogGeneticsIcelandicSheepdog(GeneticsOptionsAbstract options,
        bool isEthical) :
        base(options, isEthical, GeneNameIcelandicSheepdog.geneNames)
    {
    }

    public DogGeneticsIcelandicSheepdog(DogGeneticsIcelandicSheepdog parentA,
        DogGeneticsIcelandicSheepdog parentB) :
        base(parentA, parentB, GeneNameIcelandicSheepdog.geneNames)
    {
    }
}

