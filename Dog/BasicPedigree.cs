using System;
namespace Dog
{
	public class BasicPedigree
    {
        public Dog Self { get; protected set; }
        protected List<Dog> ancestors;

        public BasicPedigree(Dog self)
		{
			this.Self = self;
			this.ancestors = new();
			this.ancestors.Add(Self);
		}
	}
}

