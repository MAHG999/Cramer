using System;

namespace Cramer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables de ecuacion 1
            double a = 0;
            double b = 0;
            double e = 0;
            //Variables de ecuacion 2 
            double c = 0;
            double d = 0;
            double f = 0;
            //Valor der entrada
            string Valor = "";
            //Valores de salida o resultados
            double x = 0;
            double y = 0;
            //que es lo que realiza este sistema
            Console.WriteLine("ax+by=e");
            Console.WriteLine("cx+dy=f");

            //Obtencion de valores
            Console.WriteLine("Dame el valor de A:");
            Valor = Console.ReadLine();
            a = Convert.ToDouble(Valor);
            Valor = "";

            Console.WriteLine("Dame el valor de B:");
            Valor = Console.ReadLine();
            b = Convert.ToDouble(Valor);
            Valor = "";

            Console.WriteLine("Dame el valor de C:");
            Valor = Console.ReadLine();
            e = Convert.ToDouble(Valor);
            Valor = "";


            Console.WriteLine("Dame el valor de C:");
            Valor = Console.ReadLine();
            c = Convert.ToDouble(Valor);
            Valor = "";

            Console.WriteLine("Dame el valor de D:");
            Valor = Console.ReadLine();
            d = Convert.ToDouble(Valor);
            Valor = "";

            Console.WriteLine("Dame el valor de F:");
            Valor = Console.ReadLine();
            f = Convert.ToDouble(Valor);
            Valor = "";
            //realñiozacion de las ecuaciones / optención de los valores de x & y
            x = (e * d - b * f) / (a * d - b * c); 
            y = (a * f - e * c) / (a * d - b * c);
            //imprecion de los valores de x& y
            Console.WriteLine("El valor de X=" + x);
            Console.WriteLine("El valor de Y=" + y);

            Console.ReadKey();

        }
    }
}
