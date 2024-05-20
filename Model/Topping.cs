using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Model
{
    public class Topping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }

        public string GetFormattedPrice() => Price.ToString("0.00");
    }
}
