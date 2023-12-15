// Elemento visitável
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public virtual void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
