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
            if (alcohol_content_percentage < 0 || alcohol_content_percentage > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(alcohol_content_percentage), "Alcohol content percentage must be between 0 and 100.");
            }

            this.alcohol_content_percentage = alcohol_content_percentage;
        }

        public override string description => $"{base.description}, {alcohol_content_percentage}%";
    }
}
