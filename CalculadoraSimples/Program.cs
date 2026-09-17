namespace Aula05
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("==========CALCULADORA==========");
            Console.WriteLine("Digite o primeiro número: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int subtraction = number1 - number2;
            int multiplication = number1 * number2;
            int division = number1 / number2;
            int modulus = number1 % number2;

            Console.WriteLine("O resultado da soma é: " + sum);
            Console.WriteLine("O resultado da subtração é: " + subtraction);
            Console.WriteLine("O resultado da multiplicação é: " + multiplication);
            Console.WriteLine("O resultado da divisão é: " + division);
            Console.WriteLine("O resultado da divisão inteira é: " + modulus);
        }
    }
}