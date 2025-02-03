namespace MyLibrary;

public class Dwarf(string name, int energy) : LivingCreature (name, energy)
{
    public override void Eat(object? sender, EventArgs? e)
    {
        Console.WriteLine($"{Name} wants more food.");
    }
}