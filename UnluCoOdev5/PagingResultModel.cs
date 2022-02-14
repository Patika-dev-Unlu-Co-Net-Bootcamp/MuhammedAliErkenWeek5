using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using UnluCoWeek5.Models;

namespace UnluCoWeek5
{
    public class PagingResultModel<T> : List<T>
    {

        public QueryParams Params { get; }
        public PagingResponseModel Result { get; set; }
        public PagingResultModel(QueryParams query)
        {
            Params = query;
            Result = new PagingResponseModel();
            
        }



        public void GetData(IQueryable<T> query)
        {

            Result.TotalCount = query.Count();
            Result.TotalPages = (int)Math.Ceiling(Result.TotalCount / (double)Params.PageSize);
            Result.CurrentPage = Params.Page;
            Result.NextPage = Result.TotalPages >= Result.CurrentPage + 1 ? Result.CurrentPage + 1 : Result.CurrentPage;
            Result.PreviousPage = Result.CurrentPage == 1 ? Result.CurrentPage : Result.CurrentPage - 1;


            var result = query.Skip((Params.Page - 1) * Params.PageSize)
                  .Take(Params.PageSize).ToList();



            if (string.IsNullOrWhiteSpace(Params.Sort))
            {

                var entity = typeof(T);
                var property = entity.GetProperty(Params.Sort);

                result = result.OrderByDescending(x => property.GetValue(x, null)).ToList();

            }
            

            AddRange(result);


        }

    }
}



