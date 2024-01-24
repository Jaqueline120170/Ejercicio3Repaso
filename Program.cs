namespace Ejercicio3Repaso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int pesoXsaco;
            Console.WriteLine("Introduzca el peso de cada saco en número entero:");
            pesoXsaco = Convert.ToInt32(Console.ReadLine());

            int numeroSacos;
            numeroSacos = 4000 / pesoXsaco;
            Console.WriteLine("Usted puede cargar " +  numeroSacos + " sacos en la furgoneta");
        }
    }
}