using absract_factory_example;
using System.Data.Common;

Database GetDatabase(bool useSql)
{
    if (useSql)
    {
        // Create concrete class of database I want
        SqlDatabase sqlDatabase = new SqlDatabase();
        return sqlDatabase;
    }
    else
    {
        // .. use whatever other database type
        throw new NotImplementedException();
    }
}

Database sqlDatabase = GetDatabase(useSql: true);

sqlDatabase.Command.CommandText = "Select * from table where void != 1";