using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's confidence level.
/// </summary>
public class Confidence : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('c', "Confident", Dominant));
        this.AddAllele(new('n', "Nervous", Recessive));
    }
}

