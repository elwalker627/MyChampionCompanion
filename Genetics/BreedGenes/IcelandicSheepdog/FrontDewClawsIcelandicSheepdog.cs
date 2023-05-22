using Genetics;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's front dew claws.
/// </summary>
public class FrontDewClawsIcelandicSheepdog : GeneInformationAbstract
{
    public FrontDewClawsIcelandicSheepdog() : base("The front dew claws " +
        "of the dog. Dew claws are essentially extra toes.", "Front Dew Claws")
    {

    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) ||
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('n', "No Front Dew Claws", 100));
        this.AddAllele(new('s', "Single Front Dew Claws", 50));
        this.AddAllele(new('d', "Double Front Dew Claws", 0));
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

