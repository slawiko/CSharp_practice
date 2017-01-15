using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Currency.Dto
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public List<ResponseData> ResponseData = new List<ResponseData>();

        public List<ResponseData> ResponseDate
        {
            get; set;
        }


    }
}