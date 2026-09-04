//*********************************************************
//
// Beer.cs
//
// Defines the Beer class.
// Inherits from the Drink class.
// Defines unique behavior for keeping the alcohol content percentage of the beer.
//

namespace DrinkDemo.Models
{
    public class Beer : Drink
    {
        public double alcohol_content_percentage { get; }

        public Beer(string drink_name, bool is_carbonated, double alcohol_content_percentage) : base(drink_name, is_carbonated)
        {
            this.alcohol_content_percentage = alcohol_content_percentage;
        }

        public override string description => $"{base.description}, {alcohol_content_percentage}%";
    }
}
