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
    /// Generates the genes for these genetics.
    /// </summary>
    protected abstract void GenerateGenes();
}
