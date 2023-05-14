using Genetics;
namespace GeneralGenes;

	public class AffinityForHerding : PersonalityTrait
	{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "Loves Herding", Dominant));
        this.AddAllele(new('i', "Indifferent to Herding", Recessive));
    }
}

