using System.Text;

namespace DesignPatterns.Builder
{
    public class Hamburguer
    {
        public string TipoPao { get; set; }
        public string TipoCarne { get; set; }
        public bool TemBacon { get; set; }
        public bool TemBatataPalha { get; set; }
        public bool TemQueijo { get; set; }
        public bool TemSalada { get; set; }

        public string GetDescricao()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Hamburguer com Pão: " + TipoPao);
            stringBuilder.AppendLine("Com Carne: " + TipoCarne);
            stringBuilder.AppendLine("Bacon: " + TemBacon);
            stringBuilder.AppendLine("Batata Palha: " + TemBatataPalha);
            stringBuilder.AppendLine("Queijo: " + TemQueijo);
            stringBuilder.AppendLine("Salada: " + TemSalada);

            return stringBuilder.ToString();
        }
    }
}
