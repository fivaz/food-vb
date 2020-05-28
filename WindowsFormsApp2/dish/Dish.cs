using System;

namespace WindowsFormsApp2.dish
{
    public class Dish
    {
        public int id;
        public int categoryId;
        public String name;
        public double sellingPrice;

        public Dish(int id, int categoryId, String name, double sellingPrice)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.name = name;
            this.sellingPrice = sellingPrice;
        }
    }
}
