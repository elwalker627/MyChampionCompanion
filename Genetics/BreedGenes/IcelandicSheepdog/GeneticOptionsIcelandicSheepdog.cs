using Genetics;
using Vocabulary;
using GeneralGenes;
namespace IcelandicSheepdog;

public class GeneticOptionsIcelandicSheepdog : GeneticsOptionsAbstract
{
    protected override void GenerateGenes()
    {
        this.AddGene(IcelandicSheepdogGeneName.Hips, new Hips());
        this.AddGene(IcelandicSheepdogGeneName.CoatColor, new CoatColorIcelandicSheepdog());
        this.AddGene(IcelandicSheepdogGeneName.CoatLength, new CoatLengthIcelandicSheepdog());
        this.AddGene(IcelandicSheepdogGeneName.CoatTexture, new CoatTexture());
        this.AddGene(IcelandicSheepdogGeneName.Shedding, new SheddingIcelandicSheepdog());
        this.AddGene(IcelandicSheepdogGeneName.Markings, new MarkingsIcelandicSheepdog());
        this.AddGene(IcelandicSheepdogGeneName.AffectionLevel, new AffectionLevel());
        this.AddGene(IcelandicSheepdogGeneName.Friendliness, new Friendliness());
        this.AddGene(IcelandicSheepdogGeneName.Playfulness, new Playfulness());
        this.AddGene(IcelandicSheepdogGeneName.Adaptability, new Adaptability());

        this.AddGene(IcelandicSheepdogGeneName.MentalStimulationNeeds, new MentalStimulationNeedsIcelandicSheepdog());
        this.AddGene(IcelandicSheepdogGeneName.EnergyLevel, new EnergyLevelIcelandicSheepdog());
        this.AddGene(IcelandicSheepdogGeneName.Barking, new BarkingLevelIcelandicSheepdog());
        this.AddGene(IcelandicSheepdogGeneName.Reactivity, new Reactivity());
        this.AddGene(IcelandicSheepdogGeneName.Curiosity, new Curiosity());
        this.AddGene(IcelandicSheepdogGeneName.Confidence, new Confidence());
        this.AddGene(IcelandicSheepdogGeneName.AffinityForHerding, new AffinityForHerding());
        this.AddGene(IcelandicSheepdogGeneName.AffinityForFastCAT, new AffinityForFastCAT());
        this.AddGene(IcelandicSheepdogGeneName.AffinityForSwimmingAndDockDiving, new AffinityForSwimmingAndDockDiving());
        this.AddGene(IcelandicSheepdogGeneName.AffinityForAgility, new AffinityForAgility());

        this.AddGene(IcelandicSheepdogGeneName.AffinityForProtection, new AffinityForProtection());
        this.AddGene(IcelandicSheepdogGeneName.AffinityForFlyball, new AffinityForFlyball());
        this.AddGene(IcelandicSheepdogGeneName.AffinityForBarnhunt, new AffinityForBarnhunt());
        this.AddGene(IcelandicSheepdogGeneName.AffinityForScentwork, new AffinityForScentwork());
        this.AddGene(IcelandicSheepdogGeneName.AffinityForDisc, new AffinityForDisc());
        this.AddGene(IcelandicSheepdogGeneName.EyeHealth, new EyeHealth());
        this.AddGene(IcelandicSheepdogGeneName.EyeColor, new EyeColorIcelandicSheedog());
        this.AddGene(IcelandicSheepdogGeneName.HeartHealth, new HeartHealthIcelandicSheepdog());
        this.AddGene(IcelandicSheepdogGeneName.FrontDewClaws, new FrontDewClawsIcelandicSheepdog());
        this.AddGene(IcelandicSheepdogGeneName.RearDewClaws, new RearDewClawsIcelandicSheepdog());
    }
}

