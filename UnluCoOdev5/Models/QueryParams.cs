using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCoWeek5.Models
{
    public class QueryParams
    {
        public int PageSize { get; set; } = 10;
        public int Page { get; set; } = 1;
        public string Sort { get; set; } = "LastName";
       
    }
}
