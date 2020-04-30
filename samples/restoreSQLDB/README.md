 # Standalone processing individual database
 .\parallel-process-mssql-objects.ps1 -vip 10.2.148.61 -username admin -sourceServer 10.2.100.162 -sourceInstance  SQL2014 -sourceDB SQL2014_DB  -overWrite:$true -wait:$true -progress:$true

 # Standalone parallel processing all databases inside a single instance
 .\parallel-process-mssql-objects.ps1 -vip 10.2.148.61 -username admin -sourceServer 10.2.100.162 -sourceInstance  SQL2014  -overWrite:$true -wait:$true -progress:$true
 
 # Piped selection of db and parallel processing of selected dbs 
 .\searchDB.ps1 -vip 10.2.148.61 -username admin -jobName  mssql-59-and-162 | Out-GridView -PassThru | .\parallel-process-mssql-objects.ps1 -vip 10.2.148.61 -username admin -sourceServer 10.2.100.162 -overWrite:$true -wait:$true -progress:$true
 
 # Use the encapsulated script for piped operation of db
 .\restoreDB.ps1 -vip 10.2.148.61 -username admin -jobName mssql-59-and-162