namespace Genetics;

/// <summary>
/// A basic allele.
/// </summary>
public class AlleleBasic : IComparable<AlleleBasic>
{
	/// <summary>
	/// The character used to represent this allele.
	/// </summary>
	public char Representation { get; protected set; }

	/// <summary>
	/// The description of this allele's effect.
	/// </summary>
	public string Description { get; protected set; }

	/// <summary>
	/// An int [0,100] that describes the dominance of this allele among its
	/// alternate genes, with 100 being the most dominane and 0 being the
	/// least dominant. 50 is considered on the recessive side.
	/// </summary>
	public int Dominance { get; protected set; }

    /// <summary>
    /// Creates a basic allele.
    /// </summary>
    /// <param name="representation">The character used to represent this
    /// allele. Must be lowercase.</param>
    /// <param name="description">A description of the effect of this
    /// allele./param>
    /// <param name="dominance">The dominance of the allele. Must be
    /// [0,100]</param>
    /// <exception cref="ArgumentException">If the dominance is less than
    /// zero or greater than one hundred or the representation is not a
    /// lowercase letter..</exception>
    internal AlleleBasic(char representation, string description,
        int dominance)
    {
        if (representation > 'z' || representation < 'a')
            throw new ArgumentException("The representation must be lowercase.");
        else
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

    public override bool Equals(object? obj)
    {
        if (obj is null || !(obj is AlleleBasic))
            return false;

        AlleleBasic other = (AlleleBasic)obj;

        return other.Representation == this.Representation &&
            other.Description == this.Description &&
            other.Dominance == this.Dominance;
    }

    public override string ToString()
    {
        return Description;
    }
}