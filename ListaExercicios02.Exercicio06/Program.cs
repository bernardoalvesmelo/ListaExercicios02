namespace Cidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string csv = File.ReadAllText("Cidades.csv").Trim();
            string[] csvArray = csv.Split('\n');
            string cabecalho = csvArray[0];
            string[][] csvDados = new string[csvArray.Length - 1][];
            for (int i = 1; i < csvArray.Length; i++)
            {
                csvDados[i - 1] = csvArray[i].Split(',');
            }

            while (true)
            {
                Console.WriteLine("1-Mostrar cidades por nomes");
                Console.WriteLine("2-Mostrar cidades por estados");
                Console.Write("Digite outro caractere para sair: ");
                string escolha = Console.ReadLine();
                if (escolha == "1")
                {
                    Array.Sort(csvDados, (cidadeA, cidadeB) => cidadeA[2].CompareTo(cidadeB[2]));
                    MostrarCidades(csvDados, cabecalho);
                }
                else if (escolha == "2")
                {
                    Array.Sort(csvDados, (estadoA, estadoB) => estadoA[3].Trim().CompareTo(estadoB[3].Trim()));
                    MostrarCidades(csvDados, cabecalho);
                }
                else
                {
                    break;
                }
            }
        }

        static void MostrarCidades(string[][] csvDados, string cabecalho)
        {
            Console.Clear();
            Console.WriteLine(cabecalho);
            for (int i = 0; i < csvDados.Length; i++)
            {
                Console.WriteLine(string.Join(",", csvDados[i]));
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}