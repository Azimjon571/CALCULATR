﻿System.Console.Write("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber>secondNumber)
{
    System.Console.WriteLine("1st number greater than 2nd number");
}
else if(firstNumber<secondNumber)
{
    System.Console.WriteLine("2nd number greater than 1st number");
}
else if (firstNumber==secondNumber)
{
    System.Console.WriteLine("1st number equal to the 2nd number");
}