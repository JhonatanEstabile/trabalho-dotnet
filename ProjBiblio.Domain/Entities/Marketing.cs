using System.Collections.Generic;

namespace ProjBiblio.Domain.Entities
{
    public class Marketing
    {
        public int MarketingID { get; set; }

        public string Descricao { get; set; }

        public string DataInicio { get; set; }

        public string DataFim { get; set; }

        public double? PercentualDesconto { get; set; }

        public ICollection<LivroMarketing> LivMarketing { get; set; }

        public Marketing()
        {
            LivMarketing = new List<LivroMarketing>();
        }
    }
}