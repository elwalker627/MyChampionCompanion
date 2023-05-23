```
Authors:        Elise Walker
Start Date:     May 12th, 2023
Course:         CS 3500, University of Utah, School of Computing
GitHub ID:      elwaker627
Repo:           https://github.com/elwalker627/MyChampionCompanion.git
Commit Date:    May 22nd, 2023
Solution:       My_Champion_Companion
Copyright:      Elise Walker
```

# Overview of the Genetics functionality

A fully functioning library of genetics for dogs. Currently, the breeds
supported only includes the Icelandic Sheepdog.

# Good Software Practices

This project utilizes many good software practices. Below is a list of
the good software practices used, as well as examples of their use.

## Single Responsibility

Single Responsibility is where every class is responsible for one thing.

The best example of this concept utilized in this project is the breed genes.
There are many, many different genes that are used in the game, but instead
of creating a single class that handles every gene, each gene has its own
class. The reason why this is useful is for when we add dogs. Many of the genes
are reusable, and so making them single responsibility allows for adding breeds
to the game while adding less code.

## Dependency Inversion

Dependency Inversion is where any child class can replace the parent class and
still work.

Great care was taken in writing the code for the abstract classes in order to
ensure that any child class could be as simple as possible, making it easier
to ensure dependency inversion. Some concrete actions taken to ensure this
include:
* Making any method that would be consistent inside the abstract class.
* Declaring any method needed by the class for all child classes as abstract.
* Making important actions separate, abstract methods to ensure that the child
class will take care of it.

## The Liskov Substitution Principle

The Liskov Substitution Principle states that any use of a class is based on
an abstraction.

In order to make it easy to add to this game, the Liskov Substitution Principle
was heavily used. Almost every class has an abstract parent, and a specific
breed has a specific set of these classes. Examples include:
* Gene Name List
* Genetic Options
* Gene Information
* Personality Traits
* Height
* Weight
* Dog Genetics

## DRY Principle

The DRY Principle states that anywhere that code is repeated should be extracted
and consolidated in one place to avoid repetition. AKA "Don't Repeat Yourself".

The two major uses of this principle are (1) extracting methods and (2) creating
parent classes.

Some examples of extracting methods include:
* Calculating the hip score in the HipsIcelandicSheepdog class
* Getting the allele representation in alphabetical order in the AlleleSet class.
* Adding a gene in the GeneticOptionsAbstract class. This method is only called
once within this class, but it is assumed that it will be used frequently by
child classes.

The main example of creating parent classes is the Personality Trait class,
which contains all of the logic for a basic personality trait. With the use
of this parent class, all personality traits need to implement is adding the
alleles, because the allele representations are specific to the trait.

## Dependency Injection

Dependency Injection is where instead of creating static classes and fields,
there is one instance of the object created at the beginning of the program
which gets passed to any method or class that needs to use it.

Dependency Injection was used with the Gene Name List. Originally, the Gene
Name List was made static because it doesn't depend on anything. However, after
some reflection, it was decided that this is a case where Dependency Injection
is appropriate, so the class itself and anywhere the class is utilized was
updated to use Dependency Injection.