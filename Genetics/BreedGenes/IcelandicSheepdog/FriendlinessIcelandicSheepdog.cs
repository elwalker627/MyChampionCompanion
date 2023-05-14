﻿using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

public class FriendlinessIcelandicSheepdog : Friendliness
{
    public override bool EthicalPhenotype(AlleleBasic a, AlleleBasic b)
    {
        return IsNaturallyOcurring(a.Representation) &&
            IsNaturallyOcurring(b.Representation);
    }

    protected override bool IsNaturallyOcurring(char character)
    {
        return character == 'f';
    }
}
