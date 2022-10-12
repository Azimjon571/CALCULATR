System.Console.Write("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter operation(+, -, *, /, %");
string operation = Console.ReadLine();
System.Console.Write("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Ternar operator

string message = 
    firstNumber >= 0 
        ? "First numbeer is positive" 
        : "First number is negative";

System.Console.WriteLine(message);

if(firstNumber>secondNumber)
{
    System.Console.WriteLine("1st number greater than 2nd number");
}
else if(firstNumber<secondNumber)
{
    System.Console.WriteLine("2nd number greater than 1st number");
}
else
{
    System.Console.WriteLine("1st number equal to the 2nd number");
}

string result = operation switch
{
    "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
    "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
    "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
    "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
    "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
    _  => "Operation not Found!"
};
System.Console.WriteLine(result);

for(int i = 1; i<=10; i++)
{
    System.Console.WriteLine($"{firstNumber}x{i}={firstNumber*i}");
}