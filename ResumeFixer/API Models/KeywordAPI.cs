using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeFixer.API_Models
{
    public class KeywordAPI
    {
        public class Rootobject
        {
            public string message { get; set; }
            public string[] result { get; set; }
            public string status { get; set; }
        }

    }
}
