 ### Platform supported
 - Windows only
 ### Standalone processing individual database
 ```
 .\restoreDB.ps1 -vip 10.2.102.233 -username admin -jobName  mssql-162 -restoreType "RESTORE-LOCAL" -sourceInstance  SQL2014 -sourceDB SQL2014_DB
```
 ### Standalone parallel processing all databases inside a single instance
 ```
 .\restoreDB.ps1 -vip 10.2.102.233 -username admin -jobName  mssql-162 -restoreType "RESTORE-LOCAL" -sourceInstance  SQL2014
```
 ### Piped selection of db and parallel processing of selected dbs on source server
 ```
 .\restoreDB.ps1 -vip 10.2.102.233 -username admin -jobName  mssql-162 -restoreType "RESTORE-LOCAL"
 ```

 ### Piped selection of db and parallel processing of selected dbs on target server
 ```
 .\restoreDB.ps1 -vip 10.2.102.233 -username admin -jobName mssql-162 -restoreType "RESTORE-REMOTE" -targetServer 10.2.100.59 -targetInstance "MYSQLSERVER" -mdfFolder "new-backup"
 ```
