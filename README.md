- # C# Eğitim Kampı  301
  **M&Y Yazılım Akademi Eğitim Danışmanlık**

  [Eğitim Kampı Youtube - Playlist](https://www.youtube.com/playlist?list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr)

  
  
  **C# Eğitim Kampının devamı..**
  
  

**Ders 11 : New Solution & N Tier Architecture**

------

- EntityLayer, DataAcessLayer, BusinessLayer, Presentation / UI Layer Olmak üzere 4 Katman İçin Class Library Projeleri Oluşturma
- Bu 4 Katman Hakkında Ne İşe Yarayacağına Dair Bilgilendirme
- EntityLayer Katmanında Concrete Klasörü Oluştrup Category, Customer, Order, Product Sınıflarını Oluşturma
- Concrete Hakkında Kısaca Bilgilendirme
- Access Modifiers Hakkında Kısaca Bilgilendirme
- C# Sınıf Yapısı ve Sql Tablo Yapısı İlişkisi
- Field - Variable - Property Arasındaki Farklar
- SOLID Prensibi Hakkında Bilgilendirme



**Ders 12 : Data Access Katmanı ve Context Sınıfı**

------

- Entity Katmanında Yer Alan Sınıflarda Bire Çok İlişkinin Kurulması
- Nuget Package : Entity Framework İndirmesi
- Entity -> Data Access -> Business -> Presentation Projelerin Referans İlişkisi
- Data Access projesinde Context Klasörü Oluşturma
- Context : Veritabanı Bağlantı ve Veritabanına Yansıyacak Olan Tabloları Tuttuğumuz Bir Sınıf Görevini Görür.
- Context Klasörü İçerisine DbContext sınıfından kalıtım alan CampContext Sınıfı Oluşturma
  Bir Varlık(Entity) Sınıfını Veritabanına Yansıtmak İçin Context Sınıfı İçerisine DbSet<ClassName> Olarak Tanımlanması Gerekir. Pillar Lays Kavramı
- Presentation Katmanında App.Config İçerisine Sql Bağlantısını Cümlesini Tanımlama



**Ders 13 : Migration Operations & Abstract Interfaces**

------

- Migration Tanımı ve Kullanımı
- Package Manager Console default: Context sınıfımızın olduğu DAL Projesi
  - enable-migrations
  - update-database
  - add-migration

- Interface Tanımı
- Repository Design Pattern Tanımı
- Refactoring Guru Website- Tasarım Desenleri İncelemesi
- DAL Katmanında Generic Interface ve Bundan Kalıtım Alan Category, Customer, Product, Order Interface'leri Oluşturuldu



**Ders 14 : ORM / EntityFramework / DB First / Modelling **

------

- EFProject Adında Yeni Bir WinForm Projesi Oluşturduk,
- ORM, EntityFramework, DBFirst Hakkında Makale İnceledik,
- SQL Tarafında Yeni Bir Veritabanı Oluşturup Tabloları Tanımladık
- AdoNet Model Oluşturduk ve Oluşturulan İçeriği İnceledik
