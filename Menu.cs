using System;
using System.Collections.Generic;

namespace teste
{
    public class Menu
    {
        public static void Carregar(List<Pessoa> pessoas)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - cadastrar participante ");
            Console.WriteLine("2 - remover participante ");
            Console.WriteLine("3 - exibir participantes ");
            Console.Write("Opção: ");

            string msg = Console.ReadLine();
            
            switch(msg){
                case "1":
                    Pessoa.Cadastrar(pessoas);
                    break;
                case "2":
                    Pessoa.Remover(pessoas);
                    break;
                case "3":
                    Pessoa.Exibir(pessoas);
                    break;
                default:
                    Console.WriteLine("Número inválido, tente novamente");
                    Carregar(pessoas);
                    break;
            }          
        }       
    }    
}