using Genetics;
using Vocabulary;

namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's genetics.
/// </summary>
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

