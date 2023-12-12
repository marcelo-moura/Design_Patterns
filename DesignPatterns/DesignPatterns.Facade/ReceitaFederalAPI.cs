namespace DesignPatterns.Facade
{
    public class ReceitaFederalAPI
    {
        public bool CPFAtivo(string cpf)
        {
            Random random = new Random();
            int x = random.Next(0, 1);
            return x != 0;
        }
    }
}
