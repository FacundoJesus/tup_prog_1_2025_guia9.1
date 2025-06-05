namespace Ejercicio_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declaro variables, Declaro y construyo vector
            int[] vectorNumeros;
            vectorNumeros = new int[100];

            int acumulador = 0;
            int mayor = 0;
            int indiceMayor = 0;
            int menor = 0;
            int indiceMenor = 0;
            #endregion

            #region Proceso de carga de datos
            Console.WriteLine("Ingrese el valor o -1 P/Salir:");
            int valor = Convert.ToInt32(Console.ReadLine());

            int indice = 0;
            while (valor != -1 && indice < vectorNumeros.Length)
            {
                vectorNumeros[indice] = valor;
                indice++;
                Console.WriteLine("Ingrese el valor o -1 P/Salir:");
                valor = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nLista generada:");
            for (int i = 0; i < indice; i++)
            {
                acumulador += vectorNumeros[i];
                Console.Write($"Índice:{i},Número:{vectorNumeros[i],2}  ");

                if (i == 0 || vectorNumeros[i] > mayor)
                {
                    mayor = vectorNumeros[i];
                    indiceMayor = i;
                }
                if (i == 0 || vectorNumeros[i] < menor)
                {
                    menor = vectorNumeros[i];
                    indiceMenor = i;
                }

                
            }
            double promedio = (acumulador * 1.0) / indice;
            Console.WriteLine($"\nPromedio de todos los valores ingresados: {promedio:f2}");
            Console.WriteLine($"Valor Máximo:{mayor}, Índice:{indiceMayor}");
            Console.WriteLine($"Valor Mínimo:{menor}, Índice:{indiceMenor}");
            #endregion

            #region Lista Nueva que supera el promedio
            int[] superanPromedio;
            superanPromedio = new int[100];
            int j = 0;
            for (int i = 0;i < vectorNumeros.Length;i++) {
                if (vectorNumeros[i] >= promedio)
                {
                    int aux = vectorNumeros[i];
                    superanPromedio[j] = aux;
                    j++;
                }
            }
            Console.WriteLine("\nNueva lista, valores que superan el promedio:");
            for (int i = 0; i < j; i++)
            {
                Console.Write($"Índice:{i},Número:{superanPromedio[i],2}  ");
            }
            #endregion

            #region Rango que establece el usuario para mostrar una nueva lista 
            Console.WriteLine("\n\nIngrese el rango inicial de las notas que superan el promedio:");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el rango final de las notas que superan el promedio:");
            int final = Convert.ToInt32(Console.ReadLine());

            int[] valoresUsuario;
            valoresUsuario = new int[100];
            int p = 0;
            for (int i = 0; i < j ; i++) {
                if (superanPromedio[i] >= inicio && superanPromedio[i] <= final)
                {
                    int x = superanPromedio[i];
                    valoresUsuario[p] = x;
                    p++;
                }
            }

            Console.WriteLine("Notas que superan el promedio y se encuentran en el rango especificado:");
            for (int i = 0; i < p; i++)
            {
                Console.Write($"Índice:{i},Número:{valoresUsuario[i],2}  ");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
