// Implementação do visitante
public class PessoaVisitor : IVisitor
{
    public void Visit(Pessoa pessoa)
    {
        if (pessoa.Idade >= 18)
        {
            Console.WriteLine($"{pessoa.Nome} é maior de idade.");
        }
        else
        {
            Console.WriteLine($"{pessoa.Nome} é menor de idade.");
        }
    }
}
