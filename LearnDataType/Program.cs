// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}"); 
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}"); 
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}"); 

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


// int[] data = new int[3];
// data[0]= 10;
//  Console.WriteLine(data[0]);

// int[] data;
// Console.WriteLine(data[0]);


//Write code that attempts to add an int and a string and save the result in an int

// int first = 2;
// string second = "4";
// int result = first + second; // error : error CS0029: Cannot implicitly convert type 'string' to 'int'
// Console.WriteLine(result);

// int first = 2;
// string second = "4";
// string result = first + second; // implicit type casting 
// Console.WriteLine(result);


// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// int: 3
// decimal: 3

//perfrom a cast
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");


// int cost = (int)3.75m;
// int cost1 = Convert.ToInt32(3.75m);
// Console.WriteLine(cost);
// Console.WriteLine(cost1);


///use TryParse()
//   string value = "102.2222";
//         decimal result = 0;
//         if (decimal.TryParse(value, out result))
//         {
//             Console.WriteLine($"Measurement: {result}");
//         }
//         else
//         {
//             Console.WriteLine("Unable to report the measurement.");
//         }






string input = "some-text=with_underscores";
char[] charsToFind = { '-', '=', '_' };

int nextIndex = input.IndexOfAny(charsToFind);

if (nextIndex != -1)
{
    Console.WriteLine("Found character at index: " + nextIndex);
}
else
{
    Console.WriteLine("None of the characters were found.");
}







