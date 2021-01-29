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

