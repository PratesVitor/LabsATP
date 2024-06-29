using System;

class Program
{
    public static void Main(string[] args)
    {
        int vitoriasAtletico = 0;
        int vitoriasCruzeiro = 0;
        int empates = 0;
        int jogos = 0;

        do
        {
            Console.WriteLine("Digite o número de gols do Atlético:");
            int golsAtletico = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de gols do Cruzeiro:");
            int golsCruzeiro = int.Parse(Console.ReadLine());

            if (golsAtletico > golsCruzeiro)
            {
                Console.WriteLine("Atlético venceu!");
                vitoriasAtletico++;
            }
            else if (golsCruzeiro > golsAtletico)
            {
                Console.WriteLine("Cruzeiro venceu!");
                vitoriasCruzeiro++;
            }
            else
            {
                Console.WriteLine("EMPATE");
                empates++;
            }

            jogos++;

            Console.WriteLine("Novo DUELO 1.Sim 2.Não?");
        } while (Console.ReadLine() == "1");

        Console.WriteLine($"(a) Jogos disputados: {jogos}");
        Console.WriteLine($"(b) Vitórias do Atlético: {vitoriasAtletico}");
        Console.WriteLine($"(c) Vitórias do Cruzeiro: {vitoriasCruzeiro}");
        Console.WriteLine($"(d) Empates: {empates}");

        if (vitoriasAtletico > vitoriasCruzeiro)
            Console.WriteLine("(e) Atlético venceu o maior número de duelos.");
        else if (vitoriasCruzeiro > vitoriasAtletico)
            Console.WriteLine("(e) Cruzeiro venceu o maior número de duelos.");
        else
            Console.WriteLine("(e) Não houve um vencedor dos duelos.");
    }
}