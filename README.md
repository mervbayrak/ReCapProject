# ReCapProject
Yazılım Geliştirici Yetiştirme Kampı Araç Kiralama Sistemi 

![](https://github.com/mervbayrak/ReCapProject/blob/main/CarRentalWebSystem/src/assets/img/screensofgit/ekran1.png)

<table>
<tr>
<td>
  <b>Packages-technologies used</b>

* [**Microsoft.EntityFrameworkCore / Version 5.0.2**](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) 
* [**Microsoft.EntityFrameworkCore.SqlServer / Version 5.0.2**](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer) 
* [**FluentValidation / Version 9.5.0**](https://www.nuget.org/packages/FluentValidation/) 
* [**Autofac / Version 6.1.0**](https://www.nuget.org/packages/Autofac/) 
* [**JWT / JSON Web Token**](https://jwt.io/) 


</td>
</tr>
</table>



### [About Layered](#About-Layered)
<table>
  <tr>
<td>
  
#### [Core Layer](https://github.com/mervbayrak/ReCapProject/tree/main/CarRentalSystem/CarRentalSystem.Core) : 
* Bu katman projede bir kez kullanılacak, ortak sınıfların, methodların olduğu kısımdır. 

<table>
<tr>
<td>PackageReference</td>
<td>Projects</td>
</tr>
<tr>
<td>
      
* Autofac
* Autofac.Extensions.DependencyInjection
* Autofac.Extras.DynamicProxy
* FluentValidation
* Microsoft.EntityFrameworkCore
* Microsoft.Extensions.Configuration
* Microsoft.IdentityModel.Tokens
* System.IdentityModel.Tokens.Jwt
      
</td>
<td></td>
</tr>
</table>
 


#### [Data Access Layer](https://github.com/mervbayrak/ReCapProject/tree/main/CarRentalSystem/CarRentalSystem.DataAccess) : 
* Bu katmanda sadece veritabanı işlemleri yapılmaktadır. Bu katmanın görevi veriyi ekleme, silme, güncelleme ve veritabanından çekme işlemidir. 

<table>
<tr>
<td>PackageReference</td>
<td>Projects</td>
</tr>
<tr>
<td>
  
* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
</td>
<td>
  
* Core
* Entity
</td>
</tr>
</table>



#### [Entity Layer](https://github.com/mervbayrak/ReCapProject/tree/main/CarRentalSystem/CarRentalSystem.Entities) : 
* Bu katmanda veriler için hazırlanan class larımızı tutuyoruz. Örneğin veritabanı tablosu(Car) bizim burdaki class larımız oluyor.
<table>
<tr>
    <td>PackageReference</td>
    <td>Projects</td>
</tr>
<tr>
<td>
  </td>
<td>
  
 * Core
  </td>
</tr>
</table>

#### [Business Layer](https://github.com/mervbayrak/ReCapProject/tree/main/CarRentalSystem/CarRentalSystem.Business) : 
* Bu katmanda iş yüklerimizi yazıyoruz. Öncelikle şunu söylemeliyim bu katman Data Access tarafından projeye çekilmiş olan verileri alarak işleyecek olan katmandır. 
<table>
<tr>
    <td>PackageReference</td>
    <td>Projects</td>
</tr>
<tr>
<td>
  
* Autofac
* Autofac.Extensions.DependencyInjection
* Autofac.Extras.DynamicProxy
* FluentValidation
* Microsoft.AspNetCore.Http
* Microsoft.AspNetCore.Http.Abstractions
* Microsoft.Extensions.DependencyInjection
</td>
<td>

* Data Access
* Entity
  </td>
</tr>
</table> 


#### [UI Layer](https://github.com/mervbayrak/ReCapProject/tree/main/CarRentalSystem/CarRentalSystem.Console) :
* Bu proje için Console app hazırlandı.
<table>
<tr>
    <td>PackageReference</td>
    <td>Projects</td>
</tr>
<tr>
    <td>
    
  </td>
    <td>
  
 * Business
* Entity
  </td>
</tr>
</table> 


#### [Web API Layer](https://github.com/mervbayrak/ReCapProject/tree/main/CarRentalSystem/CarRentalSystem.WebAPI) :
<table>
<tr>
    <td>PackageReference</td>
    <td>Projects</td>
</tr>
<tr>
<td>
    
    
* Autofac.Extensions.DependencyInjection
* Microsoft.AspNetCore.Authentication.JwtBearer

</td>
<td>
  
  
* Business
* Core
* Data Access
* Entity

</td>
</tr>
</table> 

</td>
</tr>
</table>
