using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculadora_de_divisas
{
    public class Monedas
    {
        private const decimal UsdToEurRate = 0.92M;
        private const decimal UsdToJpyRate = 158.20M;
        private const decimal EurToUsdRate = 1.08M;
        private const decimal EurToJpyRate = 171.90M;
        private const decimal JpyToUsdRate = 0.0063M;
        private const decimal JpyToEurRate = 0.0058M;
        
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
}