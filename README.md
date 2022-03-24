class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter the first number: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Enter the second number: ");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Enter the third number: ");
    double c = double.Parse(Console.ReadLine());
    Console.Write("Enter the four number: ");
    double d = double.Parse(Console.ReadLine());
    double average = (a + b + c + d) / 4;
    Console.WriteLine($"The average of  {a}, {b}, {c}, {d} is: {average}");
  }
}
