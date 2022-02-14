
using Microsoft.EntityFrameworkCore;
using SSPLibrary;
using SSPLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnluCoWeek5.Models;
using UnluCoWeek5.Services;

namespace UnluCoWeek5.Repository
{
    public interface IMemberRepository
    {

        
        PagingResultModel<Member> GetMembers (QueryParams queryParams);
    }


    public class MemberRepository : IMemberRepository
    {
        
        private readonly MemberContext _context;
        public MemberRepository(MemberContext context)
        {
            _context = context;

            
        }

      


        public PagingResultModel<Member> GetMembers(QueryParams queryParams)
        {

            PagingResultModel<Member> members = new(queryParams);

            members.GetData(_context.MOCK_DATA);


            return members;
        }
       
       
    }
}
