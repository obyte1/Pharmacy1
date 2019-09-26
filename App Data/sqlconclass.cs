using System;

public class ConnectionString
{
    private static string _connectionString = (@"Data Source=SIDSYS-LAP-22\SQLEXPRESSS;Initial Catalog=mypharmacy;Integrated Security=True");

    public ConnectionString()
	{
	}
    public static string CONNECTIONSTRING
    {
        get { return _connectionString; }
    }
}
