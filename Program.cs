namespace Greenville_Idol;

class Program
{
    static void Main(string[] args)
    {
        for (; ; )
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");
            Console.WriteLine("");
            Console.WriteLine("Please Enter the following number below from the following menu:");
            Console.WriteLine("");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                string previous = Console.ReadLine();
                string[] split1 = previous.Split(" ");
                int previous_year = Convert.ToInt32(split1[0]);
                string current = Console.ReadLine();
                string[] split2 = current.Split(" ");
                int current_year = Convert.ToInt32(split2[0]);
                Console.WriteLine("Last year's competition had " + previous_year + " contestants, and this year's has " + current_year + " contestants");
                Console.Write("Revenue expected this year is ");
                int revenue = current_year * 25;
                Console.WriteLine(revenue.ToString("C0"));
                if (previous_year < current_year)
                {
                    Console.WriteLine("It is true that this year's competition is bigger than last year's.");
                }
                else
                {
                    Console.WriteLine("It is false that this year's competition is bigger than last year's.");
                }

            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
    }
}
