//*********************************************************
//
// Drink.cs
//
// Defines the Drink class.
// Serves as a base class for different types of drinks.
//

namespace DrinkDemo.Models
{
    public abstract class Drink
    {
        public string drink_name { get; }
        public bool is_carbonated { get; }

        public Drink(string drink_name, bool is_carbonated)
        {
            if (string.IsNullOrWhiteSpace(drink_name))
            {
                throw new ArgumentException("Drink name cannot be null or empty.", nameof(drink_name));
            }

            this.drink_name = drink_name;
            this.is_carbonated = is_carbonated;
        }

        public virtual string description
        {
            get
            {
                string carbonation_text = is_carbonated ? "carbonated" : "not carbonated";
                return $"{drink_name}, {carbonation_text}";
            }
        }

        public override string ToString() => description;
    }
}
