using System.Globalization;

internal class Program
{
    private const decimal UsdToEurRate = 0.92M;
    private const decimal UsdToJpyRate = 158.20M;
    private const decimal EurToUsdRate = 1.08M;
    private const decimal EurToJpyRate = 171.90M;
    private const decimal JpyToUsdRate = 0.0063M;
    private const decimal JpyToEurRate = 0.0058M;
    
    private static void Main(string[] args)
    {
        Saludar();
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
                        Moneda_us(op2, money);
                        continue;
                    case 2:
                        Console.Write("ingrese a que tipo de moneda quiere cambiar:\n1) Dolar\n2) Yenes\n");
                        op2 = Convert.ToByte(Console.ReadLine());
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("ingrese el valor a convertir:");
                        money = Convert.ToDecimal(Console.ReadLine());
                        Moneda_euro(op2, money);
                        continue;
                    case 3:
                        Console.Write("ingrese a que tipo de moneda quiere cambiar:\n1) Dolar\n2) Euro\n");
                        op2 = Convert.ToByte(Console.ReadLine());
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("ingrese el valor a convertir:");
                        money = Convert.ToDecimal(Console.ReadLine());
                        Moneda_yenes(op2, money);
                        continue;
                    case 4:
                        Console.Clear();
                        Despedir();
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
    public static void Saludar()
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("¡BIENVENIDO A AL CALCULADORA DE MONEDAS!");
        Console.WriteLine("---------------------------------------");
    }
    public static void Despedir()
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("¡ADIOS!");
        Console.WriteLine("---------------------------------------");
    }
    public static void Moneda_us(byte op2, decimal entrada)
    {
        switch (op2)
        {
            case 1:
                decimal resultado = entrada * UsdToEurRate;
                Console.WriteLine($"{entrada.ToString("C3", new CultureInfo("en-US"))} Dólares = {resultado.ToString("C", new CultureInfo("fr-FR"))}");
                break;

            case 2:
                resultado = entrada * UsdToJpyRate;
                Console.WriteLine($"{entrada.ToString("C3", new CultureInfo("en-US"))} Dólares = {resultado.ToString("C", new CultureInfo("ja-JP"))}");
                break;

            default:
                Console.WriteLine($"error");
                break;
        }
    }
    public static void Moneda_euro(byte op2, decimal entrada)
    {
        switch (op2)
        {
            case 1:
                decimal resultado = entrada * EurToUsdRate;
                Console.WriteLine($"{entrada.ToString("C", new CultureInfo("fr-FR"))} Euros = {resultado.ToString("C", new CultureInfo("en-US"))}");
                break;

            case 2:
                resultado = entrada * EurToJpyRate;
                Console.WriteLine($"{entrada.ToString("C", new CultureInfo("fr-FR"))} Euros = {resultado.ToString("C", new CultureInfo("ja-JP"))}");
                break;

            default:
                Console.WriteLine($"error");  
                break;
        }
    }
    public static void Moneda_yenes(byte op2, decimal entrada)
    {
        switch (op2)
        {
            case 1:
                decimal resultado = entrada * JpyToUsdRate;
                Console.WriteLine($"{entrada.ToString("C", new CultureInfo("ja-JP"))} Yenes = {resultado.ToString("C", new CultureInfo("en-US"))}");
                break;

            case 2:
                resultado = entrada * JpyToEurRate;
                Console.WriteLine($"{entrada.ToString("C", new CultureInfo("ja-JP"))} Yenes = {resultado.ToString("C", new CultureInfo("fr-FR"))}");
                break;

            default:
                Console.WriteLine($"error");  
                break;
        }
    }
}