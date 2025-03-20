namespace MyLibrary;

public class Dwarf(string name, int energy, DateTime birthday, ILogger? logger = null) : LivingCreature(name, energy, birthday, logger)
{
    public override void Eat(object? sender, EventArgs? e)
    {
        Console.WriteLine($"{Name} wants more food.");
    }
}