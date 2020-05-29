namespace WindowsFormsApp2.dish
{
    public class Dish
    {
        public int id;
        public int categoryId;
        public string name;
        public double sellingPrice;

        public Dish(int id, int categoryId, string name, double sellingPrice)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.name = name;
            this.sellingPrice = sellingPrice;
        }
    }
}
