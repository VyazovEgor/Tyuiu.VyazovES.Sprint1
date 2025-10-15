using Tyuiu.VyazovES.Sprint1.Task5.V6.Lib;

int x;
DataService ds = new DataService();

x = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(ds.Calculate(x));

Console.ReadLine();

