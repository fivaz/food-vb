namespace WindowsFormsApp2.dish
{
    public class Dish
    {
        public int id;
        public int categoryId;
        public string name;
        public int menuId;
        public double quantity;

        public Dish(int id, int categoryId, string name, int menuId, double quantity)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.name = name;
            this.menuId = menuId;
            this.quantity = quantity;
        }
    }
}
