namespace WindowsFormsApp2.shared.database
{
    public class OracleConnector
    {
        public static OracleConn getConnection()
        {
            return new OracleConn("XE", "foo_dba", "foo_dba");
        }
    }
}
