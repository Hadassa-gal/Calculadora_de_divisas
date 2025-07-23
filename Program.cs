using System.Globalization;
using Calculadora_de_divisas;

internal class Program
{
    private static void Main(string[] args)
    {
        Mensajes.Saludar();
        byte op2 = 0;
        decimal money = 0;
        do
        {
            Console.Write("ingrese el tipo de moneda a cambiar:\n1) Dolar estadounidence\n2) Euro\n3) Yenes\n4)salir\n");
            byte op = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            if (op > 0 && op < 5)
            {
                switch (op)
                {
                    case 1:
                        Console.Write("ingrese a que tipo de moneda quiere cambiar:\n1) Euro\n2) Yenes\n");
                        op2 = Convert.ToByte(Console.ReadLine());
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("ingrese el valor a convertir:");
                        money = Convert.ToDecimal(Console.ReadLine());
                        Monedas.Moneda_us(op2, money);
                        continue;
                    case 2:
                        Console.Write("ingrese a que tipo de moneda quiere cambiar:\n1) Dolar\n2) Yenes\n");
                        op2 = Convert.ToByte(Console.ReadLine());
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("ingrese el valor a convertir:");
                        money = Convert.ToDecimal(Console.ReadLine());
                        Monedas.Moneda_euro(op2, money);
                        continue;
                    case 3:
                        Console.Write("ingrese a que tipo de moneda quiere cambiar:\n1) Dolar\n2) Euro\n");
                        op2 = Convert.ToByte(Console.ReadLine());
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("ingrese el valor a convertir:");
                        money = Convert.ToDecimal(Console.ReadLine());
                        Monedas.Moneda_yenes(op2, money);
                        continue;
                    case 4:
                        Console.Clear();
                        Mensajes.Despedir();
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.Write("!ERROR¡ vuela a ingresar su elección . . .");
                Console.ReadKey();
                Console.Clear();
            }
        } while (true);
    }
    
}