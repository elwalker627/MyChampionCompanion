using Genetics;
namespace GeneralGenes;

	public class AffinityForFastCAT : PersonalityTrait
	{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('f', "Loves FastCAT", Dominant));
        this.AddAllele(new('i', "Indifferent to FastCAT", Recessive));
    }
}

