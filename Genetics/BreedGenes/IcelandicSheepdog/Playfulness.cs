using System;
namespace Genetics.BreedGenes.IcelandicSheepdog
{
    public class Playfulness : GeneInformationAbstract
    {
        public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
        {
            return true;
        }

        protected override void GenerateAlleles()
        {
            this.AddAllele(new('p', "Playful", Dominant));
            this.AddAllele(new('s', "Serious", Recessive));
        }

        protected override bool IsNaturallyOcurring(char character)
        {
            return true;
        }
    }
}

