# Exporting data from a MySQL database using SELECT…INTO OUTFILE

<https://www.red-gate.com/simple-talk/homepage/exporting-data-from-a-mysql-database-using-selectinto-outfile/>

```sql
SELECT <em>statement_elements</em>
INTO OUTFILE '<em>file_name</em>'
[FIELDS
  [TERMINATED BY '<em>string</em>']
  [[OPTIONALLY] ENCLOSED BY '<em>char</em>']
  [ESCAPED BY '<em>char</em>']]
[LINES
  [STARTING BY '<em>string</em>']
  [TERMINATED BY '<em>string</em>']];
```

Sample:

```sql
SELECT 'abc', 123, 'def', 456
INTO OUTFILE 'values01.txt';
```
![image](https://github.com/nilsandrey/TIL/assets/3579285/137baa7a-d3b0-4a86-bec6-6b666f7aef32)

Sample 2:

```sql
SELECT plane, engine_type, engine_count, max_weight, plane_length
FROM airplanes
WHERE engine_type = 'jet'
ORDER BY plane
INTO OUTFILE '/Users/user1/data/jets01.txt';
```
![image](https://github.com/nilsandrey/TIL/assets/3579285/0aa77382-631e-4bd0-bce2-09bb3173bbad)

## Modifiers

```sql
SELECT plane, engine_type, engine_count, max_weight, plane_length
FROM airplanes
WHERE engine_type = 'jet'
ORDER BY plane
INTO OUTFILE '/Users/user1/data/jets03.txt'
  FIELDS TERMINATED BY ',' OPTIONALLY ENCLOSED BY '"' ESCAPED BY '\\'
  LINES TERMINATED BY '\n' STARTING BY '';
```

![image](https://github.com/nilsandrey/TIL/assets/3579285/7fbdeb34-d1eb-41d4-b500-71eda99579c4)
