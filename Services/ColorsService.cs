using RandomThings.Models;

namespace RandomThings.Services;

public static class ColorsService
{
    private readonly static Random random = new();
    static List<Color> Colors { get; }
    static int nextId = 6;
    static ColorsService()
    {
        Colors =
        [
            new Color { Id = 1, Name = "Red", },
            new Color { Id = 2, Name = "Blue", },
            new Color { Id = 3, Name = "Yellow", },
            new Color { Id = 4, Name = "Green", },
            new Color { Id = 5, Name = "Purple", },
        ];
    }

    public static List<Color> GetAll() => Colors;

    public static Color Get(int id)
    {
        Color color = Colors.FirstOrDefault(p => p.Id == id) ??
            throw new ArgumentOutOfRangeException($"ID: {id} does not exist. Enter a new ID or add this color.");
        return color;
    }

    public static Color GetRandom()
    {
        int val = random.Next(1, Colors.Count + 1);
        Color color = Colors.FirstOrDefault(p => p.Id == val) ??
            throw new ArgumentOutOfRangeException($"Error retrieving random color.");
        return color;
    }

    public static Color Create(string name)
    {
        if (Colors.FirstOrDefault(p => p.Name == name) is not null)
            throw new ArgumentException("This color already exists. Please add a different color.");

        Color newColor = new() { Id = nextId++, Name = name };
        Colors.Add(newColor);
        return newColor;
    }

    public static Color Update(Color color, string newName)
    {
        var index = Colors.FindIndex(c => c.Name == color.Name);
        if (index == -1)
            throw new ArgumentNullException($"Color {color.Name} does not exist.");

        Colors[index].Name = newName;
        return color;
    }

    public static void Delete(int id)
    {
        var color = Get(id);
        if (color is null)
            return;

        Colors.Remove(color);
    }
}