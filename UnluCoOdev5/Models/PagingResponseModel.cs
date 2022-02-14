using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCoWeek5.Models
{
    public class PagingResponseModel
    {
        public int TotalCount { get; set; } = 0;
        public int TotalPages { get; set; } = 1;
        public int CurrentPage { get; set; } = 1;
        public int? NextPage { get; set; }
        public int? PreviousPage { get; set; }
       
    }
}
