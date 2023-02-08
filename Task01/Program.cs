// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

System.Console.Write("Enter number A :");
int numA = int.Parse(Console.ReadLine());

if (numA < 1)
{
    System.Console.WriteLine("Number is less then 1");
}

else{
    int sum = 0;
    for (int numB = 1; numB <= numA; numB++)
{
    sum+= numB;
}
System.Console.WriteLine(sum);
}


int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= numA; i++)
{
    sum+= i;
}
return sum;
}


    
