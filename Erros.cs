using System;
using System.Collections.Generic;


namespace teste
{
    public class Erros
    {
        public bool ValidarPessoa(string nome, string idade){
            if ((nome == "" || nome == null) && (idade == null || idade == "")){
                Console.WriteLine("Nenhum campo foi preenchido, cadastro cancelado!");
                return false;
            }
            else if (idade == null || idade == "" || Int32.Parse(idade) < 0 || Int32.Parse(idade) > 150){
                Console.WriteLine("Idade inválida!");
                return false;
            }
            else if (nome == null || nome == ""){
                Console.WriteLine("Nome inválido!");
                return false;
            }
            else return true;
        }
        public bool ValidarIdPlano(List<PlanoSaude> planos, int id){
            var encontrado = planos.Find(x => x.Id == id);
            if (encontrado != null){
                Console.WriteLine($"Id já existente");
                return false;
            }
            else return true;
        }
        public bool ValidarPlano(string nome, string codigo){
            if ((nome == "" || nome == null) && (codigo == null || codigo == "")){
                Console.WriteLine("Nenhum campo foi preenchido, cadastro cancelado!");
                return false;
            }
            else if (codigo == null || codigo == ""){
                Console.WriteLine("código inválido!");
                return false;
            }
            else if (nome == null || nome == ""){
                Console.WriteLine("Nome inválido!");
                return false;
            }
            else return true;          
        }

        public bool ValidarCodigo(string codigo){
            if (codigo == null || codigo == ""){
                Console.WriteLine("digite um código!");
                return false;
            } else return true;
        }
    
    }
}