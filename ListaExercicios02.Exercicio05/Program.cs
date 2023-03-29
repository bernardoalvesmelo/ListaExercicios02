namespace ListaExercicios02.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Frase em letras maiúsculas: " + frase.ToUpper());
            Console.WriteLine("Frase em letras minúsculas: " + frase.ToLower());
            Console.WriteLine("Número de caracteres na frase: " + frase.Length);
            Console.WriteLine("Primeira palavra da frase: " + frase.Split(' ')[0]);
            Console.WriteLine("Última palavra da frase: " + frase.Split(' ')[frase.Split(' ').Length - 1]);
            Console.ReadLine();
        }
    }

}