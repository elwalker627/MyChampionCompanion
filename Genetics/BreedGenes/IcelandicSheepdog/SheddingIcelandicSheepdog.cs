using Genetics;
namespace IcelandicSheepdog;

	public class SheddingIcelandicSheepdog : GeneInformationAbstract
	{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return a.Representation == 's' && b.Representation == 's';
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('s', "Shedding", Recessive));
        this.AddAllele(new('n', "Non-shedding", Dominant));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 's';
    }
}

