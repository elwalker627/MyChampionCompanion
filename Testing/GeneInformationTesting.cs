using Genetics;
namespace Testing;

public class GeneInformationTesting : GeneInformationAbstract
{
    public GeneInformationTesting() : base("Description", "Name")
    {
        this.IsCodominant = true;
    }
    
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) ||
            IsNaturallyOcurring(b.Representation);
    }

    public override string Phenotype(AlleleBasic alleleA, AlleleBasic alleleB)
    {
        if (alleleA.Representation == 'n')
            return alleleB.Description;
        else if (alleleA == alleleB)
            return alleleB.Description;
        else if (alleleB.Representation == 'n')
            return alleleA.Description;
        else if (alleleA.CompareTo(alleleB) == 0)
            return alleleA.Description + " and " + alleleB.Description;
        else
            return base.Phenotype(alleleA, alleleB);
            
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele('s', "Stripes", 75);
        this.AddAllele('p', "Plaid", 75);
        this.AddAllele('d', "Dots", 50);
        this.AddAllele('f', "Flowers", 50);
        this.AddAllele('c', "Camo", 25);
        this.AddAllele('n', "None", 25);
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 's' || character == 'p';
    }
}

