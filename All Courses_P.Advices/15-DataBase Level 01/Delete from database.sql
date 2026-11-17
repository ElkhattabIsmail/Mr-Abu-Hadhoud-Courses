 use ContactsDB
 select * from Countries

 Delete From Countries
 where CountryID = 10;

 update Contacts
 set ImagePath = null
 where ContactID = 1;

 update Contacts
 set CountryID = 1
 where ContactID = 1;

 delete from Contacts
 where ContactID = 10;

 drop database ContactsDB

