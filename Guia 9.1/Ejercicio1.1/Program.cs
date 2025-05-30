namespace Ejercicio1._1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region Declaracion del vector y variables
            int[] numeros;
            int contador;
            int acumulador = 0;
            int mayor = 0;
            int menor = 0;
            int posicionMayor = 0;
            int posicionMenor = 0;
            #endregion

            #region Definicion  del vector
            numeros = new int[100]; //100 elementos (del indice 0 al 99) - Construir el array
            #endregion

            #region Inicializacion del vector
            //numeros[0] = 5;
            Console.WriteLine("Ingrese el valor: (-1 P/Salir)");
            int valor = Convert.ToInt32(Console.ReadLine());
            contador = 0;
            #endregion

            while (valor != -1)
            {
                numeros[contador] = valor;
                contador++;
                Console.WriteLine("Ingrese el valor: (-1 P/Salir)");
                valor = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("---Listado de números ingresados---");
            for (int i = 0; i < contador; i++)
            {
                Console.Write($"{i}:{numeros[i],-4}");
                acumulador += numeros[i];

                if (i == 0 || numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posicionMayor = i;
                }

                if (i == 0 || numeros[i] < menor)
                {
                    menor = numeros[i];
                    posicionMenor = i;
                }
            }

            // Evitar Error división por 0
            if (contador > 0)
            {
                double promedio = (acumulador * 1.0) / contador;
                Console.WriteLine($"\nPromedio: {promedio:f2}");
                Console.WriteLine($"Mayor valor: {mayor} , en la posición: {posicionMayor}.");
                Console.WriteLine($"Menor valor: {menor}, en la posición: {posicionMenor}.");
            }
            else
            {
                Console.WriteLine("No has ingresado números.");
            }


        }
    }
}
