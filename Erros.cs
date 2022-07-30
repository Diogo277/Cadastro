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
    }
}