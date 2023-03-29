namespace ListaExercicios02.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.Write("Digite o texto: ");
            string texto = Console.ReadLine();
            Console.Write("Digite o número de posições a frente: ");
            int posicao = Convert.ToInt32(Console.ReadLine());
            char[] textoCifrado = new char[texto.Length];
            for (int i = 0; i < texto.Length; i++)
            {
                int novaPosicao = alfabeto.IndexOf(("" + texto[i]).ToUpper()) + posicao;
                while (novaPosicao >= 26)
                {
                    novaPosicao = novaPosicao % 26;
                }
                textoCifrado[i] = alfabeto[novaPosicao];
            }
            Console.WriteLine("Texto Cifrado: " + new String(textoCifrado));
            Console.ReadLine();
        }
    }

}