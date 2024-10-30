using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp
{
    public class MetodQuestInterAvan
    {
        // Verifica se uma matriz é simétrica
        public static void questao51()
        {
            Console.Write("\nDigite o tamanho da matriz quadrada (ex: 3 para 3x3): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];

            Console.WriteLine("Digite os elementos da matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            bool simetrica = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] != matriz[j, i])
                    {
                        simetrica = false;
                        break;
                    }
                }
            }

            Console.WriteLine(simetrica ? "A matriz é simétrica." : "A matriz não é simétrica.");
        }

        // Ordena uma lista de nomes em ordem alfabética
        public static void questao52()
        {
            Console.WriteLine("\nQuantos nomes você quer adicionar?");
            Console.Write("Quantidade: ");
            int quant = int.Parse(Console.ReadLine());

            List<string> nomes = new List<string>();

            for (int i = 1; i <= quant; i++)
            {
                Console.Write($"Digite {i}° nome: ");
                string nome = Console.ReadLine();
                nomes.Add(nome);
            }
            Console.WriteLine("\nLista ordenada alfabeticamente:");
            nomes.Sort();
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        // Encontra o elemento mais frequente em um array
        public static void questao53()
        {
            Console.WriteLine("\nDigite o número de elementos no array:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Digite os elementos do array:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maisFrequente = array.GroupBy(x => x).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
            int frequencia = array.Count(x => x == maisFrequente);

            Console.WriteLine($"O elemento mais frequente é {maisFrequente}, que aparece {frequencia} vezes.");
        }
    


        // Calcula o valor absoluto de um número sem usar Math.Abs()
        public static void questao54()
        {
            Console.Write("\nDigite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int absoluto = numero < 0 ? -numero : numero;
            Console.WriteLine($"O valor absoluto é {absoluto}");
        }

        // Implementa o algoritmo de busca linear
        public static void questao55()
        {
            Console.WriteLine("\nDigite o número de elementos no array:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Digite os elementos do array:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nDigite o número a ser buscado: ");
            int busca = int.Parse(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == busca)
                {
                    Console.WriteLine($"Número {busca} encontrado na posição {i}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Número não encontrado.");
            }
        }

        // Simula um cronômetro simples (usando Thread.Sleep)
        public static void questao56()
        {
            Console.Write("\nDigite o tempo do cronômetro em segundos: ");
            int tempo = int.Parse(Console.ReadLine());

            for (int i = tempo; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Tempo restante: {i} segundos");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nTempo esgotado!");
        }

        // Calcula o número de palavras em uma string
        public static void questao57()
        {
            
        }

        // Exibe uma mensagem personalizada com o método Falar() da classe Pessoa
        public static void questao58()
        {
        }

        // Retorna a interseção entre dois arrays
        public static void questao59()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Falar();
        }
        public class Pessoa
        {
            public void Falar()
            {
                Console.WriteLine("Olá! Eu sou Maria do Rosário.");
            }
        }
        // Converte uma string para maiúsculas e minúsculas alternadas
        public static void questao60()
        {

        }

        // Retorna o número de caracteres únicos em uma string
        public static void questao61()
        {

        }

        // Exibe os números primos até um valor fornecido
        public static void questao62()
        {

        }

        // Verifica se um número é perfeito
        public static void questao63()
        {

        }

        // Exibe os divisores de um número
        public static void questao64()
        {
        }

        // Calcula a transposta de uma matriz
        public static void questao65()
        {
        }

        // Exibe o horário atual continuamente até ser encerrado
        public static void questao66()
        {

        }

        // Simula uma calculadora simples (+, -, *, /)
        public static void questao67()
        {
            Console.Write("\n1-Multiplicar  2-Dividir\n3-Somar        4-Subtrair\n\nEscolha o número da operação que deseja fazer: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {num1 * num2}");
            } else if (num == 2)
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {num1 / num2}");
            } else if (num == 3)
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {num1 + num2}");
            } else if (num == 4)
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {num1 - num2}");
            }
        }

        // Converte valores monetários para extenso
        public static void questao68()
        {
        }

        // Calcula a média ponderada de notas
        public static void questao69()
        {
            Console.WriteLine("\nMédia poderada de 3 notas");
            Console.Write("\nDigite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o peso da primeira nota:");
            int peso1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o peso da segunda nota:");
            int peso2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota:");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite o peso da terceira nota:");
            int peso3 = int.Parse(Console.ReadLine());

            double mp = (nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3);
            double mpfinal = mp / (peso1 + peso2 + peso3);

            Console.WriteLine($"\nA média poderada das notas é: {mpfinal:F1}");
        }

        // Simula um caixa eletrônico para saques
        public static void questao70()
        {
        }

        // Verifica se dois arrays são iguais (mesmos elementos e mesma ordem)
        public static void questao71()
        {
        }

        // Gera uma senha aleatória com letras e números
        public static void questao72()
        {
            Console.Write("\nDigite o comprimento da senha: ");
            int comprimento = int.Parse(Console.ReadLine());
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder senha = new StringBuilder(comprimento);
            Random random = new Random();

            for (int i = 0; i < comprimento; i++)
            {
                int index = random.Next(caracteres.Length);
                senha.Append(caracteres[index]);
            }

            Console.WriteLine($"\nSenha gerada: {senha}");
        }
    

        // Gera uma tabela de multiplicação
        public static void questao73()
        {
            Console.Write("\nDigite um número para a tabuada: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        // Calcula a área de um triângulo com base em três lados
        public static void questao74()
        {
            Console.Write("\nDigite o primeiro lado do triangulo");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo lado do triangulo");
            int l2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro lado do triangulo");
            int l3 = int.Parse(Console.ReadLine());

            int p = (l1 + l2 + l3)/2;
            double Area = Math.Sqrt(p * (p - l1) * (p - l2) * (p - l3));
            Console.WriteLine($"\nA área do triangulo é igual a {Area:F2}");

        }

        // Gera números aleatórios únicos entre 1 e N
        public static void questao75()
        {
            Console.Write("\nDigite um valor para N: ");
            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            Random nAleatorio = new Random();
            int num = nAleatorio.Next(1,N);
            
            Console.WriteLine($"\nNúmeros aleátorios entre 0 e {N}");
            for (int i = 0; i < num;)
            {
                int quant = nAleatorio.Next(1, N+1);
                if (!list.Contains(quant))
                {
                    list.Add(quant);
                    Console.WriteLine(quant);
                    i++;
                }
            }
        }
    }
}
