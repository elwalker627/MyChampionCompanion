using Genetics;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's shedding level.
/// </summary>
public class SheddingIcelandicSheepdog : GeneInformationAbstract
{
    public SheddingIcelandicSheepdog() : base("The shedding level of the " +
        "dog.", "Shedding Level")
    {

    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 's' && b.Representation == 's';
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('s', "Shedding", Recessive));
        this.AddAllele(new('n', "Non-shedding", Dominant));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 's';
    }
}

