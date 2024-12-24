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
    public class GetCarCountByTransmissionIsAutoHandler : IRequestHandler<GetCarCountByTranmissionIsAutoQuery, GetCarCountByTransmissionIsAutoQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByTransmissionIsAutoHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByTransmissionIsAutoQueryResult> Handle(GetCarCountByTranmissionIsAutoQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByTranmissionIsAuto();
            return new GetCarCountByTransmissionIsAutoQueryResult
            {
                CarCountByTranmissionIsAuto = value,
            };
        }
    }
}
       
     