//*********************************************************
//
// Juice.cs
//
// Defines the Juice class.
// Inherits from the Drink class.
// Defines unique behavior for keeping the type of fruit used in the juice.
//

namespace DrinkDemo.Models
{
    public class Juice : Drink
    {
        public string fruit_type { get; }

        public Juice(string drink_name, bool is_carbonated, string fruit_type) : base(drink_name, is_carbonated)
        {
            if (string.IsNullOrWhiteSpace(fruit_type))
            {
                throw new ArgumentException("Fruit type cannot be null or empty.", nameof(fruit_type));
            }

            this.fruit_type = fruit_type;
        }

        public override string description => $"{base.description}, made from {fruit_type}";
    }
}
