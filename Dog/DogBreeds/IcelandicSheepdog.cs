using Genetics;
using IcelandicSheepdog;
namespace Dog
{
	public class IcelandicSheepdog : Dog
    {
        public IcelandicSheepdog(bool isEthical, GeneticsOptionsAbstract options) : base()
        {
            this.genetics = new DogGeneticsIcelandicSheepdog(options, isEthical);
            this.EthicalToBreed = IsEthicalToBreed(this.genetics,
                GeneNameIcelandicSheepdog.geneNames);
        }

        public IcelandicSheepdog(DogGeneticsIcelandicSheepdog parentA,
            DogGeneticsIcelandicSheepdog parentB, String name) : base(name)
        {
            this.genetics = new DogGeneticsIcelandicSheepdog(parentA, parentB);
            this.EthicalToBreed = IsEthicalToBreed(this.genetics,
                GeneNameIcelandicSheepdog.geneNames);
        }
    }
}