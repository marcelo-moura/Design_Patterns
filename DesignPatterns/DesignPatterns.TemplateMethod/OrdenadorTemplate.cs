namespace DesignPatterns.TemplateMethod
{
    public abstract class OrdenadorTemplate
    {
        public abstract bool IsPrimeiro(Filme filme1, Filme filme2);

        // Metodo de ordenação bolha (Bubble Sort) => O(N^2)
        public List<Filme> OrdenarFilme(List<Filme> filmes)
        {
            for (int i = 0; i < filmes.Count; i++)
            {
                for (int j = i + 1; j < filmes.Count; j++)
                {
                    if (!IsPrimeiro(filmes[i], filmes[j]))
                    {
                        Filme temp = filmes[j];
                        filmes[j] = filmes[i];
                        filmes[i] = temp;
                    }
                }
            }

            return filmes;
        }
    }
}
