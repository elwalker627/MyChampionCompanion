using Genetics;
namespace IcelandicSheepdog
{
	public class BarkingLevelIcelandicSheepdog : GeneInformationAbstract
    {
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

        protected override bool IsNaturallyOcurring(char character)
        {
            return character == 'b';
        }
    }
}

