using Genetics;
namespace Vocabulary;

/// <summary>
/// Represents a specific type of string, called a gene name.
/// </summary>
public class GeneName
{
	public String Name { get; private set; }
    public static GeneName CoatColor { get { return new("coat_color"); } }
    public static GeneName CoatLength { get { return new("coat_length"); } }
    public static GeneName Hips { get { return new("hips"); } }
    public static GeneName EyeHealth { get { return new("eye_health"); } }
    public static GeneName HeartHealth { get { return new("heart_health"); } }
    public static GeneName Trainability { get { return new("trainability"); } }
    public static GeneName Confidence { get { return new("confidence"); } }
    public static GeneName Reactivity { get { return new("reactivity"); } }
    public static GeneName CoatTexture { get { return new("coat_texture"); } }
    public static GeneName Shedding { get { return new("shedding"); } }

    public static GeneName Markings { get { return new("markings"); } }
    public static GeneName AffectionLevel { get { return new("affection_level"); } }
    public static GeneName Friendliness { get { return new("friendliness"); } }
    public static GeneName Playfulness { get { return new("playfulness"); } }
    public static GeneName Adaptability { get { return new("adaptability"); } }
    public static GeneName MentalStimulationNeeds { get { return new("mental_stimulation_needs"); } }
    public static GeneName EnergyLevel { get { return new("energy_level"); } }
    public static GeneName Barking { get { return new("barking"); } }
    public static GeneName Curiosity { get { return new("curiosity"); } }
    public static GeneName AffinityForHerding { get { return new("affinity_for_herding"); } }

    public static GeneName AffinityForSwimmingAndDockDiving { get { return new("affinity_for_swimming_and_dock_diving"); } }
    public static GeneName AffinityForFastCAT { get { return new("affinity_for_fast_cat"); } }
    public static GeneName AffinityForAgility { get { return new("affinity_for_agility"); } }
    public static GeneName AffinityForProtection { get { return new("affinity_for_protection"); } }
    public static GeneName AffinityForFlyball { get { return new("affinity_for_flyball"); } }
    public static GeneName AffinityForBarnhunt { get { return new("affinity_for_barnhunt"); } }
    public static GeneName AffinityForScentwork { get { return new("affinity_for_scentwork"); } }
    public static GeneName AffinityForDisc { get { return new("affinity_for_disc"); } }
    public static GeneName EyeColor { get { return new("eye_color"); } }

    public static HashSet<GeneName> geneNames = SetUpHashSet();

    /// <summary>
    /// Creates a gene name.
    /// </summary>
    /// <param name="name">The name of the gene.</param>
    protected GeneName(string name)
	{
		this.Name = name;
	}

		/// <inheritdoc/>
    public override string ToString()
    {
        return Name;
    }

    private static HashSet<GeneName> SetUpHashSet()
    {
        HashSet<GeneName> returner = new();

        returner.Add(CoatColor);
        returner.Add(CoatLength);
        returner.Add(Hips);
        returner.Add(EyeHealth);
        returner.Add(HeartHealth);
        returner.Add(Trainability);
        returner.Add(Confidence);
        returner.Add(Reactivity);
        returner.Add(CoatTexture);
        returner.Add(Shedding);

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
        returner.Add(EyeColor);

        return returner;
    }
}

