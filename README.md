class Program
{
  static void Main(string[] args)
  {
    Console.Write("Input first integer: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Input second integer: ");
    int y = int.Parse(Console.ReadLine());
    bool test = (y < 0 && x >= 0) || (x < 0 && y >= 0);

    Console.WriteLine($"Check if one is negative and one is positive: {test}");
  }
}
