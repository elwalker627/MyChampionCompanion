using Vocabulary;
using GeneralGenes;
namespace Genetics;

public abstract class DogGeneticsAbstract
{
    public AlleleSet Hips { get; private set; }
    public AlleleSet CoatColor { get; private set; }
    public AlleleSet CoatLength { get; private set; }
    public AlleleSet CoatTexture { get; private set; }
    public AlleleSet Shedding { get; private set; }
    public AlleleSet Markings { get; private set; }
    public AlleleSet AffectionLevel { get; private set; }
    public AlleleSet Friendliness { get; private set; }
    public AlleleSet Playfulness { get; private set; }
    public AlleleSet Adaptability { get; private set; }

    public AlleleSet MentalStimulationNeeds { get; private set; }
    public AlleleSet EnergyLevel { get; private set; }
    public AlleleSet Barking { get; private set; }
    public AlleleSet Reactivity { get; private set; }
    public AlleleSet Curiosity { get; private set; }
    public AlleleSet Confidence { get; private set; }
    public AlleleSet AffinityForHerding { get; private set; }
    public AlleleSet AffinityForSwimmingAndDockDiving { get; private set; }
    public AlleleSet AffinityForFastCAT { get; private set; }
    public AlleleSet AffinityForAgility { get; private set; }

    public AlleleSet AffinityForProtection { get; private set; }
    public AlleleSet AffinityForFlyball { get; private set; }
    public AlleleSet AffinityForBarnhunt { get; private set; }
    public AlleleSet AffinityForScentwork { get; private set; }
    public AlleleSet AffinityForDisc { get; private set; }
    public AlleleSet EyeHealth { get; private set; }
    public AlleleSet EyeColor { get; private set; }
    public AlleleSet HeartHealth { get; private set; }

    public DogGeneticsAbstract(GeneticsOptionsAbstract options, bool isEthical)
	{
        if (isEthical)
            EthicalDog(options);
        else
            UnethicalDog(options);
    }

    /// <summary>
    /// Adds traits specific to this breed. Do NOT add traits already in the
    /// parent class. This is for an ethical dog.
    /// </summary>
    /// <param name="options">The genetic options.</param>
    protected abstract void BreedSpecificEthicalDog(GeneticsOptionsAbstract options);

    /// <summary>
    /// Adds traits specific to this breed. Do NOT add traits already in the
    /// parent class. This is for an unethically bred dog.
    /// </summary>
    /// <param name="options">The genetic options.</param>
    protected abstract void BreedSpecificUnethicalDog(GeneticsOptionsAbstract options);

    /// <summary>
    /// Sets up the genetics to be from an ethical dog.
    /// </summary>
    /// <param name="options">The genetic options.</param>
    private void EthicalDog(GeneticsOptionsAbstract options)
    {
        GeneInformationAbstract gene = options.GetGene(GeneName.Hips);
        Hips = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.CoatColor);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.CoatLength);
        CoatLength = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.CoatTexture);
        CoatTexture = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Shedding);
        Shedding = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Markings);
        Markings = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffectionLevel);
        AffectionLevel = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Friendliness);
        Friendliness = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Playfulness);
        Playfulness = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Adaptability);
        Adaptability = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.MentalStimulationNeeds);
        MentalStimulationNeeds = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.EnergyLevel);
        EnergyLevel = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Barking);
        Barking = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Reactivity);
        Reactivity = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Curiosity);
        Curiosity = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Confidence);
        Confidence = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForHerding);
        AffinityForHerding = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForSwimmingAndDockDiving);
        AffinityForSwimmingAndDockDiving = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForFastCAT);
        AffinityForFastCAT = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForAgility);
        AffinityForAgility = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForProtection);
        AffinityForProtection = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForFlyball);
        AffinityForFlyball = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForBarnhunt);
        AffinityForBarnhunt = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForScentwork);
        AffinityForScentwork = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForDisc);
        AffinityForDisc = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.EyeHealth);
        EyeHealth = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.EyeColor);
        EyeColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.HeartHealth);
        HeartHealth = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        BreedSpecificEthicalDog(options);
    }

    /// <summary>
    /// Sets up the genetics to be from an unethically-bred dog.
    /// </summary>
    /// <param name="options">The genetic options.</param>
    private void UnethicalDog(GeneticsOptionsAbstract options)
    {
        GeneInformationAbstract gene = options.GetGene(GeneName.Hips);
        Hips = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.CoatColor);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.CoatLength);
        CoatLength = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.CoatTexture);
        CoatTexture = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Shedding);
        Shedding = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Markings);
        Markings = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffectionLevel);
        AffectionLevel = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Friendliness);
        Friendliness = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Playfulness);
        Playfulness = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Adaptability);
        Adaptability = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.MentalStimulationNeeds);
        MentalStimulationNeeds = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.EnergyLevel);
        EnergyLevel = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Barking);
        Barking = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Reactivity);
        Reactivity = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Curiosity);
        Curiosity = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Confidence);
        Confidence = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForHerding);
        AffinityForHerding = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForSwimmingAndDockDiving);
        AffinityForSwimmingAndDockDiving = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForFastCAT);
        AffinityForFastCAT = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForAgility);
        AffinityForAgility = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForProtection);
        AffinityForProtection = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForFlyball);
        AffinityForFlyball = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForBarnhunt);
        AffinityForBarnhunt = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForScentwork);
        AffinityForScentwork = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForDisc);
        AffinityForDisc = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.EyeHealth);
        EyeHealth = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.EyeColor);
        EyeColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.HeartHealth);
        HeartHealth = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        BreedSpecificUnethicalDog(options);
    }
}

