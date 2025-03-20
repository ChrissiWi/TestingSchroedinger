namespace MyLibrary;

public class Elf(string name, int energy, DateTime birthday, ILogger? logger = null) : LivingCreature(name, energy, birthday, logger)
{
  public new void Eat(object sender, EventArgs e)
    {
        Console.WriteLine("Thanks, but I already ate yesterday");
    }
}