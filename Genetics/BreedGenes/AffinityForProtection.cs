using Genetics;
namespace GeneralGenes;

	public class AffinityForProtection : PersonalityTrait
	{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('p', "Loves Protection", Dominant));
        this.AddAllele(new('i', "Indifferent to Protection", Recessive));
    }
}

