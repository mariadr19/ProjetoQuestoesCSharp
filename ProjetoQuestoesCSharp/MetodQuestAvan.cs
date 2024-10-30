using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoQuestoesCSharp.MetodQuestAvan;

namespace ProjetoQuestoesCSharp
{
    public class MetodQuestAvan
    {
        // 76. Crie um jogo de "Adivinhe o Número" entre 1 e 100, dando dicas se o valor é maior ou menor.
        public static void questao76()
        {
            Random random = new Random();
            int num = random.Next(1, 101);
            int palpt = 0;
            int tent = 0;

            while (palpt != num)
            {
                Console.Write("Digite um número entre 1 e 100: ");
                palpt = int.Parse(Console.ReadLine());
                tent++;

                if (palpt < num)
                {
                    Console.WriteLine("O número é maior.");
                }
                else if (palpt > num)
                {
                    Console.WriteLine("O número é menor.");
                }
                else
                {
                    Console.WriteLine($"Parabéns! Você acertou o número em {tent} tentativas.");
                }
            }

        }

        // 77. Implemente uma função que verifica se dois arrays possuem os mesmos elementos, independentemente da ordem.
        public static void questao77()
        {

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 5, 4, 3, 2, 1 };

            bool iguais = array1.Length == array2.Length && !array1.Except(array2).Any();

            if (iguais)
            {
                Console.WriteLine("Os arrays são iguais.");
            }
            else
            {
                Console.WriteLine("Os arrays são diferentes.");
            }
        }

        // 78. Crie uma função que simula uma fila de atendimento (FIFO) usando List<T>.
        public static void questao78()
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Cliente 1");
            fila.Enqueue("Cliente 2");
            fila.Enqueue("Cliente 3");

            Console.WriteLine("Atendendo clientes:");
            while (fila.Count > 0)
            {
                string cliente = fila.Dequeue();
                Console.WriteLine($"Atendendo {cliente}...");
            }
        }

        // 79. Desenvolva um jogo simples de "Pedra, Papel e Tesoura" que joga contra o computador.
        public static void questao79()
        {
            Random random = new Random();
            string[] opcoes = { "Pedra", "Papel", "Tesoura" };

            Console.Write("Escolha (Pedra, Papel ou Tesoura): ");
            string escolhaUsuario = Console.ReadLine();
            string escolhaComputador = opcoes[random.Next(0, 3)];

            Console.WriteLine($"O computador escolheu: {escolhaComputador}");

            if (escolhaUsuario == escolhaComputador)
            {
                Console.WriteLine("Empate!");
            }
            else if ((escolhaUsuario == "Pedra" && escolhaComputador == "Tesoura") ||
                     (escolhaUsuario == "Papel" && escolhaComputador == "Pedra") ||
                     (escolhaUsuario == "Tesoura" && escolhaComputador == "Papel"))
            {
                Console.WriteLine("Você ganhou!");
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }
        }

        // 80. Crie um programa que calcula a soma dos dígitos de um número fornecido pelo usuário.
        public static void questao80()
        {

        }

        // 81. Implemente uma função que encontra e exibe os números pares em uma lista.
        public static void questao81()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Números pares:");
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }

        // 82. Desenvolva um programa que lê valores do usuário e exibe a média e o maior valor informado.
        public static void questao82()
        {
            Console.WriteLine();

        }

        // 83. Crie um programa que armazena 10 nomes e os exibe em ordem alfabética.
        public static void questao83()
        {
            List<string> nomes = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Digite o {i}° nome: ");
                string nome = (Console.ReadLine());
                nomes.Add(nome);
            }
            nomes.Sort();
            Console.WriteLine("\nNomes em ordem alfabética:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        // 84. Implemente uma função que verifica se uma string é um palíndromo (lida da mesma forma ao contrário).
        public static void questao84()
        {

        }

        // 85. Crie um programa que gere 10 números aleatórios entre 1 e 50 e exiba o menor e o maior.
        public static void questao85()
        {

        }

        //Implementação da classe da questão 86
        public class ContaBancaria
        {

        }
        // 86. Desenvolva uma classe ContaBancaria com métodos para depósito e saque e exiba o saldo após cada operação.
        public static void questao86()
        {

        }

        // 87. Implemente um programa que calcula o salário líquido de um funcionário com base no salário bruto e desconto de 10%.
        public static void questao87()
        {
            Console.Write("Digite o salário bruto: ");
            double salarioBruto = Convert.ToDouble(Console.ReadLine());
            double desconto = salarioBruto * 0.10;
            double salarioLiquido = salarioBruto - desconto;

            Console.WriteLine($"O salário líquido é: {salarioLiquido}");
        }

        // 88. Crie uma função que converte um número decimal para sua representação binária.
        public static void questao88()
        {
            Console.Write("Digite um número decimal: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            string binario = Convert.ToString(numero, 2);

            Console.WriteLine($"O número {numero} em binário é: {binario}");
        }

        // 89. Desenvolva um programa que recebe três notas e exibe se o aluno foi aprovado, considerando média >= 7.
        public static void questao89()
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("O aluno foi aprovado.");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado.");
            }
        }

        // 90. Implemente uma função que soma todos os elementos de uma matriz 2x2.
        public static void questao90()
        {

        }

        // 91. Crie um programa que simula uma votação com três candidatos e exibe o vencedor ao final.
        public static void questao91()
        {

        }

        // 92. Desenvolva um programa que verifica se um número fornecido é múltiplo de 3 e 7 ao mesmo tempo.
        public static void questao92()
        {
            Console.Write("\nDigite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0)
            {
                if (num % 7 == 0)
                {
                    Console.WriteLine($"\nO número {num} é divisível por 3 e por 7.");
                }
                else
                {
                    Console.WriteLine($"\nO número {num} é divisível apenas por 3");
                }

            }
            else
            {
                if (num % 7 == 0)
                {
                    Console.WriteLine($"\nO número {num} é divisível apenas por 7");
                }
                else
                {
                    Console.WriteLine($"\nO número {num} não é divisível por 3 e por 7.");
                }
            }
        }

        // 93. Implemente um programa que calcula a distância entre dois pontos no plano cartesiano (fórmula da distância).
        public static void questao93()
        {

        }

        // 94. Crie uma função que gera uma lista de 5 números aleatórios e os exibe em ordem crescente.
        public static void questao94()
        {
            Random random = new Random();
            List<int> numerosAleatorios = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numerosAleatorios.Add(random.Next(1, 101));
            }

            numerosAleatorios.Sort();
            Console.WriteLine("Números aleatórios em ordem crescente:");
            foreach (int numero in numerosAleatorios)
            {
                Console.WriteLine(numero);
            }
        }

        // 95. Desenvolva uma agenda de contatos simples que permite adicionar e listar nomes e números de telefone.

        public class Agenda
        {
            public string Nome;
            public string Telefone;

            public Agenda(string nome, string telefone)
            {
                Nome = nome;
                Telefone = telefone;
            }
        }
        public static void NovoCTT()
        {
            Console.Write("\nDigite o nome do contato: ");
            string nnovo = Console.ReadLine();
            Console.Write("Digite o número do telefone: ");
            string tnovo = Console.ReadLine();

            Agenda agenda = new Agenda(nnovo, tnovo);
            a.Add(agenda);
        }
        public static void exibirAgenda()
        {
            Console.WriteLine("\nLista de contatos");
            foreach (var contato in a)
            {
                Console.WriteLine($"\nNome {contato.Nome}\nTelefone{contato.Telefone}");

            }
        }
        static List<Agenda> a = new List<Agenda>();
        public static void questao95()
        {
            Console.Write("\nDigite o nome do contato: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o número do telefone: ");
            string telefone = Console.ReadLine();

            Agenda agenda = new Agenda(nome, telefone);
            a.Add(agenda);

            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar um novo contato");
                Console.WriteLine("2 - Ver lista de contatos");
                Console.WriteLine("3 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        NovoCTT();
                        break;
                    case "2":
                        Console.Clear();
                        exibirAgenda();
                        break;
                    case "3":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

            // 96. Implemente uma função que exibe todos os números primos entre 1 e 100.
            public static void questao96()
        {

        }

        // 97. Crie um programa que recebe um número e exibe sua tabuada de multiplicação até 10.
        public static void questao97()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tabuada de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        // 98. Desenvolva uma função que retorna o maior número em uma matriz 3x3.
        public static void questao98()
        {

        }

        // 99. Implemente um programa que calcula a soma dos quadrados dos números de 1 a N.
        public static void questao99()
        {
            Console.Write("Digite um número N: ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                soma += i * i;
            }

            Console.WriteLine($"A soma dos quadrados dos números de 1 a {N} é: {soma}");
        }

        // 100. Crie um jogo simples de "Forca" onde o usuário tenta adivinhar uma palavra em até 5 tentativas.
        public static void questao100()
        {

        }
    }
}
