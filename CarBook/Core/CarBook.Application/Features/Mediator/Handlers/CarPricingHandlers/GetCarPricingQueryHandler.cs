using CarBook.Application.Features.Mediator.Queries.CarPricingQuries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingQueryHandler : IRequestHandler<GetCarPricingQuery, List<GetCarPricingQueryResult>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPricingQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task<List<GetCarPricingQueryResult>> Handle(GetCarPricingQuery request, CancellationToken cancellationToken)
        {
            var values =  _carPricingRepository.GetCarsPricingWithCars();
            return values.Select(x => new GetCarPricingQueryResult
            {
               
                Amount = x.Amount,
                Brand = x.Car.Brand.Name,
                CarPricingID = x.CarPricingID,
                CoverImageUrl = x.Car.CoverImageUrl,    
                Model=x.Car.Model,
                CarID = x.CarID
                
            }).ToList();
        }
    }
}
