namespace Calculadora
{
    internal class Program
    {


        static void Main(string[] args)
        {
            float numero1, numero2;
            
            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            numero2 = float.Parse(Console.ReadLine());
            float subtracao = numero1 - numero2;    
            float soma = numero1 + numero2;
            Console.WriteLine("O resultado final da soma é: " + soma);
            Console.WriteLine("A subtração dos numero é:" + subtracao);
        }
    }
}
