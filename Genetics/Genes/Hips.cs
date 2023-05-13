using System;
namespace Genetics.Genes
{
    public class Hips : GeneAbstract
    {
        private Dictionary<char, int> hipsScores;
        private Dictionary<int, char> scoresHips;

        /// <inheritdoc/>
        public Hips() : base()
        {
            this.IsIncompletelyDominant = true;
            hipsScores = new();
            scoresHips = new();
        }

        public override string Phenotype(AlleleBasic alleleA, AlleleBasic alleleB)
        {
            int score = (hipsScores[alleleA.Representation] +
                hipsScores[alleleB.Representation]) / 2;
        }

        protected override void GenerateAlleles()
        {
            this.AddAlleleAndScore(new('e', "Excellent hips", Recessive), 5);
            this.AddAlleleAndScore(new('g', "Good hips", Dominant), 4);
            this.AddAlleleAndScore(new('a', "Acceptable hips", Dominant), 3);
            this.AddAlleleAndScore(new('f', "Fair hips", Recessive), 2);
            this.AddAlleleAndScore(new('p', "Poor hips", Recessive), 1);
            this.AddAlleleAndScore(new('b', "Bad hips", Recessive), 0);
        }

        /// <summary>
        /// Adds the specified allele to the dictionary and adds the scores as
        /// needed.
        /// </summary>
        /// <param name="toAdd">The allele to add.</param>
        /// <param name="score">The hip score of the allele.</param>
        protected void AddAlleleAndScore(AlleleBasic toAdd, int score)
        {
            this.AddAllele(toAdd);
            this.hipsScores.Add(toAdd.Representation, score);
            this.scoresHips.Add(score, toAdd.Representation);
        }
    }
}

