namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal("Pesho");

            System.Console.WriteLine(animal.Name);
        }
    }
}