using System.Runtime.Serialization.Formatters;

namespace Ejercicio_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            #region Declaro vector
            int[] vector;
            #endregion

            #region Inicializo vector con 100 elementos
            vector = new int [100];
            #endregion

            #region Relleno con números de 0 a 200
            for (int i = 0; i < vector.Length; i++) {
                int numeroAleatorio = random.Next(0, 201);
                vector[i] = numeroAleatorio;
            }
            #endregion

            #region Mostrarlo por pantalla
            for (int i = 0;i < vector.Length; i++) {
                Console.Write($"/ {i}:{vector[i],-3}");
            }
            Console.ReadKey();
            #endregion

            #region Ordenamiento con Método Burbuja
            for (int i = 0; i < vector.Length-1; i++)
            {
                for (int j = i+1; j < vector.Length; j++) {
                    if (vector[j] > vector[i])
                    {
                        int aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = aux;
                    }
                }
            }
            #endregion

            #region Mostrar Lista Ordenada en Pantalla
            Console.WriteLine("\n--- LISTA ORDENADA Método Burbuja:---");
            Console.WriteLine("--- De Mayor a Menor---");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"/ {i}:{vector[i],-3}");
            }
            Console.ReadKey();
            #endregion

            #region Ordenamiento con Método QuickSort 

            #endregion

            #region Búsqueda de elemento - Método Secuencial
            int valorAleatorio = random.Next(250);

            int l = 0;
            int pos = -1;
            
            while (pos ==-1 && l < vector.Length)
            {
                if (vector[i] == valorAleatorio)
                {
                    pos = l;
                }
                l++;
            }


            if (pos !=-1)
            {
                Console.WriteLine($"Valor aleatorio: {valorAleatorio} encontrado en el índice {pos}");
            }
            else
            {
                Console.WriteLine($"El valor no ha sido encontrado en el vector.");
            }

            Console.ReadKey();
            #endregion


        }
    }
}
