using Genetics;
namespace GeneralGenes;

	public class AffinityForFlyball : PersonalityTrait
	{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('b', "Loves Flyball", Dominant));
        this.AddAllele(new('i', "Indifferent to Flyball", Recessive));
    }
}

