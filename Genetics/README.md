```
Authors:        Elise Walker
Start Date:     May 12th, 2023
Course:         CS 3500, University of Utah, School of Computing
GitHub ID:      elwaker627
Repo:           https://github.com/elwalker627/MyChampionCompanion.git
Commit Date:    May 12th, 2023
Solution:       My_Champion_Companion
Copyright:      Elise Walker
```

# Overview of the Genetics functionality

A fully functioning library of genetics. In order to make it easy to add to
this game, the Liskov Substitution Principle was heavily used. Almost every
class has an abstract parent, and a specific breed has a specific set of these
classes. The parent abstract classes have several helper methods, and any
method that is needed for any breed is included in the abstract version to
emulate the DRY (Don't Repeat Yourself) Principle.