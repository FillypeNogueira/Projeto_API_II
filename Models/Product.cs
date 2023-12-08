namespace Projeto_API_II.Models
{
    public class Product
    {
        public long ProductId { get; set; }

        public string Name { get; set; } = string.Empty; //garantindo que Name não será nula e sempre tenha um valor inicial padrão, que seria uma string vazia ("")

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set;}

        public bool Status { get; set;}

        public long CategoryId { get; set; }   

        public Category? Category { get; set; }
    }
}