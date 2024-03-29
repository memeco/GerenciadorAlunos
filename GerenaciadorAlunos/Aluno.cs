public class Aluno
{
    private static int id;
    private int _id;
    public int Id
    {
        get
        {
            return _id;
        }
    }

    public string Nome { get; set; }
    public string Turma { get; set; }

    public Aluno(string nome, string turma)
    {
        id++;
        _id = id;
        Nome = nome;
        Turma = turma;
    }

    public override string ToString()
    {
        return $"Id:{_id}\nAluno : {Nome} \nTurma : {Turma}";
    }
}
