# Learner Education Site Project
M&Y Yazılım Eğitim Akademi Danışmanlık bünyesindeki Full Stack .Net Core Development Bootcamp'i kapsamında Erhan Gündüz eğitmenliği ve Murat Yücedağ mentörlüğündeki 2. projem olan "MyAcademyLearnerProject" projesini tamamladığımı sizlerle paylaşmak istiyorum. 

- Bu proje MVC5 teknolojileri kullanılarak yapılan bir Eğitim Sitesi projesidir. Admin, Öğrenci ve Eğitmen olmak üzere birbiriyle bağlantılı 3 Panel ve UI tarafından oluşmaktadır. Admin, Öğrenci ve Eğitmen panellerinde yapılan CRUD işlemleri UI tarafına eşzamanlı olarak yansımaktadır. Ayrıca tüm panellerde Login ve LogOut seçenekleri mevcuttur. Ek olarak öğrencileri için kaydolma paneli de bulunmaktadır, fakat mevcut bir hesabı varsa ister giriş yapma sekmesinden ister kaydolma sekmesindeki "zaten bir hesabım var" butonundan öğrenci paneline giriş yapabilmektedir.

- Öğrenciler Panele giriş yaptıktan sonra Session ile öğrenci adı ataması yapılır ve kendi kimliklerine ait bilgileri (isim vb.) görebilirler. Öğrenciler kurslarını görüntüleyebilir, kurs içeriğine gidip kurslarıyla ilgili eklenen videoları (dersleri) izleyebilirler, kurslara kaydolabilir (isterse kurs detay sayfasındaki "kursa kaydol" butonundan doğrudan kayıt olma sayfasına yönlendirilebilir) ve puan verip yorum yapabilirler.

- Eğitmenler ise aynı şekilde panellerine giriş yaptıktan sonra Session ile eğitmen adı ataması yapılır ve kendi kimliklerine ait bilgileri (isim vb.) görebilirler. Eğitmenler kendi kurslarını listeleyebilir (crud işlemleri mevcut) kurslarına içerik ekleyebilir, kurslarına ait yorumları görüntüleyebilir ve düzenleyebilirler.

- Admin ise aynı şekilde giriş yaptıktan sonra sayfaya ait her şeye erişimi mevcuttur, kendi bilgilerini düzenleyebildiği gibi eğitmenlerin bilgilerini de düzenleyebilir, kurslara eğitmen atayabilir, yeni kurs oluşturabilir ve diğer tüm sayfalar için crud işlemlerini yapabilirler. 
----------------------------------------------------------------------------------------
### Kullanılan Teknolojiler: 

- Admin, Student, Teacher Login Giriş Panelleri
- LogOut
- Student Register Paneli
- Session
- Proje Seviyesinde Authorize
- CRUD
- Linq Sorgulamaları
- PagedList ile sayfalama
- PartialView Kullanımı
--------------------------------------------------------------------------------------
### Daha detaylı hakim olabilmeniz için aşağıdaki resimleri açıklamalarıyla beraber inceleyebilirsiniz:

- Görüldüğü gibi web sitesi ilk açıldığında bizi bu ekran karşılamaktadır, burda en üstte öğrenci girişi/kayıt olma, admin ve eğitmen girişleri butonları yer almaktadır, alt kısımda ise sayfalarımızın butonları bulunmaktadır.
- Tüm kurslar sayfasına ise navbar veya "tüm kursları görüntüle" butonlarından erişilebilmektedir.

  -  ![ana sayfa ilk görünüm](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/9322cd14-f707-46b6-81b0-6929b044e8a9)
--------------------------------------------------------------------------------------
- Hakkımızda sayfasında kurs hakkında tanıtım yazısı ve içerikler mevcuttur.
- Alt kısımdaki Students, Teachers, Courses ve Kategories alanlarında ise dinamik olarak veritabanından çekilen veriler gelir. Yani mevcutta kaç öğrenci, eğitmen kurs ve kategori olduğunu göstermektedir.

  - ![uı hakkımızda](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/e0070d1f-fdf8-430a-a1de-03aaaef0612b)

--------------------------------------------------------------------------------------
- Burası ise eğitmenler kısmıdır. eğitmenlerimiz hakkında kısa bir yazı ve eğitmenlerimizin isim ve unvanları gözükmektedir.
- Burada kaç kayıtlı eğitmen olursa olsun, yalnızca kaydı yapılan son 6 eğitmen görüntülenecektir.
- Eğer tüm eğitmenleri görüntülemek ve eğitmenler hakkında daha detaylı bilgileri görmek istersek aşağıdaki "Tüm Eğitmenleri Görüntüle" butonuna tıklayarak tüm eğitmenlerin bulunduğu sayfaya yönlendirilirsiniz

  - ![uı eğitmenler](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/00818351-a24b-4c80-a0dc-cd341564078e)
  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/b83d942c-fa9c-4ae9-8b9d-67902aa47eb5)
  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/285eabb9-f6b0-42ec-9f8c-16be2ca40fcc)

--------------------------------------------------------------------------------------
- Burası ise sınıflar kısmıdır. Admin tarafından eklenen sınıflara ve sınıflar hakkındaki bilgilere buradan ulaşabilirsiniz.

  - ![uı sınıflar](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/cbe0b89f-516a-4f84-ae8e-6476cf6afd15)

--------------------------------------------------------------------------------------
- Burası ise kategoriler kısmıdır. Burada kaç kayıtlı kategori olursa olsun, yalnızca kaydı yapılan son 10 kategori görüntülenecektir. 

  - ![uı kategoriler](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/664e6678-2f57-4809-98ae-29019462aff2)
--------------------------------------------------------------------------------------
- Burası ise anasayfadaki kurslar kısmıdır. Güncelde kaç kayıtlı kurs olursa olsun yalnızca eklenen son 6 kursu göstermektedir.
  
- - ![son eklenen 6 kurs](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/ab5aa2d9-4905-4252-9193-ecbdac79dda9)

--------------------------------------------------------------------------------------
- Burası ise sık sorulan sorular kısmıdır. Burada admin tarafından eklenen (contact sayfasından gönderilen talepler doğrultusunda en çok sorulan sorulara yanıt olarak) soru cevap kısmıdır.
  
  - ![uı sık sorulanlar](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/eae65a81-87bf-4e48-ac48-b745ba75dfd4)

--------------------------------------------------------------------------------------
- Burası ise sayfamızın footer kısmıdır. Aynı navbarda olduğu gibi buradan da tüm sayfalara erişim sağlanabilmektedir.
  
  - ![uı footer](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/95d0b97c-144f-41af-888b-0c75f43a3c16)

--------------------------------------------------------------------------------------
- Tüm kurslar sayfasının giriş kısmı, sayfa ilk açıldığında bu ekran bizleri karşılar, Tüm kursları görüntüle butonuna tıklayınca aşağıya doğru kaydıracaktır. Aşağıda ise Eklenmiş olan tüm kursları görebilir kurslarla alakalı detay sayfalarına ulaşabilirsiniz.
 
  - ![tüm kurslar giriş sayfası](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/e0735287-ff0d-423e-a5ac-617548da1a3d)
  - ![tüm kurslar](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/1fe593f5-4327-43d7-a21d-9cae204b252d)

-------------------------------------------------------------------------------------
- Kurs detay sayfası: Burada java ile Nesne Tabanlı Programlam ve diğer başka kurslara ait kurs detay sayfaları yer almaktadır.
- Kurs detay sayfasında kurslarla alakalı bütün bilgiler, kursun eğitmeni, kursa yapılan yorumlar gibi bilgileri görebilirsiniz.
- Ek olarak kursa kaydolmak isterseniz, "Kursa Kaydol" butonuna tıklayarak öğrenci kaydı sayfasına yönlendirilirsiniz.
- Eğer öğrenci olarak bir hesabınız varsa zaten bir hesabım var butonundan öğrenci giriş sayfasına yönlendirilirsiniz.
- Giriş yaptıktan sonra ise Öğrenci Panelindeki Kurs Kaydı sayfasına yönlendirilir ve Kursa kayıt işleminizi gerçekleştirebilirsiniz. Bu adımlar aşağıda sırasıyla gösterilmiştir.

  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/63c26682-b7f9-4b04-aff5-46033a78b01b)
  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/7ff7ac5a-4758-46e8-9eba-151b9adff6d1)
  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/362d3b70-1e35-40b8-89f8-ce51090f402a)
  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/57b62a8a-861c-4331-992b-0a39c13b3876)
  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/252f2a58-a32b-4697-b445-e0ed2d8e2a51)
  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/620b1b60-6506-4bd4-82d3-a3e1538c3172)

-------------------------------------------------------------------------------------
- Burası ise Contact(iletişim) sayfasıdır. Sayfaya ilk geldiğimizde bizi karşılayan ekran böyledir. "Mesaj Gönderin" Butonuna tıklayınca aşağıya doğru kaydıracak ve 2. fotoğraftaski kısma ulaşılacaktır( manuel olarakta inebilirsiniz : ).
- Üçüncü fotoğrafta ise görüldüğü gibi kullanıcı admine bir mesaj göndererek talepte bulunuyor. Bu talepler admin tarafında değerlendiriliyor ve admin gelen isteklere göre yeni kurslar açabilir.
- Görüldüğü gibi son Fotoğrafta Yılmaz Altun adlı kişinin talebi admin sayfasına iletilmiştir. Bu sayfayla alakalı detaylara aşağıda değineceğim.

  - ![iletişim sayfası giriş](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/2ed74fc4-d4b5-42fe-b4ed-77a85207779b)
  - ![iletişim sayfası mesaj gönderme](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/ba4ebab3-613a-4e13-bb2c-860c42bb450d)
  - ![yeni ingilizce kursu talebi mesaj gönderme](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/ea97db22-a614-4e42-b378-4231f6cd5ce3)
  - ![contact sayfasından gelen talepler listesi, son gelen mesaj henüz okunmamış](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/99ecf861-9b8c-4eb6-a073-fe49d71b2d63)

-------------------------------------------------------------------------------------
### Şimdi biraz Admin Panelini inceleyelim: Admin Panelinde Session["adminName"] ataması yapıldığından adminID sine göre hangi admin giriş yapmışsa onun bilgileri gözükmektedir.
-------------------------------------------------------------------------------------
- Admin Dashboard:
- Admin paneline giriş yapınca bizi ilk olarak Admin Dashboard'ı karşılar. Bu dasboardda görüldüğü gibi adminin siteyle alakalı genel durumları takip edebilmesi adına bir çok bilgi mevcuttur.
  
  - ![admin paneli dashboard](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/fb4c32fb-2f8a-4c1c-94c3-dd6b971a8151)

-------------------------------------------------------------------------------------
- Kategoriler listesi: Burada Admin Kategorileri görüntüleyebilmekte, yeni kategori ekleyebilmekte ve kategorileri güncelleyebilip/silebilmektedir. (CRUD İşlemleri)

  - ![admin paneli kategoriler tablosu](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/ed0df987-10b8-4b15-8818-950e17820ff0)
-------------------------------------------------------------------------------------
- Kurslar Listesi: Burada admin tüm kursları gÖrüntüleyebilir ve kurslar üzerinde CRUD işlemleri yapabilmektedir.
- İkinci Fotoğrafta görüldüğü gibi Admin yeni bir kurs ekliyor, kursa kategori ve eğitmen ataması yapıyor ve gerekli bilgileri giriyor.
  
  - ![admin paneli kurslar tablosu](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/dc540403-c184-49d1-bdb3-29bac0343fc1)
  - ![admin yeni kurs ekleme](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/dcfde3e4-74ad-4068-b9a3-2df85f61d046)
  - ![admin yeni kurs eklendi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/237a00fb-d460-4b73-b297-84664d9771dc)


-------------------------------------------------------------------------------------
- Eğitmenler Listesi: Görüldüğü gibi admin panelinden eğitmenler listesine de ulaşılabilmektedir.
- Admin yeni bir eğitmen kaydı yapabilir, Eğitmen bilgisi güncelleyebilir veya eğitmen silebilir.
- Mantık olarak eğitmen Panelinde böyle bir sayfa yok çünkü eğitmen kendi kaydını yapmaması gerekiyor. Kuruma eğitmenin kaydını admin oluşturmaktadır. Onu da bu kısımdan yapabilir. Dolayısyla ayrıca bir Eğitmen Kayıt sayfası bulunmamaktadır.

  - ![admin eğitmen ekle](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/e5e4b2e9-7bbb-4a89-b500-a2d9574ad65c)
  - ![admin eğitmen listesi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/ae7073d1-dd8b-4236-9db2-d6974f58cbff)

-------------------------------------------------------------------------------------
- Sınıflar Listesi: Admin sınıfları görüntüler, yeni sınıf oluşturabilir veya güncelleyebilir/silebilir.
- Admin sınıfları Aktif veya Pasif yapıp Anasayfada görüntülenme durumunu belirleyebilir (Aktifse görüntüle/ pasifse anasayfada çıkmasın)
- Bunun mantığı ise daha önce açılmış sonrasında kapanmış / Yada açılmış ama henüz yayınlanmaması gereken sınıfların Anasayfada görüntülenilmesinin istenmiyor olabilmesi.
  
  - ![admin sınıflar listesi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/e4744d36-a9b1-4649-b61a-f91c3c74ebf9)
-------------------------------------------------------------------------------------
- Yorumlar Listesi: Admin burada tüm kurslara yapılan yorumları görüntüleyebilmektedir.
- Bu kısım için "PagedList.Mvc kütüphanesi" kullanılmıştır. Listeleme işlemi "PagedList" ile yapılmıştır.
- Burada tüm kurslara ait hangi öğrenciler hangi puanları vermiş ve hangi yorumları yapmış admin görebilmektedir. Ayrıca admin kendisi de yorumları güncelleyebilir veya yeni yorum ekleyebilir.
- Bu sayfanın mantığı ise istenmeyen yorumlara adminin müdahale edebilme yetkisinin olmasıdır.
- Aynı görüntüleme işlemi Eğitmen Panelinde de mevcut fakat orada sadece eğitmen kendi kurslarına yapılan yorumları görebilir ve yeni yorum ekleyemen mantıken.

  - ![admin kurs yorumları listesi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/324fdf32-c75d-4792-bfb0-63964cc6f00a)

-------------------------------------------------------------------------------------
- Sık Sorulanlar Listesi: Burada admin Anasayfadaki sık sorulanlar kısmını yönetebilir(Crud işlemleri)
- Admin gelen taleplere ve sorulara göre (Contact Sayfasından kullanıcıların gönderdiği mesajlara göre değerlendiriyor) Ençok sorulan soruları seçer ve soru cevap olarak yayınlar.
- Buradaki aktif pasiflik durumu da sınıf tablosundaki gibi aynı şekilde görüntülenmesinin istenip istenilmemesi durumuna göre değiştirilenbilir
  
  - ![admin sık sorulanlar listesi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/6e797a76-55d5-46e3-82d1-451b3c532af7)

-------------------------------------------------------------------------------------
- Gelen Mesajlar Tablosu: Buradan admin Contact Sayfasından kullanıcıların gönderdiği mesajlara ulaşabilmektedir.
- Burada ise şöyle bir senaryo mevcuttur. Mesaj ilk gönderildiğinde admine "Okunmadı" olarak düşecektir. Admin ise mesaj detayına tıklayıp mesajı okuduktan sonra Okundu Olarak İşaretle butonuna tıklayıp Mesajı okundu haline getirebilir
- Buranın mantığı ise Filtrelemek istediği zaman yalnızca okunmayan mesajları ya da okunan mesajları görüntüleyebilmek içindir. Aşağıda bu işlem sırasıyla gösterilmiştir.
  
  - ![contact sayfasından gelen talepler listesi, son gelen mesaj henüz okunmamış](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/ecb141f7-f4d7-4235-b12b-e016ee8ee6fc)
  - ![mesaj detayına gidiyor](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/d0053ded-d38a-4cc3-9f7b-716d77731be6)
  - ![mesajı açtı okudu ve okundu olarak atandı](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/c997211d-0ade-4a96-8fbc-531ea98f7fe1)

-------------------------------------------------------------------------------------
-  Sosyal Medya Hesapları listesi: Burada Admin Sosyal Medyaları görüntüleyebilmekte, yenisini ekleyebilmekte ve güncelleyebilip/silebilmektedir. (CRUD İşlemleri)

  - ![sosyal medyalar listesi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/16b29797-001f-4546-8d25-9d5e4f8b40e0)

-------------------------------------------------------------------------------------
- Burası ise Contact Sayfasının sağında yer alan iletişim bilgilerini oluştururan kısım. Admin bu panelden yönetebilir.
  
  - ![iletişim listesi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/bd8157f5-137d-487e-9641-f42ee2b10f1a)

-------------------------------------------------------------------------------------
- Burası ise Adminin Profil bilgilerini yönettiği kısımdır. Admin buradan yeni admin ekleyebilir, Profil bilgilerini değiştirebilir.
- Bu kısma Navbardaki sol üstteki Profilim Sekmesinden ulaşabilir. Aynı Kısımda Çıkış yap sekmesinden Çıkış da yapabilir.

  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/75ecafc8-2791-4e76-8490-3e88a4b67de5)

-------------------------------------------------------------------------------------
### Şimdi biraz Eğitmen Panelini inceleyelim: Eğitmen Panelinde Session["teacherName"] ataması yapıldığından teacherID sine göre hangi eğitmen giriş yapmışsa onun bilgileri gözükmektedir.
-------------------------------------------------------------------------------------
- Eğitmen Giriş Sayfası: Bu sayfaya hatırlarsak Anasayfadaki Navbardan erişebiliyorduk.
- Erhan Yılmaz adlı eğitmen giriş yapıyor.
  
- - ![eğitmen giriş sayfası](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/f481d7a3-470d-4053-b9b3-29a30d63bbc8)

-------------------------------------------------------------------------------------

- Eğitmen giriş yaptığında onu ilk olarak Kurslarım Sayfası karşılar, Eğitmen kendi kurslarına ait bilgileri düzenleyebilir ya da kendisi eğitmeni olacağı yeni bir kurs oluşturabilir, eğitmenin kendi kursları için bu yetki eğitmene verilmiştir.
- Burada eğitmenin kayıtlı olduğu (hocası olduğu) kurslar görüntülennir.
- (Entitylerin içerisinde Course tablosuyla Eğitmen tablosu arasında bu bağlantı oluşturulmuştur, Kurs oluştururken Eğitmen de atanıyordu hatırlarsak)
- Son Fotğrafta ise görüldüğü gibi Yeni kurs başarıyla eklenmiş ve Kurs detay sayfasında görüntülenebilmektedir.

  - ![eğitmen paneli](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/227465a6-22b4-4a6e-b874-232cb02f2fe0)
  - ![eğitmen kendisine yeni bir kurs ekliyor](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/fe708308-0a64-48ba-9820-f2529a62f0af)
  - ![eğitmen panelinde yeni kurs eklendi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/01d0d154-a8eb-4c4a-822f-4b53d368f442)
  - ![eğitmenin eklediği yeni kurs eklendi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/d52a2d78-eba5-49bb-980c-10c79ad61b1a)


-------------------------------------------------------------------------------------
- Eğitmen burada ise kendi kurslarına yapılan yorumları, verilen puanları ve öğrenci adlarını görebilmektedir.
- Görüldüğü gibi eğitmen yapılmış olan bir yorumu silebilir veya düzenleyebilir, fakat kendisi yeni bir yorum ekleyemez.
- Bunun sebebi ise istenmeyen yorumlara admin gibi eğitmeninde müdahale edebilmesidir, fakat öğrenci gibi kendisi yeni yorum ve puan ekleyemez böyle bir yetkisi yoktur.
  
  - ![eğitmenin kurslarına yapılan yorumlar](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/771e69f8-d700-46fb-a2c3-22f4b3bafd8a)

-------------------------------------------------------------------------------------
- Burası ise Kurs İçerikleri sayfasıdır.
- Öğretmen Kendi kurslarına Video ekleyebilmektedir. Zaten bu işi eğitmenin yapması mantıken olması gerekendir.
  
  - ![eğitmenin kurs içerikleri](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/2c114ee1-5349-4d2a-81a2-1998a7de3361)
  - ![yeni kursa içerik ekleme](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/d9947b4e-43f9-457e-9f56-5e3eabbca1ba)

-------------------------------------------------------------------------------------
### Şimdi biraz Öğrenci Panelini inceleyelim: Öğrenci Panelinde Session["studentName"] ataması yapıldığından studentID sine göre hangi öğrenci giriş yapmışsa onun bilgileri gözükmektedir.
-------------------------------------------------------------------------------------
- Öğrenci Paneline giriş sayfasında görüldüğü gibi Mustafa Adlı öğrenci giriş yapıyor.
- Öğrenciyi ilk olarak kurslarım sayfası karşılıyor. Fakat önce Kurs kayıt sayfasını göstereceğim:
- Kursa kaydolduktan sonra görüldüğü gibi öğrencinin kurslarım sayfasında yeni kaydolduğu kurs gözükmektedir.
- Yani öğrencinin ID sinin ilgili Course'un tablosuna ataması yapıldı, ve kurslarım sayfasında görüntülenmektedir.

  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/5946dfed-965b-4a32-a792-d669defd9d8c)
  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/6158742c-6c2b-4866-b952-693b8374bb1f)

-------------------------------------------------------------------------------------
- Kurs yorumları sayfası: Öğrenci Bu sayfadan Kurslarına (kurs seçip) puan verip, yorum yapabilmektedir. 
  
  - ![kadir yeni kursa yorum yapıyor](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/fe6dec92-4eaf-4293-878b-03d883ce618b)
  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/18975e7e-e470-4e72-990c-201227e95b87)
    
-------------------------------------------------------------------------------------
- Kurs İçeriği Sayfası: Öğrenci kurslarım sayfasından kurs içeriği butonuna tıklayarak eğitmeninin ilgili kursuna eklemiş olduğu eğitim içeriklerini (video) görebilir ve izleyebilir.
- Bu sayfada da "PagedList.Mvc kütüphanesi" kullanılmıştır. Listeleme işlemi "PagedList" ile yapılmıştır.

  - ![image](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/cfc434b0-42cd-4ee7-bbf0-9077a0dd7b7f)
  - ![yeni kursun kurs içeriği](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/ca9d995d-aafd-4639-a04b-7d96ec9a67d6)

  - ![öğrenci alinin paneli ve kaydolduğu kurslar](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/9cd0b2d0-37e2-40f6-9d98-c026dece1893)
  - ![başka bir kursun kurs içeriği](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/9532a57f-4cfe-4813-88e6-bda47c9e0ef8)

-------------------------------------------------------------------------------------
- Görüldüğü gibi eklenen yeni kurslar ve eğitmenler Anasayfaya da yansıdı
  
  - ![yeni kurslar da eklendi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/747bb4f0-5fd5-4e1e-9092-62fc0705b608)
  - ![yeni eğitmen eklendi](https://github.com/esincaglakiral/MyAcademyLearnerProject/assets/68962573/8559330b-9894-4cdb-acac-b84e92d2b20e)

-------------------------------------------------------------------------------------
### Projemin çalışma sistemi ve mantığı bu şekildedir. Yukarıdan Kodlara ulaşabilirsiniz. 
### Linkedinden ise projemin tanıtım videosuna ulaşmak isterseniz linkedlin adresim: https://www.linkedin.com/feed/update/urn:li:activity:7190471960122867712/
### Buraya kadar okuduğunuz için teşekkür ederim, yeni projelerimde görüşmek üzere :)


