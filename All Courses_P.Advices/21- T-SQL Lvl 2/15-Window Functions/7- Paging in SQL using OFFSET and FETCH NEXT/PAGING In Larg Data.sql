select count(*) as RecordNum from  CarsDet
--select * from CarsDet

select  count(*) / 100 as RecordNum from  CarsDet

DECLARE @PageNumber AS INT, @RowsPerPage AS INT;

SET @PageNumber = 3115;
SET @RowsPerPage = 100;

SELECT MakeID, ModelID, Year, Submodel
FROM CarsDet
ORDER BY Year
OFFSET (@PageNumber - 1) * @RowsPerPage ROWS 
FETCH NEXT @RowsPerPage ROWS ONLY;