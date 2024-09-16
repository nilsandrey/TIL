# Table size

```sql
SELECT TBL.name AS ObjName
STAT. row count AS StatRowCount
STAT. used_page count
* 8 AS UsedSizeKB
STAT. * 8 AS RevervedSizeKB
, OBJ . type_desc
FROM tempdb.sys.partitions AS PART
INNER JOIN tempdb . sys . AS STAT
ON PART. partition_id =
STAT. partition_id
AND PART. partition number = STAT. partition number
INNER JOIN tempdb.sys.
tables AS TBL
TBL . object_id
ON STAT .object_id =
INNER JOIN tempdb.sys.objects as OBJ
on TBL.name = OBJ
. name
'U'
WHERE OBJ.type
ORDER BY TBL.name;
```

![image](https://github.com/nilsandrey/TIL/assets/3579285/a53ad74a-7680-4abc-87fc-da4e1883495c)


// TODO: Fix code by the image and delete the image
