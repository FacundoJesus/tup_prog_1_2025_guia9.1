namespace Ejercicio_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            #region Declaro vector
            int[] numeros;
            #endregion

            #region Inicio/Construyo vector de 30 elementos
            numeros = new int[30];
            #endregion

            #region Relleno vector con numeros del 1 al 30
            for (int i = 0; i < numeros.Length; i++) {
                numeros[i] = i + 1;
            }
            #endregion

            #region Extraigo 10
            for (int i = 0; i < 10; i++) {
                int indiceAleatorio = random.Next(numeros.Length);
                Console.Write($"//{indiceAleatorio}:{numeros[indiceAleatorio],-3}");
                numeros[indiceAleatorio] = numeros[numeros.Length-1];

                int longitud = numeros.Length - 1;
                longitud--;
            }
            #endregion
            Console.ReadKey();
        }   
        
    }
}
