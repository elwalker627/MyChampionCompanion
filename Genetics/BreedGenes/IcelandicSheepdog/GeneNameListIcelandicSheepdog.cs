namespace Vocabulary;

/// <summary>
/// An Icelandic Sheepdog's gene name list. Adds the front and rear dew claws.
/// </summary>
public class GeneNameListIcelandicSheepdog : GeneNameListAbstract
{
    public String FrontDewClaws { get { return new("front_dew_claws"); } }
    public String RearDewClaws { get { return new("rear_dew_claws"); } }
    public String Hips { get { return new("hips"); } }

    protected override void AddBreedSpecificGeneNames()
    {
        this.geneNames.Add(FrontDewClaws);
        this.geneNames.Add(RearDewClaws);
        this.geneNames.Add(Hips);
    }
}

