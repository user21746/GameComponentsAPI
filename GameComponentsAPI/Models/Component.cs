namespace GameComponentsAPI.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

}
