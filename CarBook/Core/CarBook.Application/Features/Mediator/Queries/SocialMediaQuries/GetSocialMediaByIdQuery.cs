using CarBook.Application.Features.Mediator.Results.ServiceResults;
using CarBook.Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.SocialMediaQuries
{
    public class GetSocialMediaByIdQuery: IRequest<GetSocialMediaByIdQueryResult>
    {
        public int Id { get; set; }

        public GetSocialMediaByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}


