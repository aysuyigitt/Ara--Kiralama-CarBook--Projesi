using CarBook.Application.Features.Mediator.Results.TagCloudsResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.TagCloudQuries
{
    public class GetTagCloudByIdQuery:IRequest<GetTagCloudByIdQueryResult>    
    {
        public int Id { get; set; }

    public  GetTagCloudByIdQuery(int id)
        {
            Id = id;    
        }
        
    }
}
