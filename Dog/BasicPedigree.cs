using System;
namespace Dog;

/// <summary>
/// A basic pedigree containing only itself.
/// </summary>
public class BasicPedigree
{
        public Dog Self { get; protected set; }
        protected List<Dog> ancestors;

	/// <summary>
	/// Creates a basic pedigree of only itself.
	/// </summary>
	/// <param name="self">The dog (itself).</param>
    public BasicPedigree(Dog self)
	{
		this.Self = self;
		this.ancestors = new();
		this.ancestors.Add(Self);
	}
}

