using Genetics;
namespace GeneralGenes;

	public class AffinityForScentwork : PersonalityTrait
	{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('s', "Loves Scentwork", Dominant));
        this.AddAllele(new('i', "Indifferent to Scentwork", Recessive));
    }
}

