using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

public class AffinityForHerdingIcelandicSheepdog : AffinityForHerding
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "Loves Herding", Recessive));
        this.AddAllele(new('i', "Indifferent to Herding", Dominant));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 'h';
    }
}

