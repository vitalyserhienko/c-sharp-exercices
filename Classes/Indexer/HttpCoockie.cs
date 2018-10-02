using System;
using System.Collections.Generic;

namespace Indexer
{
    public class HttpCoockie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }


        public HttpCoockie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
