using Vocabulary;
using GeneralGenes;
namespace Genetics;

public abstract class DogGeneticsAbstract
{
    private Dictionary<GeneName, AlleleSet> alleleSets;

    public DogGeneticsAbstract(GeneticsOptionsAbstract options, bool isEthical,
        IEnumerable<GeneName> geneNames)
	{
        this.alleleSets = new();

        if (isEthical)
            EthicalDog(options, geneNames);
        else
            UnethicalDog(options, geneNames);
    }

    public DogGeneticsAbstract(DogGeneticsAbstract parentA, DogGeneticsAbstract
        parentB, IEnumerable<GeneName> geneNames)
    {
        this.alleleSets = new();
        foreach (GeneName geneName in geneNames)
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
    public AlleleSet GetAlleleSet(GeneName geneName)
    {
        return alleleSets[geneName];
    }

    /// <summary>
    /// Sets up the genetics to be from an ethical dog.
    /// </summary>
    /// <param name="options">The genetic options.</param>
    protected void EthicalDog(GeneticsOptionsAbstract options,
        IEnumerable<GeneName> geneNames)
    {
        foreach (GeneName geneName in geneNames)
            this.AddGene(geneName, options, true);
    }

    /// <summary>
    /// Sets up the genetics to be from an unethically-bred dog.
    /// </summary>
    /// <param name="options">The genetic options.</param>
    protected void UnethicalDog(GeneticsOptionsAbstract options,
        IEnumerable<GeneName> geneNames)
    {
        foreach (GeneName geneName in geneNames)
            this.AddGene(geneName, options, false);
    }

    /// <summary>
    /// Adds the given gene.
    /// </summary>
    /// <param name="geneName">The name of the gene.</param>
    /// <param name="gene">The gene being added.</param>
    /// <param name="ethical">Whether or not the allele set to add needs to be
    /// ethical.</param>
    protected void AddGene(GeneName geneName, GeneticsOptionsAbstract options, bool ethical)
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

