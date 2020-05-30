using Oracle.DataAccess.Client;
using System.Collections.Generic;
using WindowsFormsApp2.shared;

namespace WindowsFormsApp2.menu
{
    class MenuORM : ORM<Menu>
    {
        public MenuORM()
        {
            table = "foo_menu";
            view = "vw_menu";
            columns = new List<string> { "MEN_NAME"};
            columnId = "MEN_ID";
            deleteColumn = "MEN_IS_DELETED";
        }

        public override void BindObject(OracleCommand command, Menu menu, bool withId)
        {
            connection.AddString(command, columns[0], menu.name);
            if (withId)
                connection.AddInt(command, columnId, menu.id);
            else
                connection.addReturnId(command);
        }
    }
}
