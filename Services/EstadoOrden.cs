using BlazingPizza.Model;

namespace BlazingPizza.Services;

public class EstadoOrden
{
    public bool ShowingConfigureDialog { get; private set; } = false;
    public Pizza ConfiguringPizza { get; private set; } = null;
    public Order Order { get; private set; } = new Order();

    public void ShowConfigurePizzaDialog(PizzaSpecial special)
    {
        ConfiguringPizza = new Pizza()
        {
            Special = special,
            SpecialId = special.Id,
            Size = Pizza.DefaultSize,
            Toppings = new List<PizzaTopping>(),
        };

        ShowingConfigureDialog = true;
    }

    public void CancelConfigurePizzaDialog()
    {
        ConfiguringPizza = null;

        ShowingConfigureDialog = false;
    }

    public void ConfirmConfigurePizzaDialog()
    {
        Order.Pizzas.Add(ConfiguringPizza);
        ConfiguringPizza = null;

        ShowingConfigureDialog = false;
    }

    public void RemoveConfiguredPizza(Pizza pizza)
    {
        Order.Pizzas.Remove(pizza);
    }
}
