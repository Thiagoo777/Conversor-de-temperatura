using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp; 
            do
            {
                Console.WriteLine("Escolha a temperatura para conversão: \n" +
                    "1 - Celsius\n" +
                    "2 - Kelvin\n" +
                    "3 - Fahrenheit\n");
                int op = Convert.ToInt32(Console.ReadLine());

                ConvertTemperature convertTemperature = new ConvertTemperature();

                if (op == 1)
                {
                    Console.WriteLine("Digite a temperatura em Celsius: ");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Para qual escala deseja converter? \n" +
                        "1 - Kelvin\n" +
                        "2 - Fahrenheit\n");
                    int escolha = Convert.ToInt32(Console.ReadLine());
                    if (escolha == 1)
                    {
                        double temp1 = convertTemperature.TempCelsiusKelvin(temp);
                        Console.WriteLine("A temperatura em Kelvin é: " + temp1);
                    }
                    else if (escolha == 2)
                    {
                        double temp2 = convertTemperature.TempCelsiusFahrenheit(temp);
                        Console.WriteLine("A temperatura em Fahrenheit é: " + temp2);
                    }

                }
                else if (op == 2)
                {
                    Console.WriteLine("Digite a temperatura em Kelvin: ");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Para qual escala deseja converter? \n" +
                        "1 - Celsius\n" +
                        "2 - Fahrenheit\n");
                    int escolha = Convert.ToInt32(Console.ReadLine());
                    if (escolha == 1)
                    {
                        double temp3 = convertTemperature.TempKelvinCelsius(temp);
                        Console.WriteLine("A temperatura em Celsius é: " + temp3);
                    }
                    else if (escolha == 2)
                    {
                        double temp4 = convertTemperature.TempKelvinFahrenheit(temp);
                        Console.WriteLine("A temperatura em Fahrenheit é: " + temp4);
                    }
                }
                else if (op == 3)
                {
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    double temp = Convert.ToDouble(Console.ReadLine()); 

                    Console.WriteLine("Para qual escala deseja converter? \n" +
                        "1 - Celsius\n" +
                        "2 - Kelvin\n");
                    int escolha = Convert.ToInt32(Console.ReadLine());

                    if (escolha == 1) 
                    {
                        double temp5 = convertTemperature.TempFahrenheitCelsius(temp);
                        Console.WriteLine("A temperatura em Celsius é: " + temp5);
                    }
                    else if (escolha == 2)
                    {
                        double temp6 = convertTemperature.TempFahrenheitKelvin(temp);
                        Console.WriteLine("A temperatura em Kelvin é: " + temp6);
                    }
                }
                else
                {
                    Console.WriteLine("Opção Invalida");
                }

                    Console.WriteLine("Deseja continuar? 1 - Sim 2 - Não");
                resp = Convert.ToInt32(Console.ReadLine());
            } while (resp == 1);
        }
    }
}
