namespace Calculadora
{
    internal class Program
    {


        static void Main(string[] args)
        {
            double numero1, numero2;
            
            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            numero2 = double.Parse(Console.ReadLine());
            double subtracao = numero1 - numero2;
            double soma = numero1 + numero2;
            Console.WriteLine("O resultado final da soma é: " + soma);
            Console.WriteLine("A subtração dos numero é:" + subtracao);
        }
    }
}
