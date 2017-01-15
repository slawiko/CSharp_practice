using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency.Dto;

namespace Currency.Dao
{
    interface MainDao
    {
        List<string> GetCurrencies();
        List<ResponseData> GetRateTable(string sourceName, string targetName, long dateFrom, long dateTo);
        List<ResponseData> GetDayRateTable(long date);
    }
}
