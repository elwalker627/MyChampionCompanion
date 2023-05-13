using Vocabulary;
namespace Genetics
{
	public abstract class GeneticsAbstract
	{
		private Dictionary<GeneName, GeneAbstract> genes;

		public GeneticsAbstract()
		{
			genes = new();
            GenerateGenes();
        }

        /// <summary>
        /// Generates the genes for these genetics.
        /// </summary>
        protected abstract void GenerateGenes();
    }
}

