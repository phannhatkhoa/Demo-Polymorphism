namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Cat("Meowmeow", "Fish");
            Animals dog = new Dog("Kiki", "Meat");
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}