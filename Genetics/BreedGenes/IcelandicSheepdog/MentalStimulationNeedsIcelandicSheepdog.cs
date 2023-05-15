using Genetics;
namespace IcelandicSheepdog;

	public class MentalStimulationNeedsIcelandicSheepdog : GeneInformationAbstract
{
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

