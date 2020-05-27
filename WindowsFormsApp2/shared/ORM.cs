using System.Data;

namespace WindowsFormsApp2.shared
{
    public interface ORM<T>
    {
        void create(T obj);

        void edit(T obj);

        void delete(int id);

        DataTable search(string text);
    }
}
