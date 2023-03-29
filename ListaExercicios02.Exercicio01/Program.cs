namespace ListaExercicios02.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            Console.WriteLine("A palavra com Title Case é: " + ("" + palavra[0]).ToUpper() + palavra.Substring(1));
            Console.ReadLine();
        }
    }

}