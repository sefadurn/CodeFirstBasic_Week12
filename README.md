🎯 Proje Amacı

Bu proje, Entity Framework Core (Code First yaklaşımı) kullanılarak SQL Server üzerinde veritabanı oluşturmayı ve yönetmeyi amaçlamaktadır.
Uygulamada oyunlar (Games) ve filmler (Movies) için tablolar tanımlanmış ve veriler üzerinde CRUD işlemleri yapılabilecek şekilde yapılandırılmıştır.

📂 Proje Yapısı

Context/

PatikaFirstDbContext.cs → Veritabanı bağlantısı ve tablo tanımları

Entities/

GameEntity.cs → Oyunları temsil eden tablo

MovieEntity.cs → Filmleri temsil eden tablo

🗄️ DbContext

PatikaFirstDbContext, SQL Server ile bağlantıyı sağlar ve tabloları (Games, Movies) yönetir.

🏗️ Entity Açıklamaları

GameEntity: Oyunları temsil eden entity. İçerisinde Id, Name, Platform ve Rating alanları bulunur.

MovieEntity: Filmleri temsil eden entity. İçerisinde Id, Title, Genre ve ReleaseYear alanları bulunur.

🚀 Migration ve Veritabanı Güncelleme

Migration oluşturmak için: dotnet ef migrations add InitialCreate

Veritabanını güncellemek için: dotnet ef database update
