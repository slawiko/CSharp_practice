using System;
using System.Collections.Generic;
using Currency.Dto;
using System.Data.SqlClient;

namespace Currency.Dao
{
    class DatabaseDao : MainDao
    {
        public static readonly string CONNECTION_STRING = "Data Source=drovdof5ba\\sqlexpress;Initial Catalog=exchange_rates;User ID=sa;Password=Maiz-1996";

        public List<string> GetCurrencies()
        {
            List<string> currencies = new List<string>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = "SELECT name FROM currency";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currencies.Add(reader.GetString(0));
                        }
                    }
                    connection.Close();
                }
            }
            return currencies;
        }

        public List<ResponseData> GetRateTable(string sourceName, string targetName, long dateFrom, long dateTo)
        {
            List<ResponseData> table = new List<ResponseData>();

            if (dateFrom <= dateTo)
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "SELECT source.name as sourceName, target.name as targetName, rate.value as rateValue, rate.date as date from rate " + 
                        "join currency source on source_id = source.id join currency target on target_id = target.id " +
                        "where source.name = @sourceName and target.name = @targetName and rate.date between @dateFrom and @dateTo order by rate.date";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@sourceName", sourceName);
                        command.Parameters.AddWithValue("@targetName", targetName);
                        command.Parameters.AddWithValue("@dateFrom", dateFrom);
                        command.Parameters.AddWithValue("@dateTo", dateTo);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ResponseData responseData = ConstructResponseData(reader);
                                table.Add(responseData);
                            }
                        }
                        connection.Close();
                    }
                }
            }


            return table;
        }

        public List<ResponseData> GetDayRateTable(long date)
        {
            List<ResponseData> table = new List<ResponseData>();

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = "SELECT source.name as sourceName, target.name as targetName, rate.value as rateValue, rate.date as date from rate " +
                    "join currency source on source_id = source.id join currency target on target_id = target.id " +
                    "where rate.date = @date";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date", date);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ResponseData responseData = ConstructResponseData(reader);
                            table.Add(responseData);
                        }
                    }
                    connection.Close();
                }
            }

            return table;
        }

        private ResponseData ConstructResponseData(SqlDataReader reader)
        {
            ResponseData responseData = new ResponseData();
            responseData.SourceName = reader["sourceName"].ToString();
            responseData.TargetName = reader["targetName"].ToString();
            responseData.Date = Convert.ToInt64(reader["date"]);
            responseData.Rate = Convert.ToDouble(reader["rateValue"]);
            return responseData;
        }
    }
}
