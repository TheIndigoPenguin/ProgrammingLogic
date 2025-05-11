namespace Lab8;

class Animal
{

    public virtual void animalSound()
    {

        Console.WriteLine("The animal makes a sound.");

    }

}

class Cat : Animal
{

    public override void animalSound()
    {

        Console.WriteLine("Meow!");

    }

}

class Dog : Animal
{

    public override void animalSound()
    {

        Console.WriteLine("Bow Wow!");

    }

}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();

        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();

    }
}
