using System;
namespace Genetics.BreedGenes.IcelandicSheepdog
{
	public class EnergyLevel : GeneInformationAbstract
    {
        public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
        {
            return IsNaturallyOcurring(a.Representation) &&
                IsNaturallyOcurring(b.Representation);
        }

        protected override void GenerateAlleles()
        {
            this.AddAllele(new('h', "High Energy", Recessive));
            this.AddAllele(new('l', "Low Energy", Dominant));
        }

        protected override bool IsNaturallyOcurring(char character)
        {
            return character == 'h';
        }
    }
}

