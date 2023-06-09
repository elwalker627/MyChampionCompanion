﻿using Genetics;
namespace Vocabulary;

/// <summary>
/// A dog's heart health.
/// </summary>
public class HeartHealth : GeneInformationAbstract
{
    public HeartHealth() : base("The health of the dog's heart", "Heart Health")
    {

    }

    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    protected override void GenerateAlleles()
    {
        this.AddAllele(new('h', "Healthy Heart", Recessive));
        this.AddAllele(new('u', "Unhealthy Heart", Dominant));
    }

    public override bool IsNaturallyOcurring(char character)
    {
        return character == 'h';
    }

    public override bool IdealDog(char c)
    {
        return c == 'h';
    }
}

