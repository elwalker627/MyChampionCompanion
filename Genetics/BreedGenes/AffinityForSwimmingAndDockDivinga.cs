using Genetics;
namespace GeneralGenes;

	public class AffinityForSwimmingAndDockDiving : PersonalityTrait
	{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('s', "Loves Swimming and Dock Diving", Dominant));
        this.AddAllele(new('i', "Indifferent to Swimming and Dock Diving", Recessive));
    }
}

