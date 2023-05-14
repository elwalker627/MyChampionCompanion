using System;
namespace Genetics.BreedGenes.IcelandicSheepdog
{
	public class Confidence : GeneInformationAbstract
    {
        public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
        {
            return true;
        }

        protected override void GenerateAlleles()
        {
            this.AddAllele(new('c', "Confident", Dominant));
            this.AddAllele(new('n', "Nervous", Recessive));
        }

        protected override bool IsNaturallyOcurring(char character)
        {
            return character == 'c';
        }
    }
}

