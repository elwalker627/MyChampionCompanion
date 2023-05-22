using Genetics;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's barking level.
/// </summary>
public class BarkingLevelIcelandicSheepdog : GeneInformationAbstract
{
    public BarkingLevelIcelandicSheepdog() : base("The barking level of the " +
        "dog.", "Barking Level")
    {

    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('b', "Barky", Dominant));
        this.AddAllele(new('q', "Quiet", Recessive));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 'b';
    }

    public override bool IdealDog(char c)
    {
        return c == 'b';
    }
}

