using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCoWeek5.Models
{
    public class MemberContext:DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> options) : base(options)
        {

        }
        public DbSet<Member> MOCK_DATA { get; set; }
       
    }
}
