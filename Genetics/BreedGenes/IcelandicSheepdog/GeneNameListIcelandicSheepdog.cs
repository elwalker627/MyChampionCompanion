﻿using Genetics;
namespace Vocabulary;

public class GeneNameListIcelandicSheepdog : GeneNameListAbstract
{
    public String FrontDewClaws { get { return new("front_dew_claws"); } }
    public String RearDewClaws { get { return new("rear_dew_claws"); } }

    protected override void AddBreedSpecificGeneNames()
    {
        this.geneNames.Add(FrontDewClaws);
        this.geneNames.Add(RearDewClaws);
    }
}

