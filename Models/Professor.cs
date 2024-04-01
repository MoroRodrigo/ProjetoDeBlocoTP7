using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeBlocoTP7.Models
{
    public class Professor
    {
        private int matricula;
        private string nome;

        public Professor(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }
    }

}
