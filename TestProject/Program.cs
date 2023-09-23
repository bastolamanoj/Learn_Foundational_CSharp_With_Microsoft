Random random = new Random();
int current = 0;
int testvar =1;
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);