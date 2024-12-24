using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.CarQuries
{
    public class GetCategoryByIdQuery
    {
        public int Id { get; set; }

        public GetCategoryByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
