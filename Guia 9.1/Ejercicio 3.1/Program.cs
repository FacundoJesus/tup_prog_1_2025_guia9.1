using System.Runtime.Serialization.Formatters;
using System.Xml;

namespace Ejercicio_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            #region Defino Array
            int[] numeros;
            #endregion

            #region Creo cantidad aleatoria de elementos
            int cantidadAleatoria = random.Next(10, 101);
            #endregion

            #region Inserto cantidad aleatoria de elementos en array
            numeros = new int[cantidadAleatoria];
            #endregion

            #region Relleno el array con valores del 0-200
            for (int i = 0; i < numeros.Length; i++) { 
                int valorGenerado = random.Next(201);
                numeros[i] = valorGenerado;
            }
            #endregion

            #region Imprimo en pantalla el Arreglo
            Console.WriteLine("Arreglo con números aleatorios");
            for (int i = 0; i < numeros.Length;i++) {
                Console.Write($"{i}:{numeros[i],2}  ");
            }
            Console.ReadKey();
            #endregion

            #region Seleccionar elemento al azar del Arreglo
            int elemento = numeros[random.Next(numeros.Length)];
            Console.WriteLine($"\n\nElemento a buscar: {elemento}");
            #endregion

            #region Buscarlo con Método Secuencial
            int pos = -1;
            int c = 0;
            while ( pos == -1 && c < numeros.Length ) {
                if (numeros[c] == elemento)
                {
                    pos = c;
                }
                c++;
            }

            if (pos != -1) {
                Console.WriteLine($"\nElemento encontrado con METODO SECUENCIAL en el índice: {pos}");
            }
            else
            {
                Console.WriteLine("\nNo se ha encontrado el valor buscado");
            }
            Console.ReadKey();
            #endregion

            #region Ordeno con método secuencial de Menor a Mayor
            for (int i = 0; i < numeros.Length-1; i++) {
                for (int j = i+1; j < numeros.Length; j++) { 
                    if (numeros[i] > numeros[j])
                    {
                        int aux = numeros[i];    // Al mayor lo meto en una variable
                        numeros[i] = numeros[j]; // Desplazo el elemento de la derecha hacia la izq.
                        numeros[j] = aux;        // Al mayor lo paso a la derecha.
                    }
                }
            }
            #endregion

            #region Muestro Array Ordenado
            Console.WriteLine($"\nArray Ordenado:");
            for (int i = 0; i < numeros.Length;i++)
            {
                Console.Write($"{i}:{numeros[i],2}  ");
            }
            #endregion

            #region Buscarlo con Algoritmo Biseccion
            int der;
            int medio;
            int ret = -1;
            bool encontrado = false;
            int izq = 0;
            der = numeros.Length - 1;
            do
            {
                medio = (izq + der) / 2;
                if (numeros[medio] == elemento)
                {
                    encontrado = true;
                }
                else
                if (numeros[medio] < elemento)
                {
                    izq = medio + 1;
                }
                else
                {
                    der = medio - 1;
                }
            } while (izq <= der && !encontrado);

            if (encontrado) {
                ret = medio;
            }

            if (ret!=-1)
            {
                Console.WriteLine($"\n\nElemento encontrado con METODO BISECCION en el índice: {ret}");
            }
            else
            {
                Console.WriteLine("\n\nNo se ha encontrado el valor buscado");
            }
            Console.ReadKey();
            #endregion


        }
    }
}
