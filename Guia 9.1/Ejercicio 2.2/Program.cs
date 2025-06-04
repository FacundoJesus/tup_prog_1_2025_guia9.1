using System.Runtime.Serialization.Formatters;

namespace Ejercicio_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            #region Declaro Arreglo
            int[] numeros;
            string[] nombres;
            string[] tercerVector;
            #endregion

            #region Inicio Arreglo
            numeros = new int[100];
            nombres = [ "Noemí", "Noelía", "Andrés", "Emilio", "Norberto", "Estefanía", "Daniela", "Valeria"];

            tercerVector = new string[100];
            #endregion

            for (int i = 0; i < numeros.Length; i++) {
                int numeroAleatorio = random.Next(1,101);
                numeros[i] = numeroAleatorio;
            }

            
            for (int j = 0;j < tercerVector.Length; j++) {
                int indiceAleatorio = random.Next(nombres.Length);
                tercerVector[j] = nombres[indiceAleatorio];
            }

            Console.WriteLine("---Tercer vector---");
            for (int i = 0;i < tercerVector.Length;i++) {
                Console.WriteLine($"{i}:{tercerVector[i]}");
            }
            Console.WriteLine("\nPresione Enter para continuar");
            Console.ReadKey();

            Console.WriteLine("\n---Vectores Paralelos (mismo índice)---");
            for (int indiceCompartido = 0; indiceCompartido < tercerVector.Length; indiceCompartido++) {

                Console.WriteLine($"Número: {numeros[indiceCompartido]} , Nombre: {tercerVector[indiceCompartido]}");
            }
            Console.WriteLine("\nPresione Enter para continuar");
            Console.ReadKey();

            //Ordenar con método burbuja
            for (int i = 0; i < numeros.Length-1; i++)
            {
                for (int j = i+1;  j < numeros.Length; j++) {
                    if (numeros[i] > numeros[j])
                    {
                        // Intercambiar números
                        int auxNumero = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = auxNumero;

                        // Intercambiar nombres 
                        string auxNombre = tercerVector[i];
                        tercerVector[i] = tercerVector[j];
                        tercerVector[j] = auxNombre;
                    }
                }
            }

            Console.WriteLine("\n---Lista ordenada: Indice, Número y Nombre---");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Índice: {i}, Número: {numeros[i]}, Nombre: {tercerVector[i]}");
            }
            Console.WriteLine("Presione Enter para salir.");
            Console.ReadKey();


        }
    }
}
