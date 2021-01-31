using System;

namespace Challenge_DanielaMelo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Se establece numero final a mostrar
            int numeroFinal = 100;

            // Se crea lista de numeros por los cuales se podra dividir
            int[] divisores = { 15, 5, 3 };
            // Se crea lista de mensajes que se podran mostrar
            string[] mensajes = { "Integraciones", "IT", "Falabella" };

            // Mostrara numeros hasta que llegue al numero final asignado            
            for (int i = 1; i < numeroFinal + 1; i++)
            {
                string mensaje = "";

                // Recorre arreglo de divisores para determinar si es primo
                for (int x = 0; x < divisores.Length; x++)
                {
                    // Si encuentra divisor asigna mensaje.
                    if (i % divisores[x] == 0)
                    {
                        mensaje = mensajes[x];
                        break;
                    }
                    mensaje = i.ToString();
                }

                // Se imprimen numeros
                Console.WriteLine(mensaje);
            }
        }
    }
}
