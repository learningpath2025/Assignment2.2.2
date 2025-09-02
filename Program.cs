namespace Assignment2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Adding two integers, Result:  {SimpleMath.Add(4, 5)}");
            Console.WriteLine($"Adding three decimals, Result:  {SimpleMath.Add(4.5m, 5.5m, 6.5m)}");
            Console.WriteLine($"Subtracting two integers, Result:  {SimpleMath.Subtract(10, 5)}");
            Console.WriteLine($"Subtracting two decimals, Result:  {SimpleMath.Subtract(10.5m, 5.5m)}");
            Console.WriteLine($"Multiplying two integers, Result:  {SimpleMath.Multiply(4, 5)}");
            Console.WriteLine($"Multiplying two floats, Result:  {SimpleMath.Multiply(4.5f, 5.5f)}");
            Console.WriteLine($"Multiplying three floats, Result:  {SimpleMath.Multiply(4.5f, 5.5f, 6.5f)}");
            Console.WriteLine($"Dividing two integers, Result:  {SimpleMath.Divide(10, 5)}");
        }
    }
}
