using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's curiosity level.
/// </summary>
public class Curiosity : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('c', "Curious", Dominant));
        this.AddAllele(new('n', "Not Curious", Recessive));
    }
}

