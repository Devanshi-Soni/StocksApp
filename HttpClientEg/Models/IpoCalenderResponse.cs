
namespace StocksApp.Models
{
    public class IpoCalendarResponse
    {
        public List<ipo> IpoCalendar { get; set; }
    }
    public class ipo
    {
        public DateOnly Date { get; set; }
        public string? Exchange { get; set; }
        public string Name { get; set; }
        //[JsonProperty("NumberOfShares")]
        public Double? NumberOfShares { get; set; }
        public string? Price { get; set; }
        public string Status { get; set; }
        public string Symbol { get; set; }
        public Double? TotalSharesValue { get; set; }
    }
}