using Genetics;
namespace IcelandicSheepdog;

public class FrontDewClawsIcelandicSheepdog : GeneInformationAbstract
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) ||
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('n', "No Front Dew Claws", 100));
        this.AddAllele(new('s', "Single Front Dew Claws", 50));
        this.AddAllele(new('d', "Double Front Dew Claws", 0));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 's' || character == 'd';
    }
}

