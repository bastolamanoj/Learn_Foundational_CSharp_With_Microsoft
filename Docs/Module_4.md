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
            -











