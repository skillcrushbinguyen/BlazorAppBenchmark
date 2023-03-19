namespace BlazorAppBenchmark.Client.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string[] Tags { get; set; } = Array.Empty<string>();
        public DateTime CreateTime { get; set; }
    }
}
