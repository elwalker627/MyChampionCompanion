using Genetics;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's mental stimulation needs.
/// </summary>
public class MentalStimulationNeedsIcelandicSheepdog : GeneInformationAbstract
{
    public MentalStimulationNeedsIcelandicSheepdog() : base("The mental " +
        "stimulation needs of the dog", "Mental Stimulation Needs")
    {

    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "High Mental Stimulation Needs", Dominant));
        this.AddAllele(new('l', "Low Mental Stimulation Needs", Recessive));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 'h';
    }
}

