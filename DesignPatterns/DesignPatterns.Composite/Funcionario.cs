namespace DesignPatterns.Composite
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        public Funcionario(string nome)
        {
            Nome = nome;
        }

        public abstract string Operation();

        public virtual Funcionario Get(int index)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(Funcionario component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Funcionario component)
        {
            throw new NotImplementedException();
        }
    }
}
