namespace DesignPatterns.Facade
{
    public class ScoreClienteFacade
    {
        DetranAPI detran = new();
        SerasaAPI serasa = new();
        ReceitaFederalAPI receita = new();

        public double Score(string cpf, string cnh)
        {
            var cnhValida = detran.CNHValida(cnh);
            var scoreSerasa = serasa.Score(cpf);
            var cpfAtivo = receita.CPFAtivo(cpf);

            var score = scoreSerasa * 1.0;
            var scoreSerasa20p100 = scoreSerasa * 0.2;
            var scoreSerasa30p100 = scoreSerasa * 0.3;

            if (!cnhValida)
                score -= scoreSerasa20p100;

            if (!cpfAtivo)
                score -= scoreSerasa30p100;

            return score;
        }
    }
}
