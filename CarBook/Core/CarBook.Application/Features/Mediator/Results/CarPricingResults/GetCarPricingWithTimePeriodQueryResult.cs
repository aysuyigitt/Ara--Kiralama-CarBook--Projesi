using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CarPricingResults
{
	public class GetCarPricingWithTimePeriodQueryResult
	{
		public string Model { get; set; }
		public int DailyAmount { get; set; }
		public int WeeklyAmount { get; set; }
		public int MonthlyAmount { get; set; }
		public string CoverImageUrl {  get; set; }	
		public string BrandName { get; set; }	
	
	}
}
