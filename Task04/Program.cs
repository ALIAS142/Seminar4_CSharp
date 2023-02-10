// Задача 28: Напишите программу, которая принимает на вход число (А) и выдаёт произведение чисел от 1 до А.

System.Console.Write("Enter number N: ");
int numberN = int.Parse(Console.ReadLine());

if (numberN < 1)
{
    System.Console.WriteLine("Number is less then 1");
}
else
{
    int result = GetMultip(numberN);
    System.Console.WriteLine($"multi =  {result}");
    System.Console.WriteLine($"multi =  {GetMultip(numberN)}");
}


int GetMultip(int number)
{
    int multi = 1;

    for (int i = 1; i <= number; i++)

    {
        multi = multi*i;
    }

    return multi;
}