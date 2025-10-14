using Tyuiu.VyazovES.Sprint1.Task0.V18.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Вязов Е. С. | НТм-24-1";


Console.WriteLine("**************************************************************************");
Console.WriteLine("* Спринт #1                                                              *");
Console.WriteLine("* Тема: Базовые навыки работы по С#                                      *");
Console.WriteLine("* Задание #1                                                             *");
Console.WriteLine("* Вариант #18                                                            *");
Console.WriteLine("* Выполнил: Вязов Егор Сергеевич | НТм-24-1                              *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                               *");
Console.WriteLine("* Написать программу которая вычисляет выражение 9 * (6 / 2 * 3) / 9 / 3 *");
Console.WriteLine("* и печатает результат на экран.                                         *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* 9 * (6 / 2 * 3) / 9 / 3                                                *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("**************************************************************************");


Console.WriteLine(ds.Calculate());

Console.ReadLine();