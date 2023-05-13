namespace Vocabulary
{
	/// <summary>
	/// Represents a specific type of string, called a gene name.
	/// </summary>
	public class GeneName
	{
		public String Name { get; private set; }
        public static GeneName CoatColor { get { return new("coat_color"); } }
        public static GeneName CoatLength { get { return new("coat_length"); } }
        public static GeneName Hips { get { return new("hips"); } }
        public static GeneName EyeHealth { get { return new("eye_health"); } }
        public static GeneName Trainability { get { return new("trainability"); } }
        public static GeneName AffinityForJob { get { return new("affinity_for_job"); } }
        public static GeneName Confidence { get { return new("confidence"); } }
        public static GeneName Reactivity { get { return new("reactivity"); } }

        /// <summary>
        /// Creates a gene name.
        /// </summary>
        /// <param name="name">The name of the gene.</param>
        private GeneName(string name)
		{
			this.Name = name;
		}

		/// <inheritdoc/>
        public override string ToString()
        {
            return Name;
        }
    }
}

