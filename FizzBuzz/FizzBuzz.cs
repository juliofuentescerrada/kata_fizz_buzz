namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public static string CalculateValue(int i)
        {
            return i switch
            {
                var fizzbuzz when fizzbuzz % 3 == 0 && fizzbuzz % 5 == 0 => "fizzbuzz",
                var fizz when fizz % 3 == 0 => "fizz",
                var buzz when buzz % 5 == 0 => "buzz",
                _ => i.ToString(),
            };
        }

        public static void Run(Action<string> write)
        {
            for (int i = 1; i <= 100; i++)
            {
                var value = CalculateValue(i);
                write(value);
            }
        }
    }
}