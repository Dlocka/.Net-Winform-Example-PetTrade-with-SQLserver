1. Configure Database Connection
  Before running the application, you must update the database connection details in the App.config file.

  Locate and Edit <connectionStrings> Block
  Open the App.config file and find the following block:
  <connectionStrings>
    <add name="connStr" connectionString="server=.;uid=sa;pwd=123456;database=PetTradeDB" providerName="System.Data.SqlClient"/>
  </connectionStrings>
  server: Specify your SQL Server instance name (e.g., localhost, .\SQLEXPRESS, 127.0.0.1, etc.)
  
  uid: Your SQL Server username
  
  pwd: Your SQL Server password

  database: Ensure this matches the actual database name (e.g., PetTradeDB)
2. Restore or Attach the Database
  You need to recover or attach the PetTradeDB using the provided .mdf and .ldf files.
  
  Option A: Attach Database in SQL Server Management Studio (SSMS)
  Open SQL Server Management Studio.
  
  Connect to your SQL Server instance.
  
  Right-click on Databases → select Attach...
  
  In the Attach Databases dialog:
  
  Click Add...
  
  Select the .mdf file (e.g., PetTradeDB.mdf).
  
  Ensure the .ldf file is listed automatically; if not, click the log file row and browse to select it.
  
  Click OK to attach the database.

  Option B: Use SQL Query
  CREATE DATABASE PetTradeDB
  ON 
  (FILENAME = 'C:\Path\To\PetTradeDB.mdf'),
  (FILENAME = 'C:\Path\To\PetTradeDB_log.ldf')
  FOR ATTACH;
  
  Replace the file paths with the actual locations of your .mdf and .ldf files.
