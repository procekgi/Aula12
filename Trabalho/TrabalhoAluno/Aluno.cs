using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAluno
{
    public class Aluno
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataDeNAscimento { get; set; }

        public int idade()
        {
            var d = DateTime.Now;
            int idadeAluno = d.Year - this.DataDeNAscimento.Year;

            return idadeAluno;

        }
        public string NomeCompleto()
        {

            return string.Concat( Nome + Sobrenome);
        }


        public int ValidaNome()
        {
            int i = 0;
            string n = Nome;
            string s = Sobrenome;

            if (n.Contains(" Ç") || n.Contains(" ç") || s.Contains(" Ç") || s.Contains(" ç"))
            {
               
                i = +1;
            }
            if (n.Contains("@") || s.Contains("@"))
            {
              
                i = +2;
            }
            return i;
        }
        
           
        public string ErroValidacao(int i)
        {
            string e;
            if (ValidaNome() == 1)
            {
                e = "Este nome não pode ser usado contém caracter '@' que é inválido";
                return e;
            }
            else if (ValidaNome() == 2)
            {
                e = "Este nome não pode ser usado contém caracter 'Ç' que é inválido no inicio do nome";
                return e;
            }

            return " ";
        }

    }

}

