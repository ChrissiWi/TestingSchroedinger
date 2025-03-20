namespace MyLibrary;

public class Dwarf(string name, int energy, DateTime birthday) : LivingCreature(name, energy, birthday)
{
    public override void Eat(object? sender, EventArgs? e)
    {
        Console.WriteLine($"{Name} wants more food.");
    }
}