namespace BananaVerdeProdutosNaturais.WebAPI.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Local { get; set; }
        public string ValidadeProduct { get; set; }
        public string Category { get; set; }
        public string Value { get; set; }
        public string Lote { get; set; }
    }
}