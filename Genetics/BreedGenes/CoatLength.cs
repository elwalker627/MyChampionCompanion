using System;
namespace Genetics
{
	public abstract class CoatLength : GeneInformationAbstract
	{
		public CoatLength()
		{
		}

        public override string Phenotype(AlleleBasic alleleA, AlleleBasic alleleB)
        {
            if (alleleA.IsDominantTo(alleleB))
                return alleleA.Description;
            else
                return alleleB.Description;
        }
    }
}

