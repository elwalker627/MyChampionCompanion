using System;
using Genetics;

namespace Dog;

public class Pedigree : BasicPedigree
{
    public Dog Mother { get; protected set; }
    public Dog Father { get; protected set; }
    public Dog MaternalGrandMother { get; protected set; }
    public Dog PaternalGrandMother { get; protected set; }
    public Dog MaternalGrandfather { get; protected set; }
    public Dog PaternalGrandfather { get; protected set; }

    public Dog MMGreat_Grandmother { get; protected set; }
    public Dog MPGreat_Grandfather { get; protected set; }
    public Dog PMGreat_Grandfather { get; protected set; }
    public Dog PPGreat_Grandfather { get; protected set; }
    public Dog MMGreat_Grandfather { get; protected set; }
    public Dog MPGreat_Grandmother { get; protected set; }
    public Dog PMGreat_Grandmother { get; protected set; }
    public Dog PPGreat_Grandmother { get; protected set; }

    public Pedigree(BasicPedigree motherBasicPedigree, BasicPedigree fatherBasicPedigree, Dog self)
        : base(self)
    {
        if (motherBasicPedigree is BasicPedigree || fatherBasicPedigree is BasicPedigree)
            throw new Exception("Cannot make a full pedigree from a basic pedigree.");

        Pedigree motherPedigree = (Pedigree)motherBasicPedigree;
        Pedigree fatherPedigree = (Pedigree)fatherBasicPedigree;

        this.Mother = motherPedigree.Self;
        this.Father = fatherPedigree.Self;
        this.MaternalGrandfather = motherPedigree.Father;
        this.MaternalGrandMother = motherPedigree.Mother;
        this.PaternalGrandfather = fatherPedigree.Father;
        this.PaternalGrandMother = fatherPedigree.Mother;

        this.MMGreat_Grandmother = ((Pedigree)motherPedigree.Mother.pedigree).Mother;
        this.MMGreat_Grandfather = ((Pedigree)motherPedigree.Mother.pedigree).Father;

        this.MPGreat_Grandfather = ((Pedigree)motherPedigree.Father.pedigree).Father;
        this.MPGreat_Grandmother = ((Pedigree)motherPedigree.Father.pedigree).Mother;

        this.PPGreat_Grandfather = ((Pedigree)fatherPedigree.Father.pedigree).Father;
        this.PPGreat_Grandmother = ((Pedigree)fatherPedigree.Father.pedigree).Mother;

        this.PMGreat_Grandfather = ((Pedigree)fatherPedigree.Mother.pedigree).Father;
        this.PMGreat_Grandmother = ((Pedigree)fatherPedigree.Mother.pedigree).Mother;

        this.SetUpPedigree();
    }

    public Pedigree(List<Dog> ggGrandparents, Func<DogGeneticsAbstract,
        DogGeneticsAbstract, Dog> constructor) : base(ggGrandparents[0])
    {
        if (ggGrandparents.Count() != 8)
            throw new Exception("Invalid ancestor count. You may repreat " +
                "for an unethically bred dog.");

        this.MMGreat_Grandmother = ggGrandparents[0];
        this.MMGreat_Grandfather = ggGrandparents[1];

        this.MaternalGrandMother = constructor(MMGreat_Grandfather.genetics, MMGreat_Grandmother.genetics);

        this.MPGreat_Grandmother = ggGrandparents[2];
        this.MPGreat_Grandfather = ggGrandparents[3];

        this.MaternalGrandfather = constructor(MPGreat_Grandmother.genetics, MPGreat_Grandfather.genetics);

        this.Mother = constructor(MaternalGrandMother.genetics, MaternalGrandfather.genetics);

        this.PMGreat_Grandmother = ggGrandparents[4];
        this.PMGreat_Grandfather = ggGrandparents[5];

        this.PaternalGrandMother = constructor(PMGreat_Grandfather.genetics, PMGreat_Grandmother.genetics);

        this.PPGreat_Grandmother = ggGrandparents[6];
        this.PPGreat_Grandfather = ggGrandparents[7];

        this.PaternalGrandfather = constructor(PPGreat_Grandmother.genetics, PPGreat_Grandfather.genetics);

        this.Father = constructor(PaternalGrandMother.genetics, PaternalGrandfather.genetics);

        this.Self = constructor(Mother.genetics, Father.genetics);

    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Pedigree))
            return false;
        Pedigree b = (Pedigree)obj;

        return this.Mother == b.Mother && this.Father == b.Father &&
            this.MaternalGrandfather == b.MaternalGrandfather &&
            this.PaternalGrandfather == b.PaternalGrandfather &&
            this.MaternalGrandMother == b.MaternalGrandMother &&
            this.PaternalGrandMother == b.PaternalGrandMother &&
            this.MMGreat_Grandfather == b.MMGreat_Grandfather &&
            this.MMGreat_Grandmother == b.MaternalGrandMother &&
            this.PPGreat_Grandfather == b.PPGreat_Grandfather &&
            this.PPGreat_Grandmother == a.PPGreat_Grandmother &&
            this.MPGreat_Grandfather == b.MPGreat_Grandfather &&
            this.MPGreat_Grandmother == b.MPGreat_Grandmother &&
            this.PMGreat_Grandfather == b.PMGreat_Grandfather &&
            this.PMGreat_Grandmother == b.PMGreat_Grandmother;
    }

    /// <summary>
    /// Sets up the pedigree. Assumes all the pedigree properties are set.
    /// </summary>
    protected void SetUpPedigree()
    {
        ancestors.Add(Mother);
        ancestors.Add(Father);
        ancestors.Add(MaternalGrandMother);
        ancestors.Add(MaternalGrandfather);
        ancestors.Add(PaternalGrandMother);
        ancestors.Add(PaternalGrandfather);
        ancestors.Add(MMGreat_Grandmother);
        ancestors.Add(MMGreat_Grandfather);
        ancestors.Add(MPGreat_Grandmother);
        ancestors.Add(MPGreat_Grandfather);
        ancestors.Add(PMGreat_Grandmother);
        ancestors.Add(PMGreat_Grandfather);
        ancestors.Add(PPGreat_Grandmother);
        ancestors.Add(PPGreat_Grandfather);
    }

    /// <summary>
    /// Constructs a pedigree from scratch. Also sets up the pedigree.
    /// </summary>
    /// <param name="isEthical">Whether or not all the ancestors need to be
    /// ethical to breed.</param>
    protected void ConstructPedigree(bool isEthical, GeneticsOptionsAbstract options)
    {
        // TODO

        this.SetUpPedigree();
    }

    /// <summary>
    /// Determines whether or not this dog is related to the given dog.
    /// </summary>
    /// <param name="dog">The given dog.</param>
    /// <returns>True if these dogs share a common ancestor from
    /// great-great-grandparent down, false otherwise.</returns>
    public bool IsRelated(Dog dog)
    {
        if (this.ancestors.Contains(dog))
            return true;
        else if (dog.pedigree is BasicPedigree)
            return false;

        List<Dog> pedigree = ((Pedigree)dog.pedigree).ancestors;
        foreach (Dog ancestor in ancestors)
            if (pedigree.Contains(ancestor))
                return true;

        return false;
    }
}

