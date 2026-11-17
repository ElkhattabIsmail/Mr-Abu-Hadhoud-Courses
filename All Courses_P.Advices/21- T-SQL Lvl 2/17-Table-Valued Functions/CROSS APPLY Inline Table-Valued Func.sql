
use SQL_Challenges;
🔍 What is CROSS APPLY?

CROSS APPLY allows you to join each row from your main table to the output of a table-valued function or expression, using data from that row.

🔁 Think of it like:

“For every row in the left table, run the function or subquery on that row and return the result.”

It’s similar to a JOIN, but more flexible for derived tables, inline functions, or XML nodes.

🔸 Basic Example

Suppose you have this table:

CREATE TABLE logs (
    log_id INT,
    ip VARCHAR(20)
);

INSERT INTO logs VALUES (1, '192.168.1.1');

And this query:
SELECT 
    logs.log_id,
    split_octets.value AS part
FROM logs
CROSS APPLY STRING_SPLIT(logs.ip, '.') AS split_octets;


🧠 What’s happening:

logs has 1 row: '192.168.1.1'

STRING_SPLIT('192.168.1.1', '.') returns 4 rows: 192, 168, 1, 1

CROSS APPLY runs STRING_SPLIT() for that row, and returns 4 rows in the result

📘 In Our XML Example:
This part:
CROSS APPLY (
    SELECT CAST('<x>' + REPLACE(ip, '.', '</x><x>') + '</x>' AS XML)
) AS X(Data)


Converts the IP like '192.168.1.1' into:

<x>192</x><x>168</x><x>1</x><x>1</x>


X.Data is the XML value for that IP

Then:
CROSS APPLY X.Data.nodes('/x') AS T(N)


.nodes('/x') finds each <x> element — one per octet

It returns a row for each <x>, so:

'192.168.1.1' → 4 rows

'192.168.1' → 3 rows

🧠 Why Not Just Use JOIN?

JOIN works only when both sides are tables.

CROSS APPLY allows the right side to be a function or expression that depends on each row of the left side.

CROSS APPLY is like a correlated subquery turned into a table.

🧪 Real-Life Analogy

Imagine you have a box of fruits (logs.ip) and a knife (STRING_SPLIT or XML). For every fruit (row), you slice it and look at the pieces (octets). CROSS APPLY says:

"Take each fruit from the box and slice it individually. Collect the slices as new rows."

🧱 Summary
Keyword	Purpose	Accepts table-valued expressions?	Can reference outer row?
INNER JOIN	Matches rows between tables	❌	❌
CROSS APPLY	Applies row-by-row logic or function	✅	✅
OUTER APPLY	Like CROSS APPLY but keeps unmatched left rows (like LEFT JOIN)	✅	✅






------------------------------------------------------------------------------------------
✅ Built-in Functions You Can Use with CROSS APPLY

CROSS APPLY works best with table-valued functions (TVFs) and expressions that return tables, including:

🔹 1. STRING_SPLIT

Split a string into rows.

SELECT log_id, ip, s.value AS octet
FROM logs
CROSS APPLY STRING_SPLIT(ip, '.') AS s;


🟡 Note: This function doesn’t return position/order.

🔹 2. OPENJSON (SQL Server 2016+)

Parse JSON and return table rows.

DECLARE @json NVARCHAR(MAX) = '["192","168","1","1"]';

SELECT value
FROM OPENJSON(@json);


Or inside CROSS APPLY:

SELECT log_id, ip, j.value AS octet
FROM logs
CROSS APPLY OPENJSON('["' + REPLACE(ip, '.', '","') + '"]') AS j;


✅ This behaves like a structured STRING_SPLIT with order!

🔹 3. nodes() (XML Method)

Used with XML to return table of nodes (perfect for ordered splits):

SELECT 
    log_id,
    ip,
    x.value('.', 'VARCHAR(10)') AS octet
FROM logs
CROSS APPLY (
    SELECT CAST('<x>' + REPLACE(ip, '.', '</x><x>') + '</x>' AS XML)
) AS xmlData(data)
CROSS APPLY data.nodes('/x') AS T(x);


✅ Great for ordered splitting.

🔹 4. CROSS APPLY VALUES() (simulate row generation)

Use VALUES() to generate multiple rows manually or manipulate columns:

SELECT log_id, ip, v.val
FROM logs
CROSS APPLY (
    VALUES
        (LEFT(ip, CHARINDEX('.', ip) - 1)),
        ('Static or calculated value')
) AS v(val);


✅ Useful for generating virtual rows per input.

🔹 5. Built-in Inline TVFs like sys.dm_exec_* (Dynamic Management Views)

Get related system info per row (e.g. active sessions):

SELECT
    s.session_id,
    c.client_net_address
FROM sys.dm_exec_sessions s
CROSS APPLY sys.dm_exec_connections c
WHERE s.session_id = c.session_id;


✅ Very useful for server health, connections, performance.

🔹 6. fn_get_sql() (Used with CROSS APPLY)

Used to get SQL text from memory:

SELECT 
    r.session_id,
    t.text
FROM sys.dm_exec_requests r
CROSS APPLY sys.dm_exec_sql_text(r.sql_handle) AS t;


✅ Very useful for monitoring active queries.
------------------------------------------------------------------------------------------





