namespace HardwareInventoryLibrary.Ram
{
    public class RamReadModel : RamBaseModel
    {
        public string? BrandName { get; set; }
        // Testing
        public DateOnly? Date { get; set; }
        public TimeOnly? Time { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? Sold { get; set; }
    }
}
