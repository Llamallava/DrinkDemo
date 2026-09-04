//*********************************************************
//
// Soda.cs
//
// Defines the Soda class.
// Inherits from the Drink class.
// Does not define any unique behavior. 
//

namespace DrinkDemo.Models
{
    public class Soda : Drink
    {
        public Soda(string drink_name, bool is_carbonated) : base(drink_name, is_carbonated)
        {

        }

        public override string description => base.description;
    }
}
