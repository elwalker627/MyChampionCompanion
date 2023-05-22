using Genetics;
namespace GeneralGenes;

/// <summary>
/// An Icelandic Sheepdog's playfulness level.
/// </summary>
public class Playfulness : PersonalityTrait
{
    public Playfulness() : base("How playful a dog is into adulthood. A dog " +
        "is either playful or serious as an adult.", "Playfulness")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('p', "Playful", Dominant));
        this.AddAllele(new('s', "Serious", Recessive));
    }
}