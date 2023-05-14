using Genetics;
namespace IcelandicSheepdog;

public class CoatColorIcelandicSheepdog : GeneInformationAbstract
{
    /// <summary>
    /// Determines if the phenotype from this genotype may have resulted from
    /// an ethical breeder.
    /// </summary>
    /// <param name="a">One of the alleles in the genotype.</param>
    /// <param name="b">One of the alleles in the genotype.</param>
    /// <returns>False; this gene option contains unethical colors.</returns>
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        if (a.IsDominantTo(b))
            return !IsUnethical(a.Representation);
        else
            return !IsUnethical(b.Representation);
    }

    /// <summary>
    /// Determines if the allele is standard.
    /// </summary>
    /// <param name="allele">The representation of the allele.</param>
    /// <returns>True if the allele is on standard, false otherwise.</returns>
    protected override bool IsStandard(char allele)
    {
        return allele == 't' || allele == 'b' || allele == 'c' || allele == 'g'
            || allele == 'a' || allele == 's' || allele == 'n' || allele == 'f'
            || allele == 'r' || allele == 'c';
    }

    /// <summary>
    /// Determines if the allele is naturally occuring (including standard
    /// colors).
    /// </summary>
    /// <param name="allele">The representation of the allele.</param>
    /// <returns>True if the allele is naturally ocurring, false otherwise.
    /// </returns>
    protected override bool IsNaturallyOcurring(char allele)
    {
        return allele == 'i' || allele == 'l' || allele == 'o' || allele == 'e'
            || allele == 'm' || allele == 'y' || allele == 'u' || allele == 'v'
            || allele == 'n' || IsStandard(allele);
    }

    protected override void GenerateAlleles()
    {
        //Standard colors
        this.AddAllele(new('t', "Tri-color and White", 95));
        this.AddAllele(new('b', "Black and White", 90));
        this.AddAllele(new('c', "Chocolate and White", 80));
        this.AddAllele(new('g', "Grey and White", 70));
        this.AddAllele(new('a', "Gold and White", 60));
        this.AddAllele(new('s', "Sable and White", 50));
        this.AddAllele(new('n', "Tan and White", 40));
        this.AddAllele(new('f', "Fawn and White", 30));
        this.AddAllele(new('r', "Red and White", 20));
        this.AddAllele(new('c', "Cream and White", 10));

        //Off standard colors
        this.AddAllele(new('i', "White", 5));
        this.AddAllele(new('l', "Black", 100));
        this.AddAllele(new('o', "Chocolate", 85));
        this.AddAllele(new('e', "Red", 25));
        this.AddAllele(new('m', "Cream", 15));
        this.AddAllele(new('y', "Grey", 75));
        this.AddAllele(new('u', "Gold", 65));
        this.AddAllele(new('v', "Sable", 55));
        this.AddAllele(new('n', "Chocolate and Tan", 88));

        //Unethical colors
        this.AddAllele(new('d', "Brindle", 92));
        this.AddAllele(new('j', "Blue", 68));
        this.AddAllele(new('k', "Red Merle", 28));
        this.AddAllele(new('z', "Blue Merle", 69));
        this.AddAllele(new('w', "Albino", 0));
        this.AddAllele(new('x', "White With Black Polka Dots", 89));
        this.AddAllele(new('p', "White With Chocolate Polka Dots", 78));
    }
}