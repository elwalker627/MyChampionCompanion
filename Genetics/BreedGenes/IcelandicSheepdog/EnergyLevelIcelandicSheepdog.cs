using Genetics;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's energy level.
/// </summary>
public class EnergyLevelIcelandicSheepdog : GeneInformationAbstract
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "High Energy", Recessive));
        this.AddAllele(new('l', "Low Energy", Dominant));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 'h';
    }
}

