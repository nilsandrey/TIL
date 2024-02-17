# Importing data into a MySQL database using LOAD DATA

## Statement

```sql
LOAD DATA [LOCAL] 
INFILE 'file_name'
[REPLACE | IGNORE]
INTO TABLE table_name
FIELDS
  [TERMINATED BY 'string']
  [[OPTIONALLY] ENCLOSED BY 'char']
  [ESCAPED BY 'char']
LINES
  [STARTING BY 'string']
  [TERMINATED BY 'string']
IGNORE n LINES
[(column_list)]
```

### Samples

CSV file `manufacturers1.csv`:

```csv
101,Airbus
102,Beagle Aircraft Limited
103,Beechcraft
104,Boeing
105,Bombardier
106,Cessna
107,Embraer
```

Sentence:

```sql
LOAD DATA LOCAL INFILE 
  '/Users/mac3/Documents/TravelData/manufacturers1.csv' 
INTO TABLE manufacturers 
FIELDS TERMINATED BY ',' 
(manufacturer_id, manufacturer);
```

## Modifiers

### Ignoring first lines

```sql
LOAD DATA LOCAL INFILE 
  '/Users/mac3/Documents/TravelData/manufacturers2.csv' 
INTO TABLE manufacturers 
FIELDS TERMINATED BY ',' 
IGNORE 1 LINES
(manufacturer_id, manufacturer);
```

for:

```csv
manufacturer_id,manufacturer
101,Airbus
102,Beagle Aircraft Limited
103,Beechcraft
104,Boeing
105,Bombardier
106,Cessna
107,Embraer
```

More: 

```sql
LOAD DATA LOCAL INFILE 
  '/Users/mac3/Documents/TravelData/manufacturers5.txt' 
INTO TABLE manufacturers 
FIELDS ENCLOSED BY '"'
LINES STARTING BY '*,*'
IGNORE 1 LINES
(manufacturer_id, manufacturer);
```

