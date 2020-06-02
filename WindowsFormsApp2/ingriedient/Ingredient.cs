using System;

namespace WindowsFormsApp2.ingredient
{
    public class Ingredient
    {
        public int id;
        public int dishId;
        public string name;
        public bool isCountable;
        public string unit;
        public double quantity;
        public double price;
        public double minimumQuantity;

        public Ingredient(int id, int dishId, string name, bool isCountable, string unit, double quantity, double price, double minimumQuantity)
        {
            this.id = id;
            this.dishId = dishId;
            this.name = name;
            this.isCountable = isCountable;
            this.unit = unit;
            this.quantity = quantity;
            this.price = price;
            this.minimumQuantity = minimumQuantity;
        }
    }
}
