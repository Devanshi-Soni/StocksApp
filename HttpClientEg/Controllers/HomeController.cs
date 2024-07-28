using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StocksApp.Models;
using StocksApp.Services;
using StocksApp.ServiceContracts;

namespace StocksApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly FinnhubService _finnhubService;
        private readonly IOptions<IpoCalender> _ipoDetails;

        public HomeController(FinnhubService finnhubService, IOptions<IpoCalender> ipoDetails)
        {
            _finnhubService = finnhubService;
            _ipoDetails = ipoDetails;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            // if from appsetting we won't get value then use this hardcoding method 
            if (_ipoDetails.Value.fromDate == null && _ipoDetails.Value.toDate == null)
            {
                string fromDate = "2020-03-15";
                string toDate = " 2020-03-16";
                _ipoDetails.Value.fromDate = DateOnly.ParseExact(fromDate, "yyyy-mm-dd");
                _ipoDetails.Value.toDate = DateOnly.ParseExact(toDate, "yyyy-mm-dd");
            }

            //Dictionary<string, object>? responseDictionary = await _finnhubService.GetIpoDetails(_ipoDetails.Value.fromDate, _ipoDetails.Value.toDate);
            IpoCalendarResponse response = await _finnhubService.GetIpoDetails(_ipoDetails.Value.fromDate, _ipoDetails.Value.toDate);
            
            return View(response.IpoCalendar);
        }
    }
}