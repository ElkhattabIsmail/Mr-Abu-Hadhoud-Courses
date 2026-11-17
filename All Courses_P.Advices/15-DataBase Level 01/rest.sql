EXEC sp_changedbowner 'sa';

restore database Shop_Database
from disk = 'C:\Shop_Database.bak';