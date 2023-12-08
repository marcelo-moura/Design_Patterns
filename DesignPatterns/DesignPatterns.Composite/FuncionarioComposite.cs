namespace DesignPatterns.Composite
{
    public class FuncionarioComposite : Funcionario
    {
        protected List<Funcionario> _children = new();

        public FuncionarioComposite(string nome) : base(nome)
        {
        }

        public override Funcionario Get(int index)
        {
            return _children[index];
        }

        public override void Add(Funcionario component)
        {
            _children.Add(component);
        }

        public override void Remove(Funcionario component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = $"Liderados de {Nome} (";

            foreach (Funcionario component in _children)
            {
                result += component.Nome;
                if(i != _children.Count - 1)
                    result += ", ";

                i++;
            }

            return result + ")";
        }
    }
}
