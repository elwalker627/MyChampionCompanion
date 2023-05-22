using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's confidence level.
/// </summary>
public class Confidence : PersonalityTrait
{
    public Confidence() : base("Confidence level of the dog. The opposite " +
        "of a confident dog is a nervous dog.", "Confidence Level")
    {

    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('c', "Confident", Dominant));
        this.AddAllele(new('n', "Nervous", Recessive));
    }
}

