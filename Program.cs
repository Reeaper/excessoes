// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Insira o primeiro valor");
            string valor1 = Console.ReadLine();
            if (string.IsNullOrEmpty(valor1))
            {
                throw new Exception("Não pode ser nulo");
            }


            Console.WriteLine("Insira o segundo valor");
            string valor2 = Console.ReadLine();
            if (double.Parse(valor2) == 0)
            {
                throw new Exception("Não é possivel realizar uma divisao por 0");
            }
            double resultado = double.Parse(valor1) / double.Parse(valor2);
            Console.WriteLine(value: $"O resultado da divisao {valor1} e {valor2} é {resultado}");
    catch (Exception e)
        {
            Console.WriteLine($"{e.Message}");
        }
        finally
        {
            Console.WriteLine("Obrigado por utilizar o nosso app");
        }
}
}