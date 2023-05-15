using Genetics;
using GeneralGenes;
namespace IcelandicSheepdog;

public class GeneticOptionsIcelandicSheepdog : GeneticsOptionsAbstract
{
    protected override void GenerateGenes()
    {
        this.AddGene(GeneNameIcelandicSheepdog.CoatColor, new CoatColorIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.CoatLength, new CoatLengthIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.CoatTexture, new CoatTextureIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.Shedding, new SheddingIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.Markings, new MarkingsIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.Friendliness, new FriendlinessIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.Adaptability, new AdaptabilityIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.MentalStimulationNeeds, new MentalStimulationNeedsIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.EnergyLevel, new EnergyLevelIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.Barking, new BarkingLevelIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.Confidence, new ConfidenceIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.EyeColor, new EyeColorIcelandicSheedog());
        this.AddGene(GeneNameIcelandicSheepdog.FrontDewClaws, new FrontDewClawsIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.RearDewClaws, new RearDewClawsIcelandicSheepdog());
        this.AddGene(GeneNameIcelandicSheepdog.AffinityForHerding, new AffinityForHerdingIcelandicSheepdog());
    }
}

