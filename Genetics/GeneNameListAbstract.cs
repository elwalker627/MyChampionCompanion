using Genetics;
namespace Vocabulary;

/// <summary>
/// Represents a specific type of string, called a gene name.
/// </summary>
public abstract class GeneNameListAbstract
{
    public String CoatColor { get { return new("coat_color"); } }
    public String CoatLength { get { return new("coat_length"); } }
    public String EyeHealth { get { return new("eye_health"); } }
    public String HeartHealth { get { return new("heart_health"); } }
    public String Trainability { get { return new("trainability"); } }
    public String Confidence { get { return new("confidence"); } }
    public String Reactivity { get { return new("reactivity"); } }
    public String CoatTexture { get { return new("coat_texture"); } }
    public String Shedding { get { return new("shedding"); } }
    public String EyeColor { get { return new("eye_color"); } }

    public String Markings { get { return new("markings"); } }
    public String AffectionLevel { get { return new("affection_level"); } }
    public String Friendliness { get { return new("friendliness"); } }
    public String Playfulness { get { return new("playfulness"); } }
    public String Adaptability { get { return new("adaptability"); } }
    public String MentalStimulationNeeds { get { return new("mental_stimulation_needs"); } }
    public String EnergyLevel { get { return new("energy_level"); } }
    public String Barking { get { return new("barking"); } }
    public String Curiosity { get { return new("curiosity"); } }
    public String AffinityForHerding { get { return new("affinity_for_herding"); } }

    public String AffinityForSwimmingAndDockDiving { get { return new("affinity_for_swimming_and_dock_diving"); } }
    public String AffinityForFastCAT { get { return new("affinity_for_fast_cat"); } }
    public String AffinityForAgility { get { return new("affinity_for_agility"); } }
    public String AffinityForProtection { get { return new("affinity_for_protection"); } }
    public String AffinityForFlyball { get { return new("affinity_for_flyball"); } }
    public String AffinityForBarnhunt { get { return new("affinity_for_barnhunt"); } }
    public String AffinityForScentwork { get { return new("affinity_for_scentwork"); } }
    public String AffinityForDisc { get { return new("affinity_for_disc"); } }
    public String[] GeneNames { get { return geneNames.ToArray(); } }

    protected HashSet<String> geneNames;

    /// <summary>
    /// Sets up the gene names.
    /// </summary>
    public GeneNameListAbstract()
    {
        this.geneNames = SetUpHashSet();
        AddBreedSpecificGeneNames();
    }

    /// <summary>
    /// Adds the breed-speciffic gene names.
    /// </summary>
    protected abstract void AddBreedSpecificGeneNames();

    /// <summary>
    /// Adds the gene names to the hashset.
    /// </summary>
    /// <returns></returns>
    private HashSet<String> SetUpHashSet()
    {
        HashSet<String> returner = new();

        returner.Add(CoatColor);
        returner.Add(CoatLength);
        returner.Add(EyeHealth);
        returner.Add(HeartHealth);
        returner.Add(Trainability);
        returner.Add(Confidence);
        returner.Add(Reactivity);
        returner.Add(CoatTexture);
        returner.Add(Shedding);
        returner.Add(EyeColor);

        returner.Add(Markings);
        returner.Add(AffectionLevel);
        returner.Add(Friendliness);
        returner.Add(Playfulness);
        returner.Add(Adaptability);
        returner.Add(MentalStimulationNeeds);
        returner.Add(EnergyLevel);
        returner.Add(Barking);
        returner.Add(AffinityForHerding);
        returner.Add(Curiosity);

        returner.Add(AffinityForSwimmingAndDockDiving);
        returner.Add(AffinityForFastCAT);
        returner.Add(AffinityForAgility);
        returner.Add(AffinityForFlyball);
        returner.Add(AffinityForProtection);
        returner.Add(AffinityForBarnhunt);
        returner.Add(AffinityForScentwork);
        returner.Add(AffinityForDisc);

        return returner;
    }
}

