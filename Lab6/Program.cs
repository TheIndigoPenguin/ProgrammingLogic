namespace Lab6;

using System;

class Car
{
  public string model;
  public string color;
  public int year;

  // Example method to display car details. You can use this as an example for the other methods.
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }

  public void Start()
  {

    Console.WriteLine("The car is starting.");

  }

  public void Drive(int miles)
  {

    Console.WriteLine("The car drove " + miles + " miles.");

  }

  public string GetDescription()
  {

    return year + " " + color + " " + model;

  }

  public void Repaint(string color)
  {

    Console.WriteLine("The car has been repainted to " + color);

  }
}

class Program
{
  static void Main()
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display(); // Calling the Display method
    myCar.Start();
    myCar.Drive(50);

    string description1 = myCar.GetDescription();
    Console.WriteLine(description1);

    myCar.Repaint("red");


  }
}