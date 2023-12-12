namespace DesignPatterns.Facade
{
    public class SerasaAPI
    {
        public int Score(string cpf)
        {
            Random random = new Random();
            return random.Next(0, 1000);
        }
    }
}
