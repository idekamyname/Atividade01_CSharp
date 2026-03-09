using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Atividade 1
             Crie um programa que solicite ao usuário seu nome e idade, e exiba uma mensagem como:
             "Olá, Maria! Você tem 25 anos."*/
            string nome;
            int idade;
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Olá, " + nome + "! Você tem " + idade + " anos");

            Console.WriteLine("===========================================");

            /* Atividade 2
            Escreva um programa que leia dois números inteiros, some-os e exiba o resultado. */
            int num1;
            int num2;
            int soma;
            Console.Write("Digite o número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("digite o número 2: ");
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + soma);

            Console.WriteLine("===========================================");

            /* Atividade 3
            Faça um programa que peça ao usuário um número e informe se ele é par ou ímpar. */
            int num;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("O número " + num + " é par");
            }
            else
            {
                Console.WriteLine("O número " + num + " é ímpar");
            }

            Console.WriteLine("===========================================");

            /* Atividade 4
            Escreva um programa que simule um menu com três opções:
            1 - Cadastrar usuário
            2 - Exibir informações
            3 - Sair
            Use a estrutura switch para tratar a escolha do usuário. */
            char op;
            do
            {
                //Console.Clear();
                Console.WriteLine("--- Menu de Operações ---");
                Console.WriteLine("1 - Cadastar Usuário");
                Console.WriteLine("2 - Exibir Informações");
                Console.WriteLine("3 - sair");
                Console.Write("Digite uma opção: ");
                op  = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '1':
                        Console.WriteLine("Cadastar Usuário");
                        break;
                    case '2':
                        Console.WriteLine("Exibir Informações");
                        break;
                    case '3':
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.ReadKey();
            } while (op != '3');

            Console.WriteLine("===========================================");

            /* Atividade 5
            Crie um programa que leia um número e imprima a tabuada desse número de 1 a 10. */
            int nume;
            Console.Write("Digite um número para tabuada: ");
            nume = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{nume} x {i} = {nume*i}");
            }

            Console.WriteLine("===========================================");

            /* Atividade 6
            Escreva um programa que conte de 1 até 10 utilizando o laço while */
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine("===========================================");

            /* Atividade 7
            Faça um programa que leia um número e informe se ele é positivo, negativo ou zero. */
            int numero;
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine($"O número {numero} é positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine($"O número {numero} é negativo");
            }
            else
            {
                Console.WriteLine("O número é zero");
            }

            Console.WriteLine("===========================================");

            /* Desafio
            Crie um programa que simule uma senha de acesso. O programa deve pedir ao usuário para digitar
            uma senha. O usuário tem 3 tentativas para acertar a senha correta ("1234"). Caso acerte, exiba
            "Acesso permitido". Se errar 3 vezes, exiba "Acesso bloqueado". */
            string senha;
            string senha_correta = "1234";
            for (int b = 0; b < 3; b++)
            {
                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();
                if (senha == senha_correta)
                {
                    Console.WriteLine("Acesso permitido");
                    break;
                }
                else
                {
                    if (b < 2)
                        Console.WriteLine("Senha Incorreta");
                    else
                    {
                        Console.WriteLine("Acesso bloqueado");
                    }
                }
                
            }
            

        }
    }
}
