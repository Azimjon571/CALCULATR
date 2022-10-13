namespace Calculate.Classes
{
    class Calculated
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }
        public Calculated(int firstNumber, int secondNumber, string operation )
        {
            firstNumber=FirstNumber;
            secondNumber=SecondNumber;
            Operation=operation;
        }
        public void PositiveOrNegetive(int firstNumber)
        {
            string message = 
                 firstNumber >= 0 
                    ? "First numbeer is positive" 
                    : "First number is negative";

            Console.WriteLine(message);

        }

        public void CompareNumbers(int firstNumber, int secondNumber)
        {
            if(firstNumber>secondNumber)
            {
                Console.WriteLine("1st number greater than 2nd number");
            }
            else if(firstNumber<secondNumber)
            {
                Console.WriteLine("2nd number greater than 1st number");
            }
            else
            {
                Console.WriteLine("1st number equal to the 2nd number");
            }
        }

        public void calculateNumbers(int firstNumber, int secondNumber)
        {
            string result = Operation switch
                {
                    "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
                    "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
                    "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
                    "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
                    "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
                    _  => "Operation not Found!"
                };
            Console.WriteLine(result);
        }
        public void CalculateTimeToTime(int firstNumber)
        {
            for(int i = 1; i<=10; i++)
                {
                    Console.WriteLine($"{firstNumber}x{i}={firstNumber*i}");
                }
        }
    }
}