using Genetics;
using Vocabulary;

namespace IcelandicSheepdog;

public class DogGeneticsIcelandicSheepdog : DogGeneticsAbstract
{
    public AlleleSet FrontDewClaws { get; private set; }
    public AlleleSet RearDewClaws { get; private set; }

    public DogGeneticsIcelandicSheepdog(GeneticsOptionsAbstract options, bool isEthical) : base(options, isEthical)
    {
    }

    protected override void BreedSpecificEthicalDog(GeneticsOptionsAbstract options)
    {
        GeneInformationAbstract gene = options.GetGene(IcelandicSheepdogGeneName.FrontDewClaws);
        FrontDewClaws = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(IcelandicSheepdogGeneName.RearDewClaws);
        RearDewClaws = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);
    }

    protected override void BreedSpecificUnethicalDog(GeneticsOptionsAbstract options)
    {
        GeneInformationAbstract gene = options.GetGene(IcelandicSheepdogGeneName.FrontDewClaws);
        FrontDewClaws = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(IcelandicSheepdogGeneName.RearDewClaws);
        RearDewClaws = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);
    }
}

