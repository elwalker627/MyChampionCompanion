using Genetics;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's rear dew claws.
/// </summary>
public class RearDewClawsIcelandicSheepdog : GeneInformationAbstract
{
    public RearDewClawsIcelandicSheepdog() : base("The rear dew claws of the " +
        "dog. Dew claws are extra toes.", "Rear Dew Claws")
    {

    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) ||
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('n', "No Rear Dew Claws", 100));
        this.AddAllele(new('s', "Single Rear Dew Claws", 50));
        this.AddAllele(new('d', "Double Rear Dew Claws", 0));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 's' || character == 'd';
    }

    public override bool IdealDog(char c)
    {
        return c == 'd';
    }
}

