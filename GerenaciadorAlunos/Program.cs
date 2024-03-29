using System;

namespace GerenciadorAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opções do menu
            const int OPCAO_ADICIONAR_ALUNO = 1;
            const int OPCAO_BUSCAR_ALUNO = 2;
            const int OPCAO_EXIBIR_TODOS = 3;
            const int OPCAO_SAIR = 4;

            // Variável para controlar o loop principal
            bool sair = false;

            // Loop principal do programa
            while (!sair)
            {
                // Exibir o menu
                ExibirMenu();

                // Ler a opção do usuário
                int opcao = int.Parse(Console.ReadLine());

                // Tratar a opção do usuário
                switch (opcao)
                {
                    case OPCAO_ADICIONAR_ALUNO:
                        AdicionarAluno();
                        break;
                    case OPCAO_BUSCAR_ALUNO:
                        BuscarAluno();
                        break;
                    case OPCAO_EXIBIR_TODOS:
                        ExibirTodosAlunos();
                        break;
                    case OPCAO_SAIR:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static void ExibirMenu()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Gerenciador de Alunos");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1 - Adicionar Aluno");
            Console.WriteLine("2 - Buscar Aluno");
            Console.WriteLine("3 - Exibir Todos");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("-----------------------");
            Console.Write("Digite a opção desejada: ");
        }

        static void AdicionarAluno()
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a turma do aluno: ");
            string turma = Console.ReadLine();

            // Criar um novo aluno
            Aluno aluno = new Aluno(nome, turma);

            // Adicionar o aluno ao repositório
            Repositorio.AdicionaAluno(aluno);

            Console.WriteLine("Aluno adicionado com sucesso!");
        }

        static void BuscarAluno()
        {
            Console.Write("Digite o índice do aluno: ");
            int indice = int.Parse(Console.ReadLine());

            // Buscar o aluno no repositório
            Aluno aluno = Repositorio.BuscaAluno(indice);

            if (aluno != null)
            {
                Console.WriteLine(aluno);
            }
            else
            {
                Console.WriteLine("Aluno não encontrado!");
            }
        }

        static void ExibirTodosAlunos()
        {
            // Obter todos os alunos do repositório
            Aluno[] alunos = Repositorio.ObterTodosAlunos();

            // Exibir cada aluno
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
