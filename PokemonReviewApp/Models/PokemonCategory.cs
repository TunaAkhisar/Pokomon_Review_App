namespace PokemonReviewApp.Models
{
    public class PokemonCategory
    {
        public int PokomonId { get; set; }
        public int CategoryId { get; set;}
        public Pokemon Pokemon { get; set;}
        public Category Category { get; set;}
    }
}
