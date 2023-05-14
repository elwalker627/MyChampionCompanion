using Genetics;
namespace IcelandicSheepdog
{
	public class CoatLengthIcelandicSheepdog : CoatLength
	{
        public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
        {
            return (a.Representation == 's' && b.Representation == 's') &&
                (a.Representation == 'l' || b.Representation == 'l');
        }

        protected override void GenerateAlleles()
        {
            this.AddAllele(new('s', "Shorthair", Recessive));
            this.AddAllele(new('l', "Longhair", Dominant));
        }

        protected override bool IsNaturallyOcurring(char character)
        {
            return character == 's' || character == 'l';
        }
    }
}

