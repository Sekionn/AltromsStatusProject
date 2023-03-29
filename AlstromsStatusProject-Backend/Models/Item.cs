namespace AlstromsStatusProject_Backend.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Barcode { get; set; }
        public int ShelfOfOrigin { get; set; }
        public int AmountCounted { get; set; }
        public string? Date { get; set; }

    }
}