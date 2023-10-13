// /* 
// This code uses a names array and corresponding methods to display
// greeting messages
// */

// string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

// string messageText = "";

// foreach (string name in names)
// {
//     if (name == "Sophia")
//         messageText = SophiaMessage();
//     else if (name == "Andrew")
//         messageText = AndrewMessage();
//     else if (name == "AllGreetings")
//         messageText = SophiaMessage();
//         messageText = messageText + "\n\r" + AndrewMessage();

//     Console.WriteLine(messageText + "\n\r");
// }

// bool pauseCode = true;
// while (pauseCode == true);

// static string SophiaMessage()
// {
//     return "Hello, my name is Sophia.";
// }

// static string AndrewMessage()
// {
//     return "Hi, my name is Andrew. Good to meet you.";
// }


// exception halding in c#

try
{
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;
    int result = num1 + num2;
    Console.WriteLine("Result: " + result);

    string str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);

    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);

    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (OverflowException ex)
{
    Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null." + ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range." + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}

Console.WriteLine("Exiting program.");