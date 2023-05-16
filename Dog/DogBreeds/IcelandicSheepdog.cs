using Genetics;
using Vocabulary;
using IcelandicSheepdog;
namespace Dog
{
	public class IcelandicSheepdog : Dog
    {
        public IcelandicSheepdog(bool isEthical, GeneticsOptionsAbstract options) : base()
        {
            GeneNameListAbstract geneNameList = new GeneNameListIcelandicSheepdog();

            this.EthicalToBreed = IsEthicalToBreed(this.genetics,
                geneNameList.GeneNames);
        }

        public IcelandicSheepdog(IcelandicSheepdog mother,
            IcelandicSheepdog father, String name) : base(name)
        {
            this.pedigree = new Pedigree(mother.pedigree, father.pedigree, this);

            GeneNameListAbstract geneNameList = new GeneNameListIcelandicSheepdog();
            this.genetics = new DogGeneticsIcelandicSheepdog((DogGeneticsIcelandicSheepdog)mother.genetics,
                (DogGeneticsIcelandicSheepdog)father.genetics, geneNameList);

            this.EthicalToBreed = IsEthicalToBreed(this.genetics,
                geneNameList.GeneNames);
        }
    }
}