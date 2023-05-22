using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's curiosity level.
/// </summary>
public class Curiosity : PersonalityTrait
{
    public Curiosity() : base("The curiosity levels of the dog", "Curiosity")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('c', "Curious", Dominant));
        this.AddAllele(new('n', "Not Curious", Recessive));
    }
}

