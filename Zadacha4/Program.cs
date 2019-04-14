using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static double EPSILON = 0.001;
    private static double F(double x) // метод нахождения значения точки заданной функции
    {
        return (x * x * x * x) + 0.8 * (x * x * x) - 0.4 * (x * x) - 1.4 * x - 1.2;
    }
    static void Main(string[] args)
    {      
        Console.WriteLine("Начало отрезка x0 =  -1,2 ");
        double begin = -1.2;
        Console.WriteLine("Конец отрезка x1 = -0,5");
        double end = -0.5;
        double dx = end - begin; //Оставим ту половину отрезка, для которой значения на концах имеют разные знаки.
        double mid = (begin + end) / 2; //середнина отрезка
        while (Math.Abs(F(mid)) > EPSILON)// пока не достигнем определённой точности 
        {
            dx /= 2;// этот отрезок снова делим пополам и оставляем ту его часть, на границах которой функция имеет разные знаки
            mid = begin + dx;
            if (Math.Sign(F(begin)) == Math.Sign(F(mid)))
                begin = mid;
        }

        Console.WriteLine($"Корень уравнения = {mid}");
        Console.ReadKey();
    }
}