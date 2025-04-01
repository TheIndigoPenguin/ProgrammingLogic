namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        int henry = 7;
        double harry = 8.96;
        float humphrey = 4;
        char helga = 'h';
        string haley = "hey there!";

        Console.WriteLine(henry);
        Console.WriteLine(harry);
        Console.WriteLine(humphrey);
        Console.WriteLine(helga);
        Console.WriteLine(haley);

        Console.WriteLine(); //For spacing! Part 2 down below.

        double harold = 9.78;
        Console.WriteLine("Double: " + harold);

        int harild = (int) harold;
        Console.WriteLine("Double to Int: " + harild);

        Console.WriteLine("Int: " + henry);
        Convert.ToString(henry);
        Console.WriteLine("Int to String: " + henry);

        bool horace = true;
        Console.WriteLine("Bool: " + horace);
        Convert.ToString(horace);
        Console.WriteLine("Bool to String: " + horace);

        Console.WriteLine(); //More spacing! Onto part 3

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello " + name + "! If my programming is correct, you are " + age + " years old!");

        Console.WriteLine(); //Part 4 time!

        int num1 = 8;
        int num2 = 11;
        Console.WriteLine("8 + 10: " + (num1 + 10));
        Console.WriteLine("8 - 2: " + (num1 - 2));
        Console.WriteLine("8 * 3: " + (num1 * 3));
        Console.WriteLine("8 / 2: " + (num1 / 2));
        Console.WriteLine("8 % 2: " + (num1 % 2));
        Console.WriteLine("11 + 10: " + (num2 + 10));
        Console.WriteLine("11 - 2: " + (num2 - 2));
        Console.WriteLine("11 * 3: " + (num2 * 3));
        Console.WriteLine("11 / 2: " + (num2 / 2));
        Console.WriteLine("11 % 2: " + (num2 % 2));
        
        Console.WriteLine(); //Part 5!

        float hudson = 1.123456789F;
        double huey = 1.123456789D;
        Console.WriteLine(hudson);
        Console.WriteLine(huey);

        Console.WriteLine(); //Grand finale!

        int hank = 10;

        Console.WriteLine("Int: " + hank);
        hank++;
        Console.WriteLine("Int + Incriment: " + hank);
        hank--;
        hank--;
        Console.WriteLine("Int + Decrement: " + hank);

        //End of assignment


    }
}
