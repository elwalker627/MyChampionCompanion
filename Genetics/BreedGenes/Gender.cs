using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's gender.
/// </summary>
public class Gender : GeneInformationAbstract
{
    public Gender() : base("The gender of the dog.", "Gender")
    {

    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return true;
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return true;
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('x', "Female", 90));
        this.AddAllele(new('y', "Male", Dominant));
    }
}