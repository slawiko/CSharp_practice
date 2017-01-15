using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Currency.Dto;

namespace Currency
{
    [ServiceContract]
    public interface ICurrencyService
    {

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/currencies")]
        List<string> GetCurrencies();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/dayrates")]
        Response GetDayRates();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/rates?source={sourceName}&target={targetName}&startDate={startDate}&endDate={endDate}")]
        Response GetRatesByCurrenciesBetweenDates(string sourceName, string targetName, string startDate, string endDate);

    }
}
