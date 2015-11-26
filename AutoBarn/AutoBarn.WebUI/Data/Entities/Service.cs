namespace AutoBarn.WebUI.Data.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DealerPrice { get; set; }
        public Model Model { get; set; }
    }
}