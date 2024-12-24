using CarBook.Application.Features.Mediator.Queries.StatisticsQuries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByKmSmallerTahn1000QueryHandler : IRequestHandler<GetCarCountByKmSmallerThen1000Query, GetCarCountByKmSmallerTahn1000QueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByKmSmallerTahn1000QueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKmSmallerTahn1000QueryResult> Handle(GetCarCountByKmSmallerThen1000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmSmallerTahn1000();
            return new GetCarCountByKmSmallerTahn1000QueryResult
            {
                CarCountByKmSmallerTahn1000 = value,
            };
        }
    }
}

       
