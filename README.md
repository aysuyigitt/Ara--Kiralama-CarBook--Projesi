## Onion Architecture ile ASP.NET Core Araç Kiralama Sistemi: BookCar 🚗

BookCar, modern yazılım mimarilerinden Onion Architecture kullanılarak geliştirilmiş bir araç kiralama sistemidir.


### 🛠️ Katmanlı Mimari


🧩 **Core:** Uygulamanın temel yapı taşlarını oluşturan arayüzler, Cors yapılandırmaları ve MediatR işlemleri.

🔗 **Infrastructure:** Harici servis entegrasyonları ve altyapı destekleyici işlemler.

🌐 **Persistence:** Uygulamanın dış dünyaya açılan yüzü, API uç noktaları.

🌍 **Frontend:** Kullanıcı arayüzü bileşenleri ve DTO'lar ile Web UI elemanları.


### Kullanılan Teknolojiler


💻 **C# ve ASP.NET Core 8.0:** Backend geliştirme ve web API altyapısı.

📤 **MediatR & CQRS:** Komut ve sorgu işlemlerinin ayrıştırılması ve iş akışı yönetimi.

🛠️ **Swagger:** API test ve dokümantasyonu.

🗄️ **MSSQL:** Veritabanı altyapısı.

🌐 **HTML ve CSS:** Kullanıcı dostu ve modern bir arayüz tasarlamak için temel web teknolojileri.

🎨 **Bootstrap:** Responsive ve estetik bir tasarım için CSS framework'ü.


### 🔍 Kullanıcı İşlevleri


📅 **Araç Arama ve Listeleme:** Kullanıcılar, başlangıç ve bitiş tarihleri ile lokasyon bilgisi girerek araçları arayabilir ve uygun araçları listeleyebilir.

🚗 **Araç Rezervasyonu ve Kiralama:** Kullanıcılar, seçtikleri araçları kolayca rezerve edebilir ve belirli tarihler arasında kiralama işlemleri yapabilir.

🚘 **Öne Çıkan Araç Modelleri:** Öne çıkan araç modelleri, kullanıcıların ilgisini çekmek için ayrı bir bölümde listelenir. Kullanıcılar, bu modelleri inceleyip "Kirala" veya "Detaylar" seçenekleriyle hızlı işlem yapabilir.

💵 **Araç Fiyatlandırma (Car Pricing):** Araçlar için farklı kiralama seçenekleri sunulmuştur.

⏱️ Saatlik Kiralama Ücreti: Kısa süreli ihtiyaçlar için esnek fiyatlandırma.

📆 Haftalık Kiralama Ücreti: Uzun süreli kiralamalarda ekonomik çözümler.

📅 Aylık Kiralama Ücreti: Daha uzun dönem ihtiyaçlar için avantajlı fiyatlar.

📖 Blog Kısmı: Blog kısmında, araç kiralama ipuçları, araba seçimi, güvenli sürüş gibi konularda bilgilendirici yazılar yer alır.
