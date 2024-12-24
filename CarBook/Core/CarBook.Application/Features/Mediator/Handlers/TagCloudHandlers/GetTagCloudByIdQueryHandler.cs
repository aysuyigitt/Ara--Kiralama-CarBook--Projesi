using CarBook.Application.Features.Mediator.Queries.TagCloudQuries;
using CarBook.Application.Features.Mediator.Results.TagCloudsResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetTagCloudByIdQuery, GetTagCloudByIdQueryResult>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetServiceByIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }
        public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
        {
           var values= await _repository.GetByIdAsync(request.Id);
            return new GetTagCloudByIdQueryResult
            {
                TagCloudID = values.TagCloudID,
                BlogID = values.BlogID,
                Title = values.Title,   
            };
        }
    }
}
