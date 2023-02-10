System.Console.Write("Enter number A :");
int Number = int.Parse(Console.ReadLine());

if (Number <= 0)
{
    System.Console.WriteLine("Error");
}

else{
System.Console.WriteLine($"countNumbers = {countNumbers(Number)}");
}

int countNumbers(int Num)
{
    int count = 0;
    for(; Num > 0; count++)
    {
        Num = Num/10;
    }
    return count;

}