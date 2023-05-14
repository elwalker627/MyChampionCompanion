using Genetics;
namespace IcelandicSheepdog;

public class EyeColorIcelandicSheedog : GeneInformationAbstract
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('b', "Brown Eyes", 50));
        this.AddAllele(new('l', "Black Eyes", 100));
        this.AddAllele(new('u', "Blue Eyes", 0));
    }

    protected override bool IsNaturallyOcurring(char character)
    {
        return character == 'b';
    }
}