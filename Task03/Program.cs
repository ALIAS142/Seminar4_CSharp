// Программа принимает на вход число и выдает количество цифр в нем (456 -> 3).

Console.WriteLine("Enter number:  ");
int numA = int.Parse(Console.ReadLine());


if (numA == 0 & numA <= 9)
{
    Console.WriteLine($"Number contains 1 digit");
}

if (numA >= 10 & numA <= 99)
{
    Console.WriteLine($"Number contains 2 digits");
}

if (numA >= 100 & numA <= 999)
{
    Console.WriteLine($"Number contains 3 digits");
}

if (numA >= 1000 & numA <= 9999)
{
    Console.WriteLine($"Number contains 4 digits");
}

if (numA >= 10000 & numA <= 99999)
{
    Console.WriteLine($"Number contains 5 digits");
}


else 
if (numA > 100000) 
    {
    Console.WriteLine($"Number contains more then 5 digits");
    }





// Console.WriteLine("Enter number:   ");
// string strnumberA = Console.ReadLine();
// int numberA = Convert.ToInt32(strnumberA);

// if (numberA > 9 & numberA < 99)
// {
//     Console.WriteLine("number is absent");
// }

// else
// if (numberA > 99 & numberA < 999)
// {
//     int result = numberA%10;
//     Console.WriteLine(result);
// }