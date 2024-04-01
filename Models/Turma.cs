using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeBlocoTP7.Models
{
    public class Turma
    {
        private int codigo;
        private Professor professor;
        private Disciplina disciplina;
        private List<Aluno> alunos;

        public Turma(int codigo, Professor professor, Disciplina disciplina)
        {
            this.codigo = codigo;
            this.professor = professor;
            this.disciplina = disciplina;
            this.alunos = new List<Aluno>();
        }

        public string AddAluno(Aluno aluno)
        {
            if (alunos.Count < 10)
            {
                alunos.Add(aluno);
                return "Aluno adicionado";
            }
            else
            {
                return "Turma cheia";
            }
        }

        public bool AbrirTurma()
        {
            // Lógica para verificar se é possível abrir a turma
            return true; // Por simplicidade, sempre abre a turma
        }

        public string GerarPauta()
        {
            System.Text.StringBuilder pauta = new System.Text.StringBuilder();
            pauta.Append("Código da turma: ").Append(codigo).Append("\n");
            pauta.Append("Disciplina: ").Append(disciplina.GetNome()).Append("\n");
            pauta.Append("Professor: ").Append(professor.GetNome()).Append("\n");
            pauta.Append("Lista de alunos:\n");
            foreach (Aluno aluno in alunos)
            {
                pauta.Append("- ").Append(aluno.GetNome()).Append("\n");
            }
            return pauta.ToString();
        }
    }
}
