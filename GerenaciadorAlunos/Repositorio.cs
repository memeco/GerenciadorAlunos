using System;

namespace GerenciadorAlunos
{
    public static class Repositorio
    {
        private static int _index = 0;
        private static Aluno[] _alunos = new Aluno[100];

        public static void AdicionaAluno(Aluno aluno)
        {
            if (_index < _alunos.Length)
            {
                _alunos[_index] = aluno;
                _index++;
                Console.WriteLine("Aluno adicionado com sucesso!"); // Added confirmation message
            }
            else
            {
                Console.WriteLine("Limite de alunos atingido!");
            }
        }

        public static Aluno BuscaAluno(int indice)
        {
            if (indice >= 0 && indice < _index)
            {
                return _alunos[indice];
            }

            return null;
        }

        public static Aluno[] ObterTodosAlunos()
        {
            Aluno[] alunos = new Aluno[_index];

            for (int i = 0; i < _index; i++)
            {
                alunos[i] = _alunos[i];
            }

            return alunos;
        }
    }
}
s