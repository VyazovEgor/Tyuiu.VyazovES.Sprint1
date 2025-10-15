using Tyuiu.VyazovES.Sprint1.Task4.V29.Lib;

double x, y;
DataService ds = new DataService();

x = Convert.ToDouble(Console.ReadLine());

y = Convert.ToDouble(Console.ReadLine());


Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();

