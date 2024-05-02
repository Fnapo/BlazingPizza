using BlazingPizza.Model;

namespace BlazingPizza.Services
{
    public class PizzaService
    {
        public async Task<Pizza[]> GetPizzasAsync()
        {
            // Call your data access technology here
            Pizza[] pizzas = new Pizza[1];

            await Task.Delay(100);

            return pizzas;
        }
    }
}
