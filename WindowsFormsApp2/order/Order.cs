using System;

namespace WindowsFormsApp2.order
{
    public class Order
    {
        public int id;
        public int accountId;
        public int tableId;
        public DateTime date;
        
        public Order(int id, int accountId, int tableId, DateTime date)
        {
            this.id = id;
            this.accountId = accountId;
            this.tableId = tableId;
            this.date = date;
        }
    }
}
