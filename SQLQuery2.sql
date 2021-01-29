--Select
--Select * from Customers  -- * kolonlar demek
Select ContactName Adi, CompanyName SirketAdi,City Sehir from Customers --Adi,SirketAdi,Sehir -Alias
Select * from Customers where City = 'Berlin'

--case insensitive = Büyük/Küçük harf duyarsız (SQL)    --where - koşul demektir.
sElEcT * from Products where CategoryID=1 or CategoryID=3

sElEcT * from Products where CategoryID=1 and UnitPrice>=10    -- <>10  = 10'dan farklı olanları getir demek.

sElEcT * from Products where CategoryID=1 and UnitPrice<>10 

select * from Products where CategoryID = 1 order by UnitPrice asc  --ascending - artan, descending - düşen

select * from Customers order by ContactName asc   -- order by = sırala

select * from Products order by CategoryID, ProductName asc

select * from Products order by UnitPrice   -- Fiyata göre sırala.

select * from Products order by UnitPrice desc

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products   -- Tüm satırları say. 
select count(*) from Customers
select count(*) from Products where CategoryID=1 -- CategoryId'si 1 olan satırlar.  
select count(*) Adet from Products where CategoryID=2

-- Hangi kategoride kaç farklı ürünümüz var?
select categoryId from Products group by CategoryID  --Bütün kategorileri tekrar etmeyecek şekilde listele demek.

select categoryId, count(*) from Products group by CategoryID -- Her kategorideki ürün sayısı

select categoryId, count(*) from Products group by CategoryID having count(*)<10  -- Ürün sayısı 10 un altında olan kategorileri listele.

--count = say, sum = topla, avg = ortalama

select categoryId, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10  -- sayısı 10dan küçük olan, fiyatı 20den fazla olan


-- * kullanmadık. Çünkü tüm kolonları istemiyoruz.
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName

-- inner join - hem products hem de categories i bir arada getirmesi için.   -- on - durumunda, şartında anlamında
select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID 

 
 --Kodun Birleşimi
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID
--Kod Sonu

--Kod Başı
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10
--Kod Sonu

--DTO- Data Transformation Object
--inner join; iki tabloda da eşleşenleri bir araya getirir.

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID  -- Order Details; boşluklu yazıldığından dolayı (hatalı yazmı) köşeli parantezli karşımıza çıkar.

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID  -- left = solda olup sağda olmayanları da getir demek.


--Customers da olup Order da olmayanlar.
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID  
where o.CustomerID is null                   --Hiç ürün almayanları bulmak için null yazdık.

--right join - Sağda olup solda olmayanlar için.

-- İkiden fazla tabloyu join etmek için;
select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o
on o.OrderID = od.OrderID