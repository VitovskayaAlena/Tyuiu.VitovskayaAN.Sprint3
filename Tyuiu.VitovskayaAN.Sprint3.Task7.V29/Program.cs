using Tyuiu.VitovskayaAN.Sprint3.Task7.V29.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление итоговых решений по спринту                            *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("Начало отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+----------+-----------+");
        Console.WriteLine("|    X     |   f(x)    |");
        Console.WriteLine("+----------+-----------+");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1, 5:f2}    |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+----------+-----------+");
        Console.ReadKey();
    }
}
