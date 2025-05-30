using System.Data;

namespace Ejercicio_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declaro los vectores
            string[] nombres;
            int[] numerosLibreta;
            double[] notas;
            #endregion

            #region Inicializo/Construyo los vectores
            nombres = new string[100];
            numerosLibreta = new int[100];
            notas = new double[100];
            #endregion


            #region Completo datos los vectores.
            Console.WriteLine("Ingrese la nota del alumno: (-1 P/SALIR):");
            double nota = Convert.ToDouble(Console.ReadLine());
            int indice = 0;
            while (nota != -1)
            {
                notas[indice] = nota;

                Console.WriteLine("Ingrese el nombre del alumno:");
                string nombre = Console.ReadLine();
                nombres[indice] = nombre;
                
                Console.WriteLine("Ingrese el numero de Libreta del alumno:");
                int nroLibreta = Convert.ToInt32(Console.ReadLine());
                numerosLibreta[indice] = nroLibreta;

                indice++;

                Console.WriteLine("Ingrese la nota del alumno: (-1 P/SALIR):");
                nota = Convert.ToDouble(Console.ReadLine());
            }
            #endregion

            #region Recorro el vector de notas
            //Recorrer el vector de las notas
            double acumulador = 0;
            double mayorNota = 0;
            string alumnoMayorNota = "";
            int numeroLibretaMayorNota = 0;
            double menorNota = 0;
            string alumnoMenorNota = "";
            int numeroLibretaMenorNota = 0;
            for (int i = 0; i < indice; i++) {

                acumulador += notas[i];

                if ( i == 0 || notas[i] > mayorNota)
                {
                    mayorNota = notas[i];
                    alumnoMayorNota = nombres[i];
                    numeroLibretaMayorNota = numerosLibreta[i];
                }
                if (i == 0 || notas[i] < menorNota)
                {
                    menorNota = notas[i];
                    alumnoMenorNota = nombres[i];
                    numeroLibretaMenorNota = numerosLibreta[i];
                }
            }
            #endregion

            #region INFORMO
            if (indice > 0)
            {
                double promedio = acumulador / indice;
                Console.WriteLine($"Promedio de notas:{promedio:f2}");
                Console.WriteLine($"Mayor Nota - Nombre: {alumnoMayorNota} // Mayor Nota:{mayorNota:f2} // Nº Libreta: {numeroLibretaMayorNota}");
                Console.WriteLine($"Menor Nota - Nombre: {alumnoMenorNota} // Mayor Nota:{menorNota:f2} // Nº Libreta: {numeroLibretaMenorNota}");

                //Cear Nuevas Listas que Superan el promedio
                string[] nombresFiltro;
                int[] numerosLibretaFiltro;
                double[] notasFiltro;

                nombresFiltro = new string[100];
                numerosLibretaFiltro = new int[100];
                notasFiltro = new double[100];

                int indiceFiltro = 0;               
                for (int p = 0; p < indice; p++)
                {
                    if (notas[p] > promedio)
                    {
                        notasFiltro[indiceFiltro] = notas[p];
                        numerosLibretaFiltro[indiceFiltro] = numerosLibreta[p];
                        nombresFiltro[indiceFiltro] = nombres[p];

                        indiceFiltro++;
                    }
                }
                Console.WriteLine($"\n---Lista de Nombres de Alumnos que superaron el promedio---");
                for (int iAlumno = 0;  iAlumno < indiceFiltro;  iAlumno++)
                {
                    Console.Write($"{nombresFiltro[iAlumno],3}");
                }
            }
            else
            {
                Console.WriteLine("No hubo ingreso de notas.");
            }

            Console.ReadKey();
            #endregion
        }
    }
}
