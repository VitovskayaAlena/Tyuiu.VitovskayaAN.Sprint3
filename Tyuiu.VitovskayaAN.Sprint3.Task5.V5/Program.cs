using Tyuiu.VitovskayaAN.Sprint3.Task5.V5.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Значение переменной X = 5");
        Console.WriteLine("Начальный шаг1 = переменая i = 1");
        Console.WriteLine("Начальный шаг2 = переменная k = 1");
        Console.WriteLine("Конечный шаг1 = 3");
        Console.WriteLine("Конечный шаг2 = 10");


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.GetSumSumSeries(5, 1, 1, 3, 10);
        Console.WriteLine("Сумма ряда = " + res);
    }
}
