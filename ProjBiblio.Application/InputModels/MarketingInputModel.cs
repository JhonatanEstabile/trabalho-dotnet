using System.Collections.Generic;

namespace ProjBiblio.Application.InputModels
{
    public class MarketingInputModel
    {
        public int Id { get; set; }

        public int LivroID { get; set; }

        public string Descricao { get; set; }

        public string DataInicio { get; set; }

        public string DataFim { get; set; }

        public double? PercentualDesconto { get; set; }
    }
}