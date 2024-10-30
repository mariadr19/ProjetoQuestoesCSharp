using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp
{
    public class MetodQuestBasic
    {
        // Classe Produto: modelo pra instanciar um objeto que representa um produto com nome e preço (Questão 1)
        public class Produto
        {
            public string Nome { get; set; }
            public int Preço { get; set; }

            public Produto(string nome, int preco)
            {
                Nome = nome;
                Preço = preco;
            }
        }

        // Questão 2: Instancie um objeto da classe Produto e exiba seus valores.
        public static void questao2()
        {
            Console.WriteLine("\nPara instanciar um objeto da classe Produto, digite o nome e o preço de um produto de sua preferência");
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            int preco = int.Parse(Console.ReadLine());

            Produto prod = new Produto(nome, preco);
            Console.WriteLine($"\nNome: {nome}\nPreço: ${preco},00");
        }

        // Questão 3: Crie um método que soma dois números inteiros e exibe o resultado.
        public static void questao3()
        {
            Console.WriteLine("\nDigite 2 números que gostaria de somar");
            Console.Write("\nPrimeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 + num2;
            Console.WriteLine($"\nO resultado da soma é: {resultado}");
        }

        // Questão 4: Escreva uma função que verifica se um número é par ou ímpar.
        public static void questao4()
        {
            Console.Write("\nInsira um número que deseja verificar: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"\nO número {num} é par.");
            }
            else
            {
                Console.WriteLine($"\nO número {num} é ímpar.");
            }
        }

        // Questão 5: Implemente um método que converte um valor em metros para centímetros.
        public static void questao5()
        {
            Console.Write("\nDigite o valor em metros: ");
            int num = int.Parse(Console.ReadLine());
            int resultado = num * 100;
            Console.WriteLine($"\n{num} metros é igual a {resultado} centímetros.");
        }

        // Questão 6: Crie um programa que recebe a idade e verifica se a pessoa é maior de idade.
        public static void questao6()
        {
            Console.Write("\nDigite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("\nVocê é maior de idade.");
            }
            else
            {
                Console.WriteLine("\nVocê é menor de idade.");
            }
        }

        // Questão 7: Escreva um método que calcula a área de um círculo com base no raio fornecido.
        public static void questao7()
        {
            Console.Write("\nDigite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());
            double area = 3.14 * (raio * raio);
            Console.WriteLine($"\nA área do círculo é {area}.");
        }

        // Questão 8: Crie um programa que exibe a tabuada de um número fornecido.
        public static void questao8()
        {
            Console.Write("\nDigite um número para a tabuada: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        // Questão 9: Desenvolva um método que soma todos os números de 1 a N.
        public static void questao9()
        {
            Console.Write("\nDigite um valor para N: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                soma += i;
            }
            Console.WriteLine($"\nA soma dos números de 1 a {n} é {soma}.");
        }

        // Questão 10: Implemente uma função que converte temperatura de Celsius para Fahrenheit.
        public static void questao10()
        {
            Console.Write("\nDigite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine($"\nA temperatura em Fahrenheit é: {fahrenheit}°F");
        }

        // Questão 11: Crie uma função que verifica se uma string é vazia ou nula.
        public static void questao11()
        {
            Console.Write("\nDigite uma palavra: ");
            string palavra = Console.ReadLine();
            if (palavra == null || palavra == "")
            {
                Console.WriteLine("\nA palavra está vazia ou é nula.");
            }
            else
            {
                Console.WriteLine("\nA palavra não está vazia e nem é nula.");
            }
        }

        // Questão 12: Crie uma função que exibe todos os números pares entre 1 e 50.
        public static void questao12()
        {
            Console.WriteLine("\nNúmeros pares entre 1 e 50:");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Questão 13: Implemente uma função que recebe três números e retorna o maior deles.
        public static void questao13()
        {
            Console.Write("\nDigite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = num1;
            if (maior < num2)
            {
                maior = num2;
            }
            if (maior < num3)
            {
                maior = num3;
            }
            Console.WriteLine($"\nO maior número é: {maior}");
        }

        // Questão 14: Crie um programa que inverte uma string.
        public static void questao14()
        {
            Console.Write("\nDigite a string que deseja inverter: ");
            string s = Console.ReadLine();
            char[] nArray = s.ToCharArray();
            Array.Reverse(nArray);
            string inverter = new string(nArray);
            Console.WriteLine($"String invertida: {inverter}\n");
        }

        // Questão 15: Desenvolva uma função que verifica se uma pessoa pode votar, dado o ano de nascimento.
        public static void questao15()
        {
            Console.Write("\nDigite o ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano em que estamos: ");
            int anoAtual = int.Parse(Console.ReadLine());
            int idade = anoAtual - ano;

            if (idade >= 16)
            {
                Console.WriteLine("\nVocê pode votar.");
            }
            else
            {
                Console.WriteLine("\nVocê ainda não pode votar.");
            }
        }

        // Questão 16: Crie uma função que verifica se um número é positivo ou negativo.
        public static void questao16()
        {
            Console.Write("\nDigite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("\nO número é positivo.");
            }
            else if (num < 0)
            {
                Console.WriteLine("\nO número é negativo.");
            }
            else
            {
                Console.WriteLine("\nO número é zero.");
            }
        }

        // Questão 17: Implemente um programa que calcula a média de três notas e exibe a situação (Aprovado/Reprovado).
        public static void questao17()
        {
            Console.Write("\nDigite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine($"\nAprovado com média {media:F2}");
            }
            else
            {
                Console.WriteLine($"\nReprovado com média {media:F2}");
            }
        }
        // Questão 18: Escreva uma função que conta quantas letras 'a' existem em uma string.
        public static void questao18()
        {
            Console.Write("\nDigite uma palavra: ");
            string palavra = Console.ReadLine();
            palavra = palavra.ToLower();
            int contagem = palavra.Count(c => c == 'a');
            Console.WriteLine($"\nA string contém {contagem} letras 'a'.");
        }

        // Questão 19: Crie um programa que imprime números de 1 a 10 em ordem decrescente.
        public static void questao19()
        {
            Console.WriteLine("\nNúmeros de 1 a 10 em ordem decrescente:");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Questão 20: Implemente uma função que calcula a soma dos quadrados dos números de 1 a N.
        public static void questao20()
        {
            Console.Write("\nDigite um valor para N: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                soma += i * i;
            }
            Console.WriteLine($"\nA soma dos quadrados dos números de 1 a {n} é {soma}.");
        }

        // Questão 21: Crie uma função que recebe o nome e a idade de uma pessoa e exibe uma mensagem de boas-vindas.
        public static void questao21()
        {
            Console.Write("\nDigite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nBoas-vindas, {nome}! Você tem {idade} anos.");
        }

        // Questão 22: Escreva um programa que recebe um número e exibe seu dobro e triplo.
        public static void questao22()
        {
            Console.Write("\nDigite um número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nO dobro de {num} é {num * 2} e o triplo é {num * 3}.");
        }

        // Questão 23: Crie uma função que retorna o último caractere de uma string fornecida.
        public static void questao23()
        {
            Console.WriteLine("\nDigite uma palavra: ");
            string nome = Console.ReadLine();
            var ultimo = nome[nome.Length - 1];
            Console.WriteLine($"\nO último caractere de {nome} é {ultimo}");
        }

        // Questão 24: Implemente uma função que converte horas em segundos.
        public static void questao24()
        {
            Console.Write("\nDigite a quantidade de horas: ");
            int horas = int.Parse(Console.ReadLine());
            int segundos = horas * 3600;
            Console.WriteLine($"{horas} horas equivalem a {segundos} segundos.");
        }

        // Questão 25: Crie uma função que verifica se um número é divisível por 3 e por 5.
        public static void questao25()
        {
            Console.Write("\nDigite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine($"\nO número {num} é divisível por 3 e por 5.");
            }
            else 
            {
                Console.WriteLine($"\nO número {num} não é divisível por 3 e por 5.");
            }
        }
    }
}
