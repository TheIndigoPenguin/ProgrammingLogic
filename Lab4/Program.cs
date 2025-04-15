using System.Net.NetworkInformation;

namespace Lab4;

class Program
{
    static void Main(string[] args)
    {

        //Part 1

        for (int i1 = 1; i1 < 11; i1++) 
        {

            Console.WriteLine(i1);

        }

        Console.WriteLine(); //Part 2
        
        for (int i2 = 1; i2 < 21; i2++)
        {

            if(i2 % 2 ==0){

                Console.WriteLine(i2);
            }

        }

        Console.WriteLine(); //Part 3

        int i3 = 5;
        while (i3 > 0)
        {

            Console.WriteLine(i3);
            i3--;

        }

        
        Console.WriteLine(); //Part 4

        int i4 = 0;
        do {

            Console.WriteLine("Enter a number greater than 100:");
            i4 = Convert.ToInt32(Console.ReadLine());

        }
        while(i4 <= 100);

        Console.WriteLine(); //Part 5

        int i5 = 0;
        while (i5 < 1000)
        {

            i5 = i5 + 10;
            Console.WriteLine(i5);
        
        }

        Console.WriteLine(); //Part 6

        for (int i6 = 0; i6 < 10; i6++)
        {
            for (int i6b = 0; i6b < i6; i6b++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //All done!
    }
}
