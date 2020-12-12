using System.Collections.Generic;

namespace ProjBiblio.Application.ViewModels
{
    public class MarketingViewModel
    {
        public int Id { get; set; }

        public int LivroID { get; set; }

        public string DataInicio { get; set; }

        public string DataFim { get; set; }

        public double? PercentualDesconto { get; set; }

        public ICollection<LivroViewModel> Livros { get; set; }

        public MarketingViewModel()
        {
            Livros = new List<LivroViewModel>();
        }
    }
}