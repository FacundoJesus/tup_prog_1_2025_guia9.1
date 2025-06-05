namespace Ejercicio_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Declaro Arrays
            
            int[] numerosLibreta;
            string[] nombres;
            double[] notas;
            #endregion

            #region Inicio arrays
            numerosLibreta = new int[100];
            nombres = new string[100];
            notas = new double[100];
            #endregion

            #region Carga de Datos
            int i = 0;
            Console.WriteLine("Ingrese el Nº de Libreta del Alumno: (-1 P/SALIR)");
            int numLibreta = Convert.ToInt32(Console.ReadLine());
            while (numLibreta !=-1)
            {
                numerosLibreta[i] = numLibreta;
                Console.WriteLine("Ingrese el Nombre del Alumno:");
                string nombre = Console.ReadLine();
                nombres[i] = nombre;
                Console.WriteLine("Ingrese la Nota del Alumno:");
                int nota = Convert.ToInt32(Console.ReadLine());
                notas[i] = nota;

                Console.WriteLine("Ingrese el Nº de Libreta del Alumno: (-1 P/SALIR)");
                numLibreta = Convert.ToInt32(Console.ReadLine());

                i++;
            }
            #endregion

            #region Obtener Mayor y Menor
            double acumulador = 0;
            double mayor = 0;
            double menor = 0;
            string nombreMayor = "";
            string nombreMenor = "";
            int numeroLibretaMayor = 0;
            int numeroLibretaMenor = 0;
            for (int j = 0; j < i; j++) {

                acumulador += notas[j];

                if (j == 0 || notas[j] > mayor)
                {
                    mayor = notas[j];
                    nombreMayor = nombres[j];
                    numeroLibretaMayor = numerosLibreta[j];
                }
                if (j == 0 || notas[j] < menor) {
                    menor = notas[j];
                    nombreMenor = nombres[j];
                    numeroLibretaMenor = numerosLibreta[j];
                }
            }
            #endregion 

            #region Informo resultados
            double promedio = 0;
            if (i > 0)
            {
                promedio = acumulador / i;
                Console.WriteLine($"Promedio: {promedio:f2}");
                Console.WriteLine($"Nombre: {nombreMayor}, Mayor Nota: {mayor:f2}, Nº de Libreta:{numeroLibretaMayor}");
                Console.WriteLine($"Nombre: {nombreMenor}, Menor Nota: {menor:f2}, Nº de Libreta:{numeroLibretaMenor}");
            }
            else
            {
                Console.WriteLine("No hubo ingreso de notas.");
            }
            #endregion

            #region Declaro y Construyo nuevos listados
            double[] nuevoListadoNotas;
            nuevoListadoNotas = new double[100];

            string[] nuevoListadoNombres;
            nuevoListadoNombres = new string[100];

            int[] nuevoListadoNumerosLibreta;
            nuevoListadoNumerosLibreta = new int[100];
            #endregion

            int l = 0;
            for (int p = 0; p < i; p++) { 
                if (notas[p] >= promedio)
                {
                    nuevoListadoNotas[l] = notas[p];
                    nuevoListadoNombres[l] = nombres[p];
                    nuevoListadoNumerosLibreta[l] = numerosLibreta[p];
                    l++;
                }
            }

            Console.WriteLine("Listado de Alumnos que superan el promedio:");
            for (int s = 0; s < l; s++) {
                Console.WriteLine($"Nombre: {nuevoListadoNombres[s]}, Nota: {nuevoListadoNotas[s]}, Nº de Libreta:{nuevoListadoNumerosLibreta[s]}");
            }

            Console.ReadKey();





        }
    }
}
