using Tyuiu.SchechkaII.Sprint1.Task1.V16.Lib;

static void Main(string[] args)
{
    Console.WriteLine("Вычисление выражения: x * 5 * a + 2 * y\n");

    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Введите a: ");
    double a = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Введите y: ");
    double y = double.Parse(Console.ReadLine() ?? "0");

    var calculator = new DataService();
    double result = calculator.Calculate(x, a, y);

    Console.WriteLine($"\nРезультат: {result}");

    Console.WriteLine("\nНажмите любую клавишу для выхода...");
    Console.ReadKey();
}
    