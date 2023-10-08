### Work with Variable Data in C# Console Applications

## When in doubt, stick with the basics
    While you've looked at several considerations, as you're getting started, for simplicity's sake you should prefer a subset of basic data types, including:

    - int for most whole numbers
    - decimal for numbers representing money
    - bool for true or false values
    - string for alphanumeric value

## Choose specialty complex types for special situations
    Don't reinvent data types if one or more data type already exists for a given purpose. The following examples identify where a specific .NET data types can be useful:

    - byte: working with encoded data that comes from other computer systems or using different character sets.
    - double: working with geometric or scientific purposes. double is used frequently when building games          involving motion.
    - System.DateTime for a specific date and time value.
    - System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.



## Questions:
1. What variable type is created if the new operator is used to create a variable? 
 -  value
 -  reference --> correct
 -  integer type 

1. A piece of code must store whole numeric values between negative and positive 1,000,000. Which data type should you choose? 

    - float

    - double

    - int (correct)

2. The code for a game needs to store lots of fractional values representing x, y, and z positions in a large 3D space. It will likely need to perform physics calculations for trajectories and so on. Absolute precision isn't required, but it's important that the program runs as efficiently as possible. Which data type is best? 

    - float (correct) : Correct. Unlike int, float can store fractional numbers, and unlike decimal, float doesn't require extra memory to store extra precision that isn't needed in this scenario.

    - decimal

    - int
3. Which of the following statements is true? 

    - Reference types are stored in the stack.

    - Value types can only store numbers.

    - Use the new operator to create a new instance of a reference type and return its address to the variable.  (correct)



### Convert data types using casting and conversion techniques in C#

##  data type casting and conversion

# In C#, there are two primary types of type conversion:

1. Implicit Type Conversion: (Widening Conversion)
    This conversion is done automatically by the compiler when there is no loss of data, such as converting from smaller data types (e.g., int) to larger data types (e.g., double).

2. Explicit Type Conversion (Casting): (Narrowing  Conversion)
    - This conversion requires a programmer's intervention and is performed explicitly using casting operators like (type) or conversion methods. It's used when there may be data loss or when converting between unrelated types
    - Use the () cast operator and the data type to perform a cast (for example, (int)myDecimal)


# Use TryParse()
--> Use TryParse()
    The TryParse() method does several things simultaneously:

    - It attempts to parse a string into the given numeric data type.
    - If successful, it stores the converted value in an out parameter.
    - It returns a bool to indicate whether the action succeeded or failed.


    eg. 
        string value = "102";
        int result = 0;
        if (int.TryParse(value, out result))
        {
            //this block of code only execute if the above if statement return true
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }

         Tips: -   The int.TryParse() method returns true if it successfully converted the string variable value into an int; otherwise, it returns false. So, surround the statement in an if statement, and then perform the decision logic, accordingly.


## Qsn 
1. Which technique should be used to change myInput, a string value "2.71828", into a decimal variable myInputDecimal? 

   - decimal myInputDecimal = (decimal)(myInput);

   - decimal myInputDecimal = myInput + 0;

   - decimal.TryParse(myInput, out myInputDecimal) --> (Correct. Using TryParse (or Parse()) is a valid technique)

2. Which best describes the return type of decimal.TryParse()? 

    - decimal

    - bool  (correct)

    - out

3. What method should be used to search for the first occurrence of a search term in a long string? 

IndexOfAny() ==> Correct. IndexOfAny() returns the first position of an array of char that occurs inside of another string.

LastIndexOf() 

Substring()


# methods
1. PadLeft()
    eg. Console.WriteLine("C110".PadLeft(6, '0'));
    - .PadLeft(6, '0') is called on the input string. 
    - This method pads the input string on the left with the specified character ('0' in this case) to reach the specified total length (6 in this case).

2. IndexOfAny(): 
    Finds the index of the first occurrence of any character in a specified array of characters within a string.

     Example: string input = "abc-123_";
      int index = input.IndexOfAny(new char[] { '-', '_' }); // Returns the index of '-' as it's the first character found.

3. Remove(): Removes a specified number of characters from a string, starting at a specified position.
        -  Example: string text = "Hello, world!"; 
           string result = text.Remove(5, 7); // Removes characters starting from index 5 to 5+7=12.



4. IndexOf(): Finds the index of the first occurrence of a specified character or substring within a string
              - Example: string sentence = "The quick brown fox"; 
                        int index = sentence.IndexOf("brown"); // Returns the index of the start of "brown".

5.  String.Trim() :
            -  is a method in C# used to remove leading and trailing whitespace (spaces, tabs, newline characters) from a string
            -  string text = "   Hello, world!   ";
              string trimmedText = text.Trim(); // Result: "Hello, world!"
6. Substring() : method is used to extract a portion of a string

7. LastIndexOf() : returns the last position of a character or string inside of another string.

8. Replace(): method is used to create a new string in which all occurrences of a specified substring or character in the original string are replaced with another specified substring or character.

syntax: string newString = originalString.Replace(oldValue, newValue);
 examples: 
 string text = "Hello, World!";
string newText = text.Replace("Hello", "Hi"); // "Hi, World!"
string removedCommas = text.Replace(",", "");   // "Hello World!"


### Perform operations on arrays using helper methods in C#
# Methods:
1. Sort() : to manipulate the order based on the given data type of the array. It is the method of array.
2. Reverse() : to flip the order of the elements in the array   
3. Clear() : The Array.Clear() method allows you to remove the contents of specific elements in your array,
            - The Array.Clear method is used to set a range of elements in an array to their default values (i.e.,  null for reference types or zero for numeric types).
             eg: 
             string[] pallets = { "B14", "A11", "B12", "A13" };

                // The original array is: ["B14", "A11", "B12", "A13"]

                Array.Clear(pallets, 0, 2);

                // After Array.Clear, the array becomes: [null, null, "B12", "A13"]


4. Resize() : The Array.Resize() method adds or removes elements from your array.
             - Use the Resize() method to change the number of elements in the array, removing or adding elements  from the end of the array

### Format alphanumeric data for presentation in C#





###  Discover padding and alignment
1. string.Format() method is used to perform composite formatting
2. Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
3. Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
4. Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
5. Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
6. Methods that turn a string into an array of strings or characters (Split(), ToCharArray())




## QSN
1. Given string myWords = "Learning C#", what is the best output description for Console.WriteLine(myWords.PadLeft(12));? 

   - One space is added to the start of the string.
    Correct. myWords is 11 characters long, adding on space completes the padding to 12.


    - Four spaces are added to the start of the string.

    - 12 spaces are added to the start of the string.
    Incorrect. myWords is 11 characters long, with 12 spaces added the padding goes to 23.

1. For the C# code Console.WriteLine("C110".PadLeft(6, '0'));, which is the expected output? 

     - C11000

     - C110000000

     - 00C110
2. Which format specifier presents a decimal value with the following format to an en-US audience: 12,345.67 

    - 0:C

    - 0:H

    - 0:N2 (correct)
3. Which character must be used as a directive to perform string interpolation? 

    - $

    - @

    - %









