using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Currency.Dto;
using Currency.Dao;

namespace Currency
{
    public class CurrencyService : ICurrencyService
    {
        MainDao dataUtil = new DatabaseDao();

        public List<string> GetCurrencies()
        {
            List<string> currencies = dataUtil.GetCurrencies();
            return currencies;
        }

        public Response GetDayRates()
        {
            Response response = new Response();
            DateTime date = DateTime.UtcNow;
            date = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            date = DateTime.SpecifyKind(date, DateTimeKind.Utc);
            List<ResponseData> responseData = dataUtil.GetDayRateTable(((DateTimeOffset) date).ToUnixTimeMilliseconds());
            response.ResponseData.AddRange(responseData);
            return response;
        }

        public Response GetRatesByCurrenciesBetweenDates(string sourceName, string targetName, string startDate, string endDate)
        {
            Response response = new Response();
            List<ResponseData> responseData = dataUtil.GetRateTable(sourceName, targetName, Convert.ToInt64(startDate), Convert.ToInt64(endDate));
            response.ResponseData.AddRange(responseData);
            return response;
        }
    }
}
