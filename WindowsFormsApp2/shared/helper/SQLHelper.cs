using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2.shared.helper
{
    class SQLHelper
    {
        public static StringBuilder removeComma(StringBuilder query)
        {
            return query.Remove(query.Length - 2, 2);
        }

        public static string insertQuery(string table, string[] columns, string[] ids)
        {
            StringBuilder query = new StringBuilder();
            query
                .Append("INSERT INTO ")
                .Append(table)
                .Append(" (");

            foreach(string id in ids)
                query.Append(id).Append(", ");
            
            foreach (string column in columns)
                query.Append(column).Append(", ");

            removeComma(query);

            query.Append(") VALUES (");

            foreach (string id in ids) 
                query.Append("NULL").Append(", ");

            foreach (string column in columns)
                query.Append(":").Append(column).Append(", ");

            removeComma(query);

            query.Append(")");

            return query.ToString();
        }

        public static string updateQuery(string table, string[] columns, string[] ids)
        {
            StringBuilder query = new StringBuilder();
            query
                .Append("UPDATE ")
                .Append(table)
                .Append(" SET ");

            foreach (string column in columns)
                query.Append(column).Append(" = :").Append(column).Append(", ");

            removeComma(query);

            query.Append(" WHERE ");

            foreach (string id in ids)
                query.Append(id).Append(" = :").Append(id).Append(", ");

            removeComma(query);

            return query.ToString();
        }

        public static string deleteQuery(string table, string deleteColumn, string[] ids)
        {
            //string sql = "UPDATE " + table + " SET ACC_IS_DELETED = 1 WHERE ACC_ID = :id";
            StringBuilder query = new StringBuilder();
            query
                .Append("UPDATE ")
                .Append(table)
                .Append(" SET ")
                .Append(deleteColumn)
                .Append(" = 1 WHERE ");

            foreach (string id in ids)
                query.Append(id).Append(" = :").Append(id).Append(", ");

            removeComma(query);

            return query.ToString();
        }

        public static string searchQuery(string view, string[] columns)
        {
            // string sql = "SELECT * FROM " + view + " WHERE ACC_LAST_NAME LIKE :query OR ACC_FIRST_NAME LIKE :query OR " +
            //"ACC_EMAIL LIKE :query OR ACC_TYPE LIKE :query";
            StringBuilder query = new StringBuilder();
            query
                .Append("SELECT * FROM ")
                .Append(view)
                .Append(" WHERE ");

            foreach (string column in columns)
                query.Append(column).Append(" LIKE :").Append(column).Append(" OR ");

            query.Remove(query.Length - 3, 3);

            return query.ToString();
        }
    }
}
