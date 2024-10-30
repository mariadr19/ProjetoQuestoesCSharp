using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp
{
    public class MetodQuestInter
    {
        // Questão 26: Crie uma função que ordena três números fornecidos.
        public static void questao26()
        {
            Console.Write("\nDigite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            int[] numeros = { num1, num2, num3 };
            Array.Sort(numeros);
            Console.WriteLine($"\nNúmeros ordenados: {numeros[0]}, {numeros[1]}, {numeros[2]}");
        }

        // Questão 27: Desenvolva um programa que calcula o fatorial de um número.
        public static void Questao27()
        {
            Console.Write("\nDigite um número para calcular seu fatorial: ");
            int num = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= num; i++)
            {
                fatorial *= i;
            }
            Console.WriteLine($"\n{num} fatorial = {fatorial}");
        }

        // Questão 28: Crie uma classe Aluno com propriedades Nome e Nota. Implemente um método para exibir esses valores.
        public class Aluno
        {
            public string Nome { get; set; }
            public double Nota { get; set; }

            public Aluno(string nome, double nota)
            {
                Nome = nome;
                Nota = nota;
            }
            public void Exibir()
            {
                Console.WriteLine($"Nome: {Nome}, Nota: {Nota}");
            }
        }

        public static void Questao28()
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, nota);
            aluno.Exibir();
        }

        // Questão 29: Implemente um método que calcula a média de uma lista de números.
        public static void questao29()
        {
            Console.Write("\nDigite quantos números você que adicionar a lista: ");
            int num = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int soma = 0;
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"Digite o {i}° número: ");
                int Num = int.Parse(Console.ReadLine());
                list.Add(Num);
                soma += Num;
            }
            double media = soma / num;
            Console.WriteLine($"\nA média é {media}");
        }

        // Questão 30: Crie um programa que verifica se uma palavra é um palíndromo.
        public static void questao30()
        {
            Console.WriteLine("\nDigite uma palavra: ");
            string palavra = Console.ReadLine();
            char[] palavraInvertida = palavra.ToCharArray();
            Array.Reverse(palavraInvertida);
            string palavraNova = new string(palavraInvertida);

            if (palavra.ToLower() == palavraNova.ToLower())
            {
                Console.WriteLine($"A palavra {palavra} é um palíndromo");
            }
            else
            {
                Console.WriteLine($"A palavra {palavra} não é um palíndromo");
            }
        }

        // Questão 31: Implemente uma função que encontra o menor número em um array.
        public static void questao31()
        {
            Console.Write("\nQuantos números deseja adicionar ao array: ");
            int num = int.Parse(Console.ReadLine());
            List<int> array = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"Adicione o {i}° número: ");
                int num1 = int.Parse(Console.ReadLine());
                array.Add(num1);
            }
            array.Sort();
            int menor = array.Find(c => c > 0);
            Console.WriteLine(menor);
        }

        // Questão 32: Crie uma função que multiplica todos os elementos de um array por um valor fornecido.
        public static void questao32()
        {
            Console.Write("\nDefina até qual número vai a lista: ");
            int nMax = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor que irá multiplicar os números da lista: ");
            int nMult = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nLista dos números de 0 a {nMax} multiplicados por {nMult}");
            for (int i = 0; i < nMax; i++)
            {
                Console.WriteLine(nMax + " x " + nMult + " = " + i * nMult);
            }
        }

        // Questão 33: Desenvolva uma função que retorna a soma dos números ímpares em um array.
        public static void questao33()
        {
            Console.Write("\nDefina até que número irá a lista: ");
            int nMax = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= nMax; i += 2)
            {
                soma += i;
            }
            Console.WriteLine($"\nA soma dos números ímpares entre 0 e {nMax} é {soma}");
        }

        // Questão 34: Crie uma classe Carro com propriedades Marca e Ano.
        public class Carro
        {
            public string Marca { get; set; }
            public int Ano { get; set; }

            public Carro(string marca, int ano)
            {
                Marca = marca;
                Ano = ano;
            }
            public void ExibirDados()
            {
                Console.WriteLine($"Marca: {Marca}, Ano: {Ano}");
            }
        }
        public static void questao34()
        {
            Console.Write("Digite a marca do carro: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o ano do carro: ");
            int ano = int.Parse(Console.ReadLine());

            Carro carro = new Carro(marca, ano);
            carro.ExibirDados();
        }

        // Questão 35: Implemente um método para verificar se um ano é bissexto.
        public static void questao35()
        {
            Console.WriteLine("\nDigite o ano que deseja verificar:");
            int ano = int.Parse(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine($"O ano {ano} é bissexto");
            }
            else
            {
                Console.WriteLine($"O ano {ano} não é bissexto");
            }
        }

        // Questão 36: Exibir os 10 primeiros números da sequência de Fibonacci
        public static void questao36()
        {
            int num1 = 0;
            int num2 = 1;
            int proximo;

            Console.WriteLine("Os 10 primeiros números da sequência de Fibonacci:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(num1+" ");
                proximo = num1 + num2;
                num1 = num2;
                num2 = proximo;
            }
            Console.WriteLine();
        }

        // Questão 37: Substituir espaços em uma string por '_'
        public static void questao37()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            string nFrase = frase.Replace(" ", "_");
            Console.WriteLine($"Frase alterada: {nFrase}");
        }

        // Questão 38: Retornar o índice do maior elemento de um array
        public static void questao38()
        {
            List<int> list = new List<int>();
            Console.Write("Digite quantos números deseja inserir: ");
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"Adicione o {i}° número: ");
                int num1 = int.Parse(Console.ReadLine());
                list.Add(num1);
                
            }
            list.Sort();
            list.Reverse();
            int maior = list.Find(c => c > 0);
            Console.WriteLine($"\nO index do número {maior} é {num-1}");
        }

        // Questão 39: Calcular o MDC entre dois números
        public static void questao39()
        {
            Console.Write("\nDigite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Informe o primeiro número: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nO Máximo Divisor Comum de {x} e  {y}  é  {MDC(x, y)}");
        }
        public static int MDC(int a, int b)
        {
            int resto;

            while (b != 0)
            {
                resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        // Questão 40: Retornar o número de vogais em uma string
        public static void questao40()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            int quant = 0;

            foreach (var p in palavra.ToLower())
            {
                if ("aeiou".Contains(p))
                {
                    quant++;
                }
            }
            Console.WriteLine($"\nA string contém {quant} vogais.");
        }

        // Questão 41: Converter um número decimal para binário
        public static void questao41()
        {
            Console.Write("\nDigite o número que deseja converter: ");
            int num = int.Parse(Console.ReadLine());
            string numBin = Convert.ToString(num, 2);

            Console.WriteLine($"\nNúmero {num} em binário é: {numBin} ");
        }


        // Questão 42: Exibir a representação em palavras de um número
        public static void questao42()
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("0 - Sair");
                Console.Write("Digite um número entre 1 e 9: ");

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.Write("Um");
                        break;
                    case "2":
                        Console.Write("Dois");
                        break;
                    case "3":
                        Console.Write("Três");
                        break;
                    case "4":
                        Console.Write("Quatro");
                        break;
                    case "5":
                        Console.Write("Cinco");
                        break;
                    case "6":
                        Console.Write("Seis");
                        break;
                    case "7":
                        Console.Write("Sete");
                        break;
                    case "8:":
                        Console.Write("Oito");
                        break;
                    case "9":
                        Console.Write("Nove");
                        break;
                    case "0":
                        sair = true;
                        break;
                }
            }
        }

        // Questão 43: Simular o lançamento de um dado 100 vezes
        public static void questao43()
        {
            Console.WriteLine("\nSimulando o lancamento de um dado 100 vezes");
            Random dado = new Random();
            
            for (int i = 0; i < 100;)
            {
                int lanc = dado.Next(1, 7);
                Console.WriteLine(lanc);
                i++;
            }
        }

        // Questão 44: Calcular o IMC e determinar a categoria
        public static void questao44()
        {
            Console.Write("Digite seu peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura (m): ");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);
            string categoria;

            if (imc < 18.5)
            { 
                categoria = "Abaixo do peso"; 
            } 
            else if (imc < 24.9)
            {
                categoria = "Peso normal";      
            }  
            else if (imc < 29.9)
            {
                categoria = "Sobrepeso";
            }
            else
            {
                categoria = "Obesidade";
            }
                

            Console.WriteLine($"Seu IMC é: {imc:F2}, Categoria: {categoria}");
        }

        // Questão 45: Encontrar o segundo maior número em um array
        public static void questao45()
        {
            List<int> n = new List<int>();
            Console.Write("\nQuantos números deseja adicionar ao array: ");
            int num = int.Parse(Console.ReadLine());
            int segMaior;
            for (int i = 1; i <= num;i++)
            {
                Console.Write($"Digite o {i}° número");
                int num1 = int.Parse(Console.ReadLine());
                n.Add(num1);
            }
            n.Sort();
            n.Reverse();
            int maior = n.Find(c => c > 0);
            segMaior = n.Find(c => c < maior);

            Console.WriteLine($"\nO segundo maior número é {segMaior}");
        }

        // Questão 46: Inverter os elementos de um array
        public static void questao46()
        {
            Console.Write("\nDigite algo que deseja inverter: ");
            string s = Console.ReadLine();
            char[] st = s.ToCharArray();
            Array.Reverse(st);
            string palavraNova = new string(st);
            Console.WriteLine($"\nArray invertido: {palavraNova}");
        }

        // Função que soma duas matrizes 2x2
        public static void questao47()
        {
            int[,] matriz1 = new int[2, 2];
            int[,] matriz2 = new int[2, 2];
            int[,] resultado = new int[2, 2];

            Console.WriteLine("Digite os elementos da primeira matriz 2x2:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os elementos da segunda matriz 2x2:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("Resultado da soma das matrizes:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(resultado[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Função que recebe uma data e exibe o dia da semana correspondente.
        public static void questao48()
        {
            Console.Write("\nDigite o dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o ano: ");
            int ano = int.Parse(Console.ReadLine());
            DateTime data = new DateTime(ano,mes,dia);
            string diaSemana = diaDaSemana(data);
            Console.WriteLine($"\nO dia da semana para {data.ToShortDateString()} é {diaSemana}.");
        }
        public static string diaDaSemana(DateTime data)
        {
            return data.ToString("dddd");
        }

        // Verificar se uma string contém apenas letras e números
        public static void questao49()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            bool apenasLetrasNumeros = palavra.All(char.IsLetterOrDigit);

            if (apenasLetrasNumeros)
            {
                Console.WriteLine("A string contém apenas letras e números.");
            }
            else
            {
                Console.WriteLine("A string contém caracteres não permitidos.");
            }

        }

        // Calcula o valor de uma potência sem usar Math.Pow()
        public static void questao50()
        {
            Console.Write("Digite a base: ");
            double baseN = double.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int exp = int.Parse(Console.ReadLine());
            double resultado = 1;

            if (exp > 0)
            {
                for (int i = 1; i <= exp; i++)
                {
                    resultado *= baseN;
                }
            }

            if (exp < 0)
            {
                for (int i = -1; i >= exp; --i)
                {
                    resultado /= baseN;
                }
            }

            Console.WriteLine($"O resultado de {baseN} ^ {exp} é: {resultado}");

        }
    }
}

