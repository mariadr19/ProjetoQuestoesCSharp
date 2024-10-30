using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Nível Básico");
                Console.WriteLine("2 - Nível Intermediário");
                Console.WriteLine("3 - Nível Intermediário-Avançado");
                Console.WriteLine("4 - Nível Avançado");
                Console.Write("\nEscolha uma opção: ");

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        questoesBasicas();
                        break;
                    case "2":
                        Console.Clear();
                        questoesIntermediarias();
                        break;
                    case "3":
                        Console.Clear();
                        questoesIntermediariasAvançadas();
                        break;
                    case "4":
                        Console.Clear();
                        questoesAvançadas();
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("\nOPÇÃO INVALIDA!!");
                        Console.Write("\nPressione ENTER para escolher novamente.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void questoesBasicas()
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("\nMenu de Questões");
                Console.WriteLine("0 -  Menu anterior");
                Console.WriteLine("1. Crie uma classe Produto com propriedades Nome e Preco.");
                Console.WriteLine("2. Instancie um objeto da classe Produto e exiba seus valores.");
                Console.WriteLine("3. Crie um método que soma dois números inteiros e exibe o resultado.");
                Console.WriteLine("4. Escreva uma função que verifica se um número é par ou ímpar.");
                Console.WriteLine("5. Implemente um método que converte um valor em metros para centímetros.");
                Console.WriteLine("6. Crie um programa que recebe a idade e verifica se a pessoa é maior de idade.");
                Console.WriteLine("7. Escreva um método que calcula a área de um círculo com base no raio fornecido.");
                Console.WriteLine("8. Crie um programa que exibe a tabuada de um número fornecido.");
                Console.WriteLine("9. Desenvolva um método que soma todos os números de 1 a N.");
                Console.WriteLine("10. Implemente uma função que converte temperatura de Celsius para Fahrenheit.");
                Console.WriteLine("11. Crie uma função que verifica se uma string é vazia ou nula.");
                Console.WriteLine("12. Crie uma função que exibe todos os números pares entre 1 e 50.");
                Console.WriteLine("13. Implemente uma função que recebe três números e retorna o maior deles.");
                Console.WriteLine("14. Crie um programa que inverte uma string.");
                Console.WriteLine("15. Desenvolva uma função que verifica se uma pessoa pode votar, dado o ano de nascimento.");
                Console.WriteLine("16. Crie uma função que verifica se um número é positivo ou negativo.");
                Console.WriteLine("17. Implemente um programa que calcula a média de três notas e exibe a situação (Aprovado/Reprovado).");
                Console.WriteLine("18. Escreva uma função que conta quantas letras 'a' existem em uma string.");
                Console.WriteLine("19. Crie um programa que imprime números de 1 a 10 em ordem decrescente.");
                Console.WriteLine("20. Implemente uma função que calcula a soma dos quadrados dos números de 1 a N.");
                Console.WriteLine("21. Crie uma função que recebe o nome e a idade de uma pessoa e exibe uma mensagem de boas-vindas.");
                Console.WriteLine("22. Escreva um programa que recebe um número e exibe seu dobro e triplo.");
                Console.WriteLine("23. Crie uma função que retorna o último caractere de uma string fornecida.");
                Console.WriteLine("24. Implemente uma função que converte horas em segundos.");
                Console.WriteLine("25. Crie uma função que verifica se um número é divisível por 3 e por 5.");

                Console.Write("\nDigite o número da questão: ");

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0":
                        sair = true;
                        break;

                    case "1":
                        //Classe criada anteriormente entre a linha 12 e 22 do arquivo MetodQuestBasic
                        Console.Clear();
                        Console.WriteLine("Questão 1: Crie uma classe Produto com propriedades Nome e Preco.");
                        Console.WriteLine("\nClasse criada com sucesso, para confirmar retorne ao código e verifique entre as linhas 12 e 22 do arquivo MetodQuestBasic.");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Questão 2: Instancie um objeto da classe Produto e exiba seus valores.");
                        MetodQuestBasic.questao2();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Questão 3: Crie um método que soma dois números inteiros e exibe o resultado.");
                        MetodQuestBasic.questao3();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Questão 4: Escreva uma função que verifica se um número é par ou ímpar.");
                        MetodQuestBasic.questao4();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Questão 5: Implemente um método que converte um valor em metros para centímetros.");
                        MetodQuestBasic.questao5();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Questão 6: Crie um programa que recebe a idade e verifica se a pessoa é maior de idade.");
                        MetodQuestBasic.questao6();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Questão 7: Escreva um método que calcula a área de um círculo com base no raio fornecido.");
                        MetodQuestBasic.questao7();
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("Questão 8: Crie um programa que exibe a tabuada de um número fornecido.");
                        MetodQuestBasic.questao8();
                        break;

                    case "9":
                        Console.Clear();
                        Console.WriteLine("Questão 9: Desenvolva um método que soma todos os números de 1 a N.");
                        MetodQuestBasic.questao9();
                        break;

                    case "10":
                        Console.Clear();
                        Console.WriteLine("Questão 10: Implemente uma função que converte temperatura de Celsius para Fahrenheit.");
                        MetodQuestBasic.questao10();
                        break;

                    case "11":
                        Console.Clear();
                        Console.WriteLine("Questão 11: Crie uma função que verifica se uma string é vazia ou nula.");
                        MetodQuestBasic.questao11();
                        break;

                    case "12":
                        Console.Clear();
                        Console.WriteLine("Questão 12: Crie uma função que exibe todos os números pares entre 1 e 50.");
                        MetodQuestBasic.questao12();
                        break;

                    case "13":
                        Console.Clear();
                        Console.WriteLine("Questão 13: Implemente uma função que recebe três números e retorna o maior deles.");
                        MetodQuestBasic.questao13();
                        break;

                    case "14":
                        Console.Clear();
                        Console.WriteLine("Questão 14: Crie um programa que inverte uma string.");
                        MetodQuestBasic.questao14();
                        break;

                    case "15":
                        Console.Clear();
                        Console.WriteLine("Questão 15: Desenvolva uma função que verifica se uma pessoa pode votar, dado o ano de nascimento.");
                        MetodQuestBasic.questao15();
                        break;

                    case "16":
                        Console.Clear();
                        Console.WriteLine("Questão 16: Crie uma função que verifica se um número é positivo ou negativo.");
                        MetodQuestBasic.questao16();
                        break;

                    case "17":
                        Console.Clear();
                        Console.WriteLine("Questão 17: Implemente um programa que calcula a média de três notas e exibe a situação (Aprovado/Reprovado).");
                        MetodQuestBasic.questao17();
                        break;

                    case "18":
                        Console.Clear();
                        Console.WriteLine("Questão 18: Escreva uma função que conta quantas letras 'a' existem em uma string.");
                        MetodQuestBasic.questao18();
                        break;

                    case "19":
                        Console.Clear();
                        Console.WriteLine("Questão 19: Crie um programa que imprime números de 1 a 10 em ordem decrescente.");
                        MetodQuestBasic.questao19();
                        break;

                    case "20":
                        Console.Clear();
                        Console.WriteLine("Questão 20: Implemente uma função que calcula a soma dos quadrados dos números de 1 a N.");
                        MetodQuestBasic.questao20();
                        break;

                    case "21":
                        Console.Clear();
                        Console.WriteLine("Questão 21: Crie uma função que recebe o nome e a idade de uma pessoa e exibe uma mensagem de boas-vindas.");
                        MetodQuestBasic.questao21();
                        break;

                    case "22":
                        Console.Clear();
                        Console.WriteLine("Questão 22: Escreva um programa que recebe um número e exibe seu dobro e triplo.");
                        MetodQuestBasic.questao22();
                        break;

                    case "23":
                        Console.Clear();
                        Console.WriteLine("Questão 23: Crie uma função que retorna o último caractere de uma string fornecida.");
                        MetodQuestBasic.questao23();
                        break;

                    case "24":
                        Console.Clear();
                        Console.WriteLine("Questão 24: Implemente uma função que converte horas em segundos.");
                        MetodQuestBasic.questao24();
                        break;

                    case "25":
                        Console.Clear();
                        Console.WriteLine("Questão 25: Crie uma função que verifica se um número é divisível por 3 e por 5.");
                        MetodQuestBasic.questao25();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
                if (!sair)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                }
            }
        }

        static void questoesIntermediarias()
        {
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("\nMenu de Questões Intermediárias");
                Console.WriteLine("0 - Menu anterior");
                Console.WriteLine("26. Crie uma função que ordena três números fornecidos.");
                Console.WriteLine("27. Desenvolva um programa que calcula o fatorial de um número.");
                Console.WriteLine("28. Crie uma classe Aluno com propriedades Nome e Nota. Implemente um método para exibir esses valores.");
                Console.WriteLine("29. Implemente um método que calcula a média de uma lista de números.");
                Console.WriteLine("30. Crie um programa que verifica se uma palavra é um palíndromo.");
                Console.WriteLine("31. Implemente uma função que encontra o menor número em um array.");
                Console.WriteLine("32. Crie uma função que multiplica todos os elementos de um array por um valor fornecido.");
                Console.WriteLine("33. Desenvolva uma função que retorna a soma dos números ímpares em um array.");
                Console.WriteLine("34. Crie uma classe Carro com propriedades Marca e Ano.");
                Console.WriteLine("35. Implemente um método para verificar se um ano é bissexto.");
                Console.WriteLine("36. Crie uma função que exibe os 10 primeiros números da sequência de Fibonacci.");
                Console.WriteLine("37. Desenvolva um programa que recebe uma string e substitui todos os espaços por '_'.");
                Console.WriteLine("38. Crie uma função que retorna o índice do maior elemento de um array.");
                Console.WriteLine("39. Implemente uma função que calcula o MDC (Máximo Divisor Comum) entre dois números.");
                Console.WriteLine("40. Desenvolva uma função que retorna o número de vogais em uma string.");
                Console.WriteLine("41. Crie uma função que converte um número decimal para binário.");
                Console.WriteLine("42. Implemente uma função que recebe um número e exibe sua representação em palavras.");
                Console.WriteLine("43. Crie um programa que simula o lançamento de um dado 100 vezes e exibe a frequência de cada valor.");
                Console.WriteLine("44. Desenvolva uma função que calcula o IMC e determina a categoria (baixo peso, normal, etc.).");
                Console.WriteLine("45. Crie uma função que encontra o segundo maior número em um array.");
                Console.WriteLine("46. Implemente um programa que inverte os elementos de um array.");
                Console.WriteLine("47. Crie uma função que soma duas matrizes 2x2.");
                Console.WriteLine("48. Desenvolva uma função que recebe uma data e exibe o dia da semana correspondente.");
                Console.WriteLine("49. Crie um programa que verifica se uma string contém apenas letras e números.");
                Console.WriteLine("50. Implemente uma função que calcula o valor de uma potência sem usar Math.Pow().");

                Console.Write("\nDigite o número da questão: ");

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0":
                        sair = true;
                        break;

                    case "26":
                        Console.Clear();
                        Console.WriteLine("Questão 26: Crie uma função que ordena três números fornecidos.");
                        MetodQuestInter.questao26();
                        break;

                    case "27":
                        Console.Clear();
                        Console.WriteLine("Questão 27: Desenvolva um programa que calcula o fatorial de um número.");
                        MetodQuestInter.Questao27();
                        break;

                    case "28":
                        Console.Clear();
                        Console.WriteLine("Questão 28: Crie uma classe Aluno com propriedades Nome e Nota. Implemente um método para exibir esses valores.");
                        MetodQuestInter.Questao28();
                        break;

                    case "29":
                        Console.Clear();
                        Console.WriteLine("Questão 29: Implemente um método que calcula a média de uma lista de números.");
                        MetodQuestInter.questao29();
                        break;

                    case "30":
                        Console.Clear();
                        Console.WriteLine("Questão 30: Crie um programa que verifica se uma palavra é um palíndromo.");
                        MetodQuestInter.questao30();
                        break;

                    case "31":
                        Console.Clear();
                        Console.WriteLine("Questão 31: Implemente uma função que encontra o menor número em um array.");
                        MetodQuestInter.questao31();
                        break;

                    case "32":
                        Console.Clear();
                        Console.WriteLine("Questão 32: Crie uma função que multiplica todos os elementos de um array por um valor fornecido.");
                        MetodQuestInter.questao32();
                        break;

                    case "33":
                        Console.Clear();
                        Console.WriteLine("Questão 33: Desenvolva uma função que retorna a soma dos números ímpares em um array.");
                        MetodQuestInter.questao33();
                        break;

                    case "34":
                        Console.Clear();
                        Console.WriteLine("Questão 34: Crie uma classe Carro com propriedades Marca e Ano.");
                        MetodQuestInter.questao34();
                        break;

                    case "35":
                        Console.Clear();
                        Console.WriteLine("Questão 35: Implemente um método para verificar se um ano é bissexto.");
                        MetodQuestInter.questao35();
                        break;

                    case "36":
                        Console.Clear();
                        Console.WriteLine("Questão 36: Crie uma função que exibe os 10 primeiros números da sequência de Fibonacci.");
                        MetodQuestInter.questao36();
                        break;

                    case "37":
                        Console.Clear();
                        Console.WriteLine("Questão 37: Desenvolva um programa que recebe uma string e substitui todos os espaços por '_'.");
                        MetodQuestInter.questao37();
                        break;

                    case "38":
                        Console.Clear();
                        Console.WriteLine("Questão 38: Crie uma função que retorna o índice do maior elemento de um array.");
                        MetodQuestInter.questao38();
                        break;

                    case "39":
                        Console.Clear();
                        Console.WriteLine("Questão 39: Implemente uma função que calcula o MDC (Máximo Divisor Comum) entre dois números.");
                        MetodQuestInter.questao39();
                        break;

                    case "40":
                        Console.Clear();
                        Console.WriteLine("Questão 40: Desenvolva uma função que retorna o número de vogais em uma string.");
                        MetodQuestInter.questao40();
                        break;

                    case "41":
                        Console.Clear();
                        Console.WriteLine("Questão 41: Crie uma função que converte um número decimal para binário.");
                        MetodQuestInter.questao41();
                        break;

                    case "42":
                        Console.Clear();
                        Console.WriteLine("Questão 42: Implemente uma função que recebe um número e exibe sua representação em palavras.");
                        MetodQuestInter.questao42();
                        break;

                    case "43":
                        Console.Clear();
                        Console.WriteLine("Questão 43: Crie um programa que simula o lançamento de um dado 100 vezes e exibe a frequência de cada valor.");
                        MetodQuestInter.questao43();
                        break;

                    case "44":
                        Console.Clear();
                        Console.WriteLine("Questão 44: Desenvolva uma função que calcula o IMC e determina a categoria (baixo peso, normal, etc.).");
                        MetodQuestInter.questao44();
                        break;

                    case "45":
                        Console.Clear();
                        Console.WriteLine("Questão 45: Crie uma função que encontra o segundo maior número em um array.");
                        MetodQuestInter.questao45();
                        break;

                    case "46":
                        Console.Clear();
                        Console.WriteLine("Questão 46: Implemente um programa que inverte os elementos de um array.");
                        MetodQuestInter.questao46();
                        break;

                    case "47":
                        Console.Clear();
                        Console.WriteLine("Questão 47: Crie uma função que soma duas matrizes 2x2.");
                        MetodQuestInter.questao47();
                        break;

                    case "48":
                        Console.Clear();
                        Console.WriteLine("Questão 48: Desenvolva uma função que recebe uma data e exibe o dia da semana correspondente.");
                        MetodQuestInter.questao48();
                        break;

                    case "49":
                        Console.Clear();
                        Console.WriteLine("Questão 49: Crie um programa que verifica se uma string contém apenas letras e números.");
                        MetodQuestInter.questao49();
                        break;

                    case "50":
                        Console.Clear();
                        Console.WriteLine("Questão 50: Implemente uma função que calcula o valor de uma potência sem usar Math.Pow().");
                        MetodQuestInter.questao50();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
                if (!sair)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                }
            }

        }
        static void questoesIntermediariasAvançadas()
        {
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("\nMenu de Questões Intermediárias-Avançadas");
                Console.WriteLine("0 - Menu anterior");
                Console.WriteLine("51. Crie uma função que verifica se uma matriz é simétrica.");
                Console.WriteLine("52. Desenvolva um programa que ordena uma lista de nomes em ordem alfabética.");
                Console.WriteLine("53. Crie uma função que encontra o elemento mais frequente em um array.");
                Console.WriteLine("54. Implemente uma função que calcula o valor absoluto de um número sem usar Math.Abs().");
                Console.WriteLine("55. Crie um programa que implementa o algoritmo de busca linear.");
                Console.WriteLine("56. Desenvolva um programa que simula um cronômetro simples (usando Thread.Sleep).");
                Console.WriteLine("57. Implemente uma função que calcula o número de palavras em uma string.");
                Console.WriteLine("58. Crie uma classe Pessoa com método Falar() que exibe uma mensagem personalizada.");
                Console.WriteLine("59. Crie uma função que retorna a interseção entre dois arrays.");
                Console.WriteLine("60. Desenvolva uma função que converte uma string para maiúsculas e minúsculas alternadas.");
                Console.WriteLine("61. Implemente uma função que retorna o número de caracteres únicos em uma string.");
                Console.WriteLine("62. Crie um programa que exibe os números primos até um valor fornecido.");
                Console.WriteLine("63. Desenvolva uma função que verifica se um número é perfeito.");
                Console.WriteLine("64. Crie uma função que exibe os divisores de um número.");
                Console.WriteLine("65. Implemente um método para calcular a transposta de uma matriz.");
                Console.WriteLine("66. Crie um programa que exibe o horário atual continuamente (até ser encerrado).");
                Console.WriteLine("67. Desenvolva uma função que simula uma calculadora simples (+, -, *, /).");
                Console.WriteLine("68. Crie um programa que converte valores monetários para extenso.");
                Console.WriteLine("69. Implemente um método que calcula a média ponderada de notas.");
                Console.WriteLine("70. Crie um programa que simula um caixa eletrônico para saques.");
                Console.WriteLine("71. Desenvolva uma função que verifica se dois arrays são iguais (mesmos elementos e mesma ordem).");
                Console.WriteLine("72. Implemente uma função que gera uma senha aleatória com letras e números.");
                Console.WriteLine("73. Crie um programa que gera uma tabela de multiplicação.");
                Console.WriteLine("74. Desenvolva uma função que calcula a área de um triângulo com base em três lados.");
                Console.WriteLine("75. Crie uma função que gera números aleatórios únicos entre 1 e N.");
                
                Console.Write("\nDigite o número da questão: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "0":
                        sair = true;
                        break;

                    case "51":
                        Console.Clear();
                        Console.WriteLine("Questão 51: Crie uma função que verifica se uma matriz é simétrica.");
                        MetodQuestInterAvan.questao51();
                        break;

                    case "52":
                        Console.Clear();
                        Console.WriteLine("Questão 52: Desenvolva um programa que ordena uma lista de nomes em ordem alfabética.");
                        MetodQuestInterAvan.questao52();
                        break;

                    case "53":
                        Console.Clear();
                        Console.WriteLine("Questão 53: Crie uma função que encontra o elemento mais frequente em um array.");
                        MetodQuestInterAvan.questao53();
                        break;

                    case "54":
                        Console.Clear();
                        Console.WriteLine("Questão 54: Implemente uma função que calcula o valor absoluto de um número sem usar Math.Abs().");
                        MetodQuestInterAvan.questao54();
                        break;

                    case "55":
                        Console.Clear();
                        Console.WriteLine("Questão 55: Crie um programa que implementa o algoritmo de busca linear.");
                        MetodQuestInterAvan.questao55();
                        break;

                    case "56":
                        Console.Clear();
                        Console.WriteLine("Questão 56: Desenvolva um programa que simula um cronômetro simples (usando Thread.Sleep).");
                        MetodQuestInterAvan.questao56();
                        break;

                    case "57":
                        Console.Clear();
                        Console.WriteLine("Questão 57: Implemente uma função que calcula o número de palavras em uma string.");
                        MetodQuestInterAvan.questao57();
                        break;

                    case "58":
                        Console.Clear();
                        Console.WriteLine("Questão 58: Crie uma classe Pessoa com método Falar() que exibe uma mensagem personalizada.");
                        MetodQuestInterAvan.questao58();
                        break;

                    case "59":
                        Console.Clear();
                        Console.WriteLine("Questão 59: Crie uma função que retorna a interseção entre dois arrays.");
                        MetodQuestInterAvan.questao59();
                        break;

                    case "60":
                        Console.Clear();
                        Console.WriteLine("Questão 60: Desenvolva uma função que converte uma string para maiúsculas e minúsculas alternadas.");
                        MetodQuestInterAvan.questao60();
                        break;

                    case "61":
                        Console.Clear();
                        Console.WriteLine("Questão 61: Implemente uma função que retorna o número de caracteres únicos em uma string.");
                        MetodQuestInterAvan.questao61();
                        break;

                    case "62":
                        Console.Clear();
                        Console.WriteLine("Questão 62: Crie um programa que exibe os números primos até um valor fornecido.");
                        MetodQuestInterAvan.questao62();
                        break;

                    case "63":
                        Console.Clear();
                        Console.WriteLine("Questão 63: Desenvolva uma função que verifica se um número é perfeito.");
                        MetodQuestInterAvan.questao63();
                        break;

                    case "64":
                        Console.Clear();
                        Console.WriteLine("Questão 64: Crie uma função que exibe os divisores de um número.");
                        MetodQuestInterAvan.questao64();
                        break;

                    case "65":
                        Console.Clear();
                        Console.WriteLine("Questão 65: Implemente um método para calcular a transposta de uma matriz.");
                        MetodQuestInterAvan.questao65();
                        break;

                    case "66":
                        Console.Clear();
                        Console.WriteLine("Questão 66: Crie um programa que exibe o horário atual continuamente (até ser encerrado).");
                        MetodQuestInterAvan.questao66();
                        break;

                    case "67":
                        Console.Clear();
                        Console.WriteLine("Questão 67: Desenvolva uma função que simula uma calculadora simples (+, -, *, /).");
                        MetodQuestInterAvan.questao67();
                        break;

                    case "68":
                        Console.Clear();
                        Console.WriteLine("Questão 68: Crie um programa que converte valores monetários para extenso.");
                        MetodQuestInterAvan.questao68();
                        break;

                    case "69":
                        Console.Clear();
                        Console.WriteLine("Questão 69: Implemente um método que calcula a média ponderada de notas.");
                        MetodQuestInterAvan.questao69();
                        break;

                    case "70":
                        Console.Clear();
                        Console.WriteLine("Questão 70: Crie um programa que simula um caixa eletrônico para saques.");
                        MetodQuestInterAvan.questao70();
                        break;

                    case "71":
                        Console.Clear();
                        Console.WriteLine("Questão 71: Desenvolva uma função que verifica se dois arrays são iguais (mesmos elementos e mesma ordem).");
                        MetodQuestInterAvan.questao71();
                        break;

                    case "72":
                        Console.Clear();
                        Console.WriteLine("Questão 72: Implemente uma função que gera uma senha aleatória com letras e números.");
                        MetodQuestInterAvan.questao72();
                        break;

                    case "73":
                        Console.Clear();
                        Console.WriteLine("Questão 73: Crie um programa que gera uma tabela de multiplicação.");
                        MetodQuestInterAvan.questao73();
                        break;

                    case "74":
                        Console.Clear();
                        Console.WriteLine("Questão 74: Desenvolva uma função que calcula a área de um triângulo com base em três lados.");
                        MetodQuestInterAvan.questao74();
                        break;

                    case "75":
                        Console.Clear();
                        Console.WriteLine("Questão 75: Crie uma função que gera números aleatórios únicos entre 1 e N.");
                        MetodQuestInterAvan.questao75();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                if (!sair)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                }
            }
        }
        static void questoesAvançadas()
        {
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("\nMenu de Questões Avançadas");
                Console.WriteLine("0 - Menu anterior");
                Console.WriteLine("76. Crie um jogo de 'Adivinhe o Número' entre 1 e 100, dando dicas se o valor é maior ou menor.");
                Console.WriteLine("77. Implemente uma função que verifica se dois arrays possuem os mesmos elementos, independentemente da ordem.");
                Console.WriteLine("78. Crie uma função que simula uma fila de atendimento (FIFO) usando List<T>.");
                Console.WriteLine("79. Desenvolva um jogo simples de 'Pedra, Papel e Tesoura' que joga contra o computador.");
                Console.WriteLine("80. Crie um programa que calcula a soma dos dígitos de um número fornecido pelo usuário.");
                Console.WriteLine("81. Implemente uma função que encontra e exibe os números pares em uma lista.");
                Console.WriteLine("82. Desenvolva um programa que lê valores do usuário e exibe a média e o maior valor informado.");
                Console.WriteLine("83. Crie um programa que armazena 10 nomes e os exibe em ordem alfabética.");
                Console.WriteLine("84. Implemente uma função que verifica se uma string é um palíndromo (lida da mesma forma ao contrário).");
                Console.WriteLine("85. Crie um programa que gere 10 números aleatórios entre 1 e 50 e exiba o menor e o maior.");
                Console.WriteLine("86. Desenvolva uma classe ContaBancaria com métodos para depósito e saque e exiba o saldo após cada operação.");
                Console.WriteLine("87. Implemente um programa que calcula o salário líquido de um funcionário com base no salário bruto e desconto de 10%.");
                Console.WriteLine("88. Crie uma função que converte um número decimal para sua representação binária.");
                Console.WriteLine("89. Desenvolva um programa que recebe três notas e exibe se o aluno foi aprovado, considerando média >= 7.");
                Console.WriteLine("90. Implemente uma função que soma todos os elementos de uma matriz 2x2.");
                Console.WriteLine("91. Crie um programa que simula uma votação com três candidatos e exibe o vencedor ao final.");
                Console.WriteLine("92. Desenvolva um programa que verifica se um número fornecido é múltiplo de 3 e 7 ao mesmo tempo.");
                Console.WriteLine("93. Implemente um programa que calcula a distância entre dois pontos no plano cartesiano (fórmula da distância).");
                Console.WriteLine("94. Crie uma função que gera uma lista de 5 números aleatórios e os exibe em ordem crescente.");
                Console.WriteLine("95. Desenvolva uma agenda de contatos simples que permite adicionar e listar nomes e números de telefone.");
                Console.WriteLine("96. Implemente uma função que exibe todos os números primos entre 1 e 100.");
                Console.WriteLine("97. Crie um programa que recebe um número e exibe sua tabuada de multiplicação até 10.");
                Console.WriteLine("98. Desenvolva uma função que retorna o maior número em uma matriz 3x3.");
                Console.WriteLine("99. Implemente um programa que calcula a soma dos quadrados dos números de 1 a N.");
                Console.WriteLine("100. Crie um jogo simples de 'Forca' onde o usuário tenta adivinhar uma palavra em até 5 tentativas.");

                Console.Write("\nDigite o número da questão: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "76":
                        Console.Clear();
                        Console.WriteLine("Questão 76: Crie um jogo de \"Adivinhe o Número\" entre 1 e 100, dando dicas se o valor é maior ou menor.");
                        MetodQuestAvan.questao76();
                        break;

                    case "77":
                        Console.Clear();
                        Console.WriteLine("Questão 77: Implemente uma função que verifica se dois arrays possuem os mesmos elementos, independentemente da ordem.");
                        MetodQuestAvan.questao77();
                        break;

                    case "78":
                        Console.Clear();
                        Console.WriteLine("Questão 78: Crie uma função que simula uma fila de atendimento (FIFO) usando List<T>.");
                        MetodQuestAvan.questao78();
                        break;

                    case "79":
                        Console.Clear();
                        Console.WriteLine("Questão 79: Desenvolva um jogo simples de \"Pedra, Papel e Tesoura\" que joga contra o computador.");
                        MetodQuestAvan.questao79();
                        break;

                    case "80":
                        Console.Clear();
                        Console.WriteLine("Questão 80: Crie um programa que calcula a soma dos dígitos de um número fornecido pelo usuário.");
                        MetodQuestAvan.questao80();
                        break;

                    case "81":
                        Console.Clear();
                        Console.WriteLine("Questão 81: Implemente uma função que encontra e exibe os números pares em uma lista.");
                        MetodQuestAvan.questao81();
                        break;

                    case "82":
                        Console.Clear();
                        Console.WriteLine("Questão 82: Desenvolva um programa que lê valores do usuário e exibe a média e o maior valor informado.");
                        MetodQuestAvan.questao82();
                        break;

                    case "83":
                        Console.Clear();
                        Console.WriteLine("Questão 83: Crie um programa que armazena 10 nomes e os exibe em ordem alfabética.");
                        MetodQuestAvan.questao83();
                        break;

                    case "84":
                        Console.Clear();
                        Console.WriteLine("Questão 84: Implemente uma função que verifica se uma string é um palíndromo (lida da mesma forma ao contrário).");
                        MetodQuestAvan.questao84();
                        break;

                    case "85":
                        Console.Clear();
                        Console.WriteLine("Questão 85: Crie um programa que gere 10 números aleatórios entre 1 e 50 e exiba o menor e o maior.");
                        MetodQuestAvan.questao85();
                        break;

                    case "86":
                        Console.Clear();
                        Console.WriteLine("Questão 86: Desenvolva uma classe ContaBancaria com métodos para depósito e saque e exiba o saldo após cada operação.");
                        MetodQuestAvan.questao86();
                        break;

                    case "87":
                        Console.Clear();
                        Console.WriteLine("Questão 87: Implemente um programa que calcula o salário líquido de um funcionário com base no salário bruto e desconto de 10%.");
                        MetodQuestAvan.questao87();
                        break;

                    case "88":
                        Console.Clear();
                        Console.WriteLine("Questão 88: Crie uma função que converte um número decimal para sua representação binária.");
                        MetodQuestAvan.questao88();
                        break;

                    case "89":
                        Console.Clear();
                        Console.WriteLine("Questão 89: Desenvolva um programa que recebe três notas e exibe se o aluno foi aprovado, considerando média >= 7.");
                        MetodQuestAvan.questao89();
                        break;

                    case "90":
                        Console.Clear();
                        Console.WriteLine("Questão 90: Implemente uma função que soma todos os elementos de uma matriz 2x2.");
                        MetodQuestAvan.questao90();
                        break;

                    case "91":
                        Console.Clear();
                        Console.WriteLine("Questão 91: Crie um programa que simula uma votação com três candidatos e exibe o vencedor ao final.");
                        MetodQuestAvan.questao91();
                        break;

                    case "92":
                        Console.Clear();
                        Console.WriteLine("Questão 92: Desenvolva um programa que verifica se um número fornecido é múltiplo de 3 e 7 ao mesmo tempo.");
                        MetodQuestAvan.questao92();
                        break;

                    case "93":
                        Console.Clear();
                        Console.WriteLine("Questão 93: Implemente um programa que calcula a distância entre dois pontos no plano cartesiano (fórmula da distância).");
                        MetodQuestAvan.questao93();
                        break;

                    case "94":
                        Console.Clear();
                        Console.WriteLine("Questão 94: Crie uma função que gera uma lista de 5 números aleatórios e os exibe em ordem crescente.");
                        MetodQuestAvan.questao94();
                        break;

                    case "95":
                        Console.Clear();
                        Console.WriteLine("Questão 95: Desenvolva uma agenda de contatos simples que permite adicionar e listar nomes e números de telefone.");
                        MetodQuestAvan.questao95();
                        break;

                    case "96":
                        Console.Clear();
                        Console.WriteLine("Questão 96: Implemente uma função que exibe todos os números primos entre 1 e 100.");
                        MetodQuestAvan.questao96();
                        break;

                    case "97":
                        Console.Clear();
                        Console.WriteLine("Questão 97: Crie um programa que recebe um número e exibe sua tabuada de multiplicação até 10.");
                        MetodQuestAvan.questao97();
                        break;

                    case "98":
                        Console.Clear();
                        Console.WriteLine("Questão 98: Desenvolva uma função que retorna o maior número em uma matriz 3x3.");
                        MetodQuestAvan.questao98();
                        break;

                    case "99":
                        Console.Clear();
                        Console.WriteLine("Questão 99: Implemente um programa que calcula a soma dos quadrados dos números de 1 a N.");
                        MetodQuestAvan.questao99();
                        break;

                    case "100":
                        Console.Clear();
                        Console.WriteLine("Questão 100: Crie um jogo simples de \"Forca\" onde o usuário tenta adivinhar uma palavra em até 5 tentativas.");
                        MetodQuestAvan.questao100();
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Por favor, escolha uma opção entre 76 e 100.");
                        break;
                }
                if (!sair)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                }
            }
        }
    }
}

