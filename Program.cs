using ProjetoDeBlocoTP7.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias das classes
        Professor professor = new Professor(1, "João");
        Disciplina disciplina = new Disciplina(1, "Matemática");
        Turma turma = new Turma(1, professor, disciplina);

        // Testando métodos da classe Turma
        System.Console.WriteLine(turma.AddAluno(new Aluno(1, "Alice"))); // Aluno adicionado
        System.Console.WriteLine(turma.AddAluno(new Aluno(2, "Bob")));   // Aluno adicionado
        System.Console.WriteLine(turma.AddAluno(new Aluno(3, "Carol"))); // Aluno adicionado
        System.Console.WriteLine(turma.AddAluno(new Aluno(4, "David"))); // Aluno adicionado
        System.Console.WriteLine(turma.AddAluno(new Aluno(5, "Eva")));   // Aluno adicionado
        System.Console.WriteLine(turma.AddAluno(new Aluno(6, "Frank"))); // Aluno adicionado
        System.Console.WriteLine(turma.AddAluno(new Aluno(7, "Grace"))); // Aluno adicionado
        System.Console.WriteLine(turma.AddAluno(new Aluno(8, "Hannah")));// Aluno adicionado
        System.Console.WriteLine(turma.AddAluno(new Aluno(9, "Ivan")));  // Aluno adicionado
        System.Console.WriteLine(turma.AddAluno(new Aluno(10, "Jack"))); // Aluno adicionado
        System.Console.WriteLine(turma.AddAluno(new Aluno(11, "Kate"))); // Turma cheia

        System.Console.WriteLine(turma.GerarPauta());
    }
}
