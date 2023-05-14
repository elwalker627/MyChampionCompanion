using System;
namespace Genetics.BreedGenes.IcelandicSheepdog
{
	public class AdaptabilityIcelandicSheepdog : GeneInformationAbstract
    {
        public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
        {
            return true;
        }

        protected override void GenerateAlleles()
        {
            this.AddAllele(new('a', "Adaptable", Dominant));
            this.AddAllele(new('r', "Routine-Loving", Recessive));
        }

        protected override bool IsNaturallyOcurring(char character)
        {
            return true;
        }
    }
}

