Entity Framework CRUD 
=======
Entity Framework kullanarak bir Kullanici sınıfı üzerinde CRUD(ekleme,okuma,güncelleme,silme) işlemlerini gösteren örnektir.


**Proje Açıklamaları :**
--------------
- <b>IsmailKocacan.EfOrnek.Domain :</b> Veritabanında ki tablolara karşılık gelen,sınıflar bu class library içersine yazılmıştır.


- <b>IsmailKocacan.EfOrnek.Data   :</b> Domain katmanı içersindeki Kullanici sınıfı "MyDbContext" üyesi olarak tanımlanmıştır.


- <b>IsmailKocacan.EfOrnek.Core   :</b> Core katmanı içersindeki  "MyDbContext" sınıfının üyeleri kullanılarak spesifik işlemlerin
yapıldığı class library projesidir.Örneğin "KullaniciManager" sınıfı domain katmanı içersindeki,Kullanici sınıfı ve Data katmanı içersindeki MyDbContext sınıflarını
kullanarak ekleme,silme,güncelleme,okuma gibi spesifik implementasyonların yapıldığı sınıftır.



- <b>IsmailKocacan.EfOrnek.UnitTest :</b> Core katmanı içersindeki methodların doğru çalışıp çalışmadığını,
test etmek için hazırladığımız unit test projesidir.


- <b>IsmailKocacan.EfOrnek.Presentation :</b> Presentation katmanında ise ,core katmanı içersindeki "KullaniciManager" sınıfı methodları
kullanılarak ilgili arayüz işlemlerinin yapıldığı katmandır.
