using Genetics;
namespace Vocabulary;

public class IcelandicSheepdogGeneName : GeneName
{
    public static IcelandicSheepdogGeneName FrontDewClaws { get { return new("front_dew_claws"); } }
    public static IcelandicSheepdogGeneName RearDewClaws { get { return new("rear_dew_claws"); } }

    protected IcelandicSheepdogGeneName(string name) : base(name)
    {
    }
}

