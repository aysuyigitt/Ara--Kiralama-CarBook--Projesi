using CarBook.Dto.CarDtos;
using CarBook.Dto.CarPricingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Araçlarımız";
            ViewBag.v1 = "Aracınızı Seçiniz";

           var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:33741/api/CarPricings");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarPricingWithCarDto>>(jsonData);

                // Kontrol için model null mı?
                if (values == null || !values.Any())
                {
                    Console.WriteLine("Model Boş Döndü!");
                }

                return View(values);
            }

            Console.WriteLine("API isteği başarısız!");
            return View();  // Eğer istek başarısızsa.
        }

        public async Task<IActionResult> CarDetail(int id)
        {
            ViewBag.v1 = "Araç Detayları";
            ViewBag.v1 = "Aracın Teknik Aksesuar ve Özellikleri";
            ViewBag.carid = id;
            return View();  
        }
    }
}
