using Genetics;
using Vocabulary;
namespace IcelandicSheepdog;

public class GeneNameIcelandicSheepdog : GeneName
{
    public static GeneNameIcelandicSheepdog FrontDewClaws { get { return new("front_dew_claws"); } }
    public static GeneNameIcelandicSheepdog RearDewClaws { get { return new("rear_dew_claws"); } }

    protected GeneNameIcelandicSheepdog(string name) : base(name)
    {
    }
}

