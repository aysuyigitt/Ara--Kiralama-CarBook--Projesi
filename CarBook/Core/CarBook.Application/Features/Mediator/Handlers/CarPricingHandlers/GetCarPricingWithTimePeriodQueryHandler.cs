using CarBook.Application.Features.Mediator.Queries.BlogQuries;
using CarBook.Application.Features.Mediator.Queries.CarPricingQuries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
	public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
	{
		private readonly ICarPricingRepository _repository;

		public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetCarPricingWithTimePeriod1();
			return values.Select(x => new GetCarPricingWithTimePeriodQueryResult
			{
				BrandName=x.BrandName,
				CoverImageUrl=x.CoverImageUrl,	
				Model=x.Model,
				DailyAmount = (int)x.Amounts[0],
				WeeklyAmount = (int)x.Amounts[1],
				MonthlyAmount = (int)x.Amounts[2]
			}).ToList();

		}
	}
}
