using Genetics;
namespace IcelandicSheepdog
{
	public class Curiosity : GeneInformationAbstract
    {
        public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
        {
            return IsNaturallyOcurring(a.Representation) &&
                IsNaturallyOcurring(b.Representation);
        }

        protected override void GenerateAlleles()
        {
            this.AddAllele(new('c', "Curious", Dominant));
            this.AddAllele(new('n', "Not Curious", Recessive));
        }

        protected override bool IsNaturallyOcurring(char character)
        {
            return true;
        }
    }
}

