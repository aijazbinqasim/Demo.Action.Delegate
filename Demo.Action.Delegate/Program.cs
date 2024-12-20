namespace Demo.Action.Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> action = A.Add;
            action(100, 300);

            Action<string, string> action2 = A.Concat;
            action2("Hello", "World");

            Action<int> square = delegate (int x)
            {
                Console.WriteLine(x * x);
            };
            square(5);

            // write action using lambda expression
            Action<int> cube = x => Console.WriteLine(x * x * x);
            cube(5);
        }
    }

    public class A
    {
        public static void Add(int a, int b) => Console.WriteLine(a + b);
        public static void Concat(string a, string b) => Console.WriteLine($"{a} - {b}");
    }
}