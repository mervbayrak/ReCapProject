# ReCapProject
Yazılım Geliştirici Yetiştirme Kampı Araç Kiralama Sistemi 


### Packages-technologies used
- Microsoft.EntityFrameworkCore
- FluentValidation


### About Layered 
#### Core Layer : 
Bu katman projede bir kez kullanılacak, ortak sınıfların, methodların olduğu kısımdır. 

#### Data Access Layer : 
Bu katmanda sadece veritabanı işlemleri yapılmaktadır. Bu katmanın görevi veriyi ekleme, silme, güncelleme ve veritabanından çekme işlemidir. (InMemory kısmı veritabanı bağlantısı olmadığı için yapıldı. Daha sonra EntityFramework kısmı devreye girecektir.)

#### Entity Layer : 
Bu katmanda veriler için hazırlanan class larımızı tutuyoruz. Örneğin veritabanı tablosu(Car) bizim burdaki class larımız oluyor.

#### Business Layer : 
Bu katmanda iş yüklerimizi yazıyoruz. Öncelikle şunu söylemeliyim bu katman Data Access tarafından projeye çekilmiş olan verileri alarak işleyecek olan katmandır. 

#### UI Layer :
Bu proje için Console app hazırlandı.
