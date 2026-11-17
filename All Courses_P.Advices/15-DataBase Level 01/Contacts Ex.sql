
restore database ContactsDB
from disk= 'C:\ContactsDB.bak'

use ContactsDB


SELECT  Contacts.FirstName
FROM     Contacts INNER JOIN
               Countries ON Contacts.CountryID = Countries.CountryID
WHERE   (ContactID = 1)

select * from Countries


select * from Contacts
where FirstName = 'Jane' and CountryID = 1;


select * from Contacts
where FirstName like 'ja%';


select * from Contacts
where FirstName like '%id';

select * from Contacts
where LastName like '%h%' and LastName not like '%h';