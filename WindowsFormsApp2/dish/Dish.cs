namespace WindowsFormsApp2.dish
{
    public class Dish
    {
        public int id;
        public int categoryId;
        public string name;

        public Dish(int id, int categoryId, string name)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.name = name;
        }
    }
}
