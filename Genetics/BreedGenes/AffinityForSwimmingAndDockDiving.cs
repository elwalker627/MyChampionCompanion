﻿using Genetics;
namespace GeneralGenes;

/// <summary>
/// A dog's affinity for swimming and dock diving.
/// </summary>
public class AffinityForSwimmingAndDockDiving : PersonalityTrait
{
    protected override void GenerateAlleles()
    {
        this.AddAllele(new('s', "Loves Swimming and Dock Diving", Dominant));
        this.AddAllele(new('i', "Indifferent to Swimming and Dock Diving", Recessive));
    }
}

