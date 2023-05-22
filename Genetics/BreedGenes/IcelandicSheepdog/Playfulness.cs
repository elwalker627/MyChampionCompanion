using Genetics;
namespace GeneralGenes;

/// <summary>
/// An Icelandic Sheepdog's playfulness level.
/// </summary>
public class Playfulness : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('p', "Playful", Dominant));
        this.AddAllele(new('s', "Serious", Recessive));
    }
}