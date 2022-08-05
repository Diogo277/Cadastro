using System;
using System.Collections.Generic;


namespace teste
{
    public class Pessoa
    {
        public string Idade {get; set;}
        public string Nome{get; set;}
        public DateTime DataCadastro {get; set;}
        public PlanoSaude Plano {get; set;}

        
        public Pessoa(string idade, string nome, PlanoSaude plano){
            Idade = idade;
            Nome = nome;
            Plano = plano;

        }
        public Pessoa(){

        }
        public static void Cadastrar(List<Pessoa> pessoas, List<PlanoSaude> planos)
        {
            Erros erro = new Erros();
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Cadastro de participante");

            Console.Write("Nome do participante: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Idade do participante: ");
            pessoa.Idade =  Console.ReadLine();
            if(planos.Count > 0){
                foreach(var batata in planos){
                                Console.WriteLine($"Id do plano: {batata.Id}, nome do plano: {batata.Nome}");
                            
                            Console.Write("Qual plano deseja cadastrar o participante? ");
                            int codigo = Convert.ToInt32(Console.ReadLine());

                            var encontrado = planos.Find(x => x.Id == codigo);
                            if(encontrado != null){
                                pessoa.Plano = encontrado;
                                pessoa.DataCadastro = DateTime.Now;
                                pessoas.Add(pessoa);
                                Console.WriteLine("Cadastro realizado com sucesso");
                            }
                            else Console.WriteLine("Plano não encontrado");
                            
                }
            } else Console.WriteLine("Cadastre um plano primeiro!");
            
        }

        public static void Exibir(List<Pessoa> pessoas){
            foreach(var batata in pessoas){
                Console.WriteLine($"Nome do participante: {batata.Nome}, idade: {batata.Idade}, data de cadastro: {batata.DataCadastro}, plano de saúde: {batata.Plano.Id}");
            }
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

        }           
       
    }
}