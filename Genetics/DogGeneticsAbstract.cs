using Vocabulary;
using GeneralGenes;
namespace Genetics;

/// <summary>
/// An abstract version of a dog's genetics.
/// </summary>
public abstract class DogGeneticsAbstract
{
    private Dictionary<String, AlleleSet> alleleSets;
    public GeneNameListAbstract geneNames;

    /// <summary>
    /// Creates a dog that is fully able to breed (either ethically or
    /// non-ethically).
    /// </summary>
    /// <param name="options">The genetic options from which to choose.</param>
    /// <param name="isEthical">Whether or not the dog needs to be ethical to
    /// breed.</param>
    /// <param name="geneNameList">The list of gene names for this breed.
    /// </param>
    public DogGeneticsAbstract(GeneticsOptionsAbstract options, bool isEthical,
        GeneNameListAbstract geneNameList)
	{
        this.alleleSets = new();
        this.geneNames = geneNameList;

        if (isEthical)
            EthicalDog(options, geneNames.GeneNames);
        else
            UnethicalDog(options, geneNames.GeneNames);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parentA"></param>
    /// <param name="parentB"></param>
    /// <param name="geneNameList"></param>
    public DogGeneticsAbstract(DogGeneticsAbstract parentA, DogGeneticsAbstract
        parentB, GeneNameListAbstract geneNameList)
    {
        this.alleleSets = new();
        this.geneNames = geneNameList;

        foreach (String geneName in geneNames.GeneNames)
        {
            this.alleleSets.Add(geneName,
                new(parentA.alleleSets[geneName].GetRandomAllele(),
                parentA.alleleSets[geneName].GetRandomAllele(),
                parentA.alleleSets[geneName].PhenotypeFunc,
                parentA.alleleSets[geneName].EthicalToBreedFunc));
        }
    }

    /// <summary>
    /// Gets the specified gene.
    /// </summary>
    /// <param name="geneName">The name of the gene.</param>
    /// <returns>The gene associated with gene name.</returns>
    public AlleleSet GetAlleleSet(String geneName)
    {
        return alleleSets[geneName];
    }

    /// <summary>
    /// Sets up the genetics to be from an ethical dog.
    /// </summary>
    /// <param name="options">The genetic options.</param>
    protected void EthicalDog(GeneticsOptionsAbstract options,
        IEnumerable<String> geneNames)
    {
        foreach (String geneName in geneNames)
            this.AddGene(geneName, options, true);
    }

    /// <summary>
    /// Sets up the genetics to be from an unethically-bred dog.
    /// </summary>
    /// <param name="options">The genetic options.</param>
    protected void UnethicalDog(GeneticsOptionsAbstract options,
        IEnumerable<String> geneNames)
    {
        foreach (String geneName in geneNames)
            this.AddGene(geneName, options, false);
    }

    /// <summary>
    /// Adds the given gene.
    /// </summary>
    /// <param name="geneName">The name of the gene.</param>
    /// <param name="gene">The gene being added.</param>
    /// <param name="ethical">Whether or not the allele set to add needs to be
    /// ethical.</param>
    protected void AddGene(String geneName, GeneticsOptionsAbstract options, bool ethical)
    {
        GeneInformationAbstract gene = options.GetGene(geneName);
        if (ethical)
        {
            AlleleBasic alleleA = gene.GetEthicalAllele();
            AlleleBasic alleleB = gene.GetEthicalAllele();

            while (!gene.EthicalToBreed(alleleA, alleleB))
            {
                alleleA = gene.GetEthicalAllele();
                alleleB = gene.GetEthicalAllele();
            }

            this.alleleSets.Add(geneName, new(alleleA, alleleB, gene.Phenotype,
                gene.EthicalToBreed));
        }

        else
            this.alleleSets.Add(geneName, new(gene.GetAnyAllele(),
                gene.GetAnyAllele(), gene.Phenotype, gene.EthicalToBreed));
    }
}

