/// <summary>
/// In The Works : Indexers and indexer overloading
/// 
/// I cannot get the length of car instance unless I declare it static
/// But being static, cannot create new instance for new values
/// </summary> 
class Program
    {
    static void Main()
        {
        Car car1 = new Car();
        int numCars = car1.Length;
        System.Console.WriteLine("There are " + numCars + " cars in inventory:");
        System.Console.WriteLine();

        for (int i = 0; i < numCars; i++)
        {
            System.Console.WriteLine(car1[i]);
        }

        System.Console.WriteLine("\nThere are " + numCars + " cars in inventory:");
        System.Console.WriteLine();
        car1[3] = "Renault";

        for (int i = 0; i < numCars; i++)
        {
            System.Console.WriteLine(car1[i]);
        }


        Car car2 = new Car();
        int numCars2 = car2.Length;
        System.Console.WriteLine("\nThere are " + numCars + " cars in inventory listed using indexer overloading:");
        System.Console.WriteLine();

        System.Console.WriteLine(car2["first"]);
        System.Console.WriteLine(car2["second"]);
        System.Console.WriteLine(car2["third"]);
        System.Console.WriteLine(car2["fourth"]);

        System.Console.WriteLine("\nEnter any key to end the program.");
        System.Console.ReadKey();

    }
}

