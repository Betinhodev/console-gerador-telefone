using ExercicioTreinamento.Models;
using System;
using System.Collections.Generic;


namespace ExercicioTreinamento
{
    public class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao gerador de telefone!");

            //cria instancia do builder
            var telefoneBuilder = new TelefoneBuilder();

            //Interação com usuário
            Console.WriteLine("Escolha o tipo de telefone.");
            Console.WriteLine("1. Telefone Aleatório");
            Console.WriteLine("2. Telefone Fixo");
            Console.WriteLine("3. Telefone Celular");

            int escolhaTipo = int.Parse(Console.ReadLine());

            switch (escolhaTipo)
            {
                case 1:
                    telefoneBuilder.NumeroAleatorio(); 
                    break;
                case 2:
                    telefoneBuilder.NumeroFixo(); 
                    break;
                case 3:
                    telefoneBuilder.NumeroCelular(); 
                    break;

                default:
                    Console.WriteLine("Escolha inválida. Usando número aleatório por padrão...");
                    break;
            }

            Console.WriteLine("Deseja formatação? (S/N):");
            bool escolhaFormatacao = Console.ReadLine().ToUpper() == "S";

            if (escolhaFormatacao)
                telefoneBuilder.ComFormatacao();
            else
                telefoneBuilder.SemFormatacao();

            Console.WriteLine("Deseja adicionar DDD (S/N): ");
            bool escolhaDdd = Console.ReadLine().ToUpper() == "S";

            if(escolhaDdd)
            {
                Console.WriteLine("Deseja DDD Aleatório ou definir um Estado? (A/E):");
                char escolhaDddTipo = Console.ReadLine().ToUpper()[0];

                if (escolhaDddTipo == 'A')
                    telefoneBuilder.ComDddAleatorio();
                else if (escolhaDddTipo == 'E')
                {
                    Console.WriteLine("Digite a sigla do estado (ex: SP):");
                    string uf = Console.ReadLine();
                    telefoneBuilder.DddPorUF(uf);
                }
            }

            var numeroTelefone = telefoneBuilder.Constroi();
            Console.WriteLine($"Numero de telefone gerado: {numeroTelefone}");
        }
    }
}