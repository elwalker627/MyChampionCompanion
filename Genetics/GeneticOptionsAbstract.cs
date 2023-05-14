using Vocabulary;
namespace Genetics;

	public abstract class GeneticsOptionsAbstract
	{
		private Dictionary<GeneName, GeneInformationAbstract> genes;

		public GeneticsOptionsAbstract()
		{
			genes = new();
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
    /// Adds the specified gene to the options.
    /// </summary>
    /// <param name="geneName">The name of the gene.</param>
    /// <param name="gene">The gene.</param>
    protected void AddGene(GeneName geneName, GeneInformationAbstract gene)
    {
        this.genes.Add(geneName, gene);
    }

    /// <summary>
    /// Generates the genes for these genetics. ALL genes must be added in this
    /// method because some of the basic genes may be overridden in sepecific
    /// breeds.
    /// </summary>
    protected abstract void GenerateGenes();
}
