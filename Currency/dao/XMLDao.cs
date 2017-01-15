using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Currency.Dto;

namespace Currency.Dao
{
    class XMLDao : MainDao
    {

        public static readonly string CURRENCIES = "C:\\Users\\drovdo\\OneDrive\\Documents\\Visual Studio 2015\\Projects\\Currency\\currencies.xml";

        public List<string> GetCurrencies()
        {
            List<string> currencies = new List<string>();

            IEnumerable<XElement> XMLCurrencies = XElement.Load(CURRENCIES).Elements();
            foreach (var currency in XMLCurrencies)
            {
                currencies.Add(currency.Attribute("name").Value);
            }

            return currencies;
        }

        public List<ResponseData> GetRateTable(string sourceName, string targetName, long dateFrom, long dateTo)
        {
            List<ResponseData> table = new List<ResponseData>();

            if (dateFrom > dateTo)
            {
                return table;
            }

            IEnumerable<XElement> XMLCurrencies = XElement.Load(CURRENCIES).Elements();
            foreach (var currency in XMLCurrencies)
            {
                string currName = currency.Attribute("name").Value;
                if (currName.Equals(sourceName))
                {
                    foreach (var target in currency.Element("targets").Elements())
                    {
                        string targetCurName = target.Attribute("name").Value;
                        if (targetCurName.Equals(targetName))
                        {
                            foreach (var rate in target.Element("rates").Elements())
                            {
                                long dateTime = DateTimeOffset.Parse(rate.Attribute("date").Value).ToUnixTimeMilliseconds();
                                if (dateTime >= dateFrom && dateTime <= dateTo)
                                {
                                    ResponseData responseDate = new ResponseData(currName, targetName, Double.Parse(rate.Value), dateTime);
                                    table.Add(responseDate);
                                }
                            }
                        }
                    }
                }
            }

            return table;
        }

        public List<ResponseData> GetDayRateTable(long date)
        {
            List<ResponseData> table = new List<ResponseData>();

            IEnumerable<XElement> XMLCurrencies = XElement.Load(CURRENCIES).Elements();
            foreach (var currency in XMLCurrencies)
            {
                string currName = currency.Attribute("name").Value;
                foreach(var target in currency.Element("targets").Elements())
                {
                    string targetName = target.Attribute("name").Value;
                    foreach(var rate in target.Element("rates").Elements())
                    {
                        long dateTime = DateTimeOffset.Parse(rate.Attribute("date").Value).ToUnixTimeMilliseconds();
                        if (dateTime.Equals(date))
                        {
                            ResponseData responseDate = new ResponseData(currName, targetName, Double.Parse(rate.Value), dateTime);
                            table.Add(responseDate);
                        }
                    }
                }
            }

            return table;
        }
    }
}
