using GeneralGenes;
using Vocabulary;
namespace Genetics;

/// <summary>
/// An abstract option of the options for the genetics of a specific breed.
/// </summary>
public abstract class GeneticsOptionsAbstract
{
	private Dictionary<String, GeneInformationAbstract> genes;

    /// <summary>
    /// Creates the genetic options with the keys being the gene name list.
    /// </summary>
    /// <param name="geneNameList">The keys to the genes.</param>
	public GeneticsOptionsAbstract(GeneNameListAbstract geneNameList)
	{
		genes = new();
        GenerateBaseGenes(geneNameList);
        GenerateGenes(geneNameList);
    }

    /// <summary>
    /// Gets the gene associated with the gene name.
    /// </summary>
    /// <param name="name">The name of the gene.</param>
    /// <returns>The gene associated with the gene name.</returns>
    public GeneInformationAbstract GetGene(String name)
    {
        return genes[name];
    }

    /// <summary>
    /// Adds the specified gene to the options. Removes the previous value if
    /// the gene name is already associated with a gene.
    /// </summary>
    /// <param name="geneName">The name of the gene.</param>
    /// <param name="gene">The gene.</param>
    protected void AddGene(String geneName, GeneInformationAbstract gene)
    {
        if (this.genes.TryGetValue(geneName, out _))
            this.genes.Remove(geneName);

        this.genes.Add(geneName, gene);
    }

    /// <summary>
    /// Generates the base genes that every dog has.
    /// </summary>
    private void GenerateBaseGenes(GeneNameListAbstract geneNameList)
    {
        this.AddGene(geneNameList.AffectionLevel, new AffectionLevel());
        this.AddGene(geneNameList.Playfulness, new Playfulness());
        this.AddGene(geneNameList.Friendliness, new Friendliness());
        this.AddGene(geneNameList.Adaptability, new Adaptability());
        this.AddGene(geneNameList.Reactivity, new Reactivity());
        this.AddGene(geneNameList.Curiosity, new Curiosity());
        this.AddGene(geneNameList.Confidence, new Confidence());
        this.AddGene(geneNameList.AffinityForHerding, new AffinityForHerding());
        this.AddGene(geneNameList.HeartHealth, new HeartHealth());
        this.AddGene(geneNameList.AffinityForFastCAT, new AffinityForFastCAT());
        this.AddGene(geneNameList.AffinityForSwimmingAndDockDiving, new AffinityForSwimmingAndDockDiving());
        this.AddGene(geneNameList.AffinityForAgility, new AffinityForAgility());
        this.AddGene(geneNameList.AffinityForProtection, new AffinityForProtection());
        this.AddGene(geneNameList.AffinityForFlyball, new AffinityForFlyball());
        this.AddGene(geneNameList.AffinityForBarnhunt, new AffinityForBarnhunt());
        this.AddGene(geneNameList.AffinityForScentwork, new AffinityForScentwork());
        this.AddGene(geneNameList.AffinityForDisc, new AffinityForDisc());
        this.AddGene(geneNameList.EyeHealth, new EyeHealth());
    }

    /// <summary>
    /// Generates the genes for these genetics. Only the genes specific to this
    /// breed need to be added.
    /// </summary>
    /// <param name="geneNameList">The list of gene names.</param>
    protected abstract void GenerateGenes(GeneNameListAbstract geneNameList);
}
