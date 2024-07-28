namespace StocksApp.ServiceContracts
{
    public interface IFinnhubService
    {
        Task<IpoCalendarResponse> GetIpoDetails(DateOnly fromDate, DateOnly toDate);
    }
}
