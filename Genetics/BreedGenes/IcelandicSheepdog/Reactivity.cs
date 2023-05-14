using System;
namespace Genetics.BreedGenes.IcelandicSheepdog
{
	public class Reactivity : GeneInformationAbstract
    {
        public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
        {
            return IsNaturallyOcurring(a.Representation) &&
                IsNaturallyOcurring(b.Representation);
        }

        protected override void GenerateAlleles()
        {
            this.AddAllele(new('n', "Non-Reactive", Dominant));
            this.AddAllele(new('r', "Reactive", Recessive));
        }

        protected override bool IsNaturallyOcurring(char character)
        {
            return character == 'n';
        }
    }
}

