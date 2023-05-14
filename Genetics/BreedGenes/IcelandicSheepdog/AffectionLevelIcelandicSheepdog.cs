using Genetics;
namespace IcelandicSheepdog
{
	public class AffectionLevelIcelandicSheepdog : GeneInformationAbstract
	{
        public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
        {
            return true;
        }

        protected override void GenerateAlleles()
        {
            this.AddAllele(new('a', "Affectionate", Dominant));
            this.AddAllele(new('f', "Aloof", Recessive));
        }

        protected override bool IsNaturallyOcurring(char character)
        {
            return true;
        }
    }
}

