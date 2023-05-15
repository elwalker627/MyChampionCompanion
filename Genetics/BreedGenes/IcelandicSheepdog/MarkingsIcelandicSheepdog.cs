using Genetics;
namespace IcelandicSheepdog;

	public class MarkingsIcelandicSheepdog : GeneInformationAbstract
	{
    public MarkingsIcelandicSheepdog() : base()
    {
        this.IsCodominant = true;
    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    public override string Phenotype(AlleleBasic alleleA, AlleleBasic alleleB)
    {
        bool aNone = alleleA.Representation == 'n';
        bool bNone = alleleB.Representation == 'n';
        if (aNone && bNone)
            return alleleA.Description;
        else if (aNone)
            return alleleB.Description;
        else if (bNone)
            return alleleA.Description;
        else
            return alleleA.Description + alleleB.Description;
    }

    protected override void GenerateAlleles()
    {
        //Ethical alleles
        this.AddAllele(new('b', "Black Markings", Dominant));
        this.AddAllele(new('m', "Black Mask", Dominant));
        this.AddAllele(new('t', "Tan Markings", Dominant));
        this.AddAllele(new('p', "Piebald", Dominant));
        this.AddAllele(new('g', "Grey Markings", Dominant));
        this.AddAllele(new('h', "Chocolate Markings", Dominant));
        this.AddAllele(new('c', "Cream Markings", Dominant));
        this.AddAllele(new('w', "White Markings", Dominant));
        this.AddAllele(new('r', "Reddish-Brown Markings", Dominant));
        this.AddAllele(new('n', "None", Dominant));

        //Unethical alleles
        this.AddAllele(new('u', "Blue Markings", Dominant));
        this.AddAllele(new('s', "Black Socks", Dominant));
        this.AddAllele(new('l', "Liver Markings", Dominant));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return !IsUnethical(character);
    }
}

