using System.Runtime.Serialization.Formatters;

namespace Ejercicio_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            #region Declaro Arrays y construyo arrays
            int[] numeros;
            numeros = new int[100];

            string[] nombres;
            nombres = ["Noemí", "Noelía", "Andrés", "Emilio", "Norberto", "Estefanía", "Daniela", "Valeria"];
            #endregion

            #region Rellenar el vectorNumeros con numeros del 1-100
            for (int i = 0; i < numeros.Length; i++) {
                int numAleatorio = random.Next(1, 101);
                numeros[i] = numAleatorio;
            }
            #endregion

            #region Mostrar la lista generada
            for (int i = 0; i<numeros.Length; i++) {
                Console.Write($"Índice: {i},Número:{numeros[i],2}  ");
            }

            #endregion
            #region Seleccionar numero al azar e informar
            int numAzar = numeros[random.Next(numeros.Length)];
            Console.WriteLine($"\nNúmero azar seleccionado: {numAzar}");
            #endregion

            #region Obtener el ìndice de ese número Azar con Búsqueda Secuencial
            int pos = -1;
            int c = 0;
            while (pos == -1 && c < numeros.Length) {
                if (numeros[c] == numAzar)
                {
                    pos = c;
                }
                c++;
            }
            if (pos != -1) {
                Console.WriteLine($"Elemento encontrado en el índice {pos}");
            }
            else
            {
                Console.WriteLine("No se ha encontrado el valor buscado");
            }
            #endregion

            #region Ordenar Lista de números con Método Burbuja
            for (int i = 0; i < numeros.Length-1;i++) { 
                for (int j = i+1; j < numeros.Length;j++)
                {
                    if (numeros[i] > numeros[j]) {
                        int nAux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = nAux;
                    }
                }
            }
            #endregion

            #region Mostrar Lista ordenada
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Índice: {i},Número:{numeros[i],2}  "); 
            }
            #endregion

            #region Obtener el ìndice de ese número Azar con Búsqueda Método Biseccion
            bool encontrado = false;
            int izq = 0;
            int medio;
            int der = numeros.Length - 1;
            do
            {
                medio = (izq+der)/ 2;
                if (numeros[medio] == numAzar)
                {
                    encontrado = true;
                }
                else
                    if (numeros[medio] < numAzar)
                {
                    izq = medio + 1;
                }
                else
                {
                    der = medio - 1;
                }
            } while (izq <= der && !encontrado);
            if (encontrado)
            {
                Console.WriteLine($"\nElemento encontrado en el índice {medio}");
            }
            else
            {
                Console.WriteLine("\nNo se ha encontrado el valor buscado");
            }
            #endregion
            Console.ReadKey();

        }
    }
}
