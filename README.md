# ReCapProject
Yazılım Geliştirici Yetiştirme Kampı Araç Kiralama Sistemi 

<table>
<tr>
<td>
  <b>Packages-technologies used</b>

* [**Microsoft.EntityFrameworkCore / Version 5.0.2**](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) 
* [**Microsoft.EntityFrameworkCore.SqlServer / Version 5.0.2**](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer) 
* [**FluentValidation / Version 9.5.0**](https://www.nuget.org/packages/FluentValidation/) 


</td>
</tr>
</table>



### [About Layered](#About-Layered)
#### Core Layer : 
* Bu katman projede bir kez kullanılacak, ortak sınıfların, methodların olduğu kısımdır. 

#### Data Access Layer : 
* Bu katmanda sadece veritabanı işlemleri yapılmaktadır. Bu katmanın görevi veriyi ekleme, silme, güncelleme ve veritabanından çekme işlemidir. 

#### Entity Layer : 
* Bu katmanda veriler için hazırlanan class larımızı tutuyoruz. Örneğin veritabanı tablosu(Car) bizim burdaki class larımız oluyor.

#### Business Layer : 
* Bu katmanda iş yüklerimizi yazıyoruz. Öncelikle şunu söylemeliyim bu katman Data Access tarafından projeye çekilmiş olan verileri alarak işleyecek olan katmandır. 

#### UI Layer :
* Bu proje için Console app hazırlandı.
