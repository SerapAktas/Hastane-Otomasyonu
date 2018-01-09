# Hastane-Otomasyonu
Otomasyon 3 modülden oluşmaktadır. C# kullanılmıştır.XML ile tüm kayıtlar tutulmuş ve diğer formlardan da XML ile veriler çekilmiştir.
* 1)Doktor
   * a)Randevu tarihine göre hasta listesini görebilir.
   * b)Sıradaki hastayi bir butona basarak çağırabilir.Ve sıradaki hasta oluşan pop-up ile kendi adını ekranda görebilir. 
* 2)Hasta
   * a)Hasta MHRS'de olduğu gibi T.C kimlik numarası ile bir üyelik oluşturabilir.
   * b)Randevu alma sayfasında öncelikle poliklinik seçilecek, sonra o poliklinikteki doktorlar listelenecektir.
     Doktor seçimi yapıldıktan sonra bir saat seçim ekranı oluşacaktır.
     Doktorun seçilen tarihte randevu saati önceden alınmış olanlar kırmızı ile görünecek ve tekrar seçilmesine izin verilmeyecektir.
     Hastalar uygun saati seçerek randevu alabileceklerdir.
     Ayrıca hastalar randevu geçmişini listeleyebilir ve güncel randevularını iptal edebilmektedirler.
* 3)Başhekim 
  -  Bu modüle bağlı Doktor, Hemşire ve Personel formları var.
   Başhekim hastane bünyesine Doktor bilgisi ekleme, silme, güncelleme, listeleme ve doktorlara hemşire atama yetkilerine sahiptir.
   Ayrıca hemşire ve personel ekleme, silme, güncelleme ve listeleme yetkilerine sahiptir.
