using Tyuiu.VyazovES.Sprint1.Task2.V14.Lib;

DataService ds = new DataService();

int x;


x = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(ds.ConvertKelvinToCelsius(x));

Console.ReadLine();
