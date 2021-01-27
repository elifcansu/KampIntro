--Select çalıştırmak istediğimiz kodu seçeriz
select ContactName Adi,CompanyName,City Sehir from Customers  --customers tablosundaki tüm kolonları getirir.* bütün kolonları getirir. biz bu kodu çalıştırdığımızda aslında fake bir tablo oluşuyor. 

select * from Customers where City='London' --şehri london olanları getir.where koşul demek 

--case insensitive harf büyük küçük farketmez
select * from Products where CategoryID=1 or CategoryID=3 --1 veya 3 numaralı kategoriye ait ürünleri getir. e ticaret sisteminde seçtiğiz kategorilerde arka tarafta aslında böyle bir kod çalışır.

select * from Products where CategoryID=1 and UnitPrice>=10 --kategorisi 1 ve unitprice 10 dan büyük olan ürünleri getirir.

select * from Products order by CategoryID,ProductName --önce categoryid sıralar sonra onları kendi içinde ürünlere göre sıralar

select * from Products order by UnitPrice asc   ---ascending fiyat artana göre sıralar. asc yazmak şark değil

select * from Products order by UnitPrice desc  ---descending fiyat azalan demek.

select * from Products where CategoryID=1 order by UnitPrice desc 

select COUNT(*) ÜrünSayısı from Products  --productta kaç data var kaç satır var demek. sayma işlemi yaptığından bir kolon bir satır gelir bu sorgularda.

select COUNT(*) ÜrünSayısı from Products where CategoryID=1 ---1 numaralı kategoride kaç ürün var

--hangi kategoriden kaç tane ürün var?
--bütün kategorileri tekrar etmeyecek şekilde getirir.

select categoryID,COUNT(*) FROM Products group by CategoryID --kategorileri gruplayıp kaç tane olduklarını getirdi.

--ürün sayısı 10 dan az olan kategorileri listele unit price da 20 den büyük olsun.
select categoryID,COUNT(*) FROM Products where UnitPrice>20 group by CategoryID having COUNT(*)<10 --having kumuletifler uygulanır sum count gibi şeyler.

--kategori ve productı birleştiriyoruz
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID


--DTO Data Transformation object   joinlerle oluşturduğumuz tabloları bir class gibi tutmamızı sağlar.

--fiyatları 10 dan büyük olan ürünleri kategorileri ile birlikte getir.
--inner join ikisinde de olanları getirir.
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10  

--solda olup sağda olmayanlarıda getir.ürünler tablosunda var ama hiç satışı yok demek
select * from Products p left join [Order Details] od  
on p.ProductID=od.ProductID

--şöyle düşün bir e ticaret sitesine kayıt olmuşsun ama hiç ürün almamışsın bunu belirleyip o kişiye size özel %10 indirim diye mesaj atarlar.
select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null --primary keye uygulanır genelde bu çünkü o null olmaz olursa da demekki böyle bir durum söz konusudur.


select * from Products p inner join [Order Details] od  
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID