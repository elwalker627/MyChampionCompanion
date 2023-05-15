using GeneralGenes;
using Vocabulary;
namespace Genetics;

public abstract class GeneticsOptionsAbstract
{
	private Dictionary<GeneName, GeneInformationAbstract> genes;

	public GeneticsOptionsAbstract()
	{
		genes = new();
        GenerateBaseGenes();
        GenerateGenes();
    }

    /// <summary>
    /// Gets the gene associated with the gene name.
    /// </summary>
    /// <param name="name">The name of the gene.</param>
    /// <returns>The gene associated with the gene name.</returns>
    public GeneInformationAbstract GetGene(GeneName name)
    {
        return genes[name];
    }

    /// <summary>
    /// Adds the specified gene to the options. Removes the previous value if
    /// the gene name is already associated with a gene.
    /// </summary>
    /// <param name="geneName">The name of the gene.</param>
    /// <param name="gene">The gene.</param>
    protected void AddGene(GeneName geneName, GeneInformationAbstract gene)
    {
        if (this.genes.TryGetValue(geneName, out _))
            this.genes.Remove(geneName);

        this.genes.Add(geneName, gene);
    }

    /// <summary>
    /// Generates the base genes that every dog has.
    /// </summary>
    private void GenerateBaseGenes()
    {
        this.AddGene(GeneName.Hips, new Hips());
        this.AddGene(GeneName.AffectionLevel, new AffectionLevel());
        this.AddGene(GeneName.Playfulness, new Playfulness());
        this.AddGene(GeneName.Friendliness, new Friendliness());
        this.AddGene(GeneName.Adaptability, new Adaptability());
        this.AddGene(GeneName.Reactivity, new Reactivity());
        this.AddGene(GeneName.Curiosity, new Curiosity());
        this.AddGene(GeneName.Confidence, new Confidence());
        this.AddGene(GeneName.AffinityForHerding, new AffinityForHerding());
        this.AddGene(GeneName.HeartHealth, new HeartHealth());
        this.AddGene(GeneName.AffinityForFastCAT, new AffinityForFastCAT());
        this.AddGene(GeneName.AffinityForSwimmingAndDockDiving, new AffinityForSwimmingAndDockDiving());
        this.AddGene(GeneName.AffinityForAgility, new AffinityForAgility());
        this.AddGene(GeneName.AffinityForProtection, new AffinityForProtection());
        this.AddGene(GeneName.AffinityForFlyball, new AffinityForFlyball());
        this.AddGene(GeneName.AffinityForBarnhunt, new AffinityForBarnhunt());
        this.AddGene(GeneName.AffinityForScentwork, new AffinityForScentwork());
        this.AddGene(GeneName.AffinityForDisc, new AffinityForDisc());
        this.AddGene(GeneName.EyeHealth, new EyeHealth());
    }

    /// <summary>
    /// Generates the genes for these genetics. Only the genes specific to this
    /// breed need to be added.
    /// </summary>
    protected abstract void GenerateGenes();
}
