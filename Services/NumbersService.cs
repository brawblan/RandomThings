namespace RandomThings.Services;

public static class NumbersService
{
    static Random RandomNumber { get; }

    static NumbersService()
    {
        RandomNumber = new();
    }

    public static int Get(int min = 0, int max = 101) => RandomNumber.Next(min, max);

    // public static void Add(Pizza pizza)
    // {
    //     pizza.Id = nextId++;
    //     Pizzas.Add(pizza);
    // }

    // public static void Delete(int id)
    // {
    //     var pizza = Get(id);
    //     if (pizza is null)
    //         return;

    //     Pizzas.Remove(pizza);
    // }

    // public static void Update(Pizza pizza)
    // {
    //     var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
    //     if (index == -1)
    //         return;

    //     Pizzas[index] = pizza;
    // }
}