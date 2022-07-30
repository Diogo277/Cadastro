using System;
using System.Collections.Generic;


namespace teste
{
    public class Pessoa
    {
        public string Idade {get; set;}
        public string Nome{get; set;}

        
        public Pessoa(string idade, string nome){
            Idade = idade;
            Nome = nome;
        }
        public Pessoa(){

        }
        public static void Cadastrar(List<Pessoa> pessoas)
        {
            Erros erro = new Erros();
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Cadastro de participante");

            Console.Write("Nome do participante: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Idade do participante: ");
            pessoa.Idade =  Console.ReadLine();

            if (erro.ValidarPessoa(pessoa.Nome, pessoa.Idade)){
                pessoas.Add(pessoa);
                Console.WriteLine("Cadastro realizado com sucesso");
            } 
            else Console.WriteLine("Pessoa inválida! Cadastro cancelado");

            Menu.Carregar(pessoas);

        }

        public static void Exibir(List<Pessoa> pessoas){
            foreach(var batata in pessoas){
                Console.WriteLine($"Nome do participante: {batata.Nome}, idade: {batata.Idade}");
            }
            Menu.Carregar(pessoas);
        } 

        public static void Remover(List<Pessoa> pessoas){
            Console.Write("Qual pessoa deseja remover? ");
            string user = Console.ReadLine();

            var encontrado = pessoas.Find(x => x.Nome == user);
            if (encontrado != null){
                pessoas.Remove(encontrado);
                Console.WriteLine($"{user} removido(a) com sucesso");
            } 
            else Console.WriteLine("Pessoa não encontrada");

            Menu.Carregar(pessoas);
        }           
       
    }
}