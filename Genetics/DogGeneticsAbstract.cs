using Vocabulary;
namespace Genetics;

public abstract class DogGeneticsAbstract
{
    public AlleleSet Hips { get; protected set; }
    public AlleleSet CoatColor { get; protected set; }
    public AlleleSet CoatLength { get; protected set; }
    public AlleleSet CoatTexture { get; protected set; }
    public AlleleSet Shedding { get; protected set; }
    public AlleleSet Markings { get; protected set; }
    public AlleleSet AffectionLevel { get; protected set; }
    public AlleleSet Friendliness { get; protected set; }
    public AlleleSet Playfulness { get; protected set; }
    public AlleleSet Adaptability { get; protected set; }
    public AlleleSet MentalStimulationNeeds { get; protected set; }
    public AlleleSet EnergyLevel { get; protected set; }
    public AlleleSet Barking { get; protected set; }
    public AlleleSet Reactivity { get; protected set; }
    public AlleleSet Curiosity { get; protected set; }
    public AlleleSet Confidence { get; protected set; }
    public AlleleSet AffinityForHerding { get; protected set; }
    public AlleleSet AffinityForSwimmingAndDockDiving { get; protected set; }
    public AlleleSet AffinityForFastCAT { get; protected set; }
    public AlleleSet AffinityForAgility { get; protected set; }
    public AlleleSet AffinityForProtection { get; protected set; }
    public AlleleSet AffinityForFlyball { get; protected set; }
    public AlleleSet AffinityForBarnhunt { get; protected set; }
    public AlleleSet AffinityForScentwork { get; protected set; }
    public AlleleSet AffinityForDisc { get; protected set; }
    public AlleleSet EyeHealth { get; protected set; }
    public AlleleSet EyeColor { get; protected set; }
    public AlleleSet HeartHealth { get; protected set; }

    public DogGeneticsAbstract(GeneticsOptionsAbstract options, bool isEthical)
	{
        if (isEthical)
            EthicalDog(options);
        else
            UnethicalDog(options);
    }

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
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.CoatTexture);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Shedding);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Markings);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffectionLevel);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Friendliness);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Playfulness);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Adaptability);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.MentalStimulationNeeds);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.EnergyLevel);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Barking);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Reactivity);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Curiosity);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.Confidence);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForHerding);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForSwimmingAndDockDiving);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForFastCAT);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForAgility);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForProtection);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForFlyball);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForBarnhunt);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForScentwork);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForDisc);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.EyeHealth);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.EyeColor);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);

        gene = options.GetGene(GeneName.HeartHealth);
        CoatColor = new(gene.GetEthicalAllele(), gene.GetEthicalAllele(), gene);
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
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.CoatTexture);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Shedding);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Markings);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffectionLevel);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Friendliness);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Playfulness);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Adaptability);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.MentalStimulationNeeds);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.EnergyLevel);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Barking);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Reactivity);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Curiosity);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.Confidence);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForHerding);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForSwimmingAndDockDiving);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForFastCAT);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForAgility);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForProtection);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForFlyball);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForBarnhunt);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForScentwork);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.AffinityForDisc);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.EyeHealth);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.EyeColor);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);

        gene = options.GetGene(GeneName.HeartHealth);
        CoatColor = new(gene.GetAnyAllele(), gene.GetAnyAllele(), gene);
    }
}

