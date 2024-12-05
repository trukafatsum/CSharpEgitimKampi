- # C# Eğitim Kampı  301
  **M&Y Yazılım Akademi Eğitim Danışmanlık**

  [Eğitim Kampı Youtube - Playlist](https://www.youtube.com/playlist?list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr)

  
  
  **C# Eğitim Kampının devamı..**

![Achievement/Artifact](https://github.com/trukafatsum/CSharpEgitimKampi301/blob/master/1-2-3caseler.jpg)

-----

# 📦İlerleme Durumu ve Alt Başlıklar


## **Ders 11 : New Solution & N Tier Architecture**

- EntityLayer, DataAcessLayer, BusinessLayer, Presentation / UI Layer Olmak üzere 4 Katman İçin Class Library Projeleri Oluşturma
- Bu 4 Katman Hakkında Ne İşe Yarayacağına Dair Bilgilendirme
- EntityLayer Katmanında Concrete Klasörü Oluştrup Category, Customer, Order, Product Sınıflarını Oluşturma
- Concrete Hakkında Kısaca Bilgilendirme
- Access Modifiers Hakkında Kısaca Bilgilendirme
- C# Sınıf Yapısı ve Sql Tablo Yapısı İlişkisi
- Field - Variable - Property Arasındaki Farklar
- SOLID Prensibi Hakkında Bilgilendirme

------

## **Ders 12 : Data Access Katmanı ve Context Sınıfı**

- Entity Katmanında Yer Alan Sınıflarda Bire Çok İlişkinin Kurulması
- Nuget Package : Entity Framework İndirmesi
- Entity -> Data Access -> Business -> Presentation Projelerin Referans İlişkisi
- Data Access projesinde Context Klasörü Oluşturma
- Context : Veritabanı Bağlantı ve Veritabanına Yansıyacak Olan Tabloları Tuttuğumuz Bir Sınıf Görevini Görür.
- Context Klasörü İçerisine DbContext sınıfından kalıtım alan CampContext Sınıfı Oluşturma
  Bir Varlık(Entity) Sınıfını Veritabanına Yansıtmak İçin Context Sınıfı İçerisine DbSet<ClassName> Olarak Tanımlanması Gerekir. Pillar Lays Kavramı
- Presentation Katmanında App.Config İçerisine Sql Bağlantısını Cümlesini Tanımlama

------

## **Ders 13 : Migration Operations & Abstract Interfaces**

- Migration Tanımı ve Kullanımı
- Package Manager Console default: Context sınıfımızın olduğu DAL Projesi
  - enable-migrations
  - update-database
  - add-migration

- Interface Tanımı
- Repository Design Pattern Tanımı
- Refactoring Guru Website- Tasarım Desenleri İncelemesi
- DAL Katmanında Generic Interface ve Bundan Kalıtım Alan Category, Customer, Product, Order Interface'leri Oluşturuldu

------

## **Ders 14 : ORM / EntityFramework / DB First / Modelling**

- EFProject Adında Yeni Bir WinForm Projesi Oluşturduk,
- ORM, EntityFramework, DBFirst Hakkında Makale İnceledik,
- SQL Tarafında Yeni Bir Veritabanı Oluşturup Tabloları Tanımladık
- AdoNet Model Oluşturduk ve Oluşturulan İçeriği İnceledik

------

## **Ders 15 : EntityFramework Methods with Example Project**

- Bir Önceki Derste Modellediğimiz Enitiylerden Instance Oluşturma
- ToList, Add, Remove, SaveChanges Metotlarının Kullanımı
- Id Değerine Göre Listeleme
- MessageBox Sınıfından Ekrana Bilgi Yazdırma

------

## **Ders 16 : EntityFramework Methods with Tour Project : Location Form**

- Bir Önceki Derste Modellediğimiz Enitiylerden Instance Oluşturma
- ToList, Add, Remove, SaveChanges Metotlarının Kullanımı
- Id Değerine Göre Listeleme
- MessageBox Sınıfından Ekrana Bilgi Yazdırma

------

## **Ders 17 : EntityFramework LINQ Methods with Tour Project : Statistics Form**

- İstatistik Bilgileri Ekranda Göstermek Üzere Yeni Bir Form Oluşturduk
- Form tasarımına 12 panel ve 24 label ekledik 
- Her Panel İçerisindeki İlgili Bilgileri LINQ Sorguları Aracılığıyla Veritabanından Getirdik
- Kullandığımız metotlar : Where, Select, ToString, Max, Count, Sum, Average, FirstOrDefault

![Statistics Image](https://github.com/trukafatsum/CSharpEgitimKampi301/blob/master/Resources/Statistics.png)

------

## **Ders 18 : EntityState Commands, Generic Repository, EF Classes**

- EntityState durumları ve önemi
- DataAccessLayer'da Generic Repository oluşumu
- EF Sınıfları tanımlanması
- Mimari çalışmalar (Abstract)..

------

## Ders 19 : BusinessLayer (Logic)

- Abstract klasörü altına Generic ve Diğer Interfaceleri tanımlama
- Concrete klasörü altına Sınıflarımızı tanımlama ve Interfacelerin implementasyonu
- PresentationLayer da Kategori için form hazırlama ve düzenleme

----

## Ders 20 : Dependency Injection (Bağımlılık Enjeksiyonu)

- **Temel Amaçları :** Gevşek bağlılık (Loose Coupling), Test Edilebilirlik, Bakım Kolaylığı, Tek Sorumluluk İlkesi (Single Responsibility - SOLID)

- **Nasıl Çalışır :** Genellikle üç yöntemle uygulanır, 1.Constructor Injection / 2. Setter Injection / 3. Method Injection
- **Avantajlar :** 
  - Bağımlılıkların yaşam döngüsünü merkezi olarak yönetebilirsiniz.
  - Kodun okunabilirliği ve düzenini arttırır
  - Yeniden kullanılabilir ve modüler bir kod yapısı sağlar
- BusinessLayer da Manager sınıflarımıza DI uyguladık
- PresentationLayer (FormUI) da Listeleme, Ekleme, Silme, Güncelleme, ID'ye Göre Getirme İşlemlerini tanımladık
