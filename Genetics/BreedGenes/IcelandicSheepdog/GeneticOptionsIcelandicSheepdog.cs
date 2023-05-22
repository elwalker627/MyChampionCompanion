using GeneralGenes;
using Genetics;
using Vocabulary;
namespace IcelandicSheepdog;

/// <summary>
/// An Icelandic Sheepdog's genetic options.
/// </summary>
public class GeneticOptionsIcelandicSheepdog : GeneticsOptionsAbstract
{
    public GeneticOptionsIcelandicSheepdog(GeneNameListAbstract geneNameList) : base(geneNameList)
    {
    }

    protected override void GenerateGenes(GeneNameListAbstract geneNameList)
    {
        if (!(geneNameList is GeneNameListIcelandicSheepdog))
            throw new ArgumentException("Only an icelandic sheepdog name list " +
                "can be passed to an icelandic sheepdog.");

        GeneNameListIcelandicSheepdog icelandicSheepdogGeneNameList =
            (GeneNameListIcelandicSheepdog)geneNameList;

        this.AddGene(icelandicSheepdogGeneNameList.Hips, new HipsIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.CoatColor, new CoatColorIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.CoatLength, new CoatLengthIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.CoatTexture, new CoatTextureIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.Shedding, new SheddingIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.Markings, new MarkingsIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.Friendliness, new FriendlinessIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.Adaptability, new AdaptabilityIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.MentalStimulationNeeds, new MentalStimulationNeedsIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.EnergyLevel, new EnergyLevelIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.Barking, new BarkingLevelIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.Confidence, new ConfidenceIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.EyeColor, new EyeColorIcelandicSheedog());
        this.AddGene(icelandicSheepdogGeneNameList.FrontDewClaws, new FrontDewClawsIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.RearDewClaws, new RearDewClawsIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.AffinityForHerding, new AffinityForHerdingIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.Trainability, new TrainabilityIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.AffinityForProtection, new AffinityForProtectionIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.Curiosity, new CuriosityIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.Playfulness, new PlayfulnessIcelandicSheepdog());
        this.AddGene(icelandicSheepdogGeneNameList.Height, new Height(16, 19, 17));
        this.AddGene(icelandicSheepdogGeneNameList.Weight, new Weight(20, 35, 25));
    }
}

