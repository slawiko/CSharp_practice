using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Currency.Dto
{
    [DataContract]
    public class ResponseData
    {
        [DataMember]
        public string SourceName { get; set; }

        [DataMember]
        public string TargetName { get; set; }

        [DataMember]
        public double Rate { get; set; }

        [DataMember]
        public long Date { get; set; }

        public ResponseData() { }

        public ResponseData(string sourceName, string targetName, double rate, long date)
        {
            SourceName = sourceName;
            TargetName = targetName;
            Rate = rate;
            Date = date;
        }
    }
}