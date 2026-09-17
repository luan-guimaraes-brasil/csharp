namespace Aula06
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("==========Verificação de números Pares ou Impares==========");
            Console.WriteLine("Digite um número: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = number % 2;

            if (result == 0)
            {
                Console.WriteLine("O número digitado é Par!");
            }  
            else 
            {
                Console.WriteLine("O número digitado é Impar!");
            }
        }
    }
}