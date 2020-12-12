namespace ProjBiblio.Domain.Entities
{
    public class LivroMarketing
    {
        public int LivroID { get; set; }
        public Livro Livro { get; set; }

        public int MarketingID { get; set; }
        public Marketing Marketing { get; set; }
    }
}