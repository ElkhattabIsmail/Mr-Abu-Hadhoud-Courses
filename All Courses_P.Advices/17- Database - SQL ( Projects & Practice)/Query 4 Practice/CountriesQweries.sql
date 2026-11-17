
select * from People

select * from Countries

select CountryID from Countries
where CountryName = 'Morocco'

update People
set ImagePath = 'C:\Users\ULTRAPC\OneDrive\Bureau\University degree\Usa Pic.jpg'
where PersonID in (1023,1024,1025)