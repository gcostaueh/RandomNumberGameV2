using System;

class Program
{
    static void Main()
    {
        do
        {
            Console.Clear(); // Limpa o console antes de iniciar o jogo
            JogarJogo();

            Console.WriteLine("\nGostaria de jogar novamente? Se sim, digite 1. Caso contrário, digite qualquer outra tecla.");
        } while (Console.ReadLine() == "1");

        Console.WriteLine("Obrigado por jogar! Até a próxima.");
    }

    static void JogarJogo()
    {
        Random aleatorio = new Random();
        int numeroSecreto = aleatorio.Next(1, 201);
        int tentativasRestantes = 10;
        string mensagemDeBoasVindas = "Boas vindas ao Enigma Numérico! Vamos jogar?";
        string descricao = "\nLembrando que você tem 10 tentativas para acertar o Número Secreto!";

        void ExibirMensagemDeBoasVindas()
        {
            Console.WriteLine(@"

███████╗███╗░░██╗██╗░██████╗░███╗░░░███╗░█████╗░
██╔════╝████╗░██║██║██╔════╝░████╗░████║██╔══██╗
█████╗░░██╔██╗██║██║██║░░██╗░██╔████╔██║███████║
██╔══╝░░██║╚████║██║██║░░╚██╗██║╚██╔╝██║██╔══██║
███████╗██║░╚███║██║╚██████╔╝██║░╚═╝░██║██║░░██║
╚══════╝╚═╝░░╚══╝╚═╝░╚═════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝

███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║██║░░╚═╝██║░░██║
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║██║░░██╗██║░░██║
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║██║╚█████╔╝╚█████╔╝
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░╚════╝░░╚════╝░");

            Console.WriteLine(mensagemDeBoasVindas);
            Console.WriteLine(descricao);
        };

        ExibirMensagemDeBoasVindas();

        do
        {
            Console.Write("\nDigite um número entre 1 e 200: ");
            int chute;

            // Verifica se a entrada é um número válido
            while (!int.TryParse(Console.ReadLine(), out chute))
            {
                Console.WriteLine("Por favor, digite um número válido.");
                Console.Write("Digite um número entre 1 e 200: ");
            }

            if (chute == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você acertou o número.");
                break;
            }
            else if (chute < numeroSecreto)
            {
                Console.Write("O número é ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("maior.");
                Console.ResetColor();
            }
            else
            {
                Console.Write("O número é ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("menor.");
                Console.ResetColor();
            }

            tentativasRestantes--;

            if (tentativasRestantes == 0)
            {
                Console.WriteLine("Você atingiu o limite de tentativas. O jogo acabou.");
                break;
            }
            else
            {
                Console.WriteLine("Você tem mais " + tentativasRestantes + " tentativas. Por favor, digite um novo número.");
            }

        } while (true);

        Console.WriteLine("\nO jogo acabou. O número secreto era: " + numeroSecreto);
    }

    static void ExibirMensagemDeBoasVindas(string mensagemDeBoasVindas, string descricao)
    {
        Console.WriteLine(mensagemDeBoasVindas);
        Console.WriteLine(descricao);
    }
}