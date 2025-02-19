🛒 E-Commerce API
Bu proje, .NET 9 ile geliştirilmiş JWT Authentication ve Entity Framework Core Identity tabanlı bir E-Ticaret API'sidir. Kullanıcı kayıt işlemleri, ürün listeleme, sepete ekleme, sipariş oluşturma gibi temel e-ticaret fonksiyonlarını sağlamaktadır.

🚀 Özellikler
✅ Kullanıcı Yönetimi
Kullanıcı kaydı
Kullanıcı girişi (JWT Token ile)

✅ Ürün Yönetimi
Ürün listeleme
Ürün ekleme
Ürün silme

✅ Sepet Yönetimi
Sepete ürün ekleme
Sepetten ürün kaldırma
Sepeti görüntüleme

✅ Sipariş Yönetimi
Sipariş oluşturma
Sipariş geçmişini görüntüleme

🏗 Teknolojiler
.NET 9
Entity Framework Core Identity
JWT Authentication
SQL Server / SQLite
Swagger (API Dokümantasyonu)

📦 Kurulum
1️⃣ Depoyu Klonlayın
git clone https://github.com/kullanici/e-commerce-api.git
cd e-commerce-api

2️⃣ Bağımlılıkları Yükleyin
dotnet restore

3️⃣ Veritabanını Güncelleyin
dotnet ef database update

4️⃣ API'yi Çalıştırın
dotnet run

🔑 Kullanıcı Girişi ve JWT Kullanımı
Kullanıcı giriş yaptıktan sonra, API JWT Token döndürür.
Bu token'ı, yetkilendirme gerektiren API isteklerinde Authorization Header olarak gönderebilirsiniz.

Authorization: Bearer <JWT_TOKEN>
📖 API Endpointleri

🔹 Kullanıcı İşlemleri
POST /api/auth/register → Yeni kullanıcı kaydı
POST /api/auth/login → Kullanıcı girişi (JWT döner)

🔹 Ürün İşlemleri
GET /api/products → Tüm ürünleri listele
POST /api/products → Yeni ürün ekle
DELETE /api/products/{id} → Ürün sil

🔹 Sepet İşlemleri
POST /api/cart/add → Sepete ürün ekle
DELETE /api/cart/remove/{id} → Sepetten ürün çıkar
GET /api/cart → Sepeti görüntüle

🔹 Sipariş İşlemleri
POST /api/orders → Sipariş oluştur
GET /api/orders → Kullanıcının sipariş geçmişi

📌 Swagger Desteği
API endpointlerini denemek için Swagger UI'ı kullanabilirsiniz.
📌 Swagger Arayüzüne Gitmek İçin:

http://localhost:5182/swagger
