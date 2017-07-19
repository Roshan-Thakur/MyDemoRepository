using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebApi.Models
{
    public class QueryResult
    {
        public enum Results
        {
            Success,
            Error
        }

        public Results Status { get; set; }

        public Dictionary<string, string> ErrMsg { get; set; }

        public QueryResult()
        {
            Status = Results.Error;
            ErrMsg = new Dictionary<string, string>();
        }

        public string GetErrorString(string seprator)
        {
            return string.Join(seprator, ErrMsg.Select(p => p.Value).ToArray<string>());
        }
    }
}