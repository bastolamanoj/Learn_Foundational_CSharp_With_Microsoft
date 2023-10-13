###  Methods in C# Console Applications

1. create method in C#
    To create the method signature, you declare the return type, method name, and parameters. Create the method body by using brackets {} that contain the code.
    eg: 
      i> Void DisplayRandomNumbers();  //method declaration
      
      ii> Method Definition  
       void DisplayRandomNumbers() 
        {
            Random random = new Random();
        }

        iii> call the method
        - DisplayRandomNumbers();



### Methods 
1. Insert(): is used to create a new string by inserting a specified substring or character at a specified position within the original string
    syntax:  string newString = originalString.Insert(index, value);
    e.g.
    string text = "Hello, World!";
    string newText = text.Insert(5, "Amazing "); // "Hello Amazing , World!"
    string insertedComma = text.Insert(5, ",");    // "Hello, World!"

2. Math.Abs(): 
              is a method used to calculate the absolute value of a numeric expression.
              The absolute value of a number is its distance from zero on the number line, irrespective of whether it's positive or negative. Here's the basic syntax of the Math.Abs method

              double absoluteValue = Math.Abs(value);

              value: The numeric expression (integer, floating-point, etc.) for which you want to calculate the absolute value.

              Examples:

                int num1 = -5;
                double num2 = -7.5;
                int abs1 = Math.Abs(num1);    // Result: 5
                double abs2 = Math.Abs(num2); // Result: 7.5


### types of methods/functions:
# Parameterized Functions:
1. Function with Parameters:
 - A standalone function that accepts one or more input parameters.

    Example:
    int Add(int a, int b)
    {
        return a + b;
    }

    int result = Add(3, 4);

2. Function with Multiple Parameters:
 - A standalone function that accepts multiple parameters of different data types.

   Example:
   double CalculateAverage(int[] numbers)
    {
        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum / numbers.Length;
    }

    double average = CalculateAverage(new int[] { 5, 10, 15 });

3. Function with default parameters:
    - Default parameters allow you to specify a default value for a function parameter so that if the caller doesn't provide a value for that parameter, the default value is used. This is useful when you want to make a function more flexible by allowing some parameters to be optional.

    public void ExampleFunction(int a, int b = 10, string message = "Hello")
    {
        Console.WriteLine($"a = {a}, b = {b}, message = {message}");
    }

    ExampleFunction(5);               // a = 5, b = 10, message = "Hello"
    ExampleFunction(5, 15);           // a = 5, b = 15, message = "Hello"
    ExampleFunction(5, 15, "Hi");     // a = 5, b = 15, message = "Hi"



## Non-Parameterized Functions:
1. Function without Parameters:
    - A standalone function that doesn't require any input parameters.
        Example:
        void Greet()
        {
            Console.WriteLine("Hello, World!");
        }

        Greet();

2. Getter and Setter Functions:
    - Functions used to get or set the value of a variable or property.

    Example:
    private string name;

    string GetName()
    {
        return name;
    }

    void SetName(string newName)
    {
        name = newName;
    }

    SetName("Alice");
    string name = GetName(); // Retrieves the name



## QSN
1. Which of the following options correctly returns a string value?

    return "";


    return 'a';


    return 5;