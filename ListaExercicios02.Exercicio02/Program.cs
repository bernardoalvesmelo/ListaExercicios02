namespace ListaExercicios02.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("O número de palavras na frase é: " + frase.Split(' ').Length);
            Console.ReadLine();
        }
    }

}