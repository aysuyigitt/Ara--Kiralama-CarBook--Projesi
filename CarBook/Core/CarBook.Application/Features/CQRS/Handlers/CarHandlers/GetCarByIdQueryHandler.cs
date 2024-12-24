using CarBook.Application.Features.CQRS.Queries.BrandQueires;
using CarBook.Application.Features.CQRS.Queries.CarQueires;
using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
		private readonly IRepository<Car> _repository;
		public GetCarByIdQueryHandler(IRepository<Car> repository)
		{
			_repository = repository;
		}
		public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
		{
			var values = await _repository.GetByIdAsync(query.Id);
			if (values == null)
			{
				throw new Exception($"Car with ID {query.Id} not found.");
			}

			return new GetCarByIdQueryResult
			{
				BrandID = values.BrandID,
				BigImageUrl = values.BigImageUrl,
				CoverImageUrl = values.CoverImageUrl,
				Fuel = values.Fuel,
				CarID = values.CarID,
				Transmission = values.Transmission,
				Seat = values.Seat,
				Model = values.Model,
				Km = values.Km,
				Luggage = values.Luggage
			};
		}
    }
}
