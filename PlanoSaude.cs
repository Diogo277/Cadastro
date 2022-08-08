using System;
using System.Collections.Generic;

namespace teste
{

    public class PlanoSaude
    {
        public string Nome {get; set;}
        public int Id {get; set;}

        
        public PlanoSaude(string nome, int id){
            Id = id;
            Nome = nome;
        }
        public PlanoSaude(){

        }
        public static void Cadastrar(List<PlanoSaude> planos)
        {
            PlanoSaude plano = new PlanoSaude();
            Erros erro = new Erros();

            Console.WriteLine("Cadastro de plano");

            Console.Write("Número do plano: ");
            string codigo = Console.ReadLine();

            Console.Write("Nome do plano: ");
            plano.Nome =  Console.ReadLine();

            if(erro.ValidarPlano(plano.Nome, codigo)){
                plano.Id = Convert.ToInt32(codigo);

            
                if(erro.ValidarIdPlano(planos, plano.Id)){
                    planos.Add(plano);
                    Console.WriteLine("Cadastro realizado com sucesso");
                }
            } else Console.WriteLine("Cadastro cancelado!");
        }
        public static void Exibir(List<PlanoSaude> planos){
            foreach(var batata in planos){
                Console.WriteLine($"Id do plano: {batata.Id}, nome do plano: {batata.Nome}");
            }
        } 

        public static void Remover(List<PlanoSaude> planos, List<Pessoa> pessoas){
            Console.Write("Qual plano deseja remover? ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            
            var encontrado = planos.Find(x => x.Id == codigo);
            if (encontrado != null){
                var lEncontrados = pessoas.Find(x => x.Plano.Id == codigo);
                if(lEncontrados != null){
                    lEncontrados.Plano.Id = 0;
                    lEncontrados.Plano.Nome = "";
                }             
                planos.Remove(encontrado);
                Console.WriteLine($"{encontrado.Nome} removido(a) com sucesso");
            } 
            else Console.WriteLine("Plano não encontrado");
        }
     
    }
}