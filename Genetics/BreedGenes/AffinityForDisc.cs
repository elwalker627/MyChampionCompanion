using Genetics;
namespace GeneralGenes;

	public class AffinityForDisc : PersonalityTrait
	{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('d', "Loves Disc", Dominant));
        this.AddAllele(new('i', "Indifferent to Disc", Recessive));
    }
}

