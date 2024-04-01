using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeBlocoTP7.Models
{
    public class Disciplina
    {
        private int codigo;
        private string nome;

        public Disciplina(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }
    }

}
