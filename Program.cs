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

            // Se imprimen numeros
            for (int i = 1; i < numeroFinal + 1; i++)
            {
                string mensaje = "";
                for (int x = 0; x < divisores.Length; x++)
                {
                    if (i % divisores[x] == 0)
                    {
                        mensaje = mensajes[x];
                        break;
                    }
                    mensaje = i.ToString();
                }
                Console.WriteLine(mensaje);
            }
        }
    }
}
