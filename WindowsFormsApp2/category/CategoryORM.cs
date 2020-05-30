using Oracle.DataAccess.Client;
using System.Collections.Generic;
using System.Data;
using WindowsFormsApp2.shared;

namespace WindowsFormsApp2.category
{
    class CategoryORM : ORM<Category>
    {
        public CategoryORM()
        {
            table = "foo_category";
            view = "vw_category";
            columns = new List<string> { "CAT_NAME" };
            columnId = "CAT_ID" ;
            deleteColumn = "CAT_IS_DELETED";
        }

        public override void BindObject(OracleCommand command, Category category, bool withId)
        {
            connection.AddString(command, "CAT_NAME", category.name);
            if (withId)
                connection.AddInt(command, "CAT_ID", category.id);
            else
                connection.addReturnId(command);
        }
    }
}
