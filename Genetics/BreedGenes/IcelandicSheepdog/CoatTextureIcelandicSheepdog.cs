using Genetics;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's coat texture.
/// </summary>
public class CoatTextureIcelandicSheepdog : GeneInformationAbstract
{
    public CoatTextureIcelandicSheepdog() : base("The texture of the coat " +
        "of the dog.", "Coat Texture")
    {

    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('d', "Double Coat", Recessive));
        this.AddAllele(new('c', "Curly Coat", Dominant));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 'd';
    }
}

