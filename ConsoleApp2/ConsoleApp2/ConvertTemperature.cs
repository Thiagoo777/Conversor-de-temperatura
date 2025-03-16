using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ConvertTemp;

namespace ConvertTemp
{
    class ConvertTemperature
    {

        public double TempCelsiusKelvin(double temp1)
        {
            return temp1 + 273;
        }
        public double TempCelsiusFahrenheit(double temp2)
        {
            return (temp2 * 1.8) + 32;
        }
        public double TempKelvinCelsius(double temp3)
        {
            return temp3 - 273;
        }
        public double TempKelvinFahrenheit(double temp4)
        {
            return (temp4 - 273) * 1.8 + 32;
        }


        public double TempFahrenheitCelsius(double temp5)
        {
            return (temp5 - 32) / 1.8;
        }


        public double TempFahrenheitKelvin(double temp6)
        {
            return (temp6 - 32) * 5 / 9 + 273;
        }



    }
}


