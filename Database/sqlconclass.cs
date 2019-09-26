using System;
using System.data;
using System.data.sqlclient;



public class ConnectionString
{
    private static string _connectionString = @"Data Source=SIDSYS-LAP-22\\sqlexpress;Initial Catalog=mypharmacy;Integrated Security=True";

    public ConnectionString()
	{
	}
    public static string CONNECTIONSTRING
    {
        get { return _connectionString; }
    }
}
