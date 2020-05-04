using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL19037Guia8Ejercicio6
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            float temperatura, sumTemp = 0, promTemp;
            float maxtem = 0, mintem = 0, sumTempIce = 0, promTempIce;
            
                while (contador <= 7)
            {
                Console.WriteLine("DIGITE LA TEMPERATURA DEL DIA {0}", contador);
                temperatura = float.Parse(Console.ReadLine());

                sumTemp = sumTemp + temperatura;
                if (contador == 1)
                {
                    mintem = temperatura;
                    maxtem = temperatura;
                }
                if (temperatura < mintem)
                {
                    mintem = temperatura;
                }
                if (temperatura > maxtem)
                {
                    maxtem = temperatura;
                }
                if (temperatura<0)
                {
                    sumTempIce = sumTempIce + 1;
                }
                contador = contador + 1;
            }

            promTemp = CalcProm(sumTemp);
            promTempIce = CalcPorcen(sumTempIce);
            
            Imprimir(promTemp, mintem, maxtem, promTempIce);
            //Console.WriteLine("\nPROMEDIO DE TEMPERATURAS {0:0.00}\nTEMPERATURA MAS FRIA {1}\nTEMPERATURA MAS CALIENTE {2} \nEL PROMEDIO DE TEMPERATURA FRIAS ES {3:00.00}%", promTemp, mintem, maxtem, promTempIce);
            Console.ReadKey();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="plusTemp"></param>
        /// <returns></returns>
        static float CalcProm(float plusTemp)
        {
            float promedio;
            promedio = plusTemp / 7;
            return promedio;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="plusIce"></param>
        /// <returns></returns>
        static float CalcPorcen(float plusIce)
        {
            float porcentaje;
            porcentaje = (plusIce / 7) * 100;
            return porcentaje;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="promTemp"></param>
        /// <param name="mintem"></param>
        /// <param name="maxtem"></param>
        /// <param name="promTempIce"></param>
        static void Imprimir(float promTemp, float mintem, float maxtem, float promTempIce)
        {

            Console.WriteLine("\nPROMEDIO DE TEMPERATURAS {0:0.00}\nEL DIA MAS FRIO REGISTRO UNA TEMPERATURA DE: {1}\nEL DIA MAS CALIENTE REGISTRO UNA TEMPERATURA DE: {2} \nEL PORCENTAJE DE TEMPERATURAS BAJO 0 ES {3:00.00}%", promTemp, mintem, maxtem, promTempIce);

            return;
        }
    }
}
