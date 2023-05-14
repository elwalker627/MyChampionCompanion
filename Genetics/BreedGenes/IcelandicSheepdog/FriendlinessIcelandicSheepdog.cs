using Genetics;
namespace IcelandicSheepdog
{
    public class FriendlinessIcelandicSheepdog : GeneInformationAbstract
    {
        public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
        {
            return IsNaturallyOcurring(a.Representation) &&
                IsNaturallyOcurring(b.Representation);
        }

        protected override void GenerateAlleles()
        {
            this.AddAllele(new('f', "Friendly", Dominant));
            this.AddAllele(new('u', "Unfriendly", Recessive));
        }

        protected override bool IsNaturallyOcurring(char character)
        {
            return character == 'f';
        }
    }
}

