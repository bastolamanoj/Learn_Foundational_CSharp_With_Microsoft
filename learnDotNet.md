### .NET CLI (Command Line Interface) to create a new console application project in C# 

- dotnet new console -o ./CsharpProjects/TestProject
--> -o: This is a command-line option that specifies the output directory for the new project.

- dotnet new console --framework net7.0  => we can also specify specific framework of any version.

## Build and run dotnet project
- dotnet build
- dotnet run 


## String Interpolation
- string interpolation
- String interpolation allows you to embed expressions (in this case, variables) within a string literal. The       expression   inside {} curly braces is evaluated, and its value is inserted into the string at that position.
- $"Product: {size} {color} {type}"
- 

## Classes and Methods
1.  Random.Next() method -> generating random numbers using the System.Random class 
2.  Trim() -> this method used on the input value to ignore leading and training space characters.
3.  ToLower() -> change into lowercase : the input value to ignore case
4.  IndexOf() ->  It is used to find the position (index) of the first occurrence of a specified substring within a   given string. If the substring is not found, it returns -1. Here's the basic syntax:
    int index = someString.IndexOf(substring);

    string text = "Hello, World!";
    int index = text.IndexOf("World"); // index will be 7

5. Remove():     Removes a specified number of characters from a string, starting at a specified position.
                 string text = "Hello, World!";
                 string modified = text.Remove(7, 6); // "Hello!"

6. Substring():  Extracts a portion of a string based on a specified start index and optional length.

                    string text = "Hello, World!";
                    string substring = text.Substring(7, 5); // "World"
                    TrimStart(): R

##  Iterate through a code block using for statement in C#

# Example of for loop
1. for loop

    for(int num=1; num <=100; num++){
        if(num % 3 == 0 && num %5 ==0 ){
            Console.WriteLine($"{num} - FizzBuzz");
        }else if(num % 5 ==0){
            Console.WriteLine($"{num} - Buzz");
        }else if(num%3 ==0){
            Console.WriteLine($"{num} - Fizz ");
        }else{
            Console.WriteLine($"{num}");
        }
    }
2. do while loop
    Random random = new Random();
    int current = 0;

    do
    {
        current = random.Next(1, 11);
        Console.WriteLine(current);
    } while (current != 7);


# Continue Statement

- In C#, the continue statement is used within loops (like for, while, or do-while) to skip the rest of the     iteration and proceed to the next iteration. It allows you to bypass the remaining code inside the loop for the current iteration and move to the next iteration immediately.



## Work with Variable Data in C# Console Applications

1. Data Types 
-  basic data types like string, char, bool, int, and decimal
-  



## Reference Data type
- int[] data;
- The previous code defines a variable that can hold a value of type int array
- int[] data;
- data = new int[3];
- The new keyword informs .NET Runtime to create an instance of int array, and then coordinate with the operating system to store the array sized for three int values in memory. The .NET Runtime complies, and returns a memory address of the new int array. Finally, the memory address is stored in the variable data. The int array's elements default to the value 0, because that is the default value of an int.




