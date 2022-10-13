namespace Calculate.Classes
{
    class Calculated
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }
        public void GetInputs()
        {
            System.Console.Write("Type 1st number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation(+, -, *, /, %");
            Operation = Console.ReadLine();
            Console.Write("Type 2nd number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }
        public void PositiveOrNegetive()
        {
            string message = 
                 FirstNumber >= 0 
                    ? "First number is positive" 
                    : "First number is negative";

            Console.WriteLine(message);

        }

        public void CompareNumbers()
        {
            if(FirstNumber>SecondNumber)
            {
                Console.WriteLine("1st number greater than 2nd number");
            }
            else if(FirstNumber<SecondNumber)
            {
                Console.WriteLine("2nd number greater than 1st number");
            }
            else
            {
                Console.WriteLine("1st number equal to the 2nd number");
            }
        }

        public void calculateNumbers()
        {
            string result = Operation switch
                {
                    "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                    "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                    "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                    "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                    "%" => $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}",
                    _  => "Operation not Found!"
                };
            Console.WriteLine(result);
        }
        public void CalculateTimeToTime()
        {
            for(int i = 1; i<=10; i++)
                {
                    Console.WriteLine($"{FirstNumber}x{i}={FirstNumber*i}");
                }
        }
    }
}