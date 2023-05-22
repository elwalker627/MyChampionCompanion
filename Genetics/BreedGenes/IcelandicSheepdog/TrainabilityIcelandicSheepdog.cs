using Genetics;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's trainability level.
/// </summary>
public class TrainabilityIcelandicSheepdog : GeneInformationAbstract
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 't' || character == 'h';
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('t', "Trainable", 50));
        this.AddAllele(new('h', "Highly Trainable", 0));
        this.AddAllele(new('i', "Independent", 100));
    }
}

