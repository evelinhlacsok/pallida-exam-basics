# EXAM: Programming Basics

### Getting Started
 - Fork this repository under your own account
 - Clone the forked repository to your computer
 - Create a `.gitignore` file so generated files won't be committed
 - Commit your progress frequently and with descriptive commit messages
 - All your answers and solutions should go in this repository

### What can I use?
- You can use any resource online, but **please work individually**
- **Don't just copy-paste** your answers and solutions, use your own words instead.
- **Don't push your work** to GitHub until your mentor announces that the time is up


# Tasks
## 1-3. Complete the following tasks: (~90 mins)
- [Uniques Characters](uniquechars/UniqueChars.cs)
- [Favourite Animals](favouriteanimals/FavouriteAnimals.cs)
- [Candy Shop](candyshop/TakeMeToThe.cs)

### Acceptance criteria
The application is accepted if:
- The solution works according to specification [1p each]
- The solution follows [styleguide](https://github.com/greenfox-academy/teaching-materials/blob/master/styleguide/cs.mds) [1p]
- Has proper error handling where the specification says it [1p each]
- Has the correct loops, methods, filters [1p each]
- The code is clean, without unnecessary repetition, and with descriptive names [1p each]
- You commit frequently with descriptive commit messages [1p]

## 4. Question time! (~10 mins) [4p]

###  What is the difference between a function and a method? [2p]
#### Your answer:

If a function is a part of a class, it's called a method.

In C#, we do not have functions that are declared ouside of classes, that is why all functions in this language are methods. 

A method is a code block that contains a series of statements. A program causes the statements to be executed by calling the method and specifying any required method arguments. In C#, every executed instruction is performed in the context of a method. The Main method is the entry point for every C# application, that is the part, when the program is started.

### What is the constructor? When it is used? [2p]
#### Your answer:
When a class or struct is created, its constructor is called. 
The constructor is a special method of a class, that let's us to instantiate that class. They have the same name as the class or the struct. 
Every class has a default constructor, but we can create more specific ones, that takes in parameters.
Constructors have the same name as the class or struct and they usually initialize the data members of the new object.
