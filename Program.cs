namespace Part1_Task2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine("Hello there !");

            // a sample set of numbers
            int[] numbers = { 10, 24, 33, 44, 55, 66, 67, 95, 102, 111, 125, 144, 155 };

            // this array will store the count of numbers in each pin group
            int[] pin_counts = new int[9];

            // putting each number into its own pin group
            foreach (int number in numbers)
            {
                int pin = Find_Pin_Group(number);
                if (pin >= 1 && pin <= 9)
                {
                    pin_counts[pin - 1]++;
                }
            }

            // printting histogram
            for (int i = 0; i < pin_counts.Length; i++)
            {
                Console.WriteLine($"Pin {i + 1}: {new string('#', pin_counts[i])}");
            }
        }

        // this function will determine the pin group based on the number
        static int Find_Pin_Group(int number)
        {
            switch (number)
            {
                case int n when (n >= 10 && n <= 29): 
                    return 1;
                case int n when (n >= 30 && n <= 49): 
                    return 2;
                case int n when (n >= 50 && n <= 69): 
                    return 3;
                case int n when (n >= 70 && n <= 89): 
                    return 4;
                case int n when (n >= 90 && n <= 109): 
                    return 5;
                case int n when (n >= 110 && n <= 129): 
                    return 6;
                case int n when (n >= 130 && n <= 149): 
                    return 7;
                case int n when (n >= 150 && n <= 169): 
                    return 8;
                case int n when (n >= 170 && n <= 190): 
                    return 9;
                // If the number is less than 10 or greater than 190 then the default is 0
                default:
                    return 0; 
            }
        }
    }
    
}
