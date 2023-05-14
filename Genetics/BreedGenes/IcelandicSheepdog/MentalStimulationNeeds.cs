using Genetics;
namespace IcelandicSheepdog
{
	public class MentalStimulationNeeds : GeneInformationAbstract
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

        protected override bool IsNaturallyOcurring(char character)
        {
            return character == 'h';
        }
    }
}

