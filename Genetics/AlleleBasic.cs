namespace Genetics
{
	public class AlleleBasic : IComparable<AlleleBasic>
	{
		/// <summary>
		/// The character used to represent this allele.
		/// </summary>
		public char Representation { get; private set; }

		/// <summary>
		/// The description of this allele's effect.
		/// </summary>
		public string Description { get; private set; }

		/// <summary>
		/// An int [0,100] that describes the dominance of this allele among its
		/// alternate genes, with 100 being the most dominane and 0 being the
		/// least dominant.
		/// </summary>
		protected int Dominance { get; private set; }

        /// <summary>
        /// Creates a basic allele.
        /// </summary>
        /// <param name="representation">The character used to represent this
        /// allele.</param>
        /// <param name="description">A description of the effect of this
        /// allele./param>
        /// <param name="dominance">The dominance of the allele. Must be
        /// [0,100]</param>
        /// <exception cref="ArgumentException">If the dominance is less than
        /// zero or greater than one hundred.</exception>
        internal AlleleBasic(char representation, string description,
            int dominance)
        {
            this.Representation = representation;
            this.Description = description;
            if (dominance > 100 || dominance < 0)
                throw new ArgumentException("Dominance must be [0,100].");
            else
                this.Dominance = dominance;
        }

        /// <summary>
        /// Determines which allele is more dominant.
        /// </summary>
        /// <param name="other">The other allele. Will throw an exception if is
        /// null.</param>
        /// <returns>Returns a positive number if this allele is more dominant, zero if
        /// the alleles are equally dominant, or a negative number if the other
        /// allele is more dominant.</returns>
        /// <exception cref="ArgumentException">When other is not an
		/// AlleleAbstract.</exception>
        public int CompareTo(AlleleBasic? other)
        {
			if (other is null)
				throw new ArgumentException("Can't compare to null.");
			else
				return this.Dominance - other.Dominance;
        }

		/// <summary>
		/// Determines if this allele is more dominant.
		/// </summary>
		/// <param name="other">The other allele. Will throw an exception if is
		/// null.</param>
		/// <returns>True if this is dominant, false otherwise.</returns>
		public bool IsDominantTo(AlleleBasic other)
		{
			return this.CompareTo(other) > 0;
		}
    }
}