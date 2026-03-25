using Tyuiu.SchechkaII.Sprint1.Task0.V14.Lib;
static void Main(string[] args)
{
    // Вычисление результата
    int result = Class1.Calculate();

    // Вывод в формате, соответствующем шаблону
    Console.WriteLine("2 * 3 * 3 + 7 = {0}", result);

    // Ожидание нажатия клавиши (необязательно, но удобно)
    Console.WriteLine("\nНажмите любую клавишу для выхода...");
    Console.ReadKey();
}