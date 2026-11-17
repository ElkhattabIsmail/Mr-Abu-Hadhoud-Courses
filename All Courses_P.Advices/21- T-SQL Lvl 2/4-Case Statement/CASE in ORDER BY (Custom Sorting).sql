
use C21_DB1;

-- إستخدامات ال case statement كثيرة جدا ومفيدة
-- مثلا تصنيف الطلاب 

--> Using CASE in ORDER BY (Custom Sorting)
--> Custom sorting of employees based on salary.

--> All Case Statement Returns a Field.
-- create a field with data 1 or 2 and group them by this data
-- like Order by NewID using GUID
-- You can use the case statement inside the orderby 

SELECT * , CASE 
        WHEN SaleAmount > 150 THEN 1   -- a Standalone field 
        ELSE 2
    END as CustomOrder
FROM Sales
ORDER BY 
    CustomOrder, SaleAmount ;  -- order by two fields




