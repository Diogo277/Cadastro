using System;
using System.Collections.Generic;

namespace teste
{
    public class Menu
    {
        public static void Carregar(List<Pessoa> pessoas, List<PlanoSaude> planos)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - cadastrar participante ");
            Console.WriteLine("2 - remover participante ");
            Console.WriteLine("3 - exibir participantes ");
            Console.WriteLine("4 - cadastrar plano de saúde");
            Console.WriteLine("5 - remover plano de saúde");
            Console.WriteLine("6 - exibir plano de saúde");

            Console.Write("Opção: ");

            string msg = Console.ReadLine();
            
            switch(msg){
                case "1":
                    Pessoa.Cadastrar(pessoas, planos);
                    Carregar(pessoas, planos);
                    break;
                case "2":
                    Pessoa.Remover(pessoas);
                    Carregar(pessoas, planos);
                    break;
                case "3":
                    Pessoa.Exibir(pessoas);
                    Carregar(pessoas, planos);
                    break;
                case "4":
                    PlanoSaude.Cadastrar(planos);
                    Carregar(pessoas, planos);
                    break;
                case "5":
                    PlanoSaude.Remover(planos, pessoas);
                    Carregar(pessoas, planos);
                    break;
                case "6":
                    PlanoSaude.Exibir(planos);
                    Carregar(pessoas, planos);
                    break;              
                default:
                    Console.WriteLine("Número inválido, tente novamente");
                    Carregar(pessoas, planos);
                    break;
            }          
        }       
    }    
}