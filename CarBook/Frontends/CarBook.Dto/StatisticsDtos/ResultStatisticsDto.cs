using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int carCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public int avgPriceForDaily { get; set; }
        public int avgPriceForWeekly { get; set; }
        public int avgPriceForMonthly { get; set; }
        public int brandNameByMaxCar { get; set; }
        public int blogTitleByMaxBlogComment { get; set; }  
        public int carCountByTranmissionIsAuto { get; set; }
        public int carCountByKmSmallerTahn1000 { get; set; }
        public int carCountByFuelGasolineOrDiesel { get; set; }
        public int carCountByFuelElectric { get; set; }
        public int carBrandAndModelByRentPriceDailyMax {  get; set; }   
        public int carBrandAndModelByRentPriceDailyMin { get; set; }  
    }
}
