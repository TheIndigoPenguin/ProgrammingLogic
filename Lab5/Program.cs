namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        //Part 1

        string[] seasons = {"Spring", "Summer", "Autumn", "Winter"};
        foreach (string i in seasons)
        {
            Console.WriteLine("Season: " + i);
        }

        Console.WriteLine();
        //Part 2
        
        string[] daysofweek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        
        Console.WriteLine("Enter a number 1-7: ");
        int j = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The day is " + daysofweek[j] + "!");

        
        Console.WriteLine();
        //Part 3

        string[] books = {"Dracula", "The Great Gatsby", "The Scarlet Letter"};
        string[] authors = {"Bram Stoker", "F. Scott Fitzgerald", "Nathaniel Hawthorne"};
        
        for (int k = 0; k < books.Length; k++)
        {   
            Console.WriteLine("Book " + (k+1) + ": " + books[k] + " by " + authors[k]);

        }

        Console.WriteLine();
        //Part 4

        int[] temperature = { 65, 72, 78, 70, 68 };
        Array.Sort(temperature);

        Console.WriteLine("Sorted Temperatures: ");
        foreach (int t in temperature)
        {
            Console.Write(t + ", ");
        }
    
        Console.WriteLine();
        Console.WriteLine("Highest Temperature: " + temperature.Max()); 
        Console.WriteLine("Lowest Temperature: " + temperature.Min());

        Console.WriteLine();
        //Part 5

        int[] countdown = {5, 4, 3 , 2, 1};
        Array.Reverse(countdown);

        Console.WriteLine("Countdown: ");
        for (int u = 0; u < countdown.Length; u++)
        {
            Console.WriteLine(countdown[u]);
        }
    }
}
