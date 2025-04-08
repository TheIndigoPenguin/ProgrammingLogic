namespace Lab3;

class Program
{
    static void Main(string[] args)
    {

        //Part 1

        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < c: " + (a < c));
        Console.WriteLine("a > b && a > c: " + (a > b && a > c));
        Console.WriteLine("a > b || a > c: " + (a > b || a > c));

        Console.WriteLine("");
        // Part 2

        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining != haveUmbrella) {

            Console.WriteLine("Take an umbrella!");

        }

        else {

            Console.WriteLine("You're good to go!");

        }

        Console.WriteLine("");
        //Part 3

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 5) {

            Console.WriteLine("Ticket is free!");

        }

        else if ((age >= 5) && (age <= 12 )) {

            Console.WriteLine("Child Ticket: $5");

        }

        else if ((age >= 13) && (age <= 64 )) {

            Console.WriteLine("Standard Ticket: $10");

        }

        else {

            Console.WriteLine("Senior Ticket: $6");

        }

        Console.WriteLine("");
        //Part 4

        Console.WriteLine("Enter Day of the Week 1-7:");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day) 
        {
            case 1:
                Console.WriteLine("Day 1 is Monday!");
                break;

            case 2:
                Console.WriteLine("Day 2 is Tuesday!");
                break;

            case 3:
                Console.WriteLine("Day 3 is Wednesday!");
                break;

            case 4:
                Console.WriteLine("Day 4 Thursday!");
                break;

            case 5:
                Console.WriteLine("Day 5 is Friday!");
                break;

            case 6:
                Console.WriteLine("Day 6 is Saturday!");
                break;

            case 7:
                Console.WriteLine("Day 7 is Sunday!");
                break;
            
            default:
                Console.WriteLine("Invalid day!");
                break;
        }

        //End of Lab!
    }
}
