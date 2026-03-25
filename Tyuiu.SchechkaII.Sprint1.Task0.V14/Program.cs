using Tyuiu.SchechkaII.Sprint1.Task0.V14.Lib;
static void Main(string[] args)
{
    int result = DataService.Calculate();


    Console.WriteLine("2 * 3 * 3 + 7 = {0}", result);


    Console.WriteLine("\nНажмите любую клавишу для выхода...");
    Console.ReadKey();
}
