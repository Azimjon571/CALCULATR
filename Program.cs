using Calculate.Classes;    
System.Console.Write("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter operation(+, -, *, /, %");
string operation = Console.ReadLine();
System.Console.Write("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Ternar operator

Calculated calculate = new Calculated(firstNumber,secondNumber,operation);
calculate.PositiveOrNegetive(firstNumber);
calculate.CompareNumbers(firstNumber, secondNumber);
calculate.calculateNumbers(firstNumber,secondNumber);
calculate.CalculateTimeToTime(firstNumber);
