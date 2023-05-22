using Genetics;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's coat length.
/// </summary>
public class CoatLengthIcelandicSheepdog : GeneInformationAbstract
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return (a.Representation == 's' && b.Representation == 's') ||
            (a.Representation == 'l' || b.Representation == 'l');
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('s', "Shorthair", Recessive));
        this.AddAllele(new('l', "Longhair", Dominant));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 's' || character == 'l';
    }
}

