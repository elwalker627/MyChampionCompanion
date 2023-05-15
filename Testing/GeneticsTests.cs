using Vocabulary;
using Genetics;
using GeneralGenes;
using IcelandicSheepdog;

namespace Testing;

[TestClass]
public class GeneticsTests
{
    // Begin testing genetics -------------------------------------------------

    /* AlleleBasic was tested, then when it was found to work, it was made 
       internal
    // AlleleBasic - constructor and properties, isdominantto, compareto
    [TestCategory("AlleleBasic")]

    [TestMethod]
    public void AlleleBasicConstructorAndProperties()
    {
        string description = "Description";
        int dominance = 50;

        AlleleBasic allele = new('a', description, dominance);
        Assert.AreEqual('a', allele.Representation);
        Assert.AreEqual(description, allele.Description);
        Assert.AreEqual(dominance, allele.Dominance);
    }

    [TestMethod]
    public void AlleleBasicIsDominantToFalse()
    {
        string description = "Description";

        AlleleBasic alleleA = new('a', description, 100);
        AlleleBasic alleleB = new('a', description, 0);

        Assert.IsFalse(alleleB.IsDominantTo(alleleA));

    }

    [TestMethod]
    public void AlleleBasicIsDominantToEqualFalse()
    {
        string description = "Description";

        AlleleBasic alleleA = new('a', description, 100);
        AlleleBasic alleleB = new('a', description, 100);

        Assert.IsFalse(alleleB.IsDominantTo(alleleA));
    }

    [TestMethod]
    public void AlleleBasicIsDominantToTrue()
    {
        string description = "Description";

        AlleleBasic alleleA = new('a', description, 100);
        AlleleBasic alleleB = new('a', description, 0);

        Assert.IsTrue(alleleA.IsDominantTo(alleleB));
    }

    [TestMethod]
    public void AlleleBasicCompareToNegative()
    {
        string description = "Description";

        AlleleBasic alleleA = new('a', description, 100);
        AlleleBasic alleleB = new('a', description, 0);

        Assert.IsTrue(alleleB.CompareTo(alleleA) < 0);

    }

    [TestMethod]
    public void AlleleBasicIsCompareToZero()
    {
        string description = "Description";

        AlleleBasic alleleA = new('a', description, 100);
        AlleleBasic alleleB = new('a', description, 100);

        Assert.AreEqual(0, alleleB.CompareTo(alleleA));
    }

    [TestMethod]
    public void AlleleBasicCompareToPositive()
    {
        string description = "Description";

        AlleleBasic alleleA = new('a', description, 100);
        AlleleBasic alleleB = new('a', description, 0);

        Assert.IsTrue(alleleA.CompareTo(alleleB) > 0);
    }
    */

    // AlleleSet - constructor and properties, genotype, phenotype
    [TestCategory("AlleleSet")]

    [TestMethod]
    public void AlleleSetConstructorAndProperties()
    {
        GeneInformationAbstract genes = new GeneInformationTesting();
        AlleleBasic a = genes.GetAnyAllele();
        AlleleBasic b = genes.GetAnyAllele();
        AlleleSet set = new(a, b, genes);

        Assert.AreEqual(a, set.alleleA);
        Assert.AreEqual(b, set.alleleB);
    }

    [TestMethod]
    public void AlleleSetGenotype()
    {
        GeneInformationAbstract genes = new GeneInformationTesting();
        int times = 50;

        for (int i = 0; i < times; i++)
        {
            // Get alleles
            AlleleBasic a = genes.GetAnyAllele();
            AlleleBasic b = genes.GetAnyAllele();
            AlleleSet set = new(a, b, genes);

            // Find which alleles are present
            bool hasStripes = a.Representation == 's' || b.Representation == 's';
            bool hasPlaid = a.Representation == 'p' || b.Representation == 'p';
            bool hasDots = a.Representation == 'd' || b.Representation == 'd';
            bool hasNone = a.Representation == 'n' || b.Representation == 'n';
            bool hasCamo = a.Representation == 'c' || b.Representation == 'c';
            bool hasFlowers = a.Representation == 'f' || b.Representation == 'f';

            // Test for correct genotype
            if (hasStripes && hasDots)
                Assert.AreEqual("Sd", set.Genotype);
            else if (hasStripes && hasNone)
                Assert.AreEqual("Sn", set.Genotype);
            else if (hasStripes && hasCamo)
                Assert.AreEqual("Sc", set.Genotype);
            else if (hasStripes && hasPlaid)
                Assert.AreEqual("PS", set.Genotype);
            else if (hasPlaid && hasDots)
                Assert.AreEqual("Pd", set.Genotype);
            else if (hasPlaid && hasNone)
                Assert.AreEqual("Pn", set.Genotype);
            else if (hasPlaid && hasCamo)
                Assert.AreEqual("Pc", set.Genotype);
            else if (hasDots && hasCamo)
                Assert.AreEqual("Dc", set.Genotype);
            else if (hasDots && hasNone)
                Assert.AreEqual("Dn", set.Genotype);
            else if (hasNone && hasCamo)
                Assert.AreEqual("cn", set.Genotype);
            else if (hasFlowers && hasStripes)
                Assert.AreEqual("Sf", set.Genotype);
            else if (hasFlowers && hasPlaid)
                Assert.AreEqual("Pf", set.Genotype);
            else if (hasFlowers && hasDots)
                Assert.AreEqual("df", set.Genotype);
            else if (hasFlowers && hasCamo)
                Assert.AreEqual("Fc", set.Genotype);
            else if (hasFlowers && hasNone)
                Assert.AreEqual("Fn", set.Genotype);
        }
    }

    [TestMethod]
    public void AlleleSetPhenotype()
    {
        GeneInformationAbstract genes = new GeneInformationTesting();
        int times = 50;

        for (int i = 0; i < times; i++)
        {
            // Get alleles
            AlleleBasic a = genes.GetAnyAllele();
            AlleleBasic b = genes.GetAnyAllele();
            AlleleSet set = new(a, b, genes);

            // Find which alleles are present
            bool hasStripes = a.Representation == 's' || b.Representation == 's';
            bool hasPlaid = a.Representation == 'p' || b.Representation == 'p';
            bool hasDots = a.Representation == 'd' || b.Representation == 'd';
            bool hasNone = a.Representation == 'n' || b.Representation == 'n';
            bool hasCamo = a.Representation == 'c' || b.Representation == 'c';
            bool hasFlowers = a.Representation == 'f' || b.Representation == 'f';

            if (hasStripes && hasNone)
                Assert.AreEqual("Stripes", set.Phenotype);
            else if (hasNone && hasPlaid)
                Assert.AreEqual("Plaid", set.Phenotype);
            else if (hasNone && hasDots)
                Assert.AreEqual("Dots", set.Phenotype);
            else if (hasNone && hasCamo)
                Assert.AreEqual("Camo", set.Phenotype);
            else if (hasFlowers && hasNone)
                Assert.AreEqual("Flowers", set.Phenotype);
            else if (a.Equals(b))
            {
                Assert.AreEqual(a.Description, set.Phenotype);
                Assert.AreEqual(b.Description, set.Phenotype);
            }
            else if (a.CompareTo(b) == 0)
                Assert.IsTrue(PhenotypeEquivalence(a.Description, b.Description,
                    set.Phenotype));
            else if (hasStripes)
                Assert.AreEqual("Stripes", set.Phenotype);
            else if (hasPlaid)
                Assert.AreEqual("Plaid", set.Phenotype);
            else if (hasDots)
                Assert.AreEqual("Dots", set.Phenotype);
            else if (hasFlowers)
                Assert.AreEqual("Flowers", set.Phenotype);
            else if (hasNone)
                Assert.AreEqual("None", set.Phenotype);
            else if (hasCamo)
                Assert.AreEqual("Camo", set.Phenotype);
            else
                throw new Exception("A combination has not been accounted for.");
        }
    }

    private bool PhenotypeEquivalence(string descriptionA, string descriptionB,
        string description)
    {
        return description == $"{descriptionA} and {descriptionB}" ||
            description == $"{descriptionB} and {descriptionA}";
    }

    // GeneticInformation - constructor and properties, genotype, phenotype
    [TestCategory("GeneInformationPersonalityTrait")]

    [TestMethod]
    public void PersonalityTraitConstructorAndProperties()
    {
        GeneInformationAbstract geneInfo = new Friendliness();

        Assert.IsFalse(geneInfo.IsCodominant);
        Assert.IsFalse(geneInfo.IsIncompletelyDominant);
    }

    [TestMethod]
    public void PersonalityTraitPhenotype()
    {
        GeneInformationAbstract geneInfo = new Friendliness();
        int times = 5;

        for(int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetAnyAllele();
            AlleleBasic alleleB = geneInfo.GetAnyAllele();

            if (alleleA.Representation == 'f' || alleleB.Representation == 'f')
                Assert.AreEqual("Friendly", geneInfo.Phenotype(alleleA, alleleB));
            else
                Assert.AreEqual("Unfriendly", geneInfo.Phenotype(alleleA, alleleB));
        }
    }

    [TestMethod]
    public void PersonalityTraitTruths()
    {
        GeneInformationAbstract geneInfo = new Friendliness();
        int times = 5;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetAnyAllele();
            AlleleBasic alleleB = geneInfo.GetAnyAllele();

            Assert.IsTrue(geneInfo.EthicalPhenotype(alleleA, alleleB));
            Assert.IsTrue(geneInfo.EthicalToBreed(alleleA, alleleB));
        }
    }

    [TestMethod]
    public void PersonalityTraitGetAnyAllele()
    {
        GeneInformationAbstract geneInfo = new Friendliness();
        int times = 10;

        bool friendly = false;
        bool unfriendly = false;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetAnyAllele();
            if (allele.Representation == 'f')
                friendly = true;
            else if (allele.Representation == 'u')
                unfriendly = true;
            else
                throw new Exception("Invalid allele returned.");
        }

        if (!(friendly && unfriendly))
            throw new Exception("Only one allele was ever returned.");
    }

    [TestMethod]
    public void PersonalityTraitGetEthicalAllele()
    {
        GeneInformationAbstract geneInfo = new Friendliness();
        int times = 10;

        bool friendly = false;
        bool unfriendly = false;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsFalse(geneInfo.IsUnethical(allele.Representation));
            if (allele.Representation == 'f')
                friendly = true;
            else if (allele.Representation == 'u')
                unfriendly = true;
            else
                throw new Exception("Invalid allele returned.");
        }

        if (!(friendly && unfriendly))
            throw new Exception("Only one allele was ever returned.");
    }

    [TestMethod]
    public void PersonalityTraitIsUnethical()
    {
        GeneInformationAbstract geneInfo = new Friendliness();
        int times = 10;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsFalse(geneInfo.IsUnethical(allele.Representation));
        }
    }

    [TestMethod]
    public void PersonalityTraitIsStandard()
    {
        GeneInformationAbstract geneInfo = new Friendliness();
        int times = 10;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsTrue(geneInfo.IsStandard(allele.Representation));
        }
    }

    [TestMethod]
    public void PersonalityTraitIsNaturallyOcurring()
    {
        GeneInformationAbstract geneInfo = new Friendliness();
        int times = 10;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsTrue(geneInfo.IsNaturallyOcurring(allele.Representation));
        }
    }

    // GeneticInformation - constructor and properties, genotype, phenotype
    [TestCategory("EyeHealth")]

    [TestMethod]
    public void EyeHealthConstructorAndProperties()
    {
        GeneInformationAbstract geneInfo = new EyeHealth();

        Assert.IsFalse(geneInfo.IsCodominant);
        Assert.IsFalse(geneInfo.IsIncompletelyDominant);
    }

    [TestMethod]
    public void EyeHealthPhenotype()
    {
        GeneInformationAbstract geneInfo = new EyeHealth();
        int times = 5;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetAnyAllele();
            AlleleBasic alleleB = geneInfo.GetAnyAllele();

            if (alleleA.Representation == 'h' || alleleB.Representation == 'h')
                Assert.AreEqual("Healthy Eyes", geneInfo.Phenotype(alleleA, alleleB));
            else
                Assert.AreEqual("Unhealthy Eyes", geneInfo.Phenotype(alleleA, alleleB));
        }
    }

    [TestMethod]
    public void EyeHealthTruths()
    {
        GeneInformationAbstract geneInfo = new EyeHealth();
        int times = 5;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetAnyAllele();
            AlleleBasic alleleB = geneInfo.GetAnyAllele();

            if(alleleA.Representation == 'h' || alleleB.Representation == 'h')
            {
                Assert.IsTrue(geneInfo.EthicalPhenotype(alleleA, alleleB));
                Assert.IsTrue(geneInfo.EthicalToBreed(alleleA, alleleB));
            }
            else
            {
                Assert.IsTrue(geneInfo.EthicalPhenotype(alleleA, alleleB));
                Assert.IsFalse(geneInfo.EthicalToBreed(alleleA, alleleB));
            }
        }
    }

    [TestMethod]
    public void EyeHealthGetAnyAllele()
    {
        GeneInformationAbstract geneInfo = new EyeHealth();
        int times = 10;

        bool healthy = false;
        bool unhealthy = false;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetAnyAllele();
            if (allele.Representation == 'h')
                healthy = true;
            else if (allele.Representation == 'u')
                unhealthy = true;
            else
                throw new Exception("Invalid allele returned.");
        }

        if (!(healthy && unhealthy))
            throw new Exception("Only one allele was ever returned.");
    }

    [TestMethod]
    public void EyeHealthGetEthicalAllele()
    {
        GeneInformationAbstract geneInfo = new EyeHealth();
        int times = 10;

        bool healthy = false;
        bool unhealthy = false;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetAnyAllele();
            Assert.IsFalse(geneInfo.IsUnethical(allele.Representation));
            if (allele.Representation == 'h')
                healthy = true;
            else if (allele.Representation == 'u')
                unhealthy = true;
            else
                throw new Exception("Invalid allele returned.");
        }

        if (!(healthy && unhealthy))
            throw new Exception("Only one allele was ever returned.");
    }

    [TestMethod]
    public void EyeHealthIsUnethical()
    {
        GeneInformationAbstract geneInfo = new EyeHealth();
        int times = 10;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsFalse(geneInfo.IsUnethical(allele.Representation));
        }
    }

    [TestMethod]
    public void EyeHealthIsStandard()
    {
        GeneInformationAbstract geneInfo = new EyeHealth();
        int times = 10;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsTrue(geneInfo.IsStandard(allele.Representation));
        }
    }

    [TestMethod]
    public void EyeHealthIsNaturallyOcurring()
    {
        GeneInformationAbstract geneInfo = new EyeHealth();
        int times = 10;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsTrue(geneInfo.IsNaturallyOcurring(allele.Representation));
        }
    }

    [TestMethod]
    public void EyeHealthEthicalToBreed()
    {
        GeneInformationAbstract geneInfo = new EyeHealth();
        int times = 10;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetEthicalAllele();
            AlleleBasic alleleB = geneInfo.GetEthicalAllele();
            if (alleleA.Representation == 'h' || alleleB.Representation == 'h')
                Assert.IsTrue(geneInfo.EthicalToBreed(alleleA, alleleB));
            else
                Assert.IsFalse(geneInfo.EthicalToBreed(alleleA, alleleB));
        }
    }

    // GeneticInformation - constructor and properties, genotype, phenotype
    [TestCategory("Hips")]

    [TestMethod]
    public void HipsConstructorAndProperties()
    {
        GeneInformationAbstract geneInfo = new Hips();

        Assert.IsFalse(geneInfo.IsCodominant);
        Assert.IsTrue(geneInfo.IsIncompletelyDominant);
        Assert.AreEqual(3, Hips.EthicalCutoff);
    }

    [TestMethod]
    public void HipsPhenotype()
    {
        GeneInformationAbstract geneInfo = new Hips();
        int times = 50;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetAnyAllele();
            AlleleBasic alleleB = geneInfo.GetAnyAllele();

            Assert.AreEqual(GetHipScoreValue(alleleA.Representation,
                alleleB.Representation), geneInfo.Phenotype(alleleA, alleleB));
        }
    }

    /// <summary>
    /// Returns the combined hip score of two alleles.
    /// </summary>
    /// <param name="a">One of the alleles making up the hip score.</param>
    /// <param name="b">One of the alleles making up the hip score.</param>
    /// <returns>The combined hip score of the two alleles.</returns>
    private int GetHipScoreTotal(char a, char b)
    {
        return (GetHipScore(a) + GetHipScore(b)) / 2;
    }

    /// <summary>
    /// Returns the hip score of the combined alleles.
    /// </summary>
    /// <param name="a">One of the alleles making up the hip score.</param>
    /// <param name="b">One of the alleles making up the hip score.</param>
    /// <returns>The combined hip score value of the two alleles.</returns>
    private String GetHipScoreValue(char a, char b)
    {
        switch(GetHipScoreTotal(a, b))
        {
            case 0:
                return "Bad Hips";
            case 1:
                return "Poor Hips";
            case 2:
                return "Fair Hips";
            case 3:
                return "Acceptable Hips";
            case 4:
                return "Good Hips";
            case 5:
                return "Excellent Hips";
            default:
                throw new Exception("Invalid hip score given.");
        }
    }

    /// <summary>
    /// Returns the hip score of a single allele.
    /// </summary>
    /// <param name="a">The representation of the allele.</param>
    /// <returns>The hip score of a.</returns>
    /// <exception cref="Exception">If an invalid hip allele is given.
    /// </exception>
    private int GetHipScore(char a)
    {
        if (a == 'e')
            return 5;
        else if (a == 'g')
            return 4;
        else if (a == 'a')
            return 3;
        else if (a == 'f')
            return 2;
        else if (a == 'p')
            return 1;
        else if (a == 'b')
            return 0;
        else
            throw new Exception("Invalid hip allele given.");
    }

    [TestMethod]
    public void HipsTruths()
    {
        GeneInformationAbstract geneInfo = new Hips();
        int times = 5;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetAnyAllele();
            AlleleBasic alleleB = geneInfo.GetAnyAllele();

            if (GetHipScoreTotal(alleleA.Representation,
                alleleB.Representation) >= Hips.EthicalCutoff)
            {
                Assert.IsTrue(geneInfo.EthicalPhenotype(alleleA, alleleB));
                Assert.IsTrue(geneInfo.EthicalToBreed(alleleA, alleleB));
            }
            else
            {
                Assert.IsFalse(geneInfo.EthicalPhenotype(alleleA, alleleB));
                Assert.IsFalse(geneInfo.EthicalToBreed(alleleA, alleleB));
            }
        }
    }

    [TestMethod]
    public void HipsGetAnyAllele()
    {
        GeneInformationAbstract geneInfo = new Hips();
        int times = 50;

        bool[] scores = new bool[6];

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetAnyAllele();
            scores[GetHipScore(allele.Representation)] = true;
        }

        foreach (bool value in scores)
            if (!value)
                throw new Exception($"{value} was never found from any allele.");
    }

    [TestMethod]
    public void HipsGetEthicalAllele()
    {
        GeneInformationAbstract geneInfo = new Hips();
        int times = 20;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetAnyAllele();
            Assert.IsFalse(geneInfo.IsUnethical(allele.Representation));
        }
    }

    [TestMethod]
    public void HipsIsUnethical()
    {
        GeneInformationAbstract geneInfo = new Hips();
        int times = 20;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsFalse(geneInfo.IsUnethical(allele.Representation));
        }
    }

    [TestMethod]
    public void HipsIsStandard()
    {
        GeneInformationAbstract geneInfo = new Hips();
        int times = 20;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsTrue(geneInfo.IsStandard(allele.Representation));
        }
    }

    [TestMethod]
    public void HipsIsNaturallyOcurring()
    {
        GeneInformationAbstract geneInfo = new Hips();
        int times = 20;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsTrue(geneInfo.IsNaturallyOcurring(allele.Representation));
        }
    }

    [TestMethod]
    public void HipsEthicalToBreed()
    {
        GeneInformationAbstract geneInfo = new Hips();
        int times = 50;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetEthicalAllele();
            AlleleBasic alleleB = geneInfo.GetEthicalAllele();
            if (GetHipScoreTotal(alleleA.Representation,
                alleleB.Representation) >= Hips.EthicalCutoff)
                    Assert.IsTrue(geneInfo.EthicalToBreed(alleleA, alleleB));
            else
                Assert.IsFalse(geneInfo.EthicalToBreed(alleleA, alleleB));
        }
    }

    // GeneticInformation - constructor and properties, genotype, phenotype
    [TestCategory("Reactivity")]

    [TestMethod]
    public void ReactivityConstructorAndProperties()
    {
        GeneInformationAbstract geneInfo = new Reactivity();

        Assert.IsFalse(geneInfo.IsCodominant);
        Assert.IsFalse(geneInfo.IsIncompletelyDominant);
    }

    [TestMethod]
    public void ReactivityPhenotype()
    {
        GeneInformationAbstract geneInfo = new Reactivity();
        int times = 50;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetAnyAllele();
            AlleleBasic alleleB = geneInfo.GetAnyAllele();

            if (alleleA.Representation == 'n' || alleleB.Representation == 'n')
                Assert.AreEqual("Non-Reactive", geneInfo.Phenotype(alleleA, alleleB));
            else
                Assert.AreEqual("Reactive", geneInfo.Phenotype(alleleA, alleleB));
        }
    }

    [TestMethod]
    public void ReactivityTruths()
    {
        GeneInformationAbstract geneInfo = new Reactivity();
        int times = 5;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetAnyAllele();
            AlleleBasic alleleB = geneInfo.GetAnyAllele();

            if (alleleA.Representation == 'n' || alleleB.Representation == 'n')
            {
                Assert.IsTrue(geneInfo.EthicalPhenotype(alleleA, alleleB));
                Assert.IsTrue(geneInfo.EthicalToBreed(alleleA, alleleB));
            }
            else
            {
                Assert.IsFalse(geneInfo.EthicalPhenotype(alleleA, alleleB));
                Assert.IsFalse(geneInfo.EthicalToBreed(alleleA, alleleB));
            }
        }
    }

    [TestMethod]
    public void ReactivityGetAnyAllele()
    {
        GeneInformationAbstract geneInfo = new Reactivity();
        int times = 50;

        bool reactive = false;
        bool nonreactive = false;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetAnyAllele();
            if (allele.Representation == 'n')
                nonreactive = true;
            else if (allele.Representation == 'r')
                reactive = true;
            else
                throw new Exception("Invalid allele given from reactive.");
        }

        if (!(reactive && nonreactive))
            throw new Exception("Only one of two alleles returned.");
    }

    [TestMethod]
    public void ReactivityGetEthicalAllele()
    {
        GeneInformationAbstract geneInfo = new Reactivity();
        int times = 20;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetAnyAllele();
            Assert.IsFalse(geneInfo.IsUnethical(allele.Representation));
        }
    }

    [TestMethod]
    public void ReactivityIsUnethical()
    {
        GeneInformationAbstract geneInfo = new Reactivity();
        int times = 20;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsFalse(geneInfo.IsUnethical(allele.Representation));
        }
    }

    [TestMethod]
    public void ReactivityIsStandard()
    {
        GeneInformationAbstract geneInfo = new Reactivity();
        int times = 20;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsTrue(geneInfo.IsStandard(allele.Representation));
        }
    }

    [TestMethod]
    public void ReactivityIsNaturallyOcurring()
    {
        GeneInformationAbstract geneInfo = new Reactivity();
        int times = 20;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic allele = geneInfo.GetEthicalAllele();
            Assert.IsTrue(geneInfo.IsNaturallyOcurring(allele.Representation));
        }
    }

    [TestMethod]
    public void ReactivityEthicalToBreed()
    {
        GeneInformationAbstract geneInfo = new Reactivity();
        int times = 50;

        for (int i = 0; i < times; i++)
        {
            AlleleBasic alleleA = geneInfo.GetEthicalAllele();
            AlleleBasic alleleB = geneInfo.GetEthicalAllele();
            if (alleleA.Representation == 'n' || alleleB.Representation == 'n')
                Assert.IsTrue(geneInfo.EthicalToBreed(alleleA, alleleB));
            else
                Assert.IsFalse(geneInfo.EthicalToBreed(alleleA, alleleB));
        }
    }

    // End testing genetics ---------------------------------------------------

    // Begin testing icelandic sheepdog ---------------------------------------
    // End testing icelandic sheepdog -----------------------------------------
}
