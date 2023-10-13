// using System;

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// foreach (int val in times)
// {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//         time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//         time = time.Insert(0, "0:");
//     }
//     else
//     {
//         time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
// }

// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// foreach (int val in times)
// {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//         time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//         time = time.Insert(0, "0:");
//     }
//     else
//     {
//         time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
// }

// Console.WriteLine();

// void AdjustTimes() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }



// make method and call to check the valid IPV4 


// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         if (int.Parse(number) > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }


// Random random = new Random();
// int input;
// Console.WriteLine("Enter Any Random Number.");
// input = int.Parse(Console.ReadLine());
// int luck = random.Next(input);
// Console.WriteLine(luck);


// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// Console.WriteLine("A fortune teller whispers the following words:");
// string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
// for (int i= 0; i< 4; i++){
//     Console.WriteLine($"{text[i]}  {fortune[i]}");
// }

//method with parmeters: 
// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }

// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }


// to check the healty and unhealthy status.

// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(status, false);
// Console.WriteLine($"End: {status}");

// void SetHealth(string status, bool isHealthy) 
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }





string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    for(int j=0; j < 1; j++){
       
        DisplayEmail(external[i, 0], external[i, 1]);
    }
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
      for(int j=0; j < 1; j++){
       
        DisplayEmail(external[i, 0], external[i, 1], externalDomain);
    }
}

void DisplayEmail(string first, string last, string domain = "contoso.com") 
{
	string email = first.Substring(0, 2) + last;
	email = email.ToLower();
	Console.WriteLine($"{email}@{domain}");
}